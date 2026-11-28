using System.Net;
using System.Text;

namespace NT106.R14._1_Lab04_Nhom4.Bai02;

/// <summary>
/// Bài 2: Download nội dung trang web bằng WebClient, ghi thành file .html
/// rồi hiển thị nội dung lên form.
/// </summary>
public partial class FormBai02 : Form
{
    private const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) NT106-Lab04";

    public FormBai02()
    {
        InitializeComponent();
        txtSavePath.Text = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "trang-web.html");
    }

    private void btnBrowse_Click(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Title = "Chọn nơi lưu file HTML",
            Filter = "HTML file (*.html)|*.html|Tất cả (*.*)|*.*",
            FileName = Path.GetFileName(txtSavePath.Text)
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            txtSavePath.Text = dialog.FileName;
        }
    }

    private async void btnDownload_Click(object? sender, EventArgs e)
    {
        string url = txtUrl.Text.Trim();
        string savePath = txtSavePath.Text.Trim();

        if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uri) ||
            (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            ShowWarning("URL phải bắt đầu bằng http:// hoặc https://");
            return;
        }
        if (savePath.Length == 0)
        {
            ShowWarning("Hãy chọn đường dẫn lưu file.");
            return;
        }

        btnDownload.Enabled = false;
        lblStatus.Text = "Đang tải...";
        try
        {
            // WebClient là API đồng bộ (chặn thread) nên chạy trên thread nền để form không bị "đơ"
            string html = await Task.Run(() => DownloadPage(url, savePath));

            rtbContent.Text = html;
            lblStatus.Text = $"Đã lưu {new FileInfo(savePath).Length:N0} byte vào {savePath}";
            MessageBox.Show("Download thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (WebException ex)
        {
            // Lỗi HTTP (404, 403...) hoặc lỗi kết nối (sai tên miền, mất mạng, timeout)
            string message = ex.Response is HttpWebResponse response
                ? $"Server trả về lỗi HTTP {(int)response.StatusCode} {response.StatusDescription}"
                : ex.Message;
            ShowError(message);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message); // ví dụ: không có quyền ghi file vào thư mục đã chọn
        }
        finally
        {
            btnDownload.Enabled = true;
        }
    }

    /// <summary>
    /// Dùng WebClient theo gợi ý của đề:
    /// DownloadFile để ghi trang web ra file, OpenRead để đọc nội dung vào Stream và hiển thị.
    /// </summary>
    private static string DownloadPage(string url, string savePath)
    {
#pragma warning disable SYSLIB0014 // WebClient bị đánh dấu obsolete từ .NET 6, nhưng đề bài yêu cầu dùng
        using var myClient = new WebClient();
#pragma warning restore SYSLIB0014
        myClient.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);

        string? folder = Path.GetDirectoryName(savePath);
        if (!string.IsNullOrEmpty(folder))
        {
            Directory.CreateDirectory(folder);
        }
        myClient.DownloadFile(url, savePath);

        using Stream response = myClient.OpenRead(url);
        using var reader = new StreamReader(response, Encoding.UTF8);
        return reader.ReadToEnd();
    }

    private void ShowWarning(string message)
    {
        MessageBox.Show(message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void ShowError(string message)
    {
        lblStatus.Text = "Lỗi";
        MessageBox.Show(message, "Không download được", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
