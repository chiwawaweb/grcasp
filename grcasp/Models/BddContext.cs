using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace grcasp.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Devis> Devis { get; set; }
    }
}