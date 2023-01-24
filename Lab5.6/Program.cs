using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 1 для создания массива размера NxN:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arrayNumbers = new int[n, n];

            Console.Write("Создаём массив размера {0} X {1}. Введите {2} чисел: ", n, n, n * n);
            Console.WriteLine();

            int mainDiagSum = 0;
            int secondDiagSum = 0;
            int sumString = 0;
            int sumTable = 0;
            bool isNotMagic = false;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    arrayNumbers[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (i == j)
                    {
                        mainDiagSum += arrayNumbers[i, j];
                    }
                    if (j == ((n - 1) - i))
                    {
                        secondDiagSum += arrayNumbers[i, j];
                    }
                }
            }

            if (mainDiagSum == secondDiagSum)
            {
                //Заполнили массив и нашли суммы диагоналей, если они равны то идём дальше и 
                //ищем суммы строк и столбцов и проверяем что они равны между собой и одной из диагоналей

                for (int i = 0, k = 0; i < n || k < n; i++, k++)
                {
                    if (i > 0 && sumString != sumTable || i > 0 && sumString != mainDiagSum)
                    {
                        isNotMagic = true;
                        break;
                    }

                    sumString = 0;
                    sumTable = 0;

                    for (int j = 0, l = 0; j < n || l < n; j++, l++)
                    {
                        sumString += arrayNumbers[i, j];
                        sumTable += arrayNumbers[l, k];
                    }
                }
            }
            else
            {
                isNotMagic = true;
            };
            //печатаем массив пользователю
            Console.WriteLine();
            Console.WriteLine("Вы ввели массив: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    Console.Write(arrayNumbers[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            //выводим результат проверки
            if (isNotMagic == true)
            {
                Console.WriteLine("Массив не является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Поздравляем, это магический квадрат!");
            }
        }
    }
}