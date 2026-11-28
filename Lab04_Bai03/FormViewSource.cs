using System.Text;

namespace NT106.R14._1_Lab04_Nhom4.Bai03;

public partial class FormViewSource : Form
{
    private readonly string html;

    public FormViewSource(string url, string html)
    {
        InitializeComponent();
        this.html = html;
        Text = "Mã nguồn - " + url;
        lblInfo.Text = $"{url} ({html.Length:N0} ký tự)";
        rtbSource.Text = html;
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        if (rtbSource.TextLength == 0)
        {
            return;
        }

        try
        {
            Clipboard.SetText(rtbSource.Text);
            MessageBox.Show(this, "Đã copy mã nguồn.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, "Không copy được: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLuu_Click(object sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Title = "Lưu mã nguồn",
            Filter = "HTML file (*.html)|*.html|Tất cả (*.*)|*.*",
            FileName = "view-source.html"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            await File.WriteAllTextAsync(dialog.FileName, html, Encoding.UTF8);
            if (IsDisposed)
            {
                return;
            }

            MessageBox.Show(this, "Đã lưu mã nguồn.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            if (IsDisposed)
            {
                return;
            }

            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
