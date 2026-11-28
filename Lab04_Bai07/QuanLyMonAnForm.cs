namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public partial class QuanLyMonAnForm : Form
{
    private const int SoDongMoiTrang = 10;

    private int trangCuaToi = 1;
    private int tongCuaToi = 0;
    private int trangTatCa = 1;
    private int tongTatCa = 0;

    public QuanLyMonAnForm()
    {
        InitializeComponent();
        lblNguoiDung.Text = "Xin chào, " + PhienDangNhap.TenDangNhap;
    }

    private async void QuanLyMonAnForm_Load(object sender, EventArgs e)
    {
        ChuanBiBang(dgvCuaToi);
        ChuanBiBang(dgvTatCa);
        await TaiCuaToiAsync();
        await TaiTatCaAsync();
    }

    private void ChuanBiBang(DataGridView bang)
    {
        bang.AutoGenerateColumns = false;
        bang.Columns.Clear();
        bang.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Tên món ăn",
            FillWeight = 28
        });
        bang.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Giá",
            FillWeight = 14
        });
        bang.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Địa chỉ",
            FillWeight = 24
        });
        bang.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Người đóng góp",
            FillWeight = 17
        });
        bang.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Mô tả",
            FillWeight = 27
        });
    }

    private void HienThiDanhSach(DataGridView bang, List<MonAn> danhSach)
    {
        bang.Rows.Clear();
        foreach (var mon in danhSach)
        {
            var chiSo = bang.Rows.Add(
                mon.TenMonAn,
                mon.Gia.ToString("N0") + " đ",
                mon.DiaChi,
                mon.NguoiDongGop,
                mon.MoTa);
            bang.Rows[chiSo].Tag = mon.Id;
        }
    }

    private void CapNhatPhanTrangCuaToi()
    {
        var soTrang = Math.Max(1, (int)Math.Ceiling(tongCuaToi / (double)SoDongMoiTrang));
        lblTrangCuaToi.Text = $"Trang {trangCuaToi}/{soTrang}";
        btnTruocCuaToi.Enabled = trangCuaToi > 1;
        btnSauCuaToi.Enabled = trangCuaToi < soTrang;
    }

    private void CapNhatPhanTrangTatCa()
    {
        var soTrang = Math.Max(1, (int)Math.Ceiling(tongTatCa / (double)SoDongMoiTrang));
        lblTrangTatCa.Text = $"Trang {trangTatCa}/{soTrang}";
        btnTruocTatCa.Enabled = trangTatCa > 1;
        btnSauTatCa.Enabled = trangTatCa < soTrang;
    }

    private async Task TaiCuaToiAsync()
    {
        lblThongBao.Text = "Đang tải món ăn của bạn...";
        var ketQua = await ApiHelper.LayDanhSachAsync(
            "/api/v1/monan/my-dishes", trangCuaToi, SoDongMoiTrang);
        if (IsDisposed)
        {
            return;
        }

        if (!ketQua.ThanhCong)
        {
            lblThongBao.Text = ketQua.ThongBao;
            return;
        }

        tongCuaToi = ketQua.Tong;
        if (ketQua.DanhSach.Count == 0 && trangCuaToi > 1)
        {
            trangCuaToi--;
            await TaiCuaToiAsync();
            return;
        }

        HienThiDanhSach(dgvCuaToi, ketQua.DanhSach);
        CapNhatPhanTrangCuaToi();
        lblThongBao.Text = $"Có {tongCuaToi} món ăn do bạn đóng góp.";
    }

    private async Task TaiTatCaAsync()
    {
        lblThongBao.Text = "Đang tải món ăn cộng đồng...";
        var ketQua = await ApiHelper.LayDanhSachAsync(
            "/api/v1/monan/all", trangTatCa, SoDongMoiTrang);
        if (IsDisposed)
        {
            return;
        }

        if (!ketQua.ThanhCong)
        {
            lblThongBao.Text = ketQua.ThongBao;
            return;
        }

        tongTatCa = ketQua.Tong;
        if (ketQua.DanhSach.Count == 0 && trangTatCa > 1)
        {
            trangTatCa--;
            await TaiTatCaAsync();
            return;
        }

        HienThiDanhSach(dgvTatCa, ketQua.DanhSach);
        CapNhatPhanTrangTatCa();
        lblThongBao.Text = $"Cộng đồng có {tongTatCa} món ăn.";
    }

    private async void btnLamMoiCuaToi_Click(object sender, EventArgs e)
    {
        await TaiCuaToiAsync();
    }

    private async void btnLamMoiTatCa_Click(object sender, EventArgs e)
    {
        await TaiTatCaAsync();
    }

    private async void btnTruocCuaToi_Click(object sender, EventArgs e)
    {
        if (trangCuaToi > 1)
        {
            trangCuaToi--;
            await TaiCuaToiAsync();
        }
    }

    private async void btnSauCuaToi_Click(object sender, EventArgs e)
    {
        trangCuaToi++;
        await TaiCuaToiAsync();
    }

    private async void btnTruocTatCa_Click(object sender, EventArgs e)
    {
        if (trangTatCa > 1)
        {
            trangTatCa--;
            await TaiTatCaAsync();
        }
    }

    private async void btnSauTatCa_Click(object sender, EventArgs e)
    {
        trangTatCa++;
        await TaiTatCaAsync();
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (dgvCuaToi.CurrentRow == null || dgvCuaToi.CurrentRow.Tag == null)
        {
            MessageBox.Show(this, "Hãy chọn món ăn cần xóa.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var id = Convert.ToInt32(dgvCuaToi.CurrentRow.Tag);
        var tenMon = dgvCuaToi.CurrentRow.Cells[0].Value?.ToString() ?? "";
        if (MessageBox.Show(this, "Xóa món \"" + tenMon + "\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        var ketQua = await ApiHelper.XoaMonAnAsync(id);
        MessageBox.Show(this, ketQua.ThongBao, "Thông báo",
            MessageBoxButtons.OK, ketQua.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        if (ketQua.ThanhCong)
        {
            await TaiCuaToiAsync();
            await TaiTatCaAsync();
        }
    }

    private async void btnRandomCuaToi_Click(object sender, EventArgs e)
    {
        await HienThiMonNgauNhienAsync(true);
    }

    private async void btnRandomTatCa_Click(object sender, EventArgs e)
    {
        await HienThiMonNgauNhienAsync(false);
    }

    private async Task HienThiMonNgauNhienAsync(bool cuaToi)
    {
        lblThongBao.Text = "Đang chọn món ngẫu nhiên...";
        var mon = await ApiHelper.LayMonAnNgauNhienAsync(cuaToi);
        if (IsDisposed)
        {
            return;
        }

        if (mon == null)
        {
            lblThongBao.Text = "Không có món ăn nào để chọn.";
            MessageBox.Show(this, "Chưa có món ăn nào trong danh sách.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        lblThongBao.Text = "Hôm nay ăn: " + mon.TenMonAn;
        var noiDung =
            "HÔM NAY ĂN GÌ?\r\n\r\n" +
            $"Món ăn: {mon.TenMonAn}\r\n" +
            $"Giá: {mon.Gia:N0} đ\r\n" +
            $"Địa chỉ: {mon.DiaChi}\r\n" +
            $"Người đóng góp: {mon.NguoiDongGop}\r\n" +
            $"Mô tả: {mon.MoTa}\r\n" +
            $"Hình ảnh: {mon.HinhAnh}";

        MessageBox.Show(this, noiDung, "Hôm nay ăn gì?", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        var tenMonAn = txtTenMonAn.Text.Trim();
        if (tenMonAn.Length == 0)
        {
            MessageBox.Show(this, "Chưa nhập tên món ăn.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMonAn.Focus();
            return;
        }

        if (!decimal.TryParse(txtGia.Text.Trim(), out var gia) || gia <= 0)
        {
            MessageBox.Show(this, "Giá phải là số lớn hơn 0.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtGia.Focus();
            return;
        }

        btnThem.Enabled = false;
        lblThongBao.Text = "Đang thêm món ăn...";
        var ketQua = await ApiHelper.ThemMonAnAsync(
            tenMonAn, txtMoTa.Text.Trim(), txtHinhAnh.Text.Trim(), gia, txtDiaChi.Text.Trim());
        if (IsDisposed)
        {
            return;
        }

        btnThem.Enabled = true;
        MessageBox.Show(this, ketQua.ThongBao, "Thông báo",
            MessageBoxButtons.OK, ketQua.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        if (!ketQua.ThanhCong)
        {
            lblThongBao.Text = ketQua.ThongBao;
            return;
        }

        txtTenMonAn.Clear();
        txtMoTa.Clear();
        txtHinhAnh.Clear();
        txtGia.Clear();
        txtDiaChi.Clear();

        trangCuaToi = 1;
        trangTatCa = 1;
        await TaiCuaToiAsync();
        await TaiTatCaAsync();
        tabControl.SelectedTab = tabCuaToi;
    }
}
