using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    internal class Program
    {
        static void CalculateCubeParams(double cubeEdge, out double volume, out double surfaceArea)
        {
            volume = cubeEdge * cubeEdge * cubeEdge;
            surfaceArea = cubeEdge * cubeEdge * 6;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ребро куба");
            double cubeEdge = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;

            CalculateCubeParams(cubeEdge, out v, out s);
            Console.WriteLine("Объём куба равен: {0:f2} \r\nПлощадь поверхности куба равна: {1:f2}", v, s);
            Console.ReadKey();
        }
    }
}