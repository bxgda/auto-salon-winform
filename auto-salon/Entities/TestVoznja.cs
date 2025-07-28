using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_salon.Entities
{
    internal class TestVoznja
    {
        public virtual int ID { get; protected set; }

        public virtual required Vozilo Vozilo { get; set; }

        public virtual required Kupac Kupac { get; set; }

        public virtual required Prodavac Prodavac { get; set; }

        public virtual DateOnly Datum { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public virtual required string Vreme { get; set; }

        public virtual required decimal Ocena { get; set; }

        public virtual string? Zakljucak { get; set; }
    }
}
