using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class Calculator : ICalculator
    {
        public string CalculateKcal(bool isAMen, double weight, double height, double age, string active)
        {
            double kcal;

            if (isAMen == true)
            {
                kcal = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else
            {
                kcal = 10 * weight + 6.25 * height - 5 * age - 161;
            }

            if (active == "Отсутствие нагрузок")
            {
                kcal = kcal * 1.2;
            }
            else if (active == "Минимальные кардио")
            {
                kcal = kcal * 1.375;
            }
            else if (active == "Занятия спортом")
            {
                kcal = kcal * 1.55;
            }
            else if (active == "Полноценные трен.")
            {
                kcal = kcal * 1.725;
            }
            else if (active == "Профессиональные")
            {
                kcal = kcal * 1.9;
            }

            kcal = Math.Round(kcal); 
            string resultKcal = kcal.ToString();
            return resultKcal;
        }

        public string CalculateIndex(double weight, double height)
        {
            double resultIndex = (weight * 10000) / (height * height);

            string resultIndexBody;

            if(resultIndex <= 16)
            {
                resultIndexBody = "Выраженный дефицит массы тела";
            }
            else if (resultIndex > 16 && resultIndex <= 18.5)
            {
                resultIndexBody = "Недостаточная (дефицит) масса тела";
            }
            else if (resultIndex > 18.5 && resultIndex <= 25)
            {
                resultIndexBody = "Норма";
            }
            else if (resultIndex > 25 && resultIndex <= 30)
            {
                resultIndexBody = "Избыточная масса тела (предожирение)";
            }
            else if (resultIndex > 30 && resultIndex <= 35)
            {
                resultIndexBody = "Ожирение первой степени";
            }
            else if (resultIndex > 35 && resultIndex <= 40)
            {
                resultIndexBody = "Ожирение второй степени";
            }
            else if (resultIndex > 40)
            {
                resultIndexBody = "Ожирение третьей степени (морбидное)";
            }
            else
            {
                resultIndexBody = "Wrong Data";
            }

            return resultIndexBody;
        }
    }
}
