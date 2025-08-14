using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class JeOcenioService : IJeOcenioService
    {
        private readonly IDataLayer _dataLayer;

        public JeOcenioService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<JeOcenioDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();

            IList<JeOcenioDTO> result = new List<JeOcenioDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<JeOcenioDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<JeOcenio> sveOcene = session.Query<JeOcenio>();
                foreach (var ocena in sveOcene)
                {
                    result.Add(ocena.ToJeOcenioDTO());
                }

                return ServiceResult<IList<JeOcenioDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<JeOcenioDTO>>.Failure($"Greška pri pribavljanju ocena: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
