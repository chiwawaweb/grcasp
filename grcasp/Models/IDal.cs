using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grcasp.Models
{
    interface IDal : IDisposable
    {
        void CreerDevisTest(string numero);
        List<VenteDevis> ObtientTousLesDevis();
    }
}
