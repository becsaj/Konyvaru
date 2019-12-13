using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Konyvaru.Models
{
    public class Kategoria
    {
        public int Id { set; get; }
        public string Megnevezes { get; set; }
        public double Nepszeruseg { set; get; }
    }
}