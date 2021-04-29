using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    public class KontekstEF6 : DbContext
    {
        public KontekstEF6() : base()
        {

        }
        public DbSet<Osoba> Osoby { get; set; }
    }
}
