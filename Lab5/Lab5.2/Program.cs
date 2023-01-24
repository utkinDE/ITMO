using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayNumbers = new double[15];
            Random random = new Random();
            double minNumber = 0;
            double maxNumber = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.NextDouble() + random.Next(0, 49);
                Console.WriteLine(arrayNumbers[i]);
            }

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = i; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[i] > arrayNumbers[j])
                    {
                        double buffer = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = buffer;
                    }
                }

                minNumber = arrayNumbers[0];
                maxNumber = arrayNumbers[arrayNumbers.Length - 1];
            }

            Console.WriteLine("Сумма максимального и минимального элементов массива равна: " + (minNumber + maxNumber));
            Console.Beep(413, 800);
            Console.ReadKey();
        }
    }
}