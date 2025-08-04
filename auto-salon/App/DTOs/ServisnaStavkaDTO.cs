using auto_salon.Entities;
using System.ComponentModel;

namespace auto_salon.App.DTOs
{
    public class ServisnaStavkaDTO
    {
        public required int ID { get; set; }

        [DisplayName("Datum servisiranja")]
        public required DateTime Datum { get; set; }

        public required string Opis { get; set; }
    }
}
