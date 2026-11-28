namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public partial class DangNhapForm : Form
{
    public DangNhapForm()
    {
        InitializeComponent();
    }

    private async void btnDangNhap_Click(object sender, EventArgs e)
    {
        var tenDangNhap = txtTenDangNhap.Text.Trim();
        var matKhau = txtMatKhau.Text;

        if (tenDangNhap.Length == 0 || matKhau.Length == 0)
        {
            lblThongBao.Text = "Nhập đầy đủ tên đăng nhập và mật khẩu.";
            return;
        }

        btnDangNhap.Enabled = false;
        lblThongBao.ForeColor = Color.FromArgb(80, 80, 80);
        lblThongBao.Text = "Đang đăng nhập...";

        var ketQua = await ApiHelper.DangNhapAsync(tenDangNhap, matKhau);
        if (IsDisposed)
        {
            return;
        }

        if (ketQua.ThanhCong)
        {
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        btnDangNhap.Enabled = true;
        lblThongBao.ForeColor = Color.FromArgb(190, 60, 60);
        lblThongBao.Text = ketQua.ThongBao;
    }
}
