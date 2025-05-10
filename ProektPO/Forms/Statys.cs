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
    public partial class Statys : Form
    {
        Controller.Statys controller;

        public Statys()
        {
            InitializeComponent();
            controller = new Controller.Statys(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void statysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.statysBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void Statys_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Statys". При необходимости она может быть перемещена или удалена.
			this.statysTableAdapter.Fill(this.proektITDataSet.Statys);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < statysDataGridView.RowCount; i++)
			{
				statysDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < statysDataGridView.ColumnCount; j++)
					if (statysDataGridView.Rows[i].Cells[j].Value != null)
						if (statysDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							statysDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
