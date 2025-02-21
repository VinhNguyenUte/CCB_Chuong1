using System;
using System.Text;

namespace BT11_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            long bien223 = 0;
            long factorial = 1; // Giai thừa
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; // Tính giai thừa i!
                bien223 += factorial; // Cộng vào tổng
            }

            Console.WriteLine($"Tổng S({n}) = {bien223}");
            Console.ReadKey();
        }

    }
}