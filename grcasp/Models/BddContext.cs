using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace grcasp.Models
{
    public class BddContext : DbContext
    {
        public BddContext() : base("DefaultConnection")
        {
            Database.SetInitializer<BddContext>(new ContextInitializer());
        }

        public DbSet<VenteDevis> VentesDevis { get; set; }
        public DbSet<VenteFacture> VentesFactures { get; set; }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<BddContext>
        {
            protected override void Seed(BddContext context)
            {
                base.Seed(context);
            }
        }
    }
}