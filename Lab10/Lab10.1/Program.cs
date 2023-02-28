using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте плоский угол через ввод целочисленных значений градусов, минут, секунд: ");
            try
            {
                Angle angle;
                do
                {
                    int degrees = Convert.ToInt32(Console.ReadLine());
                    int minutes = Convert.ToInt32(Console.ReadLine());
                    int seconds = Convert.ToInt32(Console.ReadLine());

                    angle = new Angle(degrees, minutes, seconds);

                    if (angle.isCorrect == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep(3000, 1000);
                        Console.WriteLine("Значения минут и секунд должны быть положительными");
                        Console.WriteLine("Начните вводить сначала!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Задайте плоский угол через ввод целочисленных значений градусов, минут, секунд: ");
                    }
                }
                while (angle.isCorrect == false);

                double radians = angle.ToRadians();
                Console.WriteLine("Угол в радианах равен: " + radians);
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(3000, 1000);
                Console.WriteLine(exception.Message);
                Console.ReadKey();
            }
        }
    }
}