using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{
    internal class ProizvodjacService : IProizvodjacService
    {
        private ISession? _session;

        public ServiceResult<IList<Proizvodjac>> GetProizvodjaciZaSalonNova(int salonId)
        {
            try
            {
                _session = DataLayer.GetSession();
                if (_session == null)
                    return ServiceResult<IList<Proizvodjac>>.Failure("Nema konekcije sa bazom.");

                // Povuci samo proizvođače vezane za salon novih vozila
                var salonNova = _session.Query<SalonNova>().FirstOrDefault(s => s.ID == salonId);
                if (salonNova == null)
                    return ServiceResult<IList<Proizvodjac>>.Failure("Salon nije pronađen ili nije tip NOVA.");

                var proizvodjaci = salonNova.Proizvodjaci.ToList();
                return ServiceResult<IList<Proizvodjac>>.Success(proizvodjaci);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<Proizvodjac>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<IList<Proizvodjac>> GetSviProizvodjaci()
        {
            try
            {
                _session = DataLayer.GetSession();
                if (_session == null)
                    return ServiceResult<IList<Proizvodjac>>.Failure("Nema konekcije sa bazom.");

                var proizvodjaci = _session.Query<Proizvodjac>().ToList();
                return ServiceResult<IList<Proizvodjac>>.Success(proizvodjaci);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<Proizvodjac>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}
