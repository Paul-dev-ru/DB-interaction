using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyProject
{
    class Processor : Product
    {
        public string CORE { get; set; }
        public string THREAD { get; set; }
        public int P_GHZ { get; set; }
        public string SOCKET { get; set; }
        public void VideoCards(string manufacturer, string name, string core, string thread, string socket, int p_ghz, double price)
        {
            Manufacturer = manufacturer;
            Name = name;
            CORE = core;
            THREAD = thread;
            SOCKET = socket;
            P_GHZ = p_ghz;
            Price = price;
        }
    }
}
