using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.Extensions
{
    public static class ProizvodjacExtension
    {
        public static ProizvodjacTableDTO ToProizvodjacTableDTO(this Proizvodjac proizvodjac)
        {
            return new ProizvodjacTableDTO
            {
                Naziv = proizvodjac.Naziv,
            };
        }

        public static Proizvodjac ProizvodjacTableToEntity(this ProizvodjacTableDTO proizvodjacDto)
        {
            return new Proizvodjac
            {
                Naziv = proizvodjacDto.Naziv,
            };
        }
    }
}