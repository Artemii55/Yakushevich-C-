using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first task");
            PrintHello();
            Console.WriteLine();

            Console.WriteLine("The second task");
            CheckName();
            Console.WriteLine();

            Console.WriteLine("The third task");
            PrintNumbers();
            Console.WriteLine();

            Console.ReadKey();
        }

        static void PrintHello()
        {
            Console.WriteLine("Enter the number:");
            int.TryParse(Console.ReadLine(), out int value);
                                                            
            if (value > 7)
                Console.WriteLine("Hello");
        }

        static void CheckName()
        {
            Console.WriteLine("Enter any name:");

            if (Console.ReadLine().Contains("Vyacheslav"))
                Console.WriteLine("Hello Vyacheslav");
        }

        static void PrintNumbers()
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(0, 10)];

            Console.Write("Random array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Final array: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}

