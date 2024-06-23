using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class PC
    {
        public int? Id { get; set; }
        public string? Image { get; set; }
        public float? Price { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public string? Description_En { get; set; }
        public string? Description_Ru { get; set; }

        public PC() { }

        public PC( string image, float price, string CPU, string GPU, string description_En, string description_Ru)
        {
            this.Image = image;
            this.Price = price;
            this.CPU = CPU;
            this.GPU = GPU;
            this.Description_En = description_En;
            this.Description_Ru = description_Ru;
        }

        public PC(int id, string image, float price, string CPU, string GPU, string description_En, string description_Ru)
        {
            this.Id = id;
            this.Image = image;
            this.Price = price;
            this.CPU = CPU;
            this.GPU = GPU;
            this.Description_En = description_En;
            this.Description_Ru = description_Ru;
        }
    }
}
