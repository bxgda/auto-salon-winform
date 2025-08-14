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

        public ServiceResult<bool> Delete(int id)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }
                
                // Pribavi domenski entitet
                var ocena = session.Get<JeOcenio>(id);
                if (ocena == null)
                {
                    return ServiceResult<bool>.Failure("Ocena sa datim ID-jem ne postoji.");
                }
                
                session.Delete(ocena);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju ocene: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
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
