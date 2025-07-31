using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    internal class ZapolseniTableDTO
    {
        public required string JMBG { get; set; }

        public required string Ime { get; set; }

        public required string Prezime { get; set; }

        public required string Pozicija { get; set; }

        [DisplayName("Datum zaposlenja")]
        public required DateTime DatumZaposlenja { get; set; }

        public required Uloga Uloga { get; set; }

        [DisplayName("Datum postavljenja")]
        public DateTime DatumPostavljenja { get; set; }

        public required Salon Salon { get; set; }
    }
}
