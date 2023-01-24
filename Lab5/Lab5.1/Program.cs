using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  7 чисел: ");

            double[] arrayNumbers = new double[7];
            double sumNumbers = 0;
            int i;

            for (i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = Convert.ToDouble(Console.ReadLine());
                sumNumbers += arrayNumbers[i];
            }

            Console.WriteLine("Среднее арифметическое 7 чисел есть: " + sumNumbers / i);
            Console.ReadKey();
        }
    }
}