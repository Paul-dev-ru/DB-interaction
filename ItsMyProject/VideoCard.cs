using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItsMyProject
{
    class VideoCard : Product
    {
        //public string V_MEMORY { get; set; } //кол-во памяти видеокарты
        //public string V_GHZ { get; set; }
        //public string MEMORY_BUS { get; set; } //разрядность
        //public string TYPE_MEMORY { get; set; }

        public string DESCRIPTION { get; set; }

        public VideoCard(string manufacturer, string name, string description, double price) : base(manufacturer, name, price)
        {
            DESCRIPTION = description;
        }
        public VideoCard()
        {

        }
        //public override void ToConsole()
        //{
        //    Textbox.Text = "Название: " + Name;
        //    Textbox.Text += "Цена: " + Price.ToString();
        //    Textbox.Text += "Производитель: " + Manufacturer;
        //    //Console.WriteLine(ToString() + ":");
        //    //Console.WriteLine("Название: " + Name);
        //    //Console.WriteLine("Цена: " + Price.ToString());
        //    //Console.WriteLine("Производитель: " + Manufacturer);
        //}
    }
}
