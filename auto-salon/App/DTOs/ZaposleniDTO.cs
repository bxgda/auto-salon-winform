using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class ZaposleniDTO
    {
        public required string JMBG { get; set; }

        public required Uloga Uloga { get; set; }

        public required string Ime { get; set; }

        public required string Prezime { get; set; }

        public required string Pozicija { get; set; }

        [DisplayName("Datum zaposlenja")]
        public required DateTime DatumZaposlenja { get; set; }

        [DisplayName("Datum postavljenja")]
        public DateTime DatumPostavljenja { get; set; }

        [Browsable(false)]
        public required Salon Salon { get; set; }

        [DisplayName("Kontakt telefon")]
        public virtual required string KontaktTelefon { get; set; }

        [Browsable(false)]
        public virtual required Kupac Kupac { get; set; }
    }
}
