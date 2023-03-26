using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Мяу");
            Dog dog = new Dog("Шарик", "Гав");

            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}