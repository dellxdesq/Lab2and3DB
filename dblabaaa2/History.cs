using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    internal class History
    {
        public string? Name { get; set; }
        public long? Id { get; set; }
        public string? Operation { get; set; }

        public History(List<string> data)
        {
            Name = data[0];
            Id = long.Parse(data[1]);
            Operation = data[2];
        }
        public override string ToString()
        {
            return Name + " " + Id + " " + Operation;
        }
    }
}
