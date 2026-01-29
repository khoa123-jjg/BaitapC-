using System.Text;

namespace BAI5_TUAN3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            Console.Write("Nhập số phần tử của mảng: ");
            string inputn = Console.ReadLine();
            int n = int.Parse(inputn);
            int[] mang=null;
            if (n > 0)
            {
                mang = new int[n];
            }
            if(mang == null)
            {
                Console.WriteLine("Lỗi: Mảng chưa được khỏi tạo");
            }
            Console.WriteLine("---Nhập các phần tử của mảng---");
            for (int i=0; i<mang.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}= ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for(int i=0;i<mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            Console.Write($"Số lớn nhất trong mảng là: {max}");
        }
    }
}
