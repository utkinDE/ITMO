using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число N > 0:  ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += 2 * i - 1;
                Console.WriteLine(sum);
            }
        }
    }
}