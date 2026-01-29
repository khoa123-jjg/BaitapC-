using System.Text;

namespace BAI7_TUAN3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            Console.Write("Nhập họ tên: ");
            String HOTEN = Console.ReadLine();
            if (HOTEN != null)
            {
                String[] MangKyTu = HOTEN.Split(' ');
                if (MangKyTu != null)
                {
                    for (int i = 0; i < MangKyTu.Length; i++)
                        if (!string.IsNullOrEmpty(MangKyTu[i]))
                        {
                            Console.WriteLine(MangKyTu[i]);
                        }
                }
            }
            else
            {
                Console.WriteLine("Lỗi: Chưa nhập họ tên");
                return;
            }
        }
    }
}
