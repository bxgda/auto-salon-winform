using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class PromotivnaPonudaDTO
    {
        public int ID { get; set; }

        [DisplayName("Naziv promocije")]
        public required string NazivPromocije { get; set; }

        [DisplayName("Popust %")]
        public required decimal PopustUProcentima { get; set; }

        [DisplayName("Datum početka promocije")]
        public DateTime DatumOd { get; set; }

        [DisplayName("Datum završetka promocije")]
        public DateTime DatumDo { get; set; }

        public required Vozilo Vozilo { get; set; }

        public required string Uslovi { get; set; }
    }
}
