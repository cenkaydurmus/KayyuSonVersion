
namespace KayyuTatilEvleri
{
    partial class frmMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteri));
            this.gridMusteri = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMusteri
            // 
            this.gridMusteri.BackgroundColor = System.Drawing.Color.White;
            this.gridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteri.ContextMenuStrip = this.contextMenuStrip1;
            this.gridMusteri.Location = new System.Drawing.Point(40, 70);
            this.gridMusteri.Name = "gridMusteri";
            this.gridMusteri.Size = new System.Drawing.Size(852, 409);
            this.gridMusteri.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Müşteri Ara :";
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(136, 17);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(470, 33);
            this.txtTutar.TabIndex = 27;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(880, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 35);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRezervasyonYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(632, 17);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(211, 33);
            this.btnRezervasyonYap.TabIndex = 29;
            this.btnRezervasyonYap.Text = "Yeni Müşteri Ekle";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnRezervasyonEkle
            // 
            this.btnRezervasyonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRezervasyonEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonEkle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonEkle.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(12, 494);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(211, 33);
            this.btnRezervasyonEkle.TabIndex = 30;
            this.btnRezervasyonEkle.Text = "Yeni Rezervasyon Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dÜZENLEToolStripMenuItem,
            this.sİLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // dÜZENLEToolStripMenuItem
            // 
            this.dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            this.dÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.btnRezervasyonEkle);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
    }
}