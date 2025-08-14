using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class ProizvodjacExtensions
    {
        public static ProizvodjacDTO ToProizvodjacDTO(this Proizvodjac proizvodjac)
        {
            return new ProizvodjacDTO
            {
                ID = proizvodjac.ID,
                Naziv = proizvodjac.Naziv
            };
        }

        public static Proizvodjac CreateNewEntity(this ProizvodjacDTO dto)
        {
            return new Proizvodjac
            {
                Naziv = dto.Naziv
            };
        }
    }
}
