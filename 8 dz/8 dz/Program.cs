using System;

namespace _8_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четную длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = array.Length / 2 + 1; i > 1; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
