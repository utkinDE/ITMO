using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string userString = Console.ReadLine();
            Console.WriteLine(Check(userString));
            Console.ReadKey();
        }

        static bool Check(string userString)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brace = new Dictionary<char, char>()
            {
                {'(',')' },
                {'[',']' },
                {'{','}' }

            };

            foreach (char c in userString)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(brace[c]);
                }
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}