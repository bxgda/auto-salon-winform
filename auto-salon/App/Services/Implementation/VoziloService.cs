using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{

    public class VoziloService : IVoziloService
    {
        private readonly IDataLayer _dataLayer;

        public VoziloService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(VoziloTableDTO vozilo)
        {
            // TODO: Implementacija dodavanja vozila
            throw new NotImplementedException();
        }

        public ServiceResult<bool> Delete(string brSasije)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Vozilo vozilo = session.Load<Vozilo>(brSasije);

                session.Delete(vozilo);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> svaVozila = session.Query<Vozilo>();
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
                session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetBySalonId(int salonId)
        {
            var session = _dataLayer.OpenSession();
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> vozila = session.Query<Vozilo>().Where(v => v.Salon.ID == salonId);
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
                session?.Close();
            }
        }
    }
}
