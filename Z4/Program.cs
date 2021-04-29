using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var ctx = new BazaP4.BazaP4Model();
        //    foreach (var item in ctx.Kliencis)
        //    {
        //        Console.WriteLine(item.IDklienta);
        //    }
        //    //Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    var ctx = new KontekstEF6();

        //    ctx.Osoby.Add(new Osoba() { Imie = "Jan", Nazwisko = "Kowalski", Adres = "Warszawa", Opis = "Jakiś opis" });
        //    ctx.SaveChanges();
        //}
        static void Main(string[] args)
        {
            //var tph = new TPHContext();
            //tph.Computers.Add(new PC() { Price = 1000, CoolingType = "Air" });
            //tph.Computers.Add(new Laptop() { Price = 800, Weight = 4.5 });
            //tph.SaveChanges();

            //var tpt = new TPTContext();
            //tpt.Computers.Add(new PC() { Price = 1000, CoolingType = "Air" });
            //tpt.Computers.Add(new Laptop() { Price = 800, Weight = 4.5 });
            //tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new PC() { Id = 1, Price = 1000, CoolingType = "Air" });
            tpc.Computers.Add(new Laptop() { Id = 2, Price = 800, Weight = 4.5 });
            tpc.SaveChanges();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
