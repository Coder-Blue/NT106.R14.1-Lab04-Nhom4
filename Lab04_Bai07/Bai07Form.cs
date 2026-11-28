namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public partial class Bai07Form : Form
{
    private QuanLyMonAnForm? formQuanLy;

    public Bai07Form()
    {
        InitializeComponent();
        CapNhatTrangThai();
    }

    private void CapNhatTrangThai()
    {
        var daDangNhap = PhienDangNhap.DaDangNhap();
        btnQuanLy.Enabled = daDangNhap;
        btnDangXuat.Enabled = daDangNhap;
        lblTrangThai.Text = daDangNhap
            ? "Xin chào, " + PhienDangNhap.TenDangNhap
            : "Chưa đăng nhập";
    }

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        using var form = new DangNhapForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            CapNhatTrangThai();
        }
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        using var form = new DangKyForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            lblTrangThai.Text = "Đăng ký thành công, hãy đăng nhập.";
        }
    }

    private void btnQuanLy_Click(object sender, EventArgs e)
    {
        if (!PhienDangNhap.DaDangNhap())
        {
            MessageBox.Show(this, "Hãy đăng nhập trước khi quản lý món ăn.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (formQuanLy == null || formQuanLy.IsDisposed)
        {
            formQuanLy = new QuanLyMonAnForm();
            formQuanLy.FormClosed += (_, _) => formQuanLy = null;
            formQuanLy.Show(this);
            return;
        }

        formQuanLy.Activate();
    }

    private void btnDangXuat_Click(object sender, EventArgs e)
    {
        PhienDangNhap.DangXuat();

        if (formQuanLy != null && !formQuanLy.IsDisposed)
        {
            formQuanLy.Close();
        }

        CapNhatTrangThai();
    }
}
