namespace KayyuTatilEvleri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Rezervasyon = new HashSet<Rezervasyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int musteriID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(10)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string adres { get; set; }

        public DateTime? kayitTarihi { get; set; }

        public int? kullaniciID { get; set; }

        [StringLength(11)]
        public string tcNo { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
