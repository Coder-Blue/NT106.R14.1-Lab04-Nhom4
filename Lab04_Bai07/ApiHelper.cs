using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public static class ApiHelper
{
    private const string DiaChiGoc = "https://nt106.uitiot.vn";

    private static readonly HttpClient Http = TaoHttpClient();
    private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        IncludeFields = true
    };

    private static HttpClient TaoHttpClient()
    {
        var client = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) NT106-Lab04");
        return client;
    }

    private static HttpRequestMessage TaoYeuCau(HttpMethod phuongThuc, string duongDan)
    {
        var yeuCau = new HttpRequestMessage(phuongThuc, DiaChiGoc + duongDan);
        if (PhienDangNhap.DaDangNhap())
        {
            var kieuToken = PhienDangNhap.TokenType.Length == 0 ? "Bearer" : PhienDangNhap.TokenType;
            yeuCau.Headers.Authorization = new AuthenticationHeaderValue(kieuToken, PhienDangNhap.AccessToken);
        }

        return yeuCau;
    }

    private static StringContent NoiDungJson(object duLieu)
    {
        var json = JsonSerializer.Serialize(duLieu);
        return new StringContent(json, Encoding.UTF8, "application/json");
    }

    private static string LayThongBaoLoi(string chuoi, string macDinh)
    {
        if (string.IsNullOrWhiteSpace(chuoi))
        {
            return macDinh;
        }

        try
        {
            using var taiLieu = JsonDocument.Parse(chuoi);
            if (taiLieu.RootElement.TryGetProperty("detail", out var chiTiet))
            {
                if (chiTiet.ValueKind == JsonValueKind.String)
                {
                    return chiTiet.GetString() ?? macDinh;
                }

                return chiTiet.ToString();
            }
        }
        catch
        {
            // Trả về thông báo mặc định nếu body không phải JSON.
        }

        return macDinh;
    }

    public static async Task<(bool ThanhCong, string ThongBao)> DangNhapAsync(string tenDangNhap, string matKhau)
    {
        try
        {
            var duLieu = new Dictionary<string, string>
            {
                { "username", tenDangNhap },
                { "password", matKhau }
            };

            using var phanHoi = await Http.PostAsync(
                DiaChiGoc + "/auth/token", new FormUrlEncodedContent(duLieu));
            var chuoi = await phanHoi.Content.ReadAsStringAsync();

            if (!phanHoi.IsSuccessStatusCode)
            {
                return (false, LayThongBaoLoi(chuoi, "Tên đăng nhập hoặc mật khẩu không đúng."));
            }

            using var taiLieu = JsonDocument.Parse(chuoi);
            var goc = taiLieu.RootElement;
            if (!goc.TryGetProperty("access_token", out var token))
            {
                return (false, "Không đọc được access_token từ server.");
            }

            PhienDangNhap.AccessToken = token.GetString() ?? string.Empty;
            PhienDangNhap.TokenType = goc.TryGetProperty("token_type", out var kieuToken)
                ? kieuToken.GetString() ?? "Bearer"
                : "Bearer";
            PhienDangNhap.TenDangNhap = tenDangNhap;

            return (true, "Đăng nhập thành công.");
        }
        catch (Exception ex)
        {
            return (false, "Lỗi kết nối: " + ex.Message);
        }
    }

    public static async Task<(bool ThanhCong, string ThongBao)> DangKyAsync(
        string tenDangNhap, string email, string matKhau, string ho, string ten)
    {
        try
        {
            var duLieu = new Dictionary<string, string>
            {
                { "username", tenDangNhap },
                { "email", email },
                { "password", matKhau },
                { "first_name", ten },
                { "last_name", ho }
            };

            using var phanHoi = await Http.PostAsync(
                DiaChiGoc + "/api/v1/user/signup", new FormUrlEncodedContent(duLieu));
            var chuoi = await phanHoi.Content.ReadAsStringAsync();

            if (!phanHoi.IsSuccessStatusCode)
            {
                return (false, LayThongBaoLoi(chuoi, "Đăng ký thất bại."));
            }

            return (true, "Đăng ký thành công. Hãy đăng nhập lại.");
        }
        catch (Exception ex)
        {
            return (false, "Lỗi kết nối: " + ex.Message);
        }
    }

    public static async Task<KetQuaDanhSach> LayDanhSachAsync(string duongDan, int trang, int soLuong)
    {
        var ketQua = new KetQuaDanhSach();
        try
        {
            var duLieu = new Dictionary<string, object>
            {
                { "current", trang },
                { "pageSize", soLuong }
            };

            using var yeuCau = TaoYeuCau(HttpMethod.Post, duongDan);
            yeuCau.Content = NoiDungJson(duLieu);

            using var phanHoi = await Http.SendAsync(yeuCau);
            var chuoi = await phanHoi.Content.ReadAsStringAsync();

            if (!phanHoi.IsSuccessStatusCode)
            {
                ketQua.ThongBao = LayThongBaoLoi(chuoi, "Không lấy được danh sách món ăn.");
                if (phanHoi.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    ketQua.ThongBao = "Phiên đăng nhập đã hết hạn. Hãy đăng nhập lại.";
                }

                return ketQua;
            }

            using var taiLieu = JsonDocument.Parse(chuoi);
            var goc = taiLieu.RootElement;
            var phanDuLieu = goc;

            if (goc.ValueKind == JsonValueKind.Object)
            {
                if (!goc.TryGetProperty("data", out phanDuLieu))
                {
                    ketQua.ThongBao = "Dữ liệu trả về không có trường data.";
                    return ketQua;
                }

                if (phanDuLieu.ValueKind == JsonValueKind.Object &&
                    phanDuLieu.TryGetProperty("data", out var phanBenTrong))
                {
                    phanDuLieu = phanBenTrong;
                }

                if (goc.TryGetProperty("pagination", out var phanTrang) &&
                    phanTrang.TryGetProperty("total", out var tong) &&
                    tong.TryGetInt32(out var soTong))
                {
                    ketQua.Tong = soTong;
                }
            }

            ketQua.DanhSach = JsonSerializer.Deserialize<List<MonAn>>(phanDuLieu.GetRawText(), JsonOptions)
                ?? new List<MonAn>();
            if (ketQua.Tong == 0)
            {
                ketQua.Tong = ketQua.DanhSach.Count;
            }

            ketQua.ThanhCong = true;
            return ketQua;
        }
        catch (Exception ex)
        {
            ketQua.ThongBao = "Lỗi kết nối: " + ex.Message;
            return ketQua;
        }
    }

    public static async Task<(bool ThanhCong, string ThongBao)> ThemMonAnAsync(
        string tenMonAn, string moTa, string hinhAnh, decimal gia, string diaChi)
    {
        try
        {
            var duLieu = new Dictionary<string, object>
            {
                { "ten_mon_an", tenMonAn },
                { "mo_ta", moTa },
                { "hinh_anh", hinhAnh },
                { "gia", gia },
                { "dia_chi", diaChi }
            };

            using var yeuCau = TaoYeuCau(HttpMethod.Post, "/api/v1/monan/add");
            yeuCau.Content = NoiDungJson(duLieu);

            using var phanHoi = await Http.SendAsync(yeuCau);
            var chuoi = await phanHoi.Content.ReadAsStringAsync();
            if (!phanHoi.IsSuccessStatusCode)
            {
                return (false, LayThongBaoLoi(chuoi, "Thêm món ăn thất bại."));
            }

            return (true, "Thêm món ăn thành công.");
        }
        catch (Exception ex)
        {
            return (false, "Lỗi kết nối: " + ex.Message);
        }
    }

    public static async Task<(bool ThanhCong, string ThongBao)> XoaMonAnAsync(int id)
    {
        try
        {
            using var yeuCau = TaoYeuCau(HttpMethod.Delete, "/api/v1/monan/" + id);
            using var phanHoi = await Http.SendAsync(yeuCau);
            var chuoi = await phanHoi.Content.ReadAsStringAsync();
            if (!phanHoi.IsSuccessStatusCode)
            {
                return (false, LayThongBaoLoi(chuoi, "Xóa món ăn thất bại."));
            }

            return (true, "Xóa món ăn thành công.");
        }
        catch (Exception ex)
        {
            return (false, "Lỗi kết nối: " + ex.Message);
        }
    }

    public static async Task<List<MonAn>> LayTatCaMonAnAsync(string duongDan)
    {
        var ketQua = new List<MonAn>();
        var trang = 1;

        while (trang <= 50)
        {
            var duLieu = await LayDanhSachAsync(duongDan, trang, 100);
            if (!duLieu.ThanhCong)
            {
                break;
            }

            ketQua.AddRange(duLieu.DanhSach);
            if (duLieu.DanhSach.Count == 0 || ketQua.Count >= duLieu.Tong)
            {
                break;
            }

            trang++;
        }

        return ketQua;
    }

    public static async Task<MonAn?> LayMonAnNgauNhienAsync(bool cuaToi)
    {
        var duongDan = cuaToi ? "/api/v1/monan/my-dishes" : "/api/v1/monan/all";
        var danhSach = await LayTatCaMonAnAsync(duongDan);
        if (danhSach.Count == 0)
        {
            return null;
        }

        return danhSach[Random.Shared.Next(danhSach.Count)];
    }
}
