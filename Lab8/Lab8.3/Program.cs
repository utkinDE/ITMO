using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\Temp\Text.txt";
            string strings;
            int whiteSpaceCount = 1;
            int stringsCount = 0;
            char lineFeed = '\n';
            char lineFeed2 = '\r';

            using (StreamReader sr = new StreamReader(path))
            {
                strings = sr.ReadToEnd();

                for (int i = 0; i < strings.Length - 1; i++)
                {
                    if (char.IsWhiteSpace(strings[i]))
                    {
                        whiteSpaceCount++;

                        if (char.IsWhiteSpace(strings[i + 1]))
                        {
                            whiteSpaceCount--;
                        }

                    }
                    if (lineFeed == strings[i] || lineFeed2 == strings[i])
                    {
                        stringsCount++;
                    }
                }
            }

            Console.WriteLine("Количество слов в тексте: {0}", whiteSpaceCount);
            Console.WriteLine("Количество символов в тексте: {0}", strings.Length);
            Console.WriteLine("Количество строк в тексте: {0}", stringsCount / 2 + 1);
        }
    }
}