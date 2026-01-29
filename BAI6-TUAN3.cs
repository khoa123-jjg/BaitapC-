using System.Text;

namespace BAI6_TUAN3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            Console.Write("Nhập số phần tử của mảng: ");
            String inputn = Console.ReadLine();
            int n = int.Parse(inputn);
            int[] mang = null;
            if (n > 0)
            {
                mang = new int[n];
            }
            if (mang == null)
            {
                Console.WriteLine("Lỗi: Mảng chưa được khỏi tạo");

            }
            Console.WriteLine("---Nhập mảng số nguyên---");
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Phần tử thứ [{i}]= ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int chan = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    chan++;
                }
            }
            Console.Write($"Tổng các số nguyên trong mảng là: {chan}");
        }
    }
}
