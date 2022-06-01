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
    public partial class frmEv : Form
    {
        public frmEv()
        {
            InitializeComponent();
        }

        private void frmEv_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmOda frmOda = new frmOda();
            this.Hide();
            frmOda.Show();
        }



    }
}
