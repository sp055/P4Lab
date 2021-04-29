namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zamówienia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamówienia()
        {
            PozycjeZamówienia = new HashSet<PozycjeZamówienia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDzamówienia { get; set; }

        [Required]
        [StringLength(5)]
        public string IDklienta { get; set; }

        public int? IDpracownika { get; set; }

        public DateTime? DataZamówienia { get; set; }

        public DateTime? DataWymagana { get; set; }

        public DateTime? DataWysyłki { get; set; }

        public int? IDspedytora { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fracht { get; set; }

        [StringLength(40)]
        public string NazwaOdbiorcy { get; set; }

        [StringLength(60)]
        public string AdresOdbiorcy { get; set; }

        [StringLength(15)]
        public string MiastoOdbiorcy { get; set; }

        [StringLength(15)]
        public string RegionOdbiorcy { get; set; }

        [StringLength(10)]
        public string KodPocztowyOdbiorcy { get; set; }

        [StringLength(15)]
        public string KrajOdbiorcy { get; set; }

        public virtual Klienci Klienci { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozycjeZamówienia> PozycjeZamówienia { get; set; }

        public virtual Pracownicy Pracownicy { get; set; }

        public virtual Spedytorzy Spedytorzy { get; set; }
    }
}
