using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19._1
{
    class Computer
    {
        public int Id { get; set; } 
        public string ManufactoryName  { get; set; } 
        public string TypeCpu { get; set; }
        public int CpuFrequency { get; set; }
        public int RamSize { get; set; }
        public int HddVolume { get; set; }
        public int GpuMemorySize { get; set; }
        public double Cost { get; set; }
        public int Count{ get; set; }
    }
}