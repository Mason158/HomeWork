using System;

namespace _6_dz
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
            Console.WriteLine("Обратный порядок будет таков:");
            for (int i = A.Length -1;i >=0; i--)
            {
                Console.WriteLine(A[i]);
            }
                Console.ReadKey();

            
        }
    }
}
