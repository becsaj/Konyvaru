using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Konyvaru.Models
{
    public class Konyv
    {
        public int Id { set; get; }
        public string Szerzo { get; set; }
        public string Cim{ set; get; }
        public string Keszlet { get; set; }
        public string Kep { set; get; }
        public int Ar { get; set; }
        public Kategoria Kategoria { get; set; }
        public int KategoriaId { set; get; }
    }
}