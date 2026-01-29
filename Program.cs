namespace ConsoleApp2
{
    internal class Program
    {
        static void Bai1()
        {
            Console.WriteLine("Nhập tên: ");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Tên không được để trống.");
                return;
            }
            string result = "";
            string name1 = name.Trim();
            string[] words = name1.Split();
            for (int i=0; i< words.Length-1; i++)
            {
                if (words[i]==" ")
                {
                    words[i + 1] = words[i + 1].ToUpper();
                    result +=" ";
                }
                result += words[i];
            }
            Console.WriteLine("Tên sau khi chuẩn hóa: " + result + " ");
