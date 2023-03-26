using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    class Dog : Animal
    {
        string say;
        string name;

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
                    : base(name)
        {
            this.say = say;
        }

        public override void GetSay()
        {
            Console.WriteLine(say);
        }
    }
}