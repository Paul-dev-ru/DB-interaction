using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItsMyProject
{
    public partial class Form1 : Form
    {
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

        }

        private void videoCardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
