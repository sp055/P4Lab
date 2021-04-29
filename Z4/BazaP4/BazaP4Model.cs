using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Z4.BazaP4
{
    public partial class BazaP4Model : DbContext
    {
        public BazaP4Model()
            : base("name=BazaP4Model")
        {
        }

        public virtual DbSet<Klienci> Kliencis { get; set; }
        public virtual DbSet<PozycjeZamówienia> PozycjeZamówienia { get; set; }
        public virtual DbSet<Pracownicy> Pracownicies { get; set; }
        public virtual DbSet<Spedytorzy> Spedytorzies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Zamówienia> Zamówienia { get; set; }
        public virtual DbSet<Dostawcy> Dostawcies { get; set; }
        public virtual DbSet<Kategorie> Kategories { get; set; }
        public virtual DbSet<Produkty> Produkties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klienci>()
                .Property(e => e.IDklienta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Klienci>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Klienci>()
                .HasMany(e => e.Zamówienia)
                .WithRequired(e => e.Klienci)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PozycjeZamówienia>()
                .Property(e => e.CenaJednostkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pracownicy>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zamówienia>()
                .Property(e => e.IDklienta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zamówienia>()
                .Property(e => e.Fracht)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Zamówienia>()
                .HasMany(e => e.PozycjeZamówienia)
                .WithRequired(e => e.Zamówienia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dostawcy>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produkty>()
                .Property(e => e.CenaJednostkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Produkty>()
                .HasMany(e => e.PozycjeZamówienia)
                .WithRequired(e => e.Produkty)
                .WillCascadeOnDelete(false);
        }
    }
}
