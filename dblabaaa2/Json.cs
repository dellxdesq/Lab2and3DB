using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dblabaaa2
{
    public static class Json
    {
        public static Dictionary<string, Dictionary<string, string>>? ReadJson(string dataBaseFile)
        {
            using StreamReader stream = new StreamReader(dataBaseFile);
            string json = stream.ReadToEnd();
            return JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
        }
    }
}
