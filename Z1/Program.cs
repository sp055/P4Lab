using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Z1
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

            var zapytanie = "SELECT * FROM dbo.Klienci";
            var command = new SqlCommand(zapytanie, connection);

            var reader = command.ExecuteReader();

            //while (reader.Read()) // funkcja zwraca true tak długo jak jest co wypisać 
            //{
            //    Console.WriteLine(reader.GetString(1)); // można też reader[1] jako tablice żeby dało się wrócić
            //}

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

            connection.Close(); // trzeba zamykać ręcznie połączenie żeby nie obciążać bazy danych
        }
    }
}
