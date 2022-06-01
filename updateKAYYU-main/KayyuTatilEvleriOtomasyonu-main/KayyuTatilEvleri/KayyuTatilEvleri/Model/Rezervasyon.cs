namespace KayyuTatilEvleri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rezervasyon")]
    public partial class Rezervasyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezervasyon()
        {
            Adisyon = new HashSet<Adisyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rezervasyonID { get; set; }

        public DateTime? baslangıcTarihi { get; set; }

        public DateTime? bitisTarihi { get; set; }

        public int? musteriID { get; set; }

        [StringLength(50)]
        public string odemeTuru { get; set; }

        [Column(TypeName = "money")]
        public decimal? tutar { get; set; }

        [StringLength(50)]
        public string aciklama { get; set; }

        public int? evID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adisyon> Adisyon { get; set; }

        public virtual Ev Ev { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
