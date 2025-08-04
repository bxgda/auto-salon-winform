using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class PromotivnaPonudaExtension
    {
        public static PromotivnaPonudaTableDTO ToPromotivnaPonudaTableDTO(this PromotivnaPonuda ponuda)
        {
            return new PromotivnaPonudaTableDTO
            {
                NazivPromocije = ponuda.NazivPromocije,
                Vozilo = ponuda.Vozilo,
                PopustUProcentima = ponuda.PopustUProcentima,
                Uslovi = ponuda.Uslovi,
                DatumDo = ponuda.DatumDo,
                DatumOd = ponuda.DatumOd,
            };
        }

        public static PromotivnaPonuda PromotivnaPonudaTableToEntity(this PromotivnaPonudaTableDTO ponudaDto)
        {
            return new PromotivnaPonuda
            {
                Vozilo = ponudaDto.Vozilo,
                NazivPromocije = ponudaDto.NazivPromocije,
                PopustUProcentima = ponudaDto.PopustUProcentima,
                Uslovi = ponudaDto.Uslovi,
                DatumDo = ponudaDto.DatumDo,
                DatumOd = ponudaDto.DatumOd,
            };
        }
    }
}