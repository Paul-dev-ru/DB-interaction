using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ItsMyProject
{
    class Orders
    {
        public void buy(Customer customer, Product product)
        {
            double price = product.Skidka(customer);
            customer.ActualBalance(price);

            SqlConnection connect = new SqlConnection("Data Source=PAUL\\SERVERONE;Initial Catalog=ONE;Integrated Security=True");
            connect.Open();


        }
    }
}
