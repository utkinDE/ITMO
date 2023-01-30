using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    internal class Program
    {
        static double GetArea(double x, double y, double z)
        {
            double semiP = (x + y + z) / 2;
            double triangleArea = Math.Sqrt(semiP * (semiP - x) * (semiP - y) * (semiP - z));

            return triangleArea;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника A1B1C1");

            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double firstTriangleArea = GetArea(a1, b1, c1);

            Console.WriteLine("Введите стороны первого треугольника A2B2C2");

            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double secondTriangleArea = GetArea(a2, b2, c2);

            if (firstTriangleArea > secondTriangleArea)
            {
                Console.WriteLine("Площадь трегольника A1B1C1 больше площади A2B2C2");
            }
            else if (firstTriangleArea == secondTriangleArea)
            {
                Console.WriteLine("Площади треугольников равны между собой");
            }
            else
            {
                Console.WriteLine("Площадь трегольника A2B2C2 больше площади A1B1C1");
            }
        }
    }
}