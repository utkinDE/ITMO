using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayNumbers = new double[10];
            Random random = new Random();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.NextDouble() + random.Next(-50, 49);
                Console.WriteLine(arrayNumbers[i]);
            }

            Console.WriteLine("Нажмите любую клавишу чтобы отсортировать массив");
            Console.ReadKey();

            for (int i = 0, k = 5; i < 10 || k < 10; i++, k++)
            {
                for (int j = i, e = k; j < 5 || e < 10; e++, j++)
                {
                    if (arrayNumbers[i] > arrayNumbers[j])
                    {
                        double buffer = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = buffer;
                    }
                    if (arrayNumbers[k] < arrayNumbers[e])
                    {
                        double buffer2 = arrayNumbers[k];
                        arrayNumbers[k] = arrayNumbers[e];
                        arrayNumbers[e] = buffer2;
                    }
                }

                Console.WriteLine(arrayNumbers[i]);
            }
        }
    }
}