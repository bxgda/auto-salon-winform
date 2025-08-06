using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class VoziloTableDTO
    {
        public required string Stanje { get; set; }

        [DisplayName("Broj šasije")]
        public required string BrojSasije { get; set; }

        public required string Model { get; set; }

        public required string Boja { get; set; }

        [DisplayName("Broj vrata")]
        public int BrojVrata { get; set; }

        [DisplayName("Tip goriva")]
        public required TipGoriva TipGoriva { get; set; }

        [DisplayName("Snaga motora (kW)")]
        public int SnagaMotora { get; set; }

        [DisplayName("Kilometraža")]
        public int Kilometraza { get; set; }

        [DisplayName("Godina proizvodnje")]
        public int GodinaProizvodnje { get; set; }

        [Browsable(false)]
        public int BrojVlasnika { get; set; }

        [Browsable(false)]
        public DateTime DatumRegistracije { get; set; }
    }
}
