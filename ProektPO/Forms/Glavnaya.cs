using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektPO.Forms
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statys Statys = new Statys();
            Statys.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doljnosti Doljnosti = new Doljnosti();
            Doljnosti.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gryppu Gryppu = new Gryppu();
            Gryppu.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proektu Proektu = new Proektu();
            Proektu.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GruppaSotrudnik GruppaSotrudnik = new GruppaSotrudnik();
            GruppaSotrudnik.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Etapy Etapy = new Etapy();
            Etapy.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            EtapyProekta EtapyProekta = new EtapyProekta();
            EtapyProekta.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otdelu Otdelu = new Otdelu();
            Otdelu.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sotrydniki Sotrydniki = new Sotrydniki();
            Sotrydniki.Show();
        }

         private void button33_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakazchik Zakazchik = new Zakazchik();
            Zakazchik.Show();
        }
    }
}
