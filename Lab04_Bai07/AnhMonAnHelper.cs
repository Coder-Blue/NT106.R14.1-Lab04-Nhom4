using System.Drawing;

namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public static class AnhMonAnHelper
{
    private static readonly HttpClient Http = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

    public static Image? LayAnhCucBo(string tenMonAn)
    {
        var ten = tenMonAn.ToLowerInvariant();
        string tenFile;

        if (ten.Contains("bún riêu") || ten.Contains("bun rieu"))
        {
            tenFile = "bun-rieu.jpg";
        }
        else if (ten.Contains("bún thịt") || ten.Contains("bun thit"))
        {
            tenFile = "bun-thit-nuong.jpg";
        }
        else if (ten.Contains("phở") || ten.Contains("pho"))
        {
            tenFile = "pho.jpg";
        }
        else if (ten.Contains("cơm tấm") || ten.Contains("com tam"))
        {
            tenFile = "com-tam.jpg";
        }
        else if (ten.Contains("gỏi cuốn") || ten.Contains("goi cuon"))
        {
            tenFile = "goi-cuon.jpg";
        }
        else if (ten.Contains("bún") || ten.Contains("bun"))
        {
            tenFile = "bun-rieu.jpg";
        }
        else
        {
            tenFile = "default.png";
        }

        var duongDan = Path.Combine(AppContext.BaseDirectory, "hinh-anh", tenFile);
        if (!File.Exists(duongDan))
        {
            duongDan = Path.Combine(AppContext.BaseDirectory, "hinh-anh", "default.png");
        }

        if (!File.Exists(duongDan))
        {
            return null;
        }

        using var luong = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
        using var hinh = Image.FromStream(luong);
        return new Bitmap(hinh);
    }

    public static async Task<Image?> TaiAnhTuXaAsync(MonAn mon)
    {
        if (!Uri.TryCreate(mon.HinhAnh, UriKind.Absolute, out var diaChiAnh) ||
            (diaChiAnh.Scheme != Uri.UriSchemeHttp && diaChiAnh.Scheme != Uri.UriSchemeHttps))
        {
            return null;
        }

        try
        {
            var duLieu = await Http.GetByteArrayAsync(diaChiAnh);
            using var luong = new MemoryStream(duLieu);
            using var hinh = Image.FromStream(luong);
            return new Bitmap(hinh);
        }
        catch
        {
            return null;
        }
    }
}
