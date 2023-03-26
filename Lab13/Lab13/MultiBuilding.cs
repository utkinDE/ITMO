using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal sealed class MultiBuilding : Building
    {
        int numberFloors;

        public MultiBuilding(string address, double length, double width, double height, int numberFloors)
            : base(address, length, width, height)
        {
            this.numberFloors = numberFloors;

        }

        public int NumberFloors
        {
            get
            {
                return numberFloors;
            }
            set
            {
                numberFloors = value;
            }
        }

        public new string Print()
        {
            string result = base.Print();
            result += $"Число этажей: {numberFloors}";
            return result;
        }
    }
}