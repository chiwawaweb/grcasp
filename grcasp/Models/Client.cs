using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace grcasp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string PrefixeNumero { get; set; }
        public int Numero { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
    }
}