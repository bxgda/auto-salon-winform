using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class KupacExtensions
    {
        public static KupacDTO ToKupacDTO(this Kupac kupac)
        {
            return new KupacDTO
            {
                ID = kupac.ID,
            };
        }
        public static Kupac ToEntity(this KupacDTO kupacDto)
        {
            return new Kupac { };
        }
    }
}
