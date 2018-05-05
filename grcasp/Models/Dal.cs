using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace grcasp.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void CreerDevisTest(string numero)
        {
            bdd.VentesDevis.Add(new VenteDevis { Numero = 562 });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<VenteDevis> ObtientTousLesDevis()
        {
            return bdd.VentesDevis.ToList();
        }

        public List<Client> ObtientTousLesClients()
        {
            return bdd.Clients.ToList();
        }
    }
}