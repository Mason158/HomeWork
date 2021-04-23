using System;

namespace _9_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[a];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int bub;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int n = 0; n < mas.Length - 1; n++)
                {

                    if (mas[n] > mas[n + 1])
                    {
                        bub = mas[n + 1];
                        mas[n + 1] = mas[n];
                        mas[n] = bub;
                    }

                }
            }

            foreach (int rev in mas)
                Console.Write($"{rev} ");
            Console.Read();
        }
    }
}
