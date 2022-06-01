using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayyuTatilEvleri
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmGiris frgiris = new frmGiris();
            frgiris.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRezervasyon fmrezervasyon = new frmRezervasyon();
            this.Hide();
            fmrezervasyon.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMusteri fmMusteri = new frmMusteri();
            this.Hide();
            fmMusteri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmEv fmev = new frmEv();
            this.Hide();
            fmev.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMarket fmMarket = new frmMarket();
            this.Hide();
            fmMarket.Show();
        }
    }
}
