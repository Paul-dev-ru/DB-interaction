using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ItsMyProject
{
    public partial class Form1 : Form
    {
        readonly Customer customers = new Customer(
            "Алексей",
            500000,
            0);
        readonly VideoCard videoCard = new VideoCard(
            "Nvidia",
            "RTX 3090",
            "24Gb",
            "GLPDDR6X",
            "3600ghz",
            "256bit",
            146990);
        readonly VideoCard videoCard1 = new VideoCard(
            "AMD",
            "RX 6600XT",
            "16Gb",
            "GLPDDR6X",
            "3800ghz",
            "256bit",
            169990);

        //readonly RAM rAM = new RAM(
        //    "HyperX",
        //    "Fury",
        //    4,
        //    "DDR4",
        //    3222,
        //    4500
        //    );

            
        public Form1()
        {
            InitializeComponent();
        }

        private void videoCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videoCardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oNEDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oNEDataSet.VideoCard". При необходимости она может быть перемещена или удалена.
            this.videoCardTableAdapter.Fill(this.oNEDataSet.VideoCard);
            button2.Visible = false;
            label1.Text = $"Здравствуйте, {customers.Name}!\n Запустите приложение, чтобы начать покупать!\n";





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
            label1.Text = $"Здравствуйте, {customers.Name}!\n Ваш баланс: {customers.Balance}\n Ваши затраты: {customers.Spent}";

            
            
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Производитель";
            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Кол-во видеопамяти";
            dataGridView1.Columns[3].Name = "Тип памяти";
            dataGridView1.Columns[4].Name = "Частота работы GPU";
            dataGridView1.Columns[5].Name = "Разрядность шины";
            dataGridView1.Columns[6].Name = "Цена";

            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Производитель";
            dataGridView2.Columns[1].Name = "Название";
            dataGridView2.Columns[2].Name = "Описание товара";
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[3].Name = "Цена";

            dataGridView1.Rows.Add(videoCard.Manufacturer,videoCard.Name, videoCard.V_MEMORY, videoCard.TYPE_MEMORY, videoCard.V_GHZ, videoCard.MEMORY_BUS, videoCard.Price);
            dataGridView1.Rows.Add(videoCard1.Manufacturer, videoCard1.Name, videoCard1.V_MEMORY, videoCard1.TYPE_MEMORY, videoCard1.V_GHZ, videoCard1.MEMORY_BUS, videoCard1.Price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] value = new string[7];
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    value[i] += cell.Value.ToString();
                    i++;
                }
            }

            string description = value[2] + "; " + value[3] + "; " + value[4] + "; " + value[5] + ";";
            MessageBox.Show("Товар добавлен в корзину");


            dataGridView2.Rows.Add(value[0],value[1], description, value[6]);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product[] products = new Product[]
            {
                videoCard,
                videoCard1
            };



            Orders orders = new Orders();

            string value = "";
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    value += cell.Value.ToString();
                }
            }

            MessageBox.Show(dataGridView2.Rows.Count.ToString());

            for (int i = 0; i < dataGridView2.Rows.Count; i++) //для проверки работоспособности
            {
                if (products[i].Price <= customers.Balance)
                {
                    MessageBox.Show($"Товар {products[i].Name} по цене {products[i].Price}");
                    //MessageBox.Show(value);
                    orders.Buy(customers, products[i]);
                    label1.Text = $"Здравствуйте, {customers.Name}!\n Ваш баланс: {customers.Balance}\n Ваши затраты: {customers.Spent}";
                }

                else
                {
                    MessageBox.Show("Недостаточно средств! Пополните баланс");
                }
            }



        }
    }
}
