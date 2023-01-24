using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 1 для создания массива размера NxN:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arrayNumbers = new int[n, n];

            Console.WriteLine("Создаём массив размера {0} X {1}: ", n, n);
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
                    {
                        arrayNumbers[i, j] = 1;
                    }
                    else
                    {
                        arrayNumbers[i, j] = 0;
                    }

                    Console.Write(arrayNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}