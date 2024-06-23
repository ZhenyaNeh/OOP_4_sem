using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class Calculating
    {
        public static double Price(PC pc)
        {
            double price = 1000;

            if (pc.CPU.CPU_Series.Contains("3"))
            {
                price *= 1.1;
            }
            else if (pc.CPU.CPU_Series.Contains("5"))
            {
                price *= 1.2;
            }
            else if (pc.CPU.CPU_Series.Contains("7"))
            {
                price *= 1.3;
            }
            else if (pc.CPU.CPU_Series.Contains("9"))
            {
                price *= 1.4;
            }

            if (pc.GPU.GPU_Model.Contains("60"))
            {
                price *= 1.1;
            }
            else if (pc.GPU.GPU_Model.Contains("70"))
            {
                price *= 1.2;
            }
            else if (pc.GPU.GPU_Model.Contains("80"))
            {
                price *= 1.3;
            }
            else if (pc.GPU.GPU_Model.Contains("90"))
            {
                price *= 1.4;
            }

            if (pc.GPU.GPU_DiretX11_Support)
            {
                price *= 1.1;
            }

            if(pc.Memory.RAM_Type == "DDR3")
            {
                price *= 1.1;
            }
            else
            if (pc.Memory.RAM_Type == "DDR4")
            {
                price *= 1.2;
            }
            else if (pc.Memory.RAM_Type == "DDR5")
            {
                price *= 1.3;
            }

            if (pc.Memory.HDD_Type == "HDD")
            {
                price *= 1.1;
            }
            else
            if (pc.Memory.HDD_Type == "SSD")
            {
                price *= 1.2;
            }
            else if (pc.Memory.HDD_Type == "M2.Me")
            {
                price *= 1.3;
            }

            if(pc.Memory.RAM_Size < 8 && pc.Memory.RAM_Size >= 4)
            {
                price *= 1.1;
            }
            else if (pc.Memory.RAM_Size < 16 && pc.Memory.RAM_Size >= 8)
            {
                price *= 1.2;
            }
            else if (pc.Memory.RAM_Size < 32 && pc.Memory.RAM_Size >= 16)
            {
                price *= 1.3;
            }
            else if (pc.Memory.RAM_Size < 64 && pc.Memory.RAM_Size >= 32)
            {
                price *= 1.4;
            }

            if(pc.Memory.HDD_Size < 256 && pc.Memory.HDD_Size >= 128)
            {
                price *= 1.1;
            }
            else if (pc.Memory.HDD_Size < 512 && pc.Memory.HDD_Size >= 256)
            {
                price *= 1.2;
            }
            else if (pc.Memory.HDD_Size < 1024 && pc.Memory.HDD_Size >= 512)
            {
                price *= 1.3;
            }

            price = Math.Floor(price);

            return price;
        }

    }
}
