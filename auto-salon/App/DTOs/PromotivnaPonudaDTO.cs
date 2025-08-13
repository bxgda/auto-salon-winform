using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class PromotivnaPonudaDTO
    {
        public int ID { get; set; }

        public required string NazivPromocije { get; set; }

        public required decimal PopustUProcentima { get; set; }

        public DateTime DatumOd { get; set; }

        public DateTime DatumDo { get; set; }

        public IList<VoziloTableDTO> Vozila { get; set; } = [];

        public required string Uslovi { get; set; }
    }
}
