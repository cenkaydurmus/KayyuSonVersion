namespace KayyuTatilEvleri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stok")]
    public partial class Stok
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stokID { get; set; }

        [StringLength(10)]
        public string adet { get; set; }

        [Column(TypeName = "money")]
        public decimal? alisFiyati { get; set; }

        public int? kullaniciID { get; set; }

        public DateTime? alisTarihi { get; set; }

        public int? urunID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
