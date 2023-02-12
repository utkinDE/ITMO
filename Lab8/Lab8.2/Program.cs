using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\Temp\NumbersRandom.txt";
            Random random = new Random();
            int numbersCount = 0;
            
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }

            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    numbersCount += Convert.ToInt32(sr.ReadLine());
                }

            }

            Console.WriteLine("Сумма чисел в {0} равна {1}", path, numbersCount);
            Console.ReadKey();
        }
    }
}