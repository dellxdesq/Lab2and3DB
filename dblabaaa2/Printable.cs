using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    internal interface Printable
    {
        public static List<string> GetNames()
        {
            return new List<string>
            {
                "Name", "Author", "YearPublished", "BookCase", "BookShelf"
            };
        }
        public int Width { get; }
    }
}
