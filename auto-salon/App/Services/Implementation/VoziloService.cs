using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{

    public class VoziloService : IVoziloService
    {
        private ISession? _session;

        public ServiceResult<bool> Add(VoziloTableDTO vozilo)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<bool> Delete(string brSasije)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Vozilo vozilo = _session.Load<Vozilo>(brSasije);

                _session.Delete(vozilo);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju vozila: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetAll()
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                var vozila = _session.Query<Vozilo>().ToList();
                var result = vozila.Select(v => v.ToVoziloTableDTO()).ToList();

                return ServiceResult<IList<VoziloTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<VoziloTableDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}
