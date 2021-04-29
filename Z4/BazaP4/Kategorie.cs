namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mg.Kategorie")]
    public partial class Kategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategorie()
        {
            Produkties = new HashSet<Produkty>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDkategorii { get; set; }

        [Required]
        [StringLength(20)]
        public string NazwaKategorii { get; set; }

        public string Opis { get; set; }

        [Column(TypeName = "image")]
        public byte[] Rysunek { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty> Produkties { get; set; }
    }
}
