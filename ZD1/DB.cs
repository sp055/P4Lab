using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace ZD1
{
    public class DB
    {
        private SqlConnection polaczenie;
        public DB(string connectionString)
        {
            polaczenie = new SqlConnection(connectionString);
        }

        public void Create() //wpisywanie/tworzenie danych
        {
            polaczenie.Open();

            string idKlienta;
            string nazwaFirmy;
            Console.Write("Podaj IdKlienta (max 5znaków): ");
            idKlienta = Console.ReadLine();
            Console.Write("Podaj nazwe firmy: ");
            nazwaFirmy = Console.ReadLine();

            if ((idKlienta.Length & nazwaFirmy.Length) > 0)
            {
                var insertSql = "INSERT INTO dbo.Klienci (IDklienta, NazwaFirmy) VALUES (@ID, @NazwaFirmy)"; // zakaz wpisywania danych na sztywno dlatego używamy zmiennych @
                var insertCommand = new SqlCommand(insertSql, polaczenie);
                insertCommand.Parameters.Add(new SqlParameter("@ID", idKlienta));
                insertCommand.Parameters.Add(new SqlParameter("@NazwaFirmy", nazwaFirmy));
                insertCommand.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("Nie podałeś nazwy.");
            }

            polaczenie.Close();
        }

        
        public void Read() //czytanie danych
        {
            polaczenie.Open();

            var selectSql = "SELECT * FROM dbo.Klienci";
            var command = new SqlCommand(selectSql, polaczenie);
            var reader = command.ExecuteReader();
            foreach (DbDataRecord item in reader)
            {
                Console.WriteLine(item.GetString(0) + " " + item.GetString(1));
            }
            Console.WriteLine();

            polaczenie.Close();
        }

        public void Update() //aktualizowanie danych
        {
            polaczenie.Open();

            string idKlientaUpdate;
            string nazwaFirmyUpdate;
            Console.Write("Podaj IDklienta którego nazwe firmy chcesz zaaktualizować: ");
            idKlientaUpdate = Console.ReadLine();
            Console.Write("Jak ma się nazywać zmieniona firma? ");
            nazwaFirmyUpdate = Console.ReadLine();

            var updateSql = $"UPDATE dbo.Klienci SET NazwaFirmy = @NazwaFirmy WHERE IDklienta = @ID";
            var updateCommand = new SqlCommand(updateSql, polaczenie);
            updateCommand.Parameters.Add(new SqlParameter("@NazwaFirmy", nazwaFirmyUpdate));
            updateCommand.Parameters.Add(new SqlParameter("@ID", idKlientaUpdate));
            updateCommand.ExecuteNonQuery();

            polaczenie.Close();
        }

        public void Delete() //usuwanie danych
        {
            polaczenie.Open();

            string idKlientaDelete;
            Console.Write("Podaj IDKlienta którego firmę chcesz usunąć: ");
            idKlientaDelete = Console.ReadLine();

            var deleteSql = $"DELETE FROM dbo.Klienci WHERE IDklienta = @ID";
            var deleteCommand = new SqlCommand(deleteSql, polaczenie);
            deleteCommand.Parameters.Add(new SqlParameter("@ID", idKlientaDelete));
            deleteCommand.ExecuteNonQuery();

            polaczenie.Close();
        }
    }
}
