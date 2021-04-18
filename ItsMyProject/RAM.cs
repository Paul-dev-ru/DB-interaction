using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyProject
{
    class RAM : Product
    {
        public int R_MEMORY { get; set; }
        public int R_GHZ { get; set; }
        public string TYPE_MEMORY { get; set; }

        public RAM(string manufacturer, string name, double price,int r_memory, string type_memory, int r_ghz):base(manufacturer, name, price)
        {
           
            R_MEMORY = r_memory;
            TYPE_MEMORY = type_memory;
            R_GHZ = r_ghz;

        }
    }
}
