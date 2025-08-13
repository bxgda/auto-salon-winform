using auto_salon.App.DTOs;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;
 
namespace auto_salon.App.Extensions
{
    public static class PromotivnaPonudaExtension
    {
        public static PromotivnaPonudaDTO ToPromotivnaPonudaDTO(this PromotivnaPonuda promotivnaPonuda)
        {
            return new PromotivnaPonudaDTO
            {
                ID = promotivnaPonuda.ID,
                NazivPromocije = promotivnaPonuda.NazivPromocije,
                PopustUProcentima = promotivnaPonuda.PopustUProcentima,
                DatumOd = promotivnaPonuda.DatumOd,
                DatumDo = promotivnaPonuda.DatumDo,
                Vozila = promotivnaPonuda.Vozila.Select(v => v.ToVoziloTableDTO()).ToList(),
                Uslovi = promotivnaPonuda.Uslovi
            };
        }
    }
}
