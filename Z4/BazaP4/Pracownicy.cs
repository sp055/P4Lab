namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pracownicy")]
    public partial class Pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownicy()
        {
            Zamówienia = new HashSet<Zamówienia>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDpracownika { get; set; }

        [Required]
        [StringLength(20)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(15)]
        public string Imię { get; set; }

        [StringLength(40)]
        public string Stanowisko { get; set; }

        [StringLength(25)]
        public string ZwrotGrzecznościowy { get; set; }

        public DateTime? DataUrodzenia { get; set; }

        public DateTime? DataZatrudnienia { get; set; }

        [StringLength(60)]
        public string Adres { get; set; }

        [StringLength(25)]
        public string Miasto { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string KodPocztowy { get; set; }

        [StringLength(15)]
        public string Kraj { get; set; }

        [StringLength(24)]
        public string TelefonDomowy { get; set; }

        [StringLength(4)]
        public string TelefonWewnętrzny { get; set; }

        [Column(TypeName = "image")]
        public byte[] Fotografia { get; set; }

        public string Uwagi { get; set; }

        public int? Szef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamówienia> Zamówienia { get; set; }
    }
}
