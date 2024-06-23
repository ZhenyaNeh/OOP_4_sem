using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_5
{
    class PC
    {
        public string? Image {  get; set; }
        public double Price { set; get; }
        public string? CPU { set; get; }
        public string? GPU { set; get; }
        public string? Description_En { set; get; }
        public string? Description_Ru { set; get; }

        public PC() { }

        public PC(string? image, double price, string? CPU, string? GPU, string? description_En, string? description_Ru)
        {
            this.Image = image;
            this.Price = price;
            this.CPU = CPU;
            this.GPU = GPU;
            this.Description_En = description_En;
            this.Description_Ru = description_Ru;
        }
    }
}
