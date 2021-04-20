using System;
using System.Linq;
using Z3C.ScaffoldModel;

namespace Z3C
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var db = new P4Context();

            //var customers = db.Kliencis;

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.Idklienta);
            //}

            //db.Kliencis.Add(new Klienci() {Idklienta = "AAAA", NazwaFirmy = "EFCore" }); //reszta danych będzie null
            ////db.ChangeTracker.Clear(); //traci wszystkie zmiany
            ////Console.WriteLine(db.ChangeTracker.DebugView.LongView); //pokazuje logi w konsoli
            //db.SaveChanges(); //żeby zamiany zadziałały na bazie potrzebna jest ta funkcja

            var kontekst = new Kontekst();

            kontekst.Database.EnsureCreated();

            kontekst.Osoby.Add(new Osoba() {Imie = "Jan", Nazwisko = "Kowalski" });
            kontekst.SaveChanges();
        }
    }
}
