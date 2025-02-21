using System;
using System.Text;

namespace BT71_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên dương n: ");
            int bien223 = int.Parse(Console.ReadLine());

            double S = 0; // Khởi tạo tổng
            for (int i = 1; i <= bien223; i++)
            {
                double numerator = Math.Pow(x, i); // x^i
                double denominator = i * (i + 1) / 2.0; // Tổng 1 + 2 + ... + i
                double term = Math.Pow(-1, i) * (numerator / denominator); // (-1)^i * x^i / (1+2+...+i)

                S += term; // Cộng vào tổng
            }

            Console.WriteLine($"Giá trị của S({x}, {bien223}) = {S}");
            Console.ReadKey();
        }

    }
}