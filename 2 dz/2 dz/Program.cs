using System;

namespace _2_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел в массиве?");
            int c = int.Parse(Console.ReadLine());
            int[] array = new int[c];
            Console.WriteLine("Введите числа через Enter:");
            for (int i = 0; i < c; i++)
            {
                
                array[i] = int.Parse(Console.ReadLine());
            }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > n)
                {
                    n = array[i];
                }
            }
            Console.WriteLine($"Наибольшее из них: {n}");

            Console.ReadKey();





        }
    }
}
