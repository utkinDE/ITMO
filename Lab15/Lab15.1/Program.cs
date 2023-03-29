using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(5);
            arithProgression.setStepCount(8);

            foreach (int item in arithProgression.getNextNumbersArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            arithProgression.reset();
            Console.ReadKey();

            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.ReadKey();

            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            arithProgression.reset();
            Console.ReadKey();

            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            Console.WriteLine("Запускаю геометрическую прогрессию");

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(2);
            geomProgression.setStepCount(6);
            geomProgression.setCommonRatio(2);

            foreach (int item in geomProgression.getNextNumbersArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            geomProgression.reset();
            Console.ReadKey();

            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();

            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());

            geomProgression.reset();
            Console.ReadKey();

            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
        }
    }
}