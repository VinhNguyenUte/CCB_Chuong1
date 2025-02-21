using System;
using System.Text;

namespace BT51_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int maxDigit = 0; // Biến lưu chữ số lớn nhất

            while (n > 0)
            {
                int digit = n % 10; // Lấy chữ số cuối
                if (digit > maxDigit)
                {
                    maxDigit = digit; // Cập nhật chữ số lớn nhất
                }
                n /= 10; // Bỏ chữ số cuối
            }

            Console.WriteLine($"Chữ số lớn nhất là: {maxDigit}");
            Console.ReadKey();
        }

    }
}