namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Spedytorzy")]
    public partial class Spedytorzy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Spedytorzy()
        {
            Zamówienia = new HashSet<Zamówienia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDspedytora { get; set; }

        [Required]
        [StringLength(40)]
        public string NazwaFirmy { get; set; }

        [StringLength(24)]
        public string Telefon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamówienia> Zamówienia { get; set; }
    }
}
