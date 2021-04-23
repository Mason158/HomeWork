using System;

namespace _10_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[20];
            int i;
            mas[0] = 0;
            mas[1] = 1;
            Console.WriteLine("Числа Фибаначчи:");
            for (i = 2; i < mas.Length; i++)
            {
                mas[i] = mas[i - 1] + mas[i - 2];


            }
            foreach (int x in mas)
                Console.Write($"{x} ");

            Console.ReadKey();

        }
    }
}
