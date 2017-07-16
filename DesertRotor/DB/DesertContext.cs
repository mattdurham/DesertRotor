using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesertRotor.DB
{
    public class DesertContext : DbContext
    {
        public DesertContext() : base("name=Desert")
        {
            //Autocreates the DB fresh each time
            Database.SetInitializer<DesertContext>(new DropCreateDatabaseAlways<DesertContext>());
            Database.Initialize(true);
        }
        public DbSet<Table1> t1 { get; set; }
    }

    public class Table1
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}