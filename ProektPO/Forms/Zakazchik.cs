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
    public partial class Zakazchik : Form
    {
        Controller.Zakazchik controller;

        public Zakazchik()
        {
            InitializeComponent();
            controller = new Controller.Zakazchik(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void zakazchikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.zakazchikBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Zakazchik_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Zakazchik". При необходимости она может быть перемещена или удалена.
			this.zakazchikTableAdapter.Fill(this.proektITDataSet.Zakazchik);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < zakazchikDataGridView.RowCount; i++)
			{
				zakazchikDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < zakazchikDataGridView.ColumnCount; j++)
					if (zakazchikDataGridView.Rows[i].Cells[j].Value != null)
						if (zakazchikDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							zakazchikDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
