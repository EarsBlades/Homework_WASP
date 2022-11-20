using System;

namespace Number3_1
{
    class Number3_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите порядок нормы: ");
            double p = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }

            double summ = 0;
            for (int i = 0; i < n; i++)
            {
                summ += Math.Pow(mass[i], p);
            }
            Console.WriteLine("Порядок нормы: " + Math.Pow(summ, (1/p)));
            Console.ReadKey();
        }
    }
}