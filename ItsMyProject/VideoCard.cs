using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyProject
{
    class VideoCard : Product
    {
        public int V_MEMORY { get; set; } //кол-во памяти видеокарты
        public int V_GHZ { get; set; }
        public int MEMORY_BUS { get; set; } //разрядность
        public string TYPE_MEMORY { get; set; }

        public void VideoCards(string manufacturer, string name, int v_memory, string type_memory, int v_ghz, int memory_bus, double price)
        {
            Manufacturer = manufacturer;
            Name = name;
            V_MEMORY = v_memory;
            TYPE_MEMORY = type_memory;
            V_GHZ = v_ghz;
            MEMORY_BUS = memory_bus;
            Price = price;
        }
    }
}
