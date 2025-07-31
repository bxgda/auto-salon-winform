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

        public ServiceResult<bool> Delete(int id)
        {
            try
            {
                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }

                Salon salon = _session.Load<Salon>(id);
                if (salon is SalonNova salonNova)
                {
                    salonNova.Proizvodjaci.Clear();
                    _session.Flush();
                }

                _session.Delete(salon);
                _session.Flush();
                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju salona: {ex.Message}");
            }
        }

        public ServiceResult<IList<SalonTableDTO>> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    return ServiceResult<IList<SalonTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                var saloni = _session.Query<Salon>().ToList();
                var result = saloni.Select(salon => salon.ToSalonTableDTO()).ToList();

                return ServiceResult<IList<SalonTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonTableDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
        }
    }
}