using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class PromotivnaPonudaService : IPromotivnaPonudaService
    {
        private readonly IDataLayer _dataLayer;

        public PromotivnaPonudaService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
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
    }
}
