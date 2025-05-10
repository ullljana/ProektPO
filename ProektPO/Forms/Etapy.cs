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
    public partial class Etapy : Form
    {
        Controller.Etapy controller;

        public Etapy()
        {
            InitializeComponent();
            controller = new Controller.Etapy(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void etapyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.etapyBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Etapy_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Etapy". При необходимости она может быть перемещена или удалена.
			this.etapyTableAdapter.Fill(this.proektITDataSet.Etapy);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < etapyDataGridView.RowCount; i++)
			{
				etapyDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < etapyDataGridView.ColumnCount; j++)
					if (etapyDataGridView.Rows[i].Cells[j].Value != null)
						if (etapyDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							etapyDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
