using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class PravnoLiceExtensions
    {
        public static PravnoLiceDTO ToPravnoLiceDTO(this PravnoLice pravnoLice)
        {
            return new PravnoLiceDTO
            {
                PIB = pravnoLice.PIB,
                Email = pravnoLice.Email,
                NazivFirme = pravnoLice.NazivFirme,
                Sediste = pravnoLice.Sediste,
                Telefon = pravnoLice.Telefon,
                KontaktOsoba = pravnoLice.KontaktOsoba
            };
        }
        public static PravnoLice CreateNewEntity(this PravnoLiceDTO pravnoLiceDto, Kupac kupac)
        {
            return new PravnoLice
            {
                PIB = pravnoLiceDto.PIB,
                Email = pravnoLiceDto.Email,
                NazivFirme = pravnoLiceDto.NazivFirme,
                Sediste = pravnoLiceDto.Sediste,
                Telefon = pravnoLiceDto.Telefon,
                KontaktOsoba = pravnoLiceDto.KontaktOsoba,
                Kupac = kupac
            };
        }
    }
}
