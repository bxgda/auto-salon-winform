using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.Entities;
using NHibernate;

namespace auto_salon.App.Services
{
    public class SalonService : ISalonService
    {
        private readonly ISession? _session;

        public SalonService()
        {
            _session = DataLayer.GetSession();
        }

        public IList<SalonTableDTO> GetAll()
        {
            if (_session == null)
            {
                return [];
            }

            var saloni = _session.Query<Salon>().ToList();

            return saloni.Select(salon => salon.ToSalonTableDTO()).ToList();
        }
    }
}
