using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер одномерного массива");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task0 = new Task<int[]>(func1, sizeArray);

            Action<Task<int[]>> action = new Action<Task<int[]>>(PrintArray);
            Task task1 = task0.ContinueWith(action);

            Action<Task<int[]>> action2 = new Action<Task<int[]>>(SumArray);
            Task task2 = task0.ContinueWith(action2);

            Action<Task<int[]>> action3 = new Action<Task<int[]>>(MaxArrayValue);
            Task task3 = task0.ContinueWith(action3);

            task0.Start();
            Console.ReadKey();
        }

        static int[] GetArray(object size)
        {
            int sizeArray = (int)size;
            int[] array = new int[sizeArray];
            Random random = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        static void MaxArrayValue(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Максимальное число в массиве есть " + max);
            Console.ReadKey();
        }

        static void SumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("Сумма всех чисел в массиве равна: " + sum);
            Console.ReadKey();
        }

        static void PrintArray(Task<int[]> task)
        {
            int[] array = task.Result;
            Console.WriteLine("Создан массив: ");

            foreach (int e in array)
            {
                Console.Write("{0} ", e);
            }
        }
    }
}