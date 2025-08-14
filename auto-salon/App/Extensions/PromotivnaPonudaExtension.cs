using auto_salon.App.DTOs;
using auto_salon.Entities;
 
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
                Uslovi = promotivnaPonuda.Uslovi
            };
        }

        public static PromotivnaPonuda CreateNewEntity(this PromotivnaPonudaDTO promotivnaPonudaDTO)
        {
            return new PromotivnaPonuda
            {
                NazivPromocije = promotivnaPonudaDTO.NazivPromocije,
                PopustUProcentima = promotivnaPonudaDTO.PopustUProcentima,
                DatumOd = promotivnaPonudaDTO.DatumOd,
                DatumDo = promotivnaPonudaDTO.DatumDo,
                Uslovi = promotivnaPonudaDTO.Uslovi
            };
        }
    }
}
