using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class Motherboard
    {
        //
        //-CPU_Support
        //
        private string? Motherboard_CPU_Spport { get; set; } //amd or intel
        private string? Motherboard_Socket { get; set; }
        //
        //-Motherboard_FormFactor 
        //
        private string? Motherboard_FormFactor { get; set; }
        //
        //-RAM_Support
        //
        private string? Motherboard_MemorySupport { get; set; }
        private int Motherboard_NumberOf_RAM_Slots { get; set; }
        private int Motherboard_Maximum_RAM_Capacity { get; set; }
        private int Motherboard_Maximum_RAM_Frequency { get; set; }
        //
        //-SSD_Support
        //
        private int Motherboard_NumberOf_M2_Slots { get; set; }
        private int Motherboard_NumberOf_SATA3_Slots { get; set; }
        

    }
}
