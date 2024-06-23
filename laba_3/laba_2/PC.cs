using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class PC
    {
        public string? PC_Type { get; set; }
        public CPU? CPU { get; set; }
        public GPU? GPU { get; set; }
        public Memory? Memory{ get; set; }
        public string? DateOfPurchase {  get; set; }
        public string? PhoneNumber {  get; set; }

        public PC (string pc_Type, CPU cpu, GPU gpu, Memory memory, string dateOfPurchase, string phoneNumber) 
        {
            this.PC_Type = pc_Type;
            this.CPU = cpu;
            this.GPU = gpu;
            this.Memory = memory;
            this.DateOfPurchase = dateOfPurchase;
            this.PhoneNumber = phoneNumber;
        }

        public PC()
        {
        }

        public override string ToString()
        {
            return $"PC Type: {this.PC_Type}\n" +
                   $"CPU: \n{this.CPU}\n" +
                   $"GPU: \n{this.GPU}\n" +
                   $"Memory: \n{this.Memory}\n" +
                   $"Date Of Purchase: {this.DateOfPurchase}\n" +
                   $"Phone Number: {this.PhoneNumber}\n";
        }
    }
}
