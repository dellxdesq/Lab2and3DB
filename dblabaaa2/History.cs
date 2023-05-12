using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    internal class History
    {
        public string? Author { get; set; }
        public string? Name { get; set; }
        public long? Id { get; set; }
        public string? Operation { get; set; }
        public DateOnly? Date { get; set; }

        public History(List<string> data)
        {
            Name = data[0];
            Id = long.Parse(data[1]);
            Operation = data[2];
            Date = DateOnly.Parse(data[3]);
            Author = data[4];
        }
        public override string ToString()
        {
            return Name + " " + Id + " " + Operation;
        }

        public int GetMaxWidth()
        {
            return new List<int> { Author.Length, Name.Length, Id.ToString().Length, Date.ToString().Length }.Max();
        }

        public List<string> propsToPrint()
        {
            return new List<string> { Author, Name, Id.ToString(), Date.ToString() };
        }
    }
}
