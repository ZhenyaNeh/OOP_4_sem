using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal interface ICalculator
    {
        string CalculateKcal(bool isAMen, double weight, double height, double age, string active);
        string CalculateIndex(double weight, double height);
    }
}
