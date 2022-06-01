namespace KayyuTatilEvleri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ev")]
    public partial class Ev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ev()
        {
            Rezervasyon = new HashSet<Rezervasyon>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int evID { get; set; }

        public int? no { get; set; }

        public int? katNo { get; set; }

        public int? tekyatakSayi { get; set; }

        public int? ciftYatakSayi { get; set; }

        [Column(TypeName = "money")]
        public decimal? fiyati { get; set; }

        [StringLength(20)]
        public string durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
