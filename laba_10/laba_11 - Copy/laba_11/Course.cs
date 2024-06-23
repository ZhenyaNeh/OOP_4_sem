using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    public class Course
    {
        public string Name { get; set; } = string.Empty;
        public int CountHourse { get; set; } = 0;
        public string NameTeacher { get; set; }
        public int QuantityLisens { get; set; }

        public Course()
        {
            
        }
       public Course(string name, int countHourse, string nameTeacher, int quantityLisens)
        {
            Name = name;
            CountHourse = countHourse;
            NameTeacher = nameTeacher;
            QuantityLisens = quantityLisens;
        }
    }
}
