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
    public partial class GruppaSotrudnik : Form
    {
        Controller.GruppaSotrudnik controller;
        public GruppaSotrudnik()
        {
            InitializeComponent();
            controller = new Controller.GruppaSotrudnik(ConnectionString.ConnStr);
        }

      private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void gruppaSotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.gruppaSotrudnikBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void GruppaSotrudnik_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.GruppaSotrudnik". При необходимости она может быть перемещена или удалена.
			this.gruppaSotrudnikTableAdapter.Fill(this.proektITDataSet.GruppaSotrudnik);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < gruppaSotrudnikDataGridView.RowCount; i++)
			{
				gruppaSotrudnikDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < gruppaSotrudnikDataGridView.ColumnCount; j++)
					if (gruppaSotrudnikDataGridView.Rows[i].Cells[j].Value != null)
						if (gruppaSotrudnikDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							gruppaSotrudnikDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
