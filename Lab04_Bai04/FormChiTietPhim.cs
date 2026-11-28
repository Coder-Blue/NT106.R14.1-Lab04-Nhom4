namespace NT106.R14._1_Lab04_Nhom4.Bai04;

public partial class FormChiTietPhim : Form
{
    private readonly string duongDan;

    public FormChiTietPhim(string tenPhim, string duongDan)
    {
        InitializeComponent();
        this.duongDan = duongDan;
        Text = "Chi tiết phim - " + tenPhim;
    }

    private async void FormChiTietPhim_Load(object sender, EventArgs e)
    {
        try
        {
            await webView.EnsureCoreWebView2Async();
            if (IsDisposed)
            {
                return;
            }

            if (Uri.TryCreate(duongDan, UriKind.Absolute, out var uri))
            {
                webView.Source = uri;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this,
                "Không mở được WebView2. Hãy cài Microsoft Edge WebView2 Runtime.\n\n" + ex.Message,
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
