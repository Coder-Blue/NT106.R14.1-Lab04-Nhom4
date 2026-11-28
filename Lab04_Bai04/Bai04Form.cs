using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace NT106.R14._1_Lab04_Nhom4.Bai04;

public partial class Bai04Form : Form
{
    private const string UrlMacDinh = "https://betacinemas.vn/phim.htm";
    private const string TenFileJson = "phim_betacine.json";

    private static readonly HttpClient Http = TaoHttpClient();
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        IncludeFields = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private static readonly decimal[] GiaTheoLoaiGhe = { 70000, 100000, 150000 };

    private Phim? phimDangChon;

    public Bai04Form()
    {
        InitializeComponent();
        txtUrl.Text = UrlMacDinh;
        cboLoaiGhe.SelectedIndex = 0;
        CapNhatTongTien();
    }

    private static HttpClient TaoHttpClient()
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(60) };
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0 Safari/537.36");
        return client;
    }

    private async void btnTai_Click(object sender, EventArgs e)
    {
        if (!Uri.TryCreate(txtUrl.Text.Trim(), UriKind.Absolute, out var diaChi) ||
            (diaChi.Scheme != Uri.UriSchemeHttp && diaChi.Scheme != Uri.UriSchemeHttps))
        {
            MessageBox.Show(this, "Địa chỉ phải bắt đầu bằng http:// hoặc https://.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUrl.Focus();
            return;
        }

        btnTai.Enabled = false;
        flpPhim.Controls.Clear();
        progressBar.Value = 5;
        lblTrangThai.Text = "Đang tải trang " + diaChi + " ...";

        try
        {
            var html = await Http.GetStringAsync(diaChi);
            var danhSach = await Task.Run(() => TrichXuatPhim(html, diaChi));

            if (danhSach.Count == 0)
            {
                progressBar.Value = 0;
                lblTrangThai.Text = "Không tìm thấy phim nào trên trang.";
                MessageBox.Show(this, "Không trích xuất được phim nào. Có thể cấu trúc trang đã thay đổi.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (var i = 0; i < danhSach.Count; i++)
            {
                flpPhim.Controls.Add(TaoThePhim(danhSach[i]));
                progressBar.Value = 10 + (int)((i + 1) * 85.0 / danhSach.Count);
            }

            var tenFile = Path.Combine(Application.StartupPath, TenFileJson);
            try
            {
                var json = JsonSerializer.Serialize(danhSach, JsonOptions);
                await File.WriteAllTextAsync(tenFile, json);
                lblTrangThai.Text = $"Đã trích xuất {danhSach.Count} phim và lưu vào {tenFile}";
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = $"Đã trích xuất {danhSach.Count} phim nhưng chưa lưu được JSON: {ex.Message}";
            }

            progressBar.Value = 100;
        }
        catch (Exception ex)
        {
            progressBar.Value = 0;
            lblTrangThai.Text = "Tải dữ liệu thất bại.";
            MessageBox.Show(this, "Không tải được dữ liệu phim.\n\n" + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnTai.Enabled = true;
        }
    }

    private static List<Phim> TrichXuatPhim(string html, Uri diaChiTrang)
    {
        var ketQua = new List<Phim>();
        var daCo = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        var document = new HtmlAgilityPack.HtmlDocument();
        document.LoadHtml(html);

        var cacKhoiPhim = document.DocumentNode.SelectNodes(
            "//div[contains(concat(' ', normalize-space(@class), ' '), ' film-info ')]");
        if (cacKhoiPhim == null)
        {
            return ketQua;
        }

        foreach (var khoi in cacKhoiPhim)
        {
            var tieuDe = khoi.SelectSingleNode(".//h3");
            var lienKet = tieuDe?.SelectSingleNode(".//a[@href]");
            if (tieuDe == null || lienKet == null)
            {
                continue;
            }

            var href = lienKet.GetAttributeValue("href", string.Empty).Trim();
            if (!Uri.TryCreate(diaChiTrang, href, out var duongDanChiTiet) ||
                !daCo.Add(duongDanChiTiet.AbsoluteUri))
            {
                continue;
            }

            var tenPhim = HtmlEntity.DeEntitize(tieuDe.GetAttributeValue("title", string.Empty)).Trim();
            if (tenPhim.Length == 0)
            {
                tenPhim = HtmlEntity.DeEntitize(lienKet.InnerText).Trim();
            }

            var theLoai = string.Empty;
            var thoiLuong = string.Empty;
            var cacDong = khoi.SelectNodes(".//li");
            if (cacDong != null && cacDong.Count > 0)
            {
                theLoai = LayGiaTriDong(cacDong[0]);
                if (cacDong.Count > 1)
                {
                    thoiLuong = LayGiaTriDong(cacDong[1]);
                }
            }

            var hang = khoi.Ancestors("div")
                .FirstOrDefault(d => d.GetAttributeValue("class", string.Empty)
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Contains("row"));
            var anh = hang?.SelectSingleNode(".//div[contains(@class,'product-item')]//img");
            var hinhAnh = anh?.GetAttributeValue("src", string.Empty).Trim() ?? string.Empty;
            if (hinhAnh.Length > 0 && Uri.TryCreate(diaChiTrang, hinhAnh, out var diaChiAnh))
            {
                hinhAnh = diaChiAnh.AbsoluteUri;
            }

            ketQua.Add(new Phim
            {
                TenPhim = tenPhim,
                TheLoai = theLoai,
                ThoiLuong = thoiLuong,
                HinhAnh = hinhAnh,
                DuongDanChiTiet = duongDanChiTiet.AbsoluteUri
            });
        }

        return ketQua;
    }

    private static string LayGiaTriDong(HtmlNode dong)
    {
        var nhan = dong.SelectSingleNode(".//span");
        var noiDung = dong.InnerText;
        if (nhan != null)
        {
            noiDung = noiDung.Replace(nhan.InnerText, string.Empty);
        }

        noiDung = HtmlEntity.DeEntitize(noiDung);
        return Regex.Replace(noiDung, @"\s+", " ").Trim();
    }

    private Panel TaoThePhim(Phim phim)
    {
        var the = new Panel
        {
            Width = 225,
            Height = 350,
            BorderStyle = BorderStyle.FixedSingle,
            BackColor = Color.White,
            Margin = new Padding(8)
        };

        var anh = new PictureBox
        {
            Location = new Point(10, 10),
            Size = new Size(203, 268),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.FromArgb(240, 240, 240),
            Cursor = Cursors.Hand
        };

        if (!string.IsNullOrWhiteSpace(phim.HinhAnh))
        {
            try
            {
                anh.LoadAsync(phim.HinhAnh);
            }
            catch
            {
                // Bỏ qua ảnh lỗi, vẫn hiển thị phần thông tin phim.
            }
        }

        anh.Click += (_, _) => MoChiTiet(phim);

        var ten = new Label
        {
            Location = new Point(8, 283),
            Size = new Size(207, 34),
            Text = phim.TenPhim,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Cursor = Cursors.Hand
        };
        ten.Click += (_, _) => ChonPhim(phim);

        var btnChon = new Button
        {
            Location = new Point(58, 318),
            Size = new Size(108, 26),
            Text = "Chọn vé",
            BackColor = Color.FromArgb(51, 122, 183),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Cursor = Cursors.Hand
        };
        btnChon.FlatAppearance.BorderSize = 0;
        btnChon.Click += (_, _) => ChonPhim(phim);

        the.Controls.Add(anh);
        the.Controls.Add(ten);
        the.Controls.Add(btnChon);
        return the;
    }

    private void MoChiTiet(Phim phim)
    {
        var form = new FormChiTietPhim(phim.TenPhim, phim.DuongDanChiTiet);
        form.Show(this);
    }

    private void ChonPhim(Phim phim)
    {
        phimDangChon = phim;
        lblPhimChon.Text = $"Phim: {phim.TenPhim}\n{phim.TheLoai} - {phim.ThoiLuong}";
        CapNhatTongTien();
    }

    private decimal LayGiaVe()
    {
        var chiSo = cboLoaiGhe.SelectedIndex;
        if (chiSo < 0 || chiSo >= GiaTheoLoaiGhe.Length)
        {
            return GiaTheoLoaiGhe[0];
        }

        return GiaTheoLoaiGhe[chiSo];
    }

    private void CapNhatTongTien()
    {
        var tongTien = LayGiaVe() * numSoLuong.Value;
        lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
    }

    private void cboLoaiGhe_SelectedIndexChanged(object sender, EventArgs e) => CapNhatTongTien();

    private void numSoLuong_ValueChanged(object sender, EventArgs e) => CapNhatTongTien();

    private void btnDatVe_Click(object sender, EventArgs e)
    {
        if (phimDangChon == null)
        {
            MessageBox.Show(this, "Hãy chọn một bộ phim trước khi đặt vé.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var tenKhach = txtKhachHang.Text.Trim();
        var soDienThoai = txtSoDienThoai.Text.Trim();
        if (tenKhach.Length == 0)
        {
            MessageBox.Show(this, "Chưa nhập họ tên khách hàng.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtKhachHang.Focus();
            return;
        }

        if (soDienThoai.Length == 0)
        {
            MessageBox.Show(this, "Chưa nhập số điện thoại khách hàng.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return;
        }

        var soLuong = (int)numSoLuong.Value;
        var donGia = LayGiaVe();
        var tongTien = donGia * soLuong;
        var loaiGhe = cboLoaiGhe.Text.Split('-')[0].Trim();

        var thongTin =
            "ĐẶT VÉ THÀNH CÔNG\r\n\r\n" +
            $"Khách hàng: {tenKhach}\r\n" +
            $"Số điện thoại: {soDienThoai}\r\n" +
            $"Phim: {phimDangChon.TenPhim}\r\n" +
            $"Thể loại: {phimDangChon.TheLoai}\r\n" +
            $"Thời lượng: {phimDangChon.ThoiLuong}\r\n" +
            $"Loại ghế: {loaiGhe}\r\n" +
            $"Số lượng vé: {soLuong}\r\n" +
            $"Đơn giá: {donGia:N0} đ\r\n" +
            $"Tổng thanh toán: {tongTien:N0} đ";

        MessageBox.Show(this, thongTin, "Thông tin đặt vé",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
