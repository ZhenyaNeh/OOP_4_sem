using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class Memory
    {
        public string? RAM_Type { get; set; }
        public int RAM_Size { get; set; }
        public string? HDD_Type { get; set; }
        public int HDD_Size { get; set; }

        public Memory(string ram_Type, int ram_Size, string hdd_Type, int hdd_Size) 
        {
            this.RAM_Type = ram_Type;
            this.RAM_Size = ram_Size;
            this.HDD_Type = hdd_Type;
            this.HDD_Size = hdd_Size;
        }

        public Memory() { }

        public override string ToString()
        {
            return $"RAM_Type: {this.RAM_Type}\n" +
                   $"RAM_Size: {this.RAM_Size}\n" +
                   $"HDD_Type: {this.HDD_Type}\n" +
                   $"HDD_Type: {this.HDD_Size}\n";
        }

    }
}
