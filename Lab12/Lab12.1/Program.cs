using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите радиус");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координаты центра круга");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координаты точки");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Длина окружности есть: " + Circle.GetCircleLength(r));
                Console.WriteLine("Площадь круга есть: " + Circle.GetCircleArea(r));
                Circle.DotPositionInCircle(a,b,r,x,y);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}