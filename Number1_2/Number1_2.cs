using System;

namespace Number1_2
{
    class Number1_2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Math.Abs(i-j) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}