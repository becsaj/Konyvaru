using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Konyvaru.Models
{
    public class Poszt
    {
        public int Id { set; get; }
        public DateTime Datum { get; set; }
        public string Bejegyzes { set; get; }
    }
}