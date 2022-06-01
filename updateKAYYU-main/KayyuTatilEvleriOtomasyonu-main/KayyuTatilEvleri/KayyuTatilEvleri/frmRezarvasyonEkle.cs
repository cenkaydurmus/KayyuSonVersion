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
    public partial class frmRezarvasyonEkle : Form
    {
        TatilEviContext db = new TatilEviContext();
        
        

        public frmRezarvasyonEkle()
        {
            InitializeComponent();
        }

        private void frmRezarvasyonEkle_Load(object sender, EventArgs e)
        {
            var evler = db.Ev.ToList();
            cmbEv.DataSource = evler;
            cmbEv.DisplayMember = "no";
            cmbEv.ValueMember = "evID";

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Rezervasyon r = new Rezervasyon();
            r.baslangıcTarihi = dateTimeBaslangic.Value;
            r.bitisTarihi = dateTimeBitis.Value;
            r.musteriID = Convert.ToInt32(txtMusteriID.Text);
            r.odemeTuru = cmbOdemeYontemi.SelectedItem.ToString();  
            r.tutar = Convert.ToDecimal(txtTutar.Text);
            r.evID = (int)cmbEv.SelectedValue;
            r.aciklama = txtAciklama.Text;
            db.Rezervasyon.Add(r);
            int deger = db.SaveChanges(); 

            if (deger == 1)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Abort;

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbEv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçili olan evin ıd'si ile veri tabanından o evin bilgileri çekilecek.
            // çekilen bilgiler içindeki evin fiyatı tutar kısmına yazılacak.
        }

        

        
    }
}
