using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int countPositiveNumbers = 0;
            int coutnNegativeMumbers = 0;

            do
            {
                Console.WriteLine("Введите целое число чтобы продолжить. Введите ноль чтобы завершить программу");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    countPositiveNumbers++;
                }

                if (number < 0)
                {
                    coutnNegativeMumbers++;
                }
            }

            while (number != 0);

            if (countPositiveNumbers > coutnNegativeMumbers)
            {
                Console.WriteLine("Положительных чисел больше чем отрицательных");
            }
            else if (countPositiveNumbers < coutnNegativeMumbers)
            {
                Console.WriteLine("Положительных чисел меньше чем отрицательных");
            }
            else if (coutnNegativeMumbers == countPositiveNumbers && countPositiveNumbers == 0)
            {
                Console.WriteLine("Работа программы завершена!");
            }
            else
            {
                Console.WriteLine("Положительных чисел столько же сколько и отрицательных");
            }
        }
    }
}