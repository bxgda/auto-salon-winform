using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{
    public class KupacService : IKupacService
    {
        private readonly IDataLayer _dataLayer;

        public KupacService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<KupacDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();

            IList<KupacDTO> result = new List<KupacDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<KupacDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Kupac> sviKupci = session.Query<Kupac>();
                foreach (var kupac in sviKupci)
                {
                    result.Add(kupac.ToKupacDTO());
                }

                return ServiceResult<IList<KupacDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<KupacDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
