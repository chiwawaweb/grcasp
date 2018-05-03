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
            bdd.Devis.Add(new Devis { Numero = numero });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Devis> ObtientTousLesDevis()
        {
            return bdd.Devis.ToList();
        }
    }
}