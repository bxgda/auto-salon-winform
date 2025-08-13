using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{
    public class PromotivnaPonudaService : IPromotivnaPonudaService
    {
        private readonly IDataLayer _dataLayer;

        public PromotivnaPonudaService(IDataLayer dataLayer)
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
                
                var promotivnaPonuda = session.Load<PromotivnaPonuda>(id);
                if (promotivnaPonuda == null)
                {
                    return ServiceResult<bool>.Failure("Promotivna ponuda sa datim ID-jem ne postoji.");
                }

                // Ovo brise promotivne ponude i sve instance u tabeli JE_DEO
                session.Delete(promotivnaPonuda);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri dohvatanju promotivnih ponuda: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<PromotivnaPonudaDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<PromotivnaPonudaDTO> result = new List<PromotivnaPonudaDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<PromotivnaPonudaDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<PromotivnaPonuda> svePromotivnePonude = session.Query<PromotivnaPonuda>();
                foreach (var ponuda in svePromotivnePonude)
                {
                    result.Add(ponuda.ToPromotivnaPonudaDTO());
                }

                return ServiceResult<IList<PromotivnaPonudaDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<PromotivnaPonudaDTO>>.Failure($"Greška pri dohvatanju promotivnih ponuda: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetVozilaPromotivnePonude(int idPonude)
        {
            var session = _dataLayer.OpenSession();

            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> vozilaPonude = session.Query<PromotivnaPonuda>()
                    .Where(p => p.ID == idPonude)
                    .SelectMany(p => p.Vozila);

                foreach (var vozilo in vozilaPonude)
                {
                    result.Add(vozilo.ToVoziloTableDTO());
                }

                return ServiceResult<IList<VoziloTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<VoziloTableDTO>>.Failure($"Greška pri dohvatanju vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
