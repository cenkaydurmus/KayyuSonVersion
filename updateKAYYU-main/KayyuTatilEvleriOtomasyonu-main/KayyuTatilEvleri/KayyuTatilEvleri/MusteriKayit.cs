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
    
    public partial class MusteriKayit : Form
    {
        TatilEviContext db = new TatilEviContext();
        DateTime kayitani = DateTime.Now;
        
        
        public MusteriKayit()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMusteri fmMuster = new frmMusteri();
            fmMuster.Show();
            this.Hide();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            
            Musteri m = new Musteri();
            m.ad = txtAd.Text;
            m.soyad = txtSoyad.Text;
            m.telefon = txtTelefon.Text;
            m.tcNo = txtTc.Text;
            m.kayitTarihi = kayitani; //kayıt edilen tarih ve saat
            m.adres = txtAdres.Text;
            db.Musteri.Add(m);
            int deger = db.SaveChanges();

            if (deger == 1)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Abort;

            this.Close();


        }
    }
}
