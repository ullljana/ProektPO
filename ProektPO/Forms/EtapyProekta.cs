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
    public partial class EtapyProekta : Form
    {
        Controller.EtapyProekta controller;
        public EtapyProekta()
        {
            InitializeComponent();
            controller = new Controller.EtapyProekta(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glavnaya Glavnaya = new Glavnaya();
            Glavnaya.Show();
        }

		private void etapyProektaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.etapyProektaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.proektITDataSet);

		}

		private void EtapyProekta_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Statys". При необходимости она может быть перемещена или удалена.
			this.statysTableAdapter.Fill(this.proektITDataSet.Statys);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Gryppu". При необходимости она может быть перемещена или удалена.
			this.gryppuTableAdapter.Fill(this.proektITDataSet.Gryppu);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Proektu". При необходимости она может быть перемещена или удалена.
			this.proektuTableAdapter.Fill(this.proektITDataSet.Proektu);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.Etapy". При необходимости она может быть перемещена или удалена.
			this.etapyTableAdapter.Fill(this.proektITDataSet.Etapy);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "proektITDataSet.EtapyProekta". При необходимости она может быть перемещена или удалена.
			this.etapyProektaTableAdapter.Fill(this.proektITDataSet.EtapyProekta);

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			for (int i = 0; i < etapyProektaDataGridView.RowCount; i++)
			{
				etapyProektaDataGridView.Rows[i].Selected = false;
				for (int j = 0; j < etapyProektaDataGridView.ColumnCount; j++)
					if (etapyProektaDataGridView.Rows[i].Cells[j].Value != null)
						if (etapyProektaDataGridView.Rows[i].Cells[j].Value.ToString().Contains(myTextBox.Text))
						{
							etapyProektaDataGridView.Rows[i].Selected = true;
							break;
						}
			}

		}
	}
}
