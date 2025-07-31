using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class PravnoLiceTableDTO
    {
        public required string PIB { get; set; }

        [DisplayName("Naziv firme")]
        public required string NazivFirme { get; set; }

        public required string Email { get; set; }

        public required string Telefon { get; set; }

        [DisplayName("Sedište")]
        public required string Sediste { get; set; }
    }
}
