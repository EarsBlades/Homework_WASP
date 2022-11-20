using System;

namespace Number2_1
{
    class Number2_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для перевода в бинарный вид: ");
            uint n = uint.Parse(Console.ReadLine());
            int counter = 0;
            double d = Convert.ToDouble(n);
            while (d > 1.0)
            {
                d /= 2;
                counter += 1;
            }
            Console.WriteLine(counter);
            if (n % 2 == 1)
            {
                for (int i = 0; i < counter; ++i)
                {
                    Console.Write((n >> i) & 1);
                }
            }
            else
            {
                for (int i = counter; i >= 0; --i)
                {
                    if (i > 1)
                        Console.Write((n >> i) & 1);
                }
            }
        }
    }
}