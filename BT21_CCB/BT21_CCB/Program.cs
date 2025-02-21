using System;
using System.Text;

namespace BT21_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i * i <= n; i++) // Duyệt từ 1 đến √n
            {
                if (n % i == 0) // Nếu i là ước của n
                {
                    sum += i; // Cộng ước số nhỏ hơn
                    if (i != n / i) // Nếu ước số lớn hơn khác i (tránh trùng khi i * i = n)
                    {
                        sum += n / i;
                    }
                }
            }

            Console.WriteLine($"Tổng các ước số của {n} là: {sum}");
            Console.ReadKey();
        }

    }
}