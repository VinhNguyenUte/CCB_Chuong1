using System;
using System.Text;

namespace BT41_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            double S = 1.0; // Giá trị ban đầu
            for (int i = n - 1; i >= 0; i--)
            {
                S = 1.0 / (1 + S); // Tính từ trong ra ngoài
            }

            Console.WriteLine($"Giá trị của S({n}) = {S}");
            Console.ReadKey();
        }

    }
}