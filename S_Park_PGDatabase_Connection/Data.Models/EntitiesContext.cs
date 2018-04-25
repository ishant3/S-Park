using S_Park_PGDatabase_Connection.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S_Park_PGDatabase_Connection.Data.Models
{
    public class EntitiesContext : DbContext
    {

        public EntitiesContext() : base(nameOrConnectionString: "DefaultConnectionString") { }

        public virtual DbSet<Parking_Garage> GetStatus { get; set; }
    }
}