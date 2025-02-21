using System;
using System.Text;

namespace BT91_CCB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Các số nguyên dương lẻ nhỏ hơn 100:");

            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

    }
}