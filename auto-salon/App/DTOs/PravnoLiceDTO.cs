namespace auto_salon.App.DTOs
{
    public class PravnoLiceDTO
    {
        public required string PIB { get; set; }

        public required string NazivFirme { get; set; }

        public required string Email { get; set; }

        public required string Telefon { get; set; }

        public required string Sediste { get; set; }

        public string? KontaktOsoba { get; set; }
    }
}
