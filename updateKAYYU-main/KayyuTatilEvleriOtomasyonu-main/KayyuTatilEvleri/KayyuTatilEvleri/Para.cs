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
    public partial class Para : Form
    {
        public Para()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Para_Load(object sender, EventArgs e)
        {
            decimal para = 100.5M;
            label1.Text = String.Format("{0:C2}",para);
        }
    }
}
