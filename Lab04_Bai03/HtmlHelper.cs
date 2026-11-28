using HtmlAgilityPack;

namespace NT106.R14._1_Lab04_Nhom4.Bai03;

public static class HtmlHelper
{
    public static List<Uri> LayDanhSachAnh(string html, Uri pageUri)
    {
        var document = new HtmlAgilityPack.HtmlDocument();
        document.LoadHtml(html);

        var baseUri = pageUri;
        var baseNode = document.DocumentNode.SelectSingleNode("//base[@href]");
        if (baseNode != null &&
            Uri.TryCreate(pageUri, baseNode.GetAttributeValue("href", ""), out var b))
        {
            baseUri = b;
        }

        var ketQua = new List<Uri>();
        var daCo = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        void ThemAnh(string src)
        {
            if (string.IsNullOrWhiteSpace(src) ||
                src.StartsWith("data:", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            src = HtmlEntity.DeEntitize(src.Trim());
            if (Uri.TryCreate(baseUri, src, out var uri) &&
                (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps) &&
                daCo.Add(uri.AbsoluteUri))
            {
                ketQua.Add(uri);
            }
        }

        foreach (var img in document.DocumentNode.Descendants("img"))
        {
            var src = img.GetAttributeValue("data-src", "");
            if (string.IsNullOrWhiteSpace(src))
            {
                src = img.GetAttributeValue("data-original", "");
            }
            if (string.IsNullOrWhiteSpace(src))
            {
                src = img.GetAttributeValue("data-lazy-src", "");
            }
            if (string.IsNullOrWhiteSpace(src))
            {
                src = img.GetAttributeValue("src", "");
            }

            ThemAnh(src);

            var srcset = img.GetAttributeValue("srcset", "");
            if (!string.IsNullOrWhiteSpace(srcset))
            {
                ThemAnh(srcset.Split(',')[0].Trim().Split(' ')[0]);
            }
        }

        foreach (var source in document.DocumentNode.Descendants("source"))
        {
            var srcset = source.GetAttributeValue("srcset", "");
            if (!string.IsNullOrWhiteSpace(srcset))
            {
                ThemAnh(srcset.Split(',')[0].Trim().Split(' ')[0]);
            }
        }

        return ketQua;
    }

    public static string LayTenFile(Uri uri, HashSet<string> daDung)
    {
        var ten = LamTenAnToan(Path.GetFileName(Uri.UnescapeDataString(uri.AbsolutePath)));
        if (string.IsNullOrWhiteSpace(ten))
        {
            ten = "hinh";
        }
        if (!Path.HasExtension(ten))
        {
            ten += ".jpg";
        }

        var goc = Path.GetFileNameWithoutExtension(ten);
        var duoi = Path.GetExtension(ten);
        var i = 1;
        while (!daDung.Add(ten))
        {
            ten = $"{goc}_{i++}{duoi}";
        }

        return ten;
    }

    public static string LamTenAnToan(string ten)
    {
        foreach (var c in Path.GetInvalidFileNameChars())
        {
            ten = ten.Replace(c, '_');
        }

        return ten.Trim().TrimEnd('.');
    }
}
