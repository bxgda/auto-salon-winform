using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class FizickoLiceExtension
    {
        public static FizickoLiceTableDTO ToFizickoLiceTableDTO(this FizickoLice fizickoLice)
        {
            return new FizickoLiceTableDTO
            {
                KontaktTelefon = fizickoLice.KontaktTelefon,
                Ime = fizickoLice.Ime,
                Prezime = fizickoLice.Prezime,
                JMBG = fizickoLice.JMBG,
                Email = fizickoLice.Email!,
                Kupac = fizickoLice.Kupac,
                Adresa = fizickoLice.Adresa
            };
        }

        public static FizickoLice FizickoLiceTableToEntity(this FizickoLiceTableDTO fizickoLiceDto)
        {
            return new FizickoLice
            {
                Kupac = fizickoLiceDto.Kupac,
                KontaktTelefon = fizickoLiceDto.KontaktTelefon,
                Ime = fizickoLiceDto.Ime,
                Prezime = fizickoLiceDto.Prezime,
                JMBG = fizickoLiceDto.JMBG,
                Email = fizickoLiceDto.Email,
                Adresa = fizickoLiceDto.Adresa
            };
        }
    }
}