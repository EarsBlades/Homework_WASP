using System;

namespace Number1_4
{
    class Number1_4
    { static int fact(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++) 
                x *= i;
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите высоту: "); 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(fact(i)/(fact(j) * fact(i - j)) + " ");
                Console.WriteLine();
            }
            
        }
    }
}

