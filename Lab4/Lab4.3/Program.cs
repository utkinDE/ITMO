using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int j = 0;
            int k = 1;

            int countQuadA = 0;
            int countQuadB = 0;
            int allCountQuad = 0;

            while (countQuadA <= a)
            {
                countQuadA += c;
                i++;

                if (countQuadA > a)
                {
                    i--;
                }
            }

            while (countQuadB <= b)
            {
                countQuadB += c;
                j++;

                if (countQuadB > b)
                {
                    j--;
                }
            }

            while (k <= j)
            {
                allCountQuad += i;
                k++;
            }

            Console.WriteLine("В прямоугольник можно вписать {0} квадратов со стороной {1}.", allCountQuad, c);
            Console.ReadKey();  
        }
    }
}