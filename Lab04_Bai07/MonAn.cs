namespace NT106.R14._1_Lab04_Nhom4.Bai07;

public class MonAn
{
    public int Id = 0;
    public string TenMonAn = string.Empty;
    public double Gia = 0;
    public string MoTa = string.Empty;
    public string DiaChi = string.Empty;
    public string HinhAnh = string.Empty;
    public string NguoiDongGop = string.Empty;
}

public class KetQuaDanhSach
{
    public List<MonAn> DanhSach = new List<MonAn>();
    public int Tong = 0;
    public bool ThanhCong = false;
    public string ThongBao = string.Empty;
}
