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
    public partial class Sotrydniki : Form
    {
        Controller.Sotrydniki controller;

        public Sotrydniki()
        {
            InitializeComponent();
            controller = new Controller.Sotrydniki(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

        private void Sotrydniki_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
			this.doljnostiTableAdapter.Fill(this.proektITDataSet.Doljnosti);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Otdelu". При необходимости она может быть перемещена или удалена.
			this.otdeluTableAdapter.Fill(this.proektITDataSet.Otdelu);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
			this.sotrydnikiTableAdapter.Fill(this.proektITDataSet.Sotrydniki);

		}

		private void sotrydnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.sotrydnikiBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < sotrydnikiDataGridView.RowCount; i++)
			{
				sotrydnikiDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < sotrydnikiDataGridView.ColumnCount; j++)
					if (sotrydnikiDataGridView.Rows[i].Cells[j].Value != null)
						if (sotrydnikiDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							sotrydnikiDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
