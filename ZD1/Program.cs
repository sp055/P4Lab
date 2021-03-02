using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace ZD1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=P4;Integrated Security=True;" +
                                    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                    "MultiSubnetFailover=False;MultipleActiveResultSets = True";
            using var connection = new SqlConnection(connectionString);

            connection.Open(); //otwarcie polaczenia

            var selectSql = "SELECT * FROM dbo.Klienci";
            var command = new SqlCommand(selectSql, connection);

            var reader = command.ExecuteReader();

            //czytanie danych
            foreach (DbDataRecord item in reader)
            {
                Console.WriteLine(item.GetString(0) + " " + item.GetString(1));
            }
            Console.WriteLine();

            //wpisywanie danych
            string idKlienta;
            string nazwaFirmy;
            Console.Write("Podaj IdKlienta (max 5znaków): ");
            idKlienta = Console.ReadLine();
            Console.Write("Podaj nazwe firmy: ");
            nazwaFirmy = Console.ReadLine();

            if ((idKlienta.Length & nazwaFirmy.Length) > 0)
            {
                var insertSql = "INSERT INTO dbo.Klienci (IDklienta, NazwaFirmy) VALUES (@ID, @NazwaFirmy)"; // zakaz wpisywania danych na sztywno dlatego używamy zmiennych @
                var insertCommand = new SqlCommand(insertSql, connection);
                insertCommand.Parameters.Add(new SqlParameter("@ID", idKlienta));
                insertCommand.Parameters.Add(new SqlParameter("@NazwaFirmy", nazwaFirmy));
                insertCommand.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("Nie podałeś nazwy.");
            }

            //aktualizowanie danych
            string idKlientaUpdate;
            string nazwaFirmyUpdate;
            Console.Write("Podaj IDklienta którego nazwe firmy chcesz zaaktualizować: ");
            idKlientaUpdate = Console.ReadLine();
            Console.Write("Jak ma się nazywać zmieniona firma? ");
            nazwaFirmyUpdate = Console.ReadLine();

            var updateSql = $"UPDATE dbo.Klienci SET NazwaFirmy = @NazwaFirmy WHERE IDklienta = @ID";
            var updateCommand = new SqlCommand(updateSql, connection);
            updateCommand.Parameters.Add(new SqlParameter("@NazwaFirmy", nazwaFirmyUpdate));
            updateCommand.Parameters.Add(new SqlParameter("@ID", idKlientaUpdate));
            updateCommand.ExecuteNonQuery();

            //usuwanie danych
            string idKlientaDelete;
            Console.Write("Podaj IDKlienta którego firmę chcesz usunąć: ");
            idKlientaDelete = Console.ReadLine();

            var deleteSql = $"DELETE FROM dbo.Klienci WHERE IDklienta = @ID";
            var deleteCommand = new SqlCommand(deleteSql, connection);
            deleteCommand.Parameters.Add(new SqlParameter("@ID", idKlientaDelete));
            deleteCommand.ExecuteNonQuery();

            connection.Close(); // trzeba zamykać ręcznie połączenie żeby nie obciążać bazy danych
        }
    }
}
