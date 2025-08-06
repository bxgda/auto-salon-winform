using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{
    public class UgovoriService : IUgovoriService
    {
        private ISession? _session;

        public ServiceResult<IList<UgovorTableDTO>> GetAll()
        {
            IList<UgovorTableDTO> result = new List<UgovorTableDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<UgovorTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<KupoprodajniUgovor> sviUgovori = _session.Query<KupoprodajniUgovor>();
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
                _session?.Close();
            }
        }

        public ServiceResult<bool> Delete(int id)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                KupoprodajniUgovor ugovor = _session.Load<KupoprodajniUgovor>(id);

                _session.Delete(ugovor);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju ugovora: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}
