using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");

            string userString = Console.ReadLine();
            string[] userStringArray = userString.Split();
            string userStringMax = userStringArray[0];

            foreach (string s in userStringArray)
            {
                if (s.Length > userStringMax.Length)
                {
                    userStringMax = s;
                }
            }

            Console.WriteLine("Первое самое длинное слово в предложении есть: \"{0}\"", userStringMax);
            Console.ReadKey();
        }
    }
}