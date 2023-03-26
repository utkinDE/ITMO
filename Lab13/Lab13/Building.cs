using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        string address;
        double length;
        double width;
        double height;

        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Print() {
            return $" Адрес дома: {address}, высота {length} м., ширина {width} м., длина {height} м. ";
        }
    }
}