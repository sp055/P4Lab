using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace Z2
{
    public class DB
    {
        private IDbConnection _connection;
        public DB(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Klienci> GetKlienci()
        {
            return _connection.Query<Klienci>("SELECT * FROM dbo.Klienci");
        }

        public Klienci GetKlienciById(string id)
        {
            return _connection.QuerySingle<Klienci>("SELECT * FROM dbo.Klienci WHERE IDklienta = @Id", new { Id = id }); // @Id = Id
        }
        
        public bool AddKlient(Klienci klient)
        {
            var result = _connection.Execute("INSERT INTO dbo.Klienci(IDklienta, NazwaFirmy) VALUES (@Id, @Nazwa)",
                new { Id = klient.IDklienta, Nazwa = klient.NazwaFirmy });
            return result == 1;
        }
    }
}
