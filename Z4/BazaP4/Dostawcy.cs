namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mg.Dostawcy")]
    public partial class Dostawcy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dostawcy()
        {
            Produkties = new HashSet<Produkty>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDdostawcy { get; set; }

        [Required]
        [StringLength(40)]
        public string NazwaFirmy { get; set; }

        [StringLength(30)]
        public string Przedstawiciel { get; set; }

        [StringLength(30)]
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

        public string StronaMacierzysta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty> Produkties { get; set; }
    }
}
