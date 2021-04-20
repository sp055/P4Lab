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

            var db = new DB(connectionString);

            db.Create();
            db.Read();
            Console.WriteLine("---------------");
            db.Update();
            //dataBaseObj.Read();
            Console.WriteLine("---------------");
            db.Delete();
            //dataBaseObj.Read();
            Console.WriteLine("---------------");

        }
    }
}
