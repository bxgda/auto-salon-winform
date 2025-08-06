using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using NHibernate.Linq;

namespace auto_salon.App.Services.Implementation
{
    public class UgovoriService : IUgovoriService
    {
        private readonly IDataLayer _dataLayer;

        public UgovoriService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<UgovorTableDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<UgovorTableDTO> result = new List<UgovorTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<UgovorTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<KupoprodajniUgovor> sviUgovori = session.Query<KupoprodajniUgovor>();
                foreach (var ugovor in sviUgovori)
                {
                    result.Add(ugovor.ToUgovorTableDTO());
                }

                return ServiceResult<IList<UgovorTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<UgovorTableDTO>>.Failure($"Greška pri dohvatanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Delete(int id)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                KupoprodajniUgovor ugovor = session.Load<KupoprodajniUgovor>(id);

                session.Delete(ugovor);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<UgovorDetailsDTO> GetDetails(int id)
        {
            using var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<UgovorDetailsDTO>.Failure("Nema konekcije sa bazom podataka.");
                }

                var ugovor = session.Query<KupoprodajniUgovor>()
                    .Fetch(x => x.Vozilo)
                    .Fetch(x => x.Prodavac)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.FizickoLice)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.PravnoLice)
                    .FirstOrDefault(x => x.ID == id);

                if (ugovor == null)
                {
                    return ServiceResult<UgovorDetailsDTO>.Failure("Ugovor nije pronađen.");
                }

                // Mapiranje u novi DTO
                var result = ugovor.ToUgovorDetailsDTO();

                return ServiceResult<UgovorDetailsDTO>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<UgovorDetailsDTO>.Failure($"Greška pri dohvatanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

    }
}
