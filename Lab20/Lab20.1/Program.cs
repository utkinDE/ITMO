using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20._1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = CircumferenceCalc;
            double circumference = myDelegate(3);
            Console.WriteLine("Длина окружности равна {0:f4}", circumference);

            myDelegate += AreaCalc;
            double area = myDelegate(3);
            Console.WriteLine("Площадь круга равна {0:f4}", area);

            myDelegate -= AreaCalc;
            myDelegate -= CircumferenceCalc;
            myDelegate += SphereCalc;
            double sphereVolume = myDelegate(3);
            Console.WriteLine("Объем сферы равен {0:f4}", sphereVolume);
        }
        static double CircumferenceCalc(double radius) => 2 * Math.PI * radius;

        static double AreaCalc(double radius) => Math.PI * radius * radius;

        static double SphereCalc(double radius) => (4 / 3) * Math.PI * Math.Pow(radius, 3);
    }
}