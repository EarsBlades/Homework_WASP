using System;

namespace Number3_3
{
    class Number3_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            Console.WriteLine("Вводите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите начало:конец:шаг: ");
            string[] input = Console.ReadLine().Split(new char[] { ':' }, 3, StringSplitOptions.RemoveEmptyEntries);
            int begin = Int32.Parse(input[0]);
            int end = Int32.Parse(input[1]);
            int step = Int32.Parse(input[2]);

            if (step > 0)
            {
                for (int i = begin; i < end; i += step)
                {
                    Console.Write(mass[i] + " ");
                }
            }
            if (step < 0)
            {
                for (int i = end; i > begin; i += step)

                {
                    Console.Write(mass[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}