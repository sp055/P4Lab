using System;

namespace ZD2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = P4; 
                              Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
                              ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            //read
            foreach (Klienci klienci in db.GetKlienci())
            {
                Console.WriteLine($"{klienci.IDklienta}: {klienci.NazwaFirmy}");
            }
            Console.WriteLine("-----");

            //read jednego klienta po id
            Console.Write($"Podaj Id dla firmy którą chcesz wyświetlić(max 5 znaków): ");
            var wys = Console.ReadLine().ToUpper();
            if ((wys.Length) > 0)
            {
                var jedenKlient = db.GetKlienciById(wys);
                Console.WriteLine($"{jedenKlient.IDklienta}: {jedenKlient.NazwaFirmy}");
            }

            else
            {
                Console.WriteLine("Nie podałeś Id.");
            }
            Console.WriteLine("-----");

            //create
            string noweId;
            string nowaFirma;
            Console.Write("Podaj nazwę firmy jaką chcesz dodać: ");
            nowaFirma = Console.ReadLine();
            Console.Write($"Podaj Id dla firmy '{nowaFirma}' (max 5 znaków): ");
            noweId = Console.ReadLine().ToUpper();

            if ((noweId.Length & nowaFirma.Length) > 0)
            {
                db.AddKlient(new Klienci() { IDklienta = noweId, NazwaFirmy = nowaFirma });
            }
            else
            {
                Console.WriteLine("Nie podałeś nazwy.");
            }

            //delete
            Console.Write("Podaj nazwę Id firmy którą chcesz usunąć(max 5 znaków): ");
            var del = Console.ReadLine().ToUpper(); ;
            if (db.DeleteKlient(new Klienci() { IDklienta = del }))
            {
                Console.WriteLine($"Usunięto '{del}'.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono takiego Id.");
            }

            //update
            string idKlientaUpdate;
            string nazwaFirmyUpdate;
            Console.Write("Podaj IDklienta którego nazwe firmy chcesz zaaktualizować: ");
            idKlientaUpdate = Console.ReadLine().ToUpper();
            Console.Write("Jak ma się nazywać zmieniona firma? ");
            nazwaFirmyUpdate = Console.ReadLine();
            if (db.UpdateKlient(new Klienci() { IDklienta = idKlientaUpdate, NazwaFirmy = nazwaFirmyUpdate })
                & (idKlientaUpdate.Length & nazwaFirmyUpdate.Length) > 0)
            {
                Console.WriteLine($"Zaaktualizowano '{idKlientaUpdate}' nazwę firmy na '{nazwaFirmyUpdate}'");
            }
            else
            {
                Console.WriteLine("Nie zaaktualizowano.");
            }
        }
    }
}




