using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(-50, 50);
                Console.WriteLine(arrayNumbers[i]);
            }

            Console.WriteLine("Нажмите любую клавишу чтобы подсчитать числа в массиве");
            Console.ReadKey();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 != 0 && arrayNumbers[i] >= 0 && i % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество нечётных положительных элементов, стоящих на чётных местах, равно: " + count);
            Console.ReadKey();
        }
    }
}