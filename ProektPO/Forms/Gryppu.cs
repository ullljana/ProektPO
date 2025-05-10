using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProektPO.Controller;
namespace ProektPO.Forms
{
    public partial class Gryppu : Form
    {
        Controller.Gryppu controller;
        public Gryppu()
        {
            InitializeComponent();
            controller = new Controller.Gryppu(ConnectionString.ConnStr);
        }

      private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void gryppuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gryppuBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Gryppu_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
			this.sotrydnikiTableAdapter.Fill(this.proektITDataSet.Sotrydniki);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Gryppu". При необходимости она может быть перемещена или удалена.
			this.gryppuTableAdapter.Fill(this.proektITDataSet.Gryppu);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < gryppuDataGridView.RowCount; i++)
			{
				gryppuDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < gryppuDataGridView.ColumnCount; j++)
					if (gryppuDataGridView.Rows[i].Cells[j].Value != null)
						if (gryppuDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							gryppuDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
