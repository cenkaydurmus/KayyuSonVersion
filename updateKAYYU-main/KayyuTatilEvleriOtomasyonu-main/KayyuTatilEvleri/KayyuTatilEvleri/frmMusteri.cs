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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAnasayfa fmanasayfa = new frmAnasayfa();
            this.Hide();
            fmanasayfa.Show();
        }
        TatilEviContext db = new TatilEviContext();
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            var liste = db.Musteri.Select(x => new
            {
                x.musteriID,
                x.ad,
                x.soyad,
                x.telefon,
                x.adres,
                x.kayitTarihi,
                x.tcNo,
                x.kullaniciID,

            }).ToList();


            gridMusteri.DataSource = liste;
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            MusteriKayit frm = new MusteriKayit();
            this.Hide();
            frm.Show();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int msil = (int)gridMusteri.SelectedRows[0].Cells[0].Value;
            Musteri m = db.Musteri.Where(x => x.musteriID == msil).SingleOrDefault();
            if (m != null)
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "İşlem Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    db.Musteri.Remove(m);
                    db.SaveChanges();
                    gridMusteri.DataSource = db.Musteri.ToList();
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.");
            }
            else
                MessageBox.Show("İşlem bulunamadı.");
        }
    }
}
