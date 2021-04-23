using System;

namespace _7_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[a];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                foreach (int x in A)
                    if (x % 2 == 1)
                        i++; 
                Console.WriteLine($"Количество нечетных элементов массива - {i}");
                break;
            }
           

        } 
}   }
