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
        public bool Particulier { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}