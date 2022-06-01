using KayyuTatilEvleri.Model;
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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            frmKayit frkayit = new frmKayit();
            frkayit.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            TatilEviContext db = new TatilEviContext();

            Kullanici k = db.Kullanici.Where(x=> x.email== txtEposta.Text && x.sifre==txtSifre.Text).SingleOrDefault();

            if (k == null)
            {   
                MessageBox.Show("Kullanıcı Bulunamadı.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (k != null)
            {
                int kID = k.kullaniciID;
                frmAnasayfa fmanasayfa = new frmAnasayfa();
                fmanasayfa.Show();
                this.Hide();
                
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtSifre.PasswordChar = '\0';
            else          
                txtSifre.PasswordChar = '*';    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnGirisYap_MouseHover(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
