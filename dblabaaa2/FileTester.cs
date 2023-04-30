using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    public class FileTester
    {

        public bool Test(string dataBaseFile)
        {

            var config = Json.ReadJson(dataBaseFile);
            bool answer = true;

            foreach (var (tableFile, tableConfig) in config)
            {
                answer = answer && TestDimensions(tableFile) && TestColumnDataTypeEquality(tableFile, tableConfig);
            }

            return answer;
        }

        private bool TestDimensions(string tableFile)
        {
            var fileData = File.ReadAllLines(tableFile);
            var length = 0;
            if (fileData.Length > 0)
                length = fileData[0].Split(",").Length;

            for (var i = 0; i < fileData.Length; ++i)
            {
                var strArrLength = fileData[i].Split(",").Length;
                if (length != strArrLength)
                {
                    Console.WriteLine($"{tableFile} {i} Строка неправильного размера");
                    return false;
                }
            }

            return true;
        }

        private bool TestColumnDataTypeEquality(string tableFile, Dictionary<string, string> tableConfig)
        {
            var fileData = ReadFileData(tableFile);

            if (fileData.Count == 0 || fileData[0].Count == 0)
                return true;

            var types = tableConfig.Values.ToArray();

            for (var i = 0; i < tableConfig.Values.Count; ++i)
            {
                for (var j = 0; j < fileData.Count; ++j)
                {
                    try
                    {
                        var obj = fileData[j][i];
                        if (obj.Length > 0)
                        {
                            Convert.ChangeType(obj, Type.GetType(types[i]));
                        }
                    }
                    catch
                    {
                        Console.WriteLine($"{tableFile} {j} {i} Элемент неправильного типа");
                        return false;
                    }
                }
            }

            return true;
        }

        public static List<List<string>> ReadFileData(string file)
        {
            var fileData = new List<List<string>>();

            var fileRows = File.ReadAllLines(file);
            foreach (var str in fileRows)
            {
                fileData.Add(str.Split(',').ToList());
            }

            return fileData;
        }
    }
}
