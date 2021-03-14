using System;
using Dapper;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Testowa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            foreach (Klienci klienci in db.GetKlienci())
            {
                Console.WriteLine($"{klienci.IDklienta}: {klienci.NazwaFirmy}");
            }
            Console.WriteLine();

            var jedenKlient = db.GetKlienciById("ALFKI");
            Console.WriteLine($"{jedenKlient.IDklienta}: {jedenKlient.NazwaFirmy}");

            db.AddKlient(new Klienci() { IDklienta = "AAAAA", NazwaFirmy = "SuperFirma" });
            Console.WriteLine();
            foreach (Klienci klienci in db.GetKlienci())
            {
                Console.WriteLine($"{klienci.IDklienta}: {klienci.NazwaFirmy}");
            }
            Console.WriteLine();
        }
    }
}
