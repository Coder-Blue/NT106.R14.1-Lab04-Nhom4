using System.Text;
using System.Text.Json;
using Microsoft.Web.WebView2.Core;

namespace NT106.R14._1_Lab04_Nhom4.Bai03;

public partial class Bai03Form : Form
{
    private const string HomeUrl = "https://uit.edu.vn";

    private static readonly HttpClient Http = TaoHttpClient();

    public Bai03Form()
    {
        InitializeComponent();
        txtDiaChi.Text = HomeUrl;
    }

    private static HttpClient TaoHttpClient()
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0 Safari/537.36");
        return client;
    }

    private async void Bai03Form_Load(object sender, EventArgs e)
    {
        try
        {
            await webView.EnsureCoreWebView2Async();
            if (IsDisposed)
            {
                return;
            }

            webView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            webView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
            webView.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
            webView.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
            webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;

            MoUrl(HomeUrl);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this,
                "Không khởi tạo được WebView2. Hãy cài Microsoft Edge WebView2 Runtime.\n\n" + ex.Message,
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnQuayLai.Enabled = false;
            btnTien.Enabled = false;
            btnTaiLai.Enabled = false;
            btnMo.Enabled = false;
            btnTrangChu.Enabled = false;
            lblTrangThai.Text = "WebView2 không khả dụng, chỉ dùng được các nút tải.";
        }
    }

    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
    {
        lblTrangThai.Text = "Đang mở " + e.Uri;
    }

    private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
    {
        lblTrangThai.Text = e.IsSuccess ? "Đã tải xong." : "Lỗi tải trang: " + e.WebErrorStatus;

        if (webView.CoreWebView2 != null && !string.IsNullOrWhiteSpace(webView.CoreWebView2.DocumentTitle))
        {
            Text = "Bài 03 - " + webView.CoreWebView2.DocumentTitle;
        }

        CapNhatNutDieuHuong();
    }

    private void CoreWebView2_SourceChanged(object? sender, CoreWebView2SourceChangedEventArgs e)
    {
        if (webView.Source != null)
        {
            txtDiaChi.Text = webView.Source.ToString();
        }
    }

    private void CoreWebView2_HistoryChanged(object? sender, object e) => CapNhatNutDieuHuong();

    private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
        e.Handled = true;
        if (!string.IsNullOrWhiteSpace(e.Uri))
        {
            MoUrl(e.Uri);
        }
    }

    private void MoUrl(string input)
    {
        var url = input.Trim();
        if (url.Length == 0 || webView.CoreWebView2 == null)
        {
            return;
        }

        if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
            !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {
            url = "https://" + url;
        }

        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
        {
            MessageBox.Show(this, "URL không hợp lệ.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        webView.CoreWebView2.Navigate(uri.ToString());
    }

    private void btnMo_Click(object sender, EventArgs e) => MoUrl(txtDiaChi.Text);

    private void btnQuayLai_Click(object sender, EventArgs e)
    {
        if (webView.CoreWebView2 != null && webView.CanGoBack)
        {
            webView.GoBack();
        }
    }

    private void btnTien_Click(object sender, EventArgs e)
    {
        if (webView.CoreWebView2 != null && webView.CanGoForward)
        {
            webView.GoForward();
        }
    }

    private void btnTaiLai_Click(object sender, EventArgs e)
    {
        if (webView.CoreWebView2 != null)
        {
            webView.Reload();
        }
    }

    private void btnTrangChu_Click(object sender, EventArgs e) => MoUrl(HomeUrl);

    private void CapNhatNutDieuHuong()
    {
        if (webView.CoreWebView2 == null)
        {
            return;
        }

        btnQuayLai.Enabled = webView.CanGoBack;
        btnTien.Enabled = webView.CanGoForward;
    }

    private Uri? LayUriHienTai()
    {
        // ưu tiên địa chỉ người dùng vừa nhập, nếu không hợp lệ mới lấy trang đang mở
        if (Uri.TryCreate(txtDiaChi.Text.Trim(), UriKind.Absolute, out var uri) &&
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return uri;
        }

        return webView.Source is { } source &&
               (source.Scheme == Uri.UriSchemeHttp || source.Scheme == Uri.UriSchemeHttps)
            ? source
            : null;
    }

    private async Task<string> LayHtmlAsync(Uri uri)
    {
        // lấy DOM đang hiển thị để giữ được nội dung do JavaScript tạo ra
        if (webView.CoreWebView2 != null &&
            webView.Source != null &&
            webView.Source.AbsoluteUri == uri.AbsoluteUri)
        {
            try
            {
                var json = await webView.CoreWebView2.ExecuteScriptAsync(
                    "document.documentElement.outerHTML");
                var html = JsonSerializer.Deserialize<string>(json);
                if (!string.IsNullOrWhiteSpace(html))
                {
                    // outerHTML không có DOCTYPE, thêm lại cho file HTML đầy đủ
                    if (!html.TrimStart().StartsWith("<!DOCTYPE", StringComparison.OrdinalIgnoreCase))
                    {
                        html = "<!DOCTYPE html>\n" + html;
                    }

                    return html;
                }
            }
            catch
            {
                // WebView2 lỗi thì quay lại tải bằng HttpClient
            }
        }

        return await Http.GetStringAsync(uri);
    }

    private async void btnTaiHtml_Click(object sender, EventArgs e)
    {
        var uri = LayUriHienTai();
        if (uri == null)
        {
            MessageBox.Show(this, "Chưa có địa chỉ trang web.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Title = "Lưu trang web",
            Filter = "HTML file (*.html)|*.html|Tất cả (*.*)|*.*",
            FileName = HtmlHelper.LamTenAnToan(uri.Host) + ".html"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        btnTaiHtml.Enabled = false;
        try
        {
            lblTrangThai.Text = "Đang lấy mã HTML...";
            var html = await LayHtmlAsync(uri);
            if (IsDisposed)
            {
                return;
            }

            await File.WriteAllTextAsync(dialog.FileName, html, Encoding.UTF8);
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Đã lưu " + dialog.FileName;
            MessageBox.Show(this, "Đã lưu file HTML.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Lỗi.";
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                btnTaiHtml.Enabled = true;
            }
        }
    }

    private async void btnTaiHinh_Click(object sender, EventArgs e)
    {
        var uri = LayUriHienTai();
        if (uri == null)
        {
            MessageBox.Show(this, "Chưa có địa chỉ trang web.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var dialog = new FolderBrowserDialog
        {
            Description = "Chọn thư mục lưu hình ảnh của trang web"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        btnTaiHinh.Enabled = false;
        btnTaiHtml.Enabled = false;
        btnXemNguon.Enabled = false;
        progressBar.Visible = false;

        try
        {
            lblTrangThai.Text = "Đang đọc HTML...";
            var html = await LayHtmlAsync(uri);
            var dsAnh = HtmlHelper.LayDanhSachAnh(html, uri);

            if (dsAnh.Count == 0)
            {
                MessageBox.Show(this, "Trang này không có hình ảnh nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            progressBar.Maximum = dsAnh.Count;
            progressBar.Value = 0;
            progressBar.Visible = true;
            var daDung = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var thanhCong = 0;

            foreach (var anh in dsAnh)
            {
                try
                {
                    var data = await Http.GetByteArrayAsync(anh);
                    if (IsDisposed)
                    {
                        return;
                    }

                    var ten = HtmlHelper.LayTenFile(anh, daDung);
                    await File.WriteAllBytesAsync(Path.Combine(dialog.SelectedPath, ten), data);
                    thanhCong++;
                }
                catch
                {
                    // ảnh nào lỗi thì bỏ qua, tải tiếp ảnh khác
                }

                if (IsDisposed)
                {
                    return;
                }

                progressBar.Value++;
                lblTrangThai.Text = $"Đang tải hình {progressBar.Value}/{dsAnh.Count}...";
            }

            lblTrangThai.Text = $"Đã tải {thanhCong}/{dsAnh.Count} hình vào {dialog.SelectedPath}";
            MessageBox.Show(this, $"Đã tải {thanhCong}/{dsAnh.Count} hình ảnh.", "Hoàn tất",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Lỗi.";
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                btnTaiHinh.Enabled = true;
                btnTaiHtml.Enabled = true;
                btnXemNguon.Enabled = true;
            }
        }
    }

    private async void btnXemNguon_Click(object sender, EventArgs e)
    {
        var uri = LayUriHienTai();
        if (uri == null)
        {
            MessageBox.Show(this, "Chưa có địa chỉ trang web.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        btnXemNguon.Enabled = false;
        try
        {
            lblTrangThai.Text = "Đang lấy mã nguồn...";
            var html = await LayHtmlAsync(uri);
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Đã mở mã nguồn.";
            new FormViewSource(uri.ToString(), html).Show(this);
        }
        catch (Exception ex)
        {
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Lỗi.";
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                btnXemNguon.Enabled = true;
            }
        }
    }
}
