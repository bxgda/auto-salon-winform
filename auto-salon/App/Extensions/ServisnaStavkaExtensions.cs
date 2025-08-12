using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class ServisnaStavkaExtensions
    {
        public static ServisnaStavkaDTO ToServisnaStavkaDTO(this ServisnaStavka servisnaStavka)
        {
            return new ServisnaStavkaDTO
            {
                ID = servisnaStavka.ID,
                Datum = servisnaStavka.Datum,
                Opis = servisnaStavka.Opis
            };
        }

        public static ServisnaStavka CreateNewEntity(this ServisnaStavkaDTO servisnaStavkaDTO, PolovnoVozilo polovnoVozilo)
        {
            return new ServisnaStavka
            {
                ID = servisnaStavkaDTO.ID,
                Datum = servisnaStavkaDTO.Datum,
                Opis = servisnaStavkaDTO.Opis,
                Vozilo = polovnoVozilo
            };
        }
    }
}
