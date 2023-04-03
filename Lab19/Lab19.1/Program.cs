using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() {Id = 1, ManufactoryName = "Nokia", TypeCpu ="80386DX2", CpuFrequency = 40, RamSize = 4,HddVolume = 40, GpuMemorySize = 4, Cost = 1200, Count=3},
                new Computer() {Id = 2, ManufactoryName = "IBM", TypeCpu ="80486DX4", CpuFrequency = 100, RamSize = 8,HddVolume = 120, GpuMemorySize = 8, Cost = 2200, Count=10},
                new Computer() {Id = 3, ManufactoryName = "Acer", TypeCpu ="Pentium I", CpuFrequency = 150, RamSize = 8,HddVolume = 120, GpuMemorySize = 4, Cost = 2500, Count=15},
                new Computer() {Id = 4, ManufactoryName = "Dell", TypeCpu ="Pentium I", CpuFrequency = 200, RamSize = 16,HddVolume = 240, GpuMemorySize = 16, Cost = 4500, Count=24},
                new Computer() {Id = 5, ManufactoryName = "HP", TypeCpu ="Pentium Pro", CpuFrequency = 180, RamSize = 16,HddVolume = 240, GpuMemorySize = 16, Cost = 4800, Count=31},
                new Computer() {Id = 6, ManufactoryName = "Toshiba", TypeCpu ="Pentium Pro", CpuFrequency = 200, RamSize = 8,HddVolume = 120, GpuMemorySize = 8, Cost = 5100, Count=36},
                new Computer() {Id = 7, ManufactoryName = "Sharp", TypeCpu ="Pentium II", CpuFrequency = 233, RamSize = 32,HddVolume = 320, GpuMemorySize = 32, Cost = 8100, Count=5},
                new Computer() {Id = 8, ManufactoryName = "Sharp", TypeCpu ="Pentium II", CpuFrequency = 200, RamSize = 32,HddVolume = 240, GpuMemorySize = 16, Cost = 7200, Count=5},
                new Computer() {Id = 9, ManufactoryName = "Zema", TypeCpu ="80286", CpuFrequency = 24, RamSize = 1,HddVolume = 40, GpuMemorySize = 1, Cost = 600, Count=2},
                new Computer() {Id = 10, ManufactoryName = "Zema", TypeCpu ="80286", CpuFrequency = 22, RamSize = 1,HddVolume = 40, GpuMemorySize = 1, Cost = 500, Count=1},
            };

            Console.WriteLine("Введите название процессора");
            string typeCPU = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.TypeCpu == typeCPU).ToList();
            Print(computers1);
            Console.ReadKey();

            Console.WriteLine("Введите объём ОЗУ");
            int ramSize = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RamSize >= ramSize).ToList();
            Print(computers2);
            Console.ReadKey();

            List<Computer> computers3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computers3);
            Console.ReadKey();

            IEnumerable<IGrouping<string, Computer>> computer4 = computers.GroupBy(x => x.TypeCpu);
            foreach (IGrouping<string, Computer> group in computer4)
            {
                Console.WriteLine(group.Key);
                foreach (Computer e in group)
                {
                    Console.WriteLine($"{e.Id} {e.ManufactoryName} {e.TypeCpu} {e.CpuFrequency} {e.RamSize} {e.HddVolume} {e.GpuMemorySize} {e.Cost} {e.Count}");
                }
            }

            Computer computerMinCost = computers.OrderBy(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{computerMinCost.Id} {computerMinCost.ManufactoryName} {computerMinCost.TypeCpu} {computerMinCost.CpuFrequency} " +
                $"{computerMinCost.RamSize} {computerMinCost.HddVolume} {computerMinCost.GpuMemorySize} {computerMinCost.Cost} {computerMinCost.Count}");

            Computer computerMaxCost = computers.OrderByDescending(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{computerMaxCost.Id} {computerMaxCost.ManufactoryName} {computerMaxCost.TypeCpu} {computerMaxCost.CpuFrequency} " +
                $"{computerMaxCost.RamSize} {computerMaxCost.HddVolume} {computerMaxCost.GpuMemorySize} {computerMaxCost.Cost} {computerMaxCost.Count}");

            Console.WriteLine("Введите желаемое количество компьютеров в штуках");
            int inStock = Convert.ToInt32(Console.ReadLine());

            bool isSetQuantity = computers.Any(x => x.Count > inStock);
            if (!isSetQuantity)
            {
                Console.WriteLine($"К сожалению, у нас нет ни одной модели компьютера в количестве не менее {inStock} штук :(");
                Console.WriteLine("Но мы можем предложить модель компьютера, которых у нас больше всего =)");

                Computer computerMaxCount = computers.OrderByDescending(x => x.Count).FirstOrDefault();
                Console.WriteLine($"{computerMaxCount.Id} {computerMaxCount.ManufactoryName} {computerMaxCount.TypeCpu} {computerMaxCount.CpuFrequency} " +
                    $"{computerMaxCount.RamSize} {computerMaxCount.HddVolume} {computerMaxCount.GpuMemorySize} {computerMaxCount.Cost} \n Вот таких у нас аж {computerMaxCount.Count}!");
                Console.ReadKey();
            }
            else
            {
                List<Computer> computersList = computers.Where(x => x.Count >= inStock).ToList();
                Print(computersList);
                Console.ReadKey();
            }
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.Id} {e.ManufactoryName} {e.TypeCpu} {e.CpuFrequency} {e.RamSize} {e.HddVolume} {e.GpuMemorySize} {e.Cost} {e.Count}");
            }
            Console.WriteLine();

        }
    }
}