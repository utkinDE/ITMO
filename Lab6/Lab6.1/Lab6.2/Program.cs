using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");

            string userString = Console.ReadLine();
            bool isPalindrome = true;

            for (int i = 0, j = userString.Length - 1; i < userString.Length - 1 && j >= 0; i++, j--)
            {
             
                while (char.IsWhiteSpace(userString[i])) {
                    i++;
                }
                while (char.IsWhiteSpace(userString[j])) {
                    j--;
                }

                if (char.ToLower(userString[i]) != char.ToLower(userString[j]))
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Это палиндром");
                Console.ReadKey();
            }
            else
            {
                Console.Beep(413, 800);
                Console.WriteLine("Это не палиндром");
                Console.ReadKey();
            }
        }
    }
}