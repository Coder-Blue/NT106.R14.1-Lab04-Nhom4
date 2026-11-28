namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public partial class DangKyForm : Form
{
    public DangKyForm()
    {
        InitializeComponent();
    }

    private async void btnDangKy_Click(object sender, EventArgs e)
    {
        var tenDangNhap = txtTenDangNhap.Text.Trim();
        var email = txtEmail.Text.Trim();
        var matKhau = txtMatKhau.Text;
        var nhapLai = txtNhapLaiMatKhau.Text;

        if (tenDangNhap.Length == 0 || email.Length == 0 || matKhau.Length == 0)
        {
            lblThongBao.Text = "Nhập đầy đủ tên đăng nhập, email và mật khẩu.";
            return;
        }

        if (matKhau != nhapLai)
        {
            lblThongBao.Text = "Mật khẩu nhập lại không khớp.";
            return;
        }

        btnDangKy.Enabled = false;
        lblThongBao.ForeColor = Color.FromArgb(80, 80, 80);
        lblThongBao.Text = "Đang tạo tài khoản...";

        var ketQua = await ApiHelper.DangKyAsync(
            tenDangNhap, email, matKhau, txtHo.Text.Trim(), txtTen.Text.Trim());
        if (IsDisposed)
        {
            return;
        }

        if (ketQua.ThanhCong)
        {
            MessageBox.Show(this, ketQua.ThongBao, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        btnDangKy.Enabled = true;
        lblThongBao.ForeColor = Color.FromArgb(190, 60, 60);
        lblThongBao.Text = ketQua.ThongBao;
    }
}
