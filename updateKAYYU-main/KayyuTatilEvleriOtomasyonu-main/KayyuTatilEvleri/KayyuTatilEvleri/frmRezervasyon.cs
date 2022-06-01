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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        public void Doldur()
        {
            GridRezervasyon.DataSource = db.Rezervasyon.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        TatilEviContext db = new TatilEviContext();
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            Rezervasyon ekle = new Rezervasyon();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAnasayfa fmanasayfa = new frmAnasayfa();
            this.Hide();
            fmanasayfa.Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           

        }

        private void GridRezervasyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = GridRezervasyon.CurrentRow;
            int RezervasyonID = (int)satir.Cells["RezervasyonID"].Value;
            frmDuzenle fmduzenle = new frmDuzenle();          
            fmduzenle.RezervasyonID = RezervasyonID;        
            DialogResult sonuc = fmduzenle.ShowDialog();
            
            if (sonuc == DialogResult.OK)
                Doldur();
            else
                MessageBox.Show("İptal edildi");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eKLEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rsil = (int)GridRezervasyon.SelectedRows[0].Cells[0].Value;
            Rezervasyon r = db.Rezervasyon.Where(x => x.rezervasyonID == rsil).SingleOrDefault();
            if (r!=null)
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "İşlem Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    db.Rezervasyon.Remove(r);
                    db.SaveChanges();
                    Doldur();
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.");
            }
            else
                MessageBox.Show("İşlem bulunamadı.");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmRezarvasyonEkle frm = new frmRezarvasyonEkle();
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc==DialogResult.OK)
            
                Doldur();
            else
                MessageBox.Show("İşlem iptal edildi");



        }
    }
}
