using auto_salon.Entities;

namespace auto_salon.App.DTOs
{
    public class ZaposleniDTO : FizickoLiceDTO
    {
        public StatusZaposlenja StatusZaposlenja { get; set; } = StatusZaposlenja.AKTIVAN;

        public required Uloga Uloga { get; set; }

        public required string Pozicija { get; set; }

        public required DateTime DatumZaposlenja { get; set; }

        public DateTime DatumPostavljenja { get; set; }
    }
}
