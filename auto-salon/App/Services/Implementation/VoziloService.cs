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
            // TODO: Implementacija dodavanja vozila
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
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> svaVozila = _session.Query<Vozilo>();
                foreach (var vozilo in svaVozila)
                {
                    result.Add(vozilo.ToVoziloTableDTO());
                }

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

        public ServiceResult<IList<VoziloTableDTO>> GetBySalonId(int salonId)
        {
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> vozila = _session.Query<Vozilo>().Where(v => v.Salon.ID == salonId);
                foreach (var v in vozila)
                {
                    result.Add(v.ToVoziloTableDTO());
                }

                return ServiceResult<IList<VoziloTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<VoziloTableDTO>>.Failure($"Greška pri pribavljanju vozila: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}
