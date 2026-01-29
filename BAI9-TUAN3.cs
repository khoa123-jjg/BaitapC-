using System.Text;

namespace BAI9_TUAN3
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
                    int sophantu = 0;
                    for (int i = 0; i < MangKyTu.Length; i++)
                        if (!string.IsNullOrEmpty(MangKyTu[i]))
                        {
                            sophantu++;
                        }
                    Console.WriteLine($"Số phần tử khác null or rổng: {sophantu}");
                }
            }
            else
            {
                Console.WriteLine("Lỗi: Chưa nhập chuỗi ký tự");
            }
        }
    }
}
