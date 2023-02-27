using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Чтобы начать работать с калькулятором, введите два числа и выберите тип операции. " +
                "Используя для отделения дробной части запятую. Например - \"0,5\": ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите первое число:");
            try
            {
                double numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double numberTwo = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***************************** \r\n" + "Введите номер операции 1-4 где: ");
                Console.WriteLine("1 - умножение;\r\n" + "2 - деление;\r\n" + "3 - сложение;\r\n" + "4 - вычитание. \r\n" + "*****************************");
                Console.ForegroundColor = ConsoleColor.White;
                int operationsNumber = Convert.ToInt32(Console.ReadLine());
                double result;

                switch (operationsNumber)
                {
                    case 1:
                        result = numberOne * numberTwo;
                        Console.WriteLine("Результат произведения чисел {0} и {1} есть: {2} ", numberOne, numberTwo, result);
                        break;
                    case 2:
                        result = numberOne / numberTwo;
                        if (numberTwo == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        Console.WriteLine("Результат частного чисел {0} и {1} есть: {2} ", numberOne, numberTwo, result);
                        break;
                    case 3:
                        result = numberOne + numberTwo;
                        Console.WriteLine("Результат сложения чисел {0} и {1} есть: {2} ", numberOne, numberTwo, result);
                        break;
                    case 4:
                        result = numberOne - numberTwo;
                        Console.WriteLine("Результат разности чисел {0} и {1} есть: {2} ", numberOne, numberTwo, result);
                        break;
                    default:
                        Console.WriteLine("Введён неверный номер операции!");
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(3000, 1000);
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
    }
}