using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ItsMyProject
{
    class Product
    {

        public int counter = 0;
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }


        public Product(string manufacturer, string name, double price)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
        }
        public Product()
        {
            //data
        }
        public double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent>30000 && customer.Spent<50000)
            {
                return Price * 0.9;
            }

            if (customer.Spent>50000)
            {
                return Price * 0.8;
            }

            return Price;
        }

        //public virtual void OutputData()
        //{
        //    textbox.Text
        //    Console.WriteLine(ToString() + ":");
        //    Console.WriteLine("Название: " + Name);
        //    Console.WriteLine("Цена: " + Price.ToString());
        //    Console.WriteLine("Производитель: " + Manufacturer);
        //}
    }
}
