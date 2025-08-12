using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class FizickoLiceExtensions
    {
        public static FizickoLiceDTO ToFizickoLiceDTO(this FizickoLice fizickoLice)
        {
            return new FizickoLiceDTO
            {
                JMBG = fizickoLice.JMBG,
                Ime = fizickoLice.Ime,
                Prezime = fizickoLice.Prezime,
                Email = fizickoLice.Email,
                KontaktTelefon = fizickoLice.KontaktTelefon,
                Adresa = fizickoLice.Adresa,
            };
        }
        public static FizickoLice CreateNewEntity(this FizickoLiceDTO fizickoLiceDto)
        {
            return new FizickoLice
            {
                JMBG = fizickoLiceDto.JMBG,
                Ime = fizickoLiceDto.Ime,
                Prezime = fizickoLiceDto.Prezime,
                Email = fizickoLiceDto.Email,
                KontaktTelefon = fizickoLiceDto.KontaktTelefon,
                Adresa = fizickoLiceDto.Adresa,
            };
        }
    }
}
