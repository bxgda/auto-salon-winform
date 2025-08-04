using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class FizickoLiceDTO
    {
        public required string JMBG { get; set; }

        public required string Ime { get; set; }

        public required string Prezime { get; set; }

        public required string Email { get; set; }

        [DisplayName("Kontakt telefon")]
        public required string KontaktTelefon { get; set; }

        public string? Adresa { get; set; }
    }
}
