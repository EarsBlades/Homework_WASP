using System;

namespace Number1_1
{
    class Number1_1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    for (int k = j + 1; k < 10; k++)
                        for (int l = k + 1; l < 10; l++)
                            Console.WriteLine(i.ToString()+j.ToString()+k.ToString()+l.ToString());
        }
    }
}