using System;
using System.Text;

namespace BT61_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            if (IsDecreasing(n))
            {
                Console.WriteLine($"{n} có các chữ số giảm dần từ trái sang phải.");
            }
            else
            {
                Console.WriteLine($"{n} KHÔNG có các chữ số giảm dần từ trái sang phải.");
            }
            Console.ReadKey();
        }

        static bool IsDecreasing(int n)
        {
            string numStr = n.ToString(); // Chuyển số thành chuỗi
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] <= numStr[i + 1]) // Nếu không giảm dần
                    return false;
            }
            return true;
        }

    }
}