using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    public class Customer
    {
        private string? _name;
        public Customer(string? name, long? id)
        {
            Name = name;
            Id = id;
        }

        public Customer(List<string> data)
        {
            Name = data[0];
            Id = long.Parse(data[1]);
        }

        public override string ToString()
        {
            return Name + " " + Id;
        }

        public string? Name { get; set; }
        public long? Id { get; set; }
    }
}
