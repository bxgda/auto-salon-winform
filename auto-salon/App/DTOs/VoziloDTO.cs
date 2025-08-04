using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class VoziloDTO
    {
        public KupoprodajniUgovor? Ugovor { get; set; }

        public required Salon Salon { get; set; }

        [DisplayName("Broj šasije")]
        public required string BrojSasije { get; set; }
        
        [DisplayName("Proizvođač")]
        public required Proizvodjac Proizvodjac { get; set; }

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
    }

    public class PolovnoVoziloTableDTO : VoziloDTO
    {
        [DisplayName("Datum registracije")]
        public DateTime DatumRegistracije { get; set; }

        [DisplayName("Broj vlasnika")]
        public int BrojVlasnika { get; set; }
    }

    public class NovoVoziloTableDTO : VoziloDTO { }
}
