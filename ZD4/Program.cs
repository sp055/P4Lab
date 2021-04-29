using System;

namespace ZD4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Osoby.Add(new Pracownik() { Imie = "Marcin", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now.AddDays(12), DataZwolnienia = null});
            tph.Osoby.Add(new Pracownik() { Imie = "Andrzej", Nazwisko = "Nowak", DataZatrudnienia = DateTime.Now.AddDays(9), DataZwolnienia = DateTime.Now.AddDays(100) });
            tph.Osoby.Add(new Pracownik() { Imie = "Maciek", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now.AddDays(22), DataZwolnienia = DateTime.Now.AddDays(100) });

            tph.Osoby.Add(new Klient() { Imie = "Sebastian", Nazwisko = "Nowak", NrTelefonu = "072-132-0864", NrRejestracyjny = "G2C 8M7" });
            tph.Osoby.Add(new Klient() { Imie = "Jerzy", Nazwisko = "Kowalski", NrTelefonu = "087-201-2707", NrRejestracyjny = "SE45 6YG" });
            tph.Osoby.Add(new Klient() { Imie = "Paweł", Nazwisko = "Nowak", NrTelefonu = "046-557-6330", NrRejestracyjny = "S5E 3W0" });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Osoby.Add(new Pracownik() { Imie = "Adam", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now.AddDays(8), DataZwolnienia = null});
            tpt.Osoby.Add(new Pracownik() { Imie = "Bartek", Nazwisko = "Nowak", DataZatrudnienia = DateTime.Now.AddDays(6), DataZwolnienia = DateTime.Now.AddDays(100) });
            tpt.Osoby.Add(new Pracownik() { Imie = "Miłosz", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now.AddDays(7), DataZwolnienia = DateTime.Now.AddDays(100) });

            tpt.Osoby.Add(new Klient() { Imie = "Szymon", Nazwisko = "Nowak", NrTelefonu = "093-558-7231", NrRejestracyjny = "W28 I60" });
            tpt.Osoby.Add(new Klient() { Imie = "Bartosz", Nazwisko = "Kowalski", NrTelefonu = "005-140-5799", NrRejestracyjny = "QW8 9HH" });
            tpt.Osoby.Add(new Klient() { Imie = "Arkadiusz", Nazwisko = "Nowak", NrTelefonu = "030-567-6088", NrRejestracyjny = "VL2 1AM" });
            tpt.SaveChanges();
        }
    }
}
