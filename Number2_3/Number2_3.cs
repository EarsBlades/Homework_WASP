using System;

namespace Number2_3
{
    class Number2_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 short: ");
            short s1 = short.Parse(Console.ReadLine());
            Console.Write("Введите 2 short: ");
            short s2 = short.Parse(Console.ReadLine());
            Console.Write("Введите 3 short: ");
            short s3 = short.Parse(Console.ReadLine());
            Console.Write("Введите 4 short: ");
            short s4 = short.Parse(Console.ReadLine());
            long res = 0, tmp = 0;
            res = s4;
            res <<= 48;
            tmp = s3;
            tmp <<= 32;
            res ^= tmp;
            tmp = 0;
            tmp = s2;
            tmp <<= 16;
            res ^= tmp;
            res ^= s1;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}