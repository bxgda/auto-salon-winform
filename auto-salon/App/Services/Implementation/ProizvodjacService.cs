using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
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

        public ServiceResult<IList<ProizvodjacDTO>> GetProizvodjaciZaSalonNova(int salonId)
        {
            var session = _dataLayer.OpenSession();
            
            IList<ProizvodjacDTO> result = new List<ProizvodjacDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema konekcije sa bazom.");

                // Povuci samo proizvodjace koji nude u salon sa ID salonId
                IEnumerable<Proizvodjac> proizvodjaci = session.Query<Proizvodjac>()
                    .Where(p => p.Saloni.Any(s => s.ID == salonId));

                foreach (var proizvodjac in proizvodjaci)
                {
                    result.Add(proizvodjac.ToProizvodjacDTO());
                }

                if (result.Count == 0)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema pronađenih proizvodjača za dati salon.");

                return ServiceResult<IList<ProizvodjacDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ProizvodjacDTO>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ProizvodjacDTO>> GetSviProizvodjaci()
        {
            var session = _dataLayer.OpenSession();

            IList<ProizvodjacDTO> result = new List<ProizvodjacDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema konekcije sa bazom.");

                IEnumerable<Proizvodjac> sviProizvodjaci = session.Query<Proizvodjac>();
                foreach (var proizvodjac in sviProizvodjaci)
                {
                    result.Add(proizvodjac.ToProizvodjacDTO());
                }

                return ServiceResult<IList<ProizvodjacDTO>>.Success(result);

            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ProizvodjacDTO>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
