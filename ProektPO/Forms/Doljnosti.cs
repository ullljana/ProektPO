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
    public partial class Doljnosti : Form
    {
        Controller.Doljnosti controller;

        public Doljnosti()
        {
            InitializeComponent();
            controller = new Controller.Doljnosti(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void doljnostiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.doljnostiBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Doljnosti_Load_1(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
			this.doljnostiTableAdapter.Fill(this.proektITDataSet.Doljnosti);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < doljnostiDataGridView.RowCount; i++)
			{
				doljnostiDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < doljnostiDataGridView.ColumnCount; j++)
					if (doljnostiDataGridView.Rows[i].Cells[j].Value != null)
						if (doljnostiDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							doljnostiDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
