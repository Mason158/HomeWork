using System;

namespace _5_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задан массив:");
            int[] array = { 2, 6, 7, 4, 3, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Сумма элементов массива с нечетными индексами:");
            for (int i = 0; i < array.Length;)
            {
                int a = array[1] + array[3] + array [5];
                Console.WriteLine(a);
                break;
            }
            

            


        }
    }
}
