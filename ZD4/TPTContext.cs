using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ZD4
{
    public class TPTContext : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pracownik>().ToTable("Pracownicy");
            modelBuilder.Entity<Klient>().ToTable("Klienci");
        }
    }
}
