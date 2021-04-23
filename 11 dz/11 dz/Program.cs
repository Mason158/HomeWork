using System;

namespace _11_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1;
            Console.WriteLine("Первое имя:");
            name1 = Console.ReadLine();



            while (name1.Trim().Length == 0)
            {
                Console.WriteLine("Введите имя:");
                name1 = Console.ReadLine();
            }
            Console.WriteLine($"{name1} какой возраст?");
            int age1 = Convert.ToInt32(Console.ReadLine());

            while (age1 <= 0)
            {
                Console.WriteLine($"{name1} Корректный возраст?");

                age1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{name1}  {age1} лет");
            }


            string name2;
            Console.WriteLine("Второе имя:");
            name2 = Console.ReadLine();



            while (name2.Trim().Length == 0)
            {
                Console.WriteLine("Корректное имя:");
                name2 = Console.ReadLine();
            }
            Console.WriteLine($"{name2} Какой возраст?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            while (age2 <= 0)
            {
                Console.WriteLine($"{name2} Корректный возраст?");

                age2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{name2}  {age2} лет");
            }

            Console.WriteLine("Кто из них старше?");
            int c;
            int b;

            string starwiy = Console.ReadLine();
            if (starwiy == name1 && age1 > age2)
            {
                c = age1 - age2;
                Console.WriteLine($"{name1} старше на {c} лет");
            }


            else if (starwiy == name1 && age1 < age2)
            {
                c = age2 - age1;
                Console.WriteLine($"не верно {name1} младше на {c} лет");
            }


            else if (starwiy == name2 && age2 > age1)
            {
                b = age2 - age1;
                Console.WriteLine($" {name1} старше на {b} лет");
            }

            else if (starwiy == name2 && age2 < age1)
            {
                b = age1 - age2;
                Console.WriteLine($"не верно { name1} младше на {b} лет");
            }



            Console.ReadKey();
        }
    }
}
