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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Devis> ObtientTousLesDevis()
        {
            throw new NotImplementedException();
        }
    }
}