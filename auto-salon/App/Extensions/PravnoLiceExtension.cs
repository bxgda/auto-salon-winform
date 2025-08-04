using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class PravnoLiceExtension
    {
        public static PravnoLiceTableDTO ToPravnoLiceTableDTO(this PravnoLice pravnoLice)
        {
            return new PravnoLiceTableDTO
            {

                NazivFirme = pravnoLice.NazivFirme,
                Sediste = pravnoLice.Sediste,
                PIB = pravnoLice.PIB,
                Telefon = pravnoLice.Telefon,
                Email = pravnoLice.Email,
                Kupac = pravnoLice.Kupac
            };
        }

        public static PravnoLice PravnoLiceTableToEntity(this PravnoLiceTableDTO pravnoLiceDto)
        {
            return new PravnoLice
            {
                NazivFirme = pravnoLiceDto.NazivFirme,
                Sediste = pravnoLiceDto.Sediste,
                Kupac = pravnoLiceDto.Kupac,
                PIB = pravnoLiceDto.PIB,
                Telefon = pravnoLiceDto.Telefon,
                Email = pravnoLiceDto.Email
            };
        }
    }
}