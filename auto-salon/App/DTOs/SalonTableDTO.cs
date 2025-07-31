using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class SalonTableDTO
    {
        public int ID { get; set; }

        public required string Tip { get; set; }

        [DisplayName("Država")]
        public required string Drzava { get; set; }

        public required string Grad { get; set; }

        public required string Adresa { get; set; }

        public required string Naziv { get; set; }

        [DisplayName("Radno vreme")]
        public required string RadnoVreme { get; set; }

        [DisplayName("Kontakt telefon")]
        public required string KontaktTelefon { get; set; }

        [DisplayName("Broj Zaposlenih")]
        public int BrojZaposlenih { get; set; }
    }
}
