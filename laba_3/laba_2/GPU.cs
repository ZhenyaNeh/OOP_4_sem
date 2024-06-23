using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class GPU
    {
        [Required(ErrorMessage = "Manufacturer is required")]
        public string? GPU_Manufacturer { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длинна диапозон (3,50)" )]
        public string? GPU_Series { get; set; }
        public string? GPU_Model { get; set; }
        [RegularExpression(@"^\d+(\.\d+)?[Gg][Hh][Zz]$", ErrorMessage = "Некоректная частота")]
        public string? GPU_Frequency { get; set; }
        public bool GPU_DiretX11_Support { get; set; }
        public string? GPU_MamoriCapacity { get; set; }

        public GPU(string gpu_Manufacturer, string gpu_Series, string gpu_Model, string gpu_Freqency, bool gpu_DiretX11_Support, string gpu_MamoriCapacity)
        {
            this.GPU_Manufacturer = gpu_Manufacturer;
            this.GPU_Series = gpu_Series;
            this.GPU_Model = gpu_Model;
            this.GPU_Frequency = gpu_Freqency;
            this.GPU_DiretX11_Support = gpu_DiretX11_Support;
            this.GPU_MamoriCapacity = gpu_MamoriCapacity;
        }

        public GPU() { }

        public override string ToString()
        {
            return $"GPU Manufacturer: {this.GPU_Manufacturer}\n" +
                   $"GPU Series: {this.GPU_Series}\n" +
                   $"GPU Model: {this.GPU_Model}\n" +
                   $"GPU Frequency: {this.GPU_Frequency}\n" +
                   $"GPU DiretX11 Support: {this.GPU_DiretX11_Support}\n" +
                   $"GPU Mamori Capacity: {this.GPU_MamoriCapacity}\n";
        }
    }
}
