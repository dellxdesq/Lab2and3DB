using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    internal static class TablePrinter
    {
        public static void PrintTable(List<History> hist)
        {
            
            int width = GetMaxWidth(hist, 12);

            var headers = new List<string>() { "Автор", "Название", "Читает", "Взял" };
            Print(headers, width);

            foreach (var h in hist)
            {
                Print(h.propsToPrint(), width);
            }
        }

        public static void Print(List<string> list, int i)
        {
            string left = "| ";
            string bottomLine = "";

            foreach (var header in list)
            {
                string spaces = new String(' ', i  - header.Length + 1);
                bottomLine = left + header + spaces;
                Console.Write(bottomLine);
            }

            Console.WriteLine("|");
            Console.WriteLine(new String('-', bottomLine.Length * list.Count));
        }

        public static int GetMaxWidth(List<History> table, int minValue)
        {
            var max = 0;
            foreach (var hist in table)
            {
                max = Math.Max(max, hist.GetMaxWidth());
            }

            return Math.Max(max, minValue);
        }

        
    }

}
