using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;

namespace NT106.R14._1_Lab04_Nhom4.Bai03;

/// <summary>
/// Bài 3: Web Browser cơ bản
///  - Xem nội dung website (control WebView2)
///  - Download file HTML của trang đang xem
///  - Download Resource: tải tất cả hình ảnh của trang (trích xuất bằng HtmlAgilityPack)
///  - View Source: mở form mới chứa mã nguồn HTML
/// </summary>
public partial class FormBai03 : Form
{
    private const string HomeUrl = "https://uit.edu.vn";

    // Dùng chung một HttpClient cho cả form; tạo mới mỗi lần gọi sẽ tốn socket
    private static readonly HttpClient Http = CreateHttpClient();

    public FormBai03()
    {
        InitializeComponent();
    }

    private static HttpClient CreateHttpClient()
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        // Một số website trả lỗi 403 nếu request không có User-Agent giống trình duyệt
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0 Safari/537.36");
        return client;
    }

    private async void FormBai03_Load(object? sender, EventArgs e)
    {
        try
        {
            // Khởi tạo nhân trình duyệt Edge (cần WebView2 Runtime, Windows 10/11 thường có sẵn)
            await webView.EnsureCoreWebView2Async();

            webView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            webView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
            webView.CoreWebView2.SourceChanged += (_, _) => txtAddress.Text = webView.Source.ToString();
            webView.CoreWebView2.HistoryChanged += (_, _) => UpdateNavigationButtons();

            NavigateTo(HomeUrl);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không khởi tạo được WebView2. Hãy cài Microsoft Edge WebView2 Runtime.\n\n" + ex.Message,
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #region Điều hướng

    /// <summary>URL của trang đang hiển thị (sau khi đã chuyển hướng, nếu có).</summary>
    private Uri? CurrentUri =>
        webView.Source ?? (Uri.TryCreate(txtAddress.Text.Trim(), UriKind.Absolute, out Uri? uri) ? uri : null);

    private void NavigateTo(string input)
    {
        string url = input.Trim();
        if (url.Length == 0 || webView.CoreWebView2 == null)
        {
            return;
        }

        // Người dùng hay gõ "uit.edu.vn" mà quên https://
        if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
            !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {
            url = "https://" + url;
        }

        if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uri))
        {
            MessageBox.Show("URL không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        webView.CoreWebView2.Navigate(uri.ToString());
    }

    private void btnGo_Click(object? sender, EventArgs e) => NavigateTo(txtAddress.Text);

    private void btnBack_Click(object? sender, EventArgs e)
    {
        if (webView.CanGoBack)
        {
            webView.GoBack();
        }
    }

    private void btnForward_Click(object? sender, EventArgs e)
    {
        if (webView.CanGoForward)
        {
            webView.GoForward();
        }
    }

    private void btnReload_Click(object? sender, EventArgs e) => webView.Reload();

    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
    {
        lblStatus.Text = "Đang tải " + e.Uri;
    }

    private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
    {
        lblStatus.Text = e.IsSuccess ? "Hoàn tất." : "Lỗi tải trang: " + e.WebErrorStatus;
        Text = "Lab 4 - Bài 3: " + webView.CoreWebView2.DocumentTitle;
        UpdateNavigationButtons();
    }

    private void UpdateNavigationButtons()
    {
        btnBack.Enabled = webView.CanGoBack;
        btnForward.Enabled = webView.CanGoForward;
    }

    #endregion

    #region Download HTML

    private async void btnDownloadHtml_Click(object? sender, EventArgs e)
    {
        Uri? pageUri = CurrentUri;
        if (pageUri == null)
        {
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Filter = "HTML file (*.html)|*.html",
            FileName = MakeSafeFileName(pageUri.Host) + ".html"
        };
        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            lblStatus.Text = "Đang tải file HTML...";
            string html = await Http.GetStringAsync(pageUri);
            await File.WriteAllTextAsync(dialog.FileName, html);

            lblStatus.Text = "Đã lưu " + dialog.FileName;
            MessageBox.Show("Đã lưu file HTML.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    #endregion

    #region Download Resource (hình ảnh)

    private async void btnDownloadResource_Click(object? sender, EventArgs e)
    {
        Uri? pageUri = CurrentUri;
        if (pageUri == null)
        {
            return;
        }

        using var dialog = new FolderBrowserDialog { Description = "Chọn thư mục lưu hình ảnh của trang web" };
        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        btnDownloadResource.Enabled = false;
        try
        {
            lblStatus.Text = "Đang phân tích HTML...";
            string html = await Http.GetStringAsync(pageUri);
            List<Uri> imageUris = ExtractImageUris(html, pageUri);

            if (imageUris.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hình ảnh nào trong trang.", "Thông báo");
                return;
            }

            progressBar.Maximum = imageUris.Count;
            progressBar.Value = 0;
            int successCount = 0;
            var usedNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (Uri imageUri in imageUris)
            {
                try
                {
                    byte[] data = await Http.GetByteArrayAsync(imageUri);
                    string fileName = GetUniqueFileName(imageUri, usedNames);
                    await File.WriteAllBytesAsync(Path.Combine(dialog.SelectedPath, fileName), data);
                    successCount++;
                }
                catch (HttpRequestException)
                {
                    // Ảnh lỗi (404, bị chặn...) thì bỏ qua, tải tiếp các ảnh còn lại
                }
                catch (TaskCanceledException)
                {
                    // Ảnh tải quá lâu (timeout) cũng bỏ qua
                }

                progressBar.Value++;
                lblStatus.Text = $"Đang tải hình {progressBar.Value}/{imageUris.Count}...";
            }

            lblStatus.Text = $"Đã tải {successCount}/{imageUris.Count} hình vào {dialog.SelectedPath}";
            MessageBox.Show($"Đã tải {successCount}/{imageUris.Count} hình ảnh.", "Hoàn tất",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
        finally
        {
            btnDownloadResource.Enabled = true;
        }
    }

    /// <summary>
    /// Dùng HtmlAgilityPack lấy mọi thẻ &lt;img&gt; trong HTML và đổi đường dẫn tương đối
    /// (ví dụ "/images/logo.png") thành URL tuyệt đối dựa trên địa chỉ trang.
    /// </summary>
    private static List<Uri> ExtractImageUris(string html, Uri pageUri)
    {
        var document = new HtmlAgilityPack.HtmlDocument(); // ghi rõ để không nhầm với System.Windows.Forms.HtmlDocument
        document.LoadHtml(html);

        var result = new List<Uri>();
        HtmlNodeCollection? imgNodes = document.DocumentNode.SelectNodes("//img");
        if (imgNodes == null)
        {
            return result;
        }

        foreach (HtmlNode img in imgNodes)
        {
            // Nhiều trang dùng lazy-load: link ảnh thật nằm ở data-src, src chỉ là ảnh chờ
            string src = img.GetAttributeValue("data-src", "");
            if (src.Length == 0)
            {
                src = img.GetAttributeValue("src", "");
            }

            // Bỏ qua ảnh rỗng và ảnh nhúng thẳng trong HTML (data:image/png;base64,...)
            if (string.IsNullOrWhiteSpace(src) || src.StartsWith("data:", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            src = HtmlEntity.DeEntitize(src.Trim()); // "&amp;" trong HTML -> "&"
            if (Uri.TryCreate(pageUri, src, out Uri? absolute) &&
                (absolute.Scheme == Uri.UriSchemeHttp || absolute.Scheme == Uri.UriSchemeHttps) &&
                !result.Contains(absolute))
            {
                result.Add(absolute);
            }
        }
        return result;
    }

    /// <summary>Lấy tên file từ URL; nếu trùng tên với ảnh đã tải thì thêm hậu tố _1, _2...</summary>
    private static string GetUniqueFileName(Uri uri, HashSet<string> usedNames)
    {
        string name = MakeSafeFileName(Path.GetFileName(Uri.UnescapeDataString(uri.AbsolutePath)));
        if (string.IsNullOrEmpty(name))
        {
            name = "image";
        }
        if (!Path.HasExtension(name))
        {
            name += ".jpg";
        }

        string baseName = Path.GetFileNameWithoutExtension(name);
        string extension = Path.GetExtension(name);
        int counter = 1;
        while (!usedNames.Add(name))
        {
            name = $"{baseName}_{counter++}{extension}";
        }
        return name;
    }

    private static string MakeSafeFileName(string name)
    {
        foreach (char c in Path.GetInvalidFileNameChars())
        {
            name = name.Replace(c, '_');
        }
        return name;
    }

    #endregion

    #region View Source

    private async void btnViewSource_Click(object? sender, EventArgs e)
    {
        Uri? pageUri = CurrentUri;
        if (pageUri == null)
        {
            return;
        }

        try
        {
            lblStatus.Text = "Đang lấy mã nguồn...";
            string html = await Http.GetStringAsync(pageUri);
            lblStatus.Text = "Hoàn tất.";
            new FormViewSource(pageUri.ToString(), html).Show(this);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    #endregion

    private void ShowError(string message)
    {
        lblStatus.Text = "Lỗi";
        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
