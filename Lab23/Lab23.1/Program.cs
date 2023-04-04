using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат вычисления факториала от 1 до {0} есть: ", x);
            FactorialAsync(x);
            Console.ReadKey();
        }
        static void Factorial(double x)
        {
            double result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;

            }

            Console.WriteLine(result);
        }
        static async void FactorialAsync(double x)
        {
            await Task.Run(() => Factorial(x));
        }
    }
}