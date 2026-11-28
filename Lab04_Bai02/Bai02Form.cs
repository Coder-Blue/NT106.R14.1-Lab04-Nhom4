using System.Net;
using System.Text;

namespace NT106.R14._1_Lab04_Nhom4.Bai02;

public partial class Bai02Form : Form
{
    private const string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) NT106-Lab04";

    public Bai02Form()
    {
        InitializeComponent();
        txtLuuFile.Text = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "uit.html");
    }

    private void btnChonFile_Click(object sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Title = "Chọn nơi lưu file HTML",
            Filter = "HTML file (*.html)|*.html|Tất cả (*.*)|*.*",
            FileName = Path.GetFileName(txtLuuFile.Text)
        };

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            txtLuuFile.Text = dialog.FileName;
        }
    }

    private async void btnTai_Click(object sender, EventArgs e)
    {
        var url = txtUrl.Text.Trim();
        var file = txtLuuFile.Text.Trim();

        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            MessageBox.Show(this, "URL phải bắt đầu bằng http:// hoặc https://.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUrl.Focus();
            return;
        }

        if (file.Length == 0)
        {
            MessageBox.Show(this, "Chưa chọn đường dẫn lưu file.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtLuuFile.Focus();
            return;
        }

        btnTai.Enabled = false;
        btnChonFile.Enabled = false;
        lblTrangThai.Text = "Đang tải trang web...";

        try
        {
            var html = await Task.Run(() => TaiTrangWeb(url, file));
            if (IsDisposed)
            {
                return;
            }

            rtbNoiDung.Text = html;
            lblTrangThai.Text = $"Đã lưu {new FileInfo(file).Length:N0} byte vào {file}";
            MessageBox.Show(this, "Download thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (WebException ex)
        {
            if (IsDisposed)
            {
                return;
            }

            var message = ex.Response is HttpWebResponse response
                ? $"Server trả về lỗi HTTP {(int)response.StatusCode} {response.StatusDescription}"
                : ex.Message;
            lblTrangThai.Text = "Tải thất bại.";
            MessageBox.Show(this, message, "Không tải được", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (IsDisposed)
            {
                return;
            }

            lblTrangThai.Text = "Tải thất bại.";
            MessageBox.Show(this, ex.Message, "Không tải được", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (!IsDisposed)
            {
                btnTai.Enabled = true;
                btnChonFile.Enabled = true;
            }
        }
    }

    private static string TaiTrangWeb(string url, string file)
    {
        var folder = Path.GetDirectoryName(file);
        if (!string.IsNullOrEmpty(folder))
        {
            Directory.CreateDirectory(folder);
        }

#pragma warning disable SYSLIB0014
        using var client = new WebClient();
#pragma warning restore SYSLIB0014
        client.Headers.Add(HttpRequestHeader.UserAgent, UserAgent);
        client.DownloadFile(url, file);

        // đọc lại file vừa tải để hiển thị, không gọi mạng thêm lần nữa
        using var stream = File.OpenRead(file);
        using var reader = new StreamReader(stream, Encoding.UTF8, true);
        return reader.ReadToEnd();
    }
}
