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
                Console.WriteLine(item.GetString(1));
            }

            //wpisywanie danych
            var insertSql = "INSERT INTO dbo.Klienci (IDklienta, NazwaFirmy) VALUES (@ID, @NazwaFirmy)"; // zakaz wpisywania danych na sztywno dlatego używamy zmiennych @
            var insertCommand = new SqlCommand(insertSql, connection);
            insertCommand.Parameters.Add(new SqlParameter("@ID", "AAAA"));
            insertCommand.Parameters.Add(new SqlParameter("@NazwaFirmy", "SuperFirma"));
            insertCommand.ExecuteNonQuery();

            //aktualizowanie danych
            var updateSql = "UPDATE dbo.Klienci SET IDklienta = 'BBBB' WHERE IDklienta = 'AAAA'";
            var updateCommand = new SqlCommand(updateSql, connection);
            updateCommand.ExecuteNonQuery();

            //usuwanie danych
            var deleteSql = "DELETE FROM dbo.Klienci WHERE IDklienta = 'BBBB'";
            var deleteCommand = new SqlCommand(deleteSql, connection);
            deleteCommand.ExecuteNonQuery();

            connection.Close(); // trzeba zamykać ręcznie połączenie żeby nie obciążać bazy danych
        }
    }
}
