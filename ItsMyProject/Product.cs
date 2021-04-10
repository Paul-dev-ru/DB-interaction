using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyProject
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public double Skidka(Customer customer)
        {
            if (customer.Spent > 50000)
            {
                return Price * 0.95;
            }

            if (customer.Spent > 150000)
            {
                return Price * 0.85;
            }

            return Price;
        }
    }
}
