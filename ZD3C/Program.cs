using System;
using ZD3C.Scaffold;

namespace ZD3C
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new P4Context();
            db.Add(new MyUsers() { });

            db.SaveChanges();
        }
    }
}
