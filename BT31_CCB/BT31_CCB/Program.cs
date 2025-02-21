using System;
using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int bien223 = int.Parse(Console.ReadLine());

        if (IsPrime(bien223))
        {
            Console.WriteLine($"{bien223} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{bien223} không phải là số nguyên tố.");
        }
        Console.ReadKey();
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false; // Số nhỏ hơn 2 không phải số nguyên tố
        if (n == 2) return true; // 2 là số nguyên tố duy nhất chẵn
        if (n % 2 == 0) return false; // Số chẵn khác 2 không phải số nguyên tố

        // Kiểm tra từ 3 đến √n, chỉ kiểm tra số lẻ
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false; // Nếu chia hết thì không phải số nguyên tố
        }

        return true; // Nếu không tìm thấy ước nào khác ngoài 1 và n, là số nguyên tố
    }
}
