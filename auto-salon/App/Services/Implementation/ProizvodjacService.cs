using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class ProizvodjacService : IProizvodjacService
    {
        private readonly IDataLayer _dataLayer;

        public ProizvodjacService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<Proizvodjac>> GetProizvodjaciZaSalonNova(int salonId)
        {
            var session = _dataLayer.OpenSession();
            
            try
            {
                if (session == null)
                    return ServiceResult<IList<Proizvodjac>>.Failure("Nema konekcije sa bazom.");

                // Povuci samo proizvođače vezane za salon novih vozila
                var salonNova = session.Query<SalonNova>().FirstOrDefault(s => s.ID == salonId);
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
                session?.Close();
            }
        }

        public ServiceResult<IList<Proizvodjac>> GetSviProizvodjaci()
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                    return ServiceResult<IList<Proizvodjac>>.Failure("Nema konekcije sa bazom.");

                var proizvodjaci = session.Query<Proizvodjac>().ToList();
                return ServiceResult<IList<Proizvodjac>>.Success(proizvodjaci);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<Proizvodjac>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
