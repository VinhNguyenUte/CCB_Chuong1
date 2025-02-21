using System;
using System.Text;

namespace BT81_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập số c: ");
            double c = double.Parse(Console.ReadLine());

            double max = a; // Giả sử a là số lớn nhất

            if (b > max)
                max = b;
            if (c > max)
                max = c;

            Console.WriteLine($"Số lớn nhất trong 3 số là: {max}");
            Console.ReadKey();
        }

    }
}