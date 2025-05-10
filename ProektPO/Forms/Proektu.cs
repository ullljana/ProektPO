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
    public partial class Proektu : Form
    {
        Controller.Proektu controller;

        public Proektu()
        {
            InitializeComponent();
            controller = new Controller.Proektu(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

        private void Proektu_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Zakazchik". При необходимости она может быть перемещена или удалена.
			this.zakazchikTableAdapter.Fill(this.proektITDataSet.Zakazchik);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Proektu". При необходимости она может быть перемещена или удалена.
			this.proektuTableAdapter.Fill(this.proektITDataSet.Proektu);

		}

		private void proektuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.proektuBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < proektuDataGridView.RowCount; i++)
			{
				proektuDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < proektuDataGridView.ColumnCount; j++)
					if (proektuDataGridView.Rows[i].Cells[j].Value != null)
						if (proektuDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							proektuDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
