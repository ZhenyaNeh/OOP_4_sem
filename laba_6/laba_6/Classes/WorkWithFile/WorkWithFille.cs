using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace laba_6
{
    class WorkWithFille
    {
        public static void Serialize<T>(List<T> pc, string path)
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

        public static List<T> DeSerialize<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                {
                    return new List<T>();
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                return JsonSerializer.Deserialize<List<T>>(fs, options) ?? new List<T>();
            }
        }
    }
}
