namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public static class PhienDangNhap
{
    public static string AccessToken = string.Empty;
    public static string TokenType = "Bearer";
    public static string TenDangNhap = string.Empty;

    public static bool DaDangNhap()
    {
        return AccessToken.Length > 0;
    }

    public static void DangXuat()
    {
        AccessToken = string.Empty;
        TokenType = "Bearer";
        TenDangNhap = string.Empty;
    }
}
