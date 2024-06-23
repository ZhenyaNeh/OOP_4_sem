using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class CPU
    {
        public string? CPU_Manufacturer {  get; set; }
        public string? CPU_Series { get; set;}
        public string? CPU_Model { get; set; }
        public int? CPU_CountCores { get; set;}
        public string? CPU_Frequency { get; set;}
        public int? CPU_ArchitectureBitSize { get; set;}

        public CPU(string cpu_Manufacturer, string cpu_Series, string cpu_Model,int cpu_CountCores, string cpu_Freqency, int cpu_ArchitectureBitSize)
        {
            this.CPU_Manufacturer = cpu_Manufacturer;
            this.CPU_Series = cpu_Series;
            this.CPU_Model = cpu_Model;
            this.CPU_CountCores = cpu_CountCores;
            this.CPU_Frequency = cpu_Freqency;
            this.CPU_ArchitectureBitSize = cpu_ArchitectureBitSize;
        }

        public CPU () { }

        public override string ToString()
        {
            return $"CPU Manufacturer: {this.CPU_Manufacturer}\n" +
                   $"CPU Series: {this.CPU_Series}\n" +
                   $"CPU Model: {this.CPU_Model}\n" +
                   $"CPU CountCores: {this.CPU_CountCores}\n" +
                   $"CPU Frequency: {this.CPU_Frequency}\n" +
                   $"CPU Architecture Bit Size: {this.CPU_ArchitectureBitSize}\n";
        }
    }
}
