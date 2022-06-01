using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KayyuTatilEvleri.Model
{
    public partial class TatilEviContext : DbContext
    {
        public TatilEviContext()
            : base("name=TatilEviContext")
        {
        }

        public virtual DbSet<Adisyon> Adisyon { get; set; }
        public virtual DbSet<Ev> Ev { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adisyon>()
                .Property(e => e.birimFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ev>()
                .Property(e => e.fiyati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ev>()
                .Property(e => e.durum)
                .IsFixedLength();

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.tcNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.tcNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Rezervasyon>()
                .Property(e => e.tutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stok>()
                .Property(e => e.adet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Stok>()
                .Property(e => e.alisFiyati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.fiyati)
                .HasPrecision(19, 4);
        }
    }
}
