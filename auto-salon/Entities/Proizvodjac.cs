using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_salon.Entities
{
    public class Proizvodjac
    {
        public virtual int ID { get; protected set; }
        public virtual required string Naziv { get; set; }
        public virtual required IList<Vozilo> Vozila { get; set; }

        public Proizvodjac()
        {
            Vozila = new List<Vozilo>();
        }
    }
}
