using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ItsMyProject
{
    class Orders
    {
        public void Buy(Customer customer, Product product)
        {
            double price = product.GetDiscountPrice(customer);
            customer.ReduceBalance(price);
            

            //SqlConnection connect = new SqlConnection("Data Source=PAUL\\SERVERONE;Initial Catalog=ONE;Integrated Security=True");
            //connect.Open();

            //SqlCommand cmd = new SqlCommand("", connect);
            //cmd.Parameters.AddWithValue("", order);
            //cmd.ExecuteNonQuery();
        }
    }
}
