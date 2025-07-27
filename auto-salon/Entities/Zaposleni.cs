using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_salon.Entities
{
    public enum Uloga
    {
        PRODAVAC,
        MENADZER,
        SERVISER,
        FINANSIJSKI_SAVETNIK
    }
    public class Zaposleni
    {
        public virtual required string JMBG { get; set; }
        public virtual required Uloga Uloga { get; set; }
        public virtual required string Pozicija { get; set; }
        public virtual required DateTime DatumZaposlenja { get; set; } = DateTime.Now;
        public virtual DateTime DatumPostavljenja { get; set; }
        public virtual required Salon Salon { get; set; }
    }
}
