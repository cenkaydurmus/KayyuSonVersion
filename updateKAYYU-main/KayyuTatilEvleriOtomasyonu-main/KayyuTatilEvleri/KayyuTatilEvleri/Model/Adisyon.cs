namespace KayyuTatilEvleri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adisyon")]
    public partial class Adisyon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int adisyonID { get; set; }

        public int? urunID { get; set; }

        [Column(TypeName = "money")]
        public decimal? birimFiyat { get; set; }

        public DateTime? alisTarihi { get; set; }

        public int? adet { get; set; }

        public int? rezervasyonID { get; set; }

        public virtual Rezervasyon Rezervasyon { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
