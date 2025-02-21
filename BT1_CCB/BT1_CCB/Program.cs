using System;
using System.Text;

namespace BT1_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int bien223 = 0;
            for (int i = 1; i <= n; i++)
            {
                bien223 += i;
            }

            Console.WriteLine($"Tổng S({n}) = {bien223}");
            Console.ReadKey();
        }

    }
}