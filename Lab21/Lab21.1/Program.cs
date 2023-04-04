using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21._1
{
    internal class Program
    {
        const int x = 3;
        const int y = 4;
        static int[,] areaPath = new int[x, y] { { 1, 2, 100, 4 }, { 2, 0, 3, 1 }, { 2, 3, 1, 2 } };

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardener2();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{areaPath[i, j]}");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Gardener1()
        {
            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y; j++)
                {
                    if (areaPath[i, j] >= 0)
                    {
                        int delay = areaPath[i, j];
                        Thread.Sleep(delay);
                        areaPath[i, j] = -1;
                    }
                }
            }
        }

        static void Gardener2()
        {
            for (int i = x - 1; i >= 0; i--)
            {
                for (int j = y - 1; j >= 0; j--)
                {
                    if (areaPath[i, j] >= 0)
                    {
                        int delay = areaPath[i, j];
                        areaPath[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
    }
}