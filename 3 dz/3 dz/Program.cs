using System;

namespace _3_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 9, 2, 45, -3, 0, 87, 94, -82 };
            int a = 0;
            int num = array[0];

            for (int i = 0; i < array.Length; i++)

            {
                if (array[i] < num)
                {
                    num = array[i];
                    a = i;
                }
            }

            Console.WriteLine($"Индекс минимального элемента массива {a}");

            Console.ReadLine();

        }
    }
}
