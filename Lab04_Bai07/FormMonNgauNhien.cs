namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public partial class FormMonNgauNhien : Form
{
    private readonly MonAn mon;

    public FormMonNgauNhien(MonAn mon)
    {
        InitializeComponent();
        this.mon = mon;

        Text = "Ăn " + mon.TenMonAn + " đi!!!";
        lblTen.Text = mon.TenMonAn;
        lblGia.Text = "Giá: " + mon.Gia.ToString("N0") + " đ";
        lblDiaChi.Text = "Địa chỉ: " + mon.DiaChi;
        lblNguoiDongGop.Text = "Đóng góp: " + mon.NguoiDongGop;
        lblMoTa.Text = mon.MoTa;
    }

    private async void FormMonNgauNhien_Load(object sender, EventArgs e)
    {
        picAnh.Image = AnhMonAnHelper.LayAnhCucBo(mon.TenMonAn);

        var anh = await AnhMonAnHelper.TaiAnhTuXaAsync(mon);
        if (IsDisposed)
        {
            anh?.Dispose();
            return;
        }

        if (anh == null)
        {
            return;
        }

        var hinhCu = picAnh.Image;
        picAnh.Image = anh;
        hinhCu?.Dispose();
    }
}
