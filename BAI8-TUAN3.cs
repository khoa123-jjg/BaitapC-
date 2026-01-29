using System.Text;

namespace BAI8_TUAN3
{
    class Program
    {
        static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Phạm Nhật Khoa");
        Console.WriteLine("2415053122221");
        Console.Write("Nhập chuỗi ký tự: ");
        String CHUOIKYTU = Console.ReadLine();
        if (CHUOIKYTU != null)
        {
            String[] MangKyTu = CHUOIKYTU.Split(' ');
            if (MangKyTu != null)
            {
                String KyTuMax="";
                for (int i = 0; i < MangKyTu.Length; i++)
                    if (!string.IsNullOrEmpty(MangKyTu[i]))
                    {
                        if(KyTuMax.Length < MangKyTu[i].Length)
                        {
                            KyTuMax = MangKyTu[i];
                        }
                    }
                     Console.WriteLine($"Chuỗi ký tự dài nhất là: {KyTuMax}");
                }
        }
        else
        {
            Console.WriteLine("Lỗi: Chưa nhập chuỗi ký tự");
        }
    }
}
}
