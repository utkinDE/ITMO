using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Новосибирск", 210.5, 20.4, 25.3);
            Console.WriteLine(building.Print());
            Console.ReadKey();
            MultiBuilding multiBuilding = new MultiBuilding("Бердск", 210.5, 20.4, 25.3,9);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}