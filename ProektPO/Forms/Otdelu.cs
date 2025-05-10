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
    public partial class Otdelu : Form
    {
        Controller.Otdelu controller;
        public Otdelu()
        {
            InitializeComponent();
            controller = new Controller.Otdelu(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void otdeluBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.otdeluBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Otdelu_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
			this.sotrydnikiTableAdapter.Fill(this.proektITDataSet.Sotrydniki);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Otdelu". При необходимости она может быть перемещена или удалена.
			this.otdeluTableAdapter.Fill(this.proektITDataSet.Otdelu);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < otdeluDataGridView.RowCount; i++)
			{
				otdeluDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < otdeluDataGridView.ColumnCount; j++)
					if (otdeluDataGridView.Rows[i].Cells[j].Value != null)
						if (otdeluDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							otdeluDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
