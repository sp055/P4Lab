namespace Z4.BazaP4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PozycjeZamówienia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDzamówienia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDproduktu { get; set; }

        [Column(TypeName = "money")]
        public decimal CenaJednostkowa { get; set; }

        public short Ilość { get; set; }

        public float Rabat { get; set; }

        public virtual Produkty Produkty { get; set; }

        public virtual Zamówienia Zamówienia { get; set; }
    }
}
