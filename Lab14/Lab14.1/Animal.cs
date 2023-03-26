using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void GetSay();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetSay();
        }
    }
}
