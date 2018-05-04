using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using grcasp.Migrations;

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
        public DbSet<Client> Clients { get; set; }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<BddContext>
        {
            protected override void Seed(BddContext context)
            {
                base.Seed(context);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BddContext, grcasp.Migrations.Configuration>());
        }
    }
}