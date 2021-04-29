namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Klienci")]
    public partial class Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienci()
        {
            Zamówienia = new HashSet<Zamówienia>();
        }

        [Key]
        [StringLength(5)]
        public string IDklienta { get; set; }

        [Required]
        [StringLength(40)]
        public string NazwaFirmy { get; set; }

        [StringLength(30)]
        public string Przedstawiciel { get; set; }

        [StringLength(35)]
        public string StanowiskoPrzedstawiciela { get; set; }

        [StringLength(60)]
        public string Adres { get; set; }

        [StringLength(15)]
        public string Miasto { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string KodPocztowy { get; set; }

        [StringLength(15)]
        public string Kraj { get; set; }

        [StringLength(24)]
        public string Telefon { get; set; }

        [StringLength(24)]
        public string Faks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamówienia> Zamówienia { get; set; }
    }
}
