using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace laba_2
{
    public class WorkWithFille
    {
        static private string path = "..\\..\\..\\..\\SaveData.json";

        public static void Serialize(List<PC> pc)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(fs, pc, options);
            }
        }

        public static List<PC> DeSerialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                {
                    return new List<PC>();
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                return JsonSerializer.Deserialize<List<PC>>(fs, options);
            }
        }
    }
}





