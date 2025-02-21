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

            for (int bien223 = 1; bien223 < 100; bien223 += 2)
            {
                Console.Write(bien223 + " ");
            }
            Console.ReadKey();
        }

    }
}