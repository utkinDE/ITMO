using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строковый номер счёта в банке");
            string accountString = Console.ReadLine();
            Console.WriteLine("Введите сумму");
            double balanceDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string nameString = Console.ReadLine();

            BankAccount<string> bankAccount1 = new BankAccount<string>(accountString, balanceDouble, nameString);
            Console.WriteLine(bankAccount1.GetInfo());

            Console.WriteLine("Введите числовой номер счёта в банке");
            int accountInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму");
            balanceDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            nameString = Console.ReadLine();

            BankAccount<int> bankAccount2 = new BankAccount<int>(accountInt, balanceDouble, nameString);
            Console.WriteLine(bankAccount2.GetInfo());
        }
    }
}