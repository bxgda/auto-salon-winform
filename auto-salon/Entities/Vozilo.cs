using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_salon.Entities
{
    public enum TipGoriva
    {
        DIZEL,
        BENZIN,
        ELEKTRICNI,
        HIDROGEN,
        PLIN,
        METAN,
        HIBRID
    }

    public enum Stanje
    {
        NOVO,
        POLOVNO
    }

    internal class Vozilo
    {
        public virtual required string BrojSasije { get; set; }
        public virtual required string Model { get; set; } = string.Empty;
        public virtual required TipGoriva TipGoriva { get; set; }
        public virtual int Kilometraza { get; set; } = 0;
        public virtual int BrojVrata { get; set; }
        public virtual int SnagaMotora { get; set; }
        public virtual required string Boja { get; set; }
        public virtual int GodinaProizvodnje { get; set; }
        public virtual required Stanje Stanje { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }
        public virtual int BrojVlasnika { get; set; } = 0;
        public virtual required Proizvodjac Proizvodjac { get; set; }
        public virtual required Salon Salon { get; set; }
    }
}