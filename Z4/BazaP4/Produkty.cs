namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mg.Produkty")]
    public partial class Produkty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkty()
        {
            PozycjeZamówienia = new HashSet<PozycjeZamówienia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDproduktu { get; set; }

        [Required]
        [StringLength(40)]
        public string NazwaProduktu { get; set; }

        public int? IDdostawcy { get; set; }

        public int? IDkategorii { get; set; }

        [StringLength(255)]
        public string IlośćJednostkowa { get; set; }

        [Column(TypeName = "money")]
        public decimal? CenaJednostkowa { get; set; }

        public short? StanMagazynu { get; set; }

        public short? IlośćZamówiona { get; set; }

        public short? StanMinimum { get; set; }

        public bool Wycofany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozycjeZamówienia> PozycjeZamówienia { get; set; }

        public virtual Dostawcy Dostawcy { get; set; }

        public virtual Kategorie Kategorie { get; set; }
    }
}
