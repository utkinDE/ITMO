using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    internal static class Circle
    {
        public static double GetCircleLength(double r)
        {
            return 2 * Math.PI * r;
        }

        public static double GetCircleArea(double r)
        {
            return 2 * Math.PI * r * r;
        }

        public static void DotPositionInCircle(double dotX, double dotY, double r, double centerX, double centerY)
        {
            if ((Math.Pow((centerX - dotX), 2.0) + Math.Pow((centerY - dotY), 2.0)) <= r * r)
            {
                Console.WriteLine("Точка принадлежит кругу");
                return;
                
            }
            Console.WriteLine("Точка не принадлежит кругу");
        }
    }
}