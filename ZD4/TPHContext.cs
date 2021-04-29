using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ZD4
{
    public class TPHContext : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }
    }
}
