namespace NT106.R14._1_Lab04_Nhom4.Bai03;

/// <summary>Form phụ của Bài 3: hiển thị mã nguồn HTML của trang đang xem.</summary>
public partial class FormViewSource : Form
{
    public FormViewSource(string url, string html)
    {
        InitializeComponent();
        Text = "View Source - " + url;
        lblInfo.Text = $"{url}   ({html.Length:N0} ký tự)";
        rtbSource.Text = html;
    }

    private void btnCopy_Click(object? sender, EventArgs e)
    {
        if (rtbSource.TextLength == 0)
        {
            return;
        }
        Clipboard.SetText(rtbSource.Text);
        MessageBox.Show("Đã copy mã nguồn.", "Thông báo");
    }
}
