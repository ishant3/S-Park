using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceTest.Data.Entities;

namespace WcfServiceTest.Data.Model
{
    public class EntitiesContext:DbContext
    {
        public EntitiesContext() : base(nameOrConnectionString: "DefaultConnectionString") { }

        public virtual DbSet<Parking_Space> GetStatus { get; set; }
    }
}