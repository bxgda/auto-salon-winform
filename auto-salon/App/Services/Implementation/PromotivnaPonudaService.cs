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

        public ServiceResult<bool> Add(PromotivnaPonudaDTO promotivnaPonudaDTO)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (promotivnaPonudaDTO == null)
                {
                    return ServiceResult<bool>.Failure("Promotivna ponuda ne može biti null.");
                }

                // Kreiraj domenski entitet
                PromotivnaPonuda ponudaEntity = promotivnaPonudaDTO.CreateNewEntity();

                session.SaveOrUpdate(ponudaEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju promotivne ponude: {ex.Message}");
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
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");

                IEnumerable<Vozilo> vozilaPonude = session.Query<PromotivnaPonuda>()
                    .Where(p => p.ID == idPonude)
                    .SelectMany(p => p.Vozila);

                foreach (var vozilo in vozilaPonude)
                    result.Add(vozilo.ToVoziloTableDTO());

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

        public ServiceResult<bool> RemoveVoziloFromPromotivnaPonuda(int idPromotivnePonude, string brojSasije)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                var promotivnaPonuda = session.Load<PromotivnaPonuda>(idPromotivnePonude);
                if (promotivnaPonuda == null)
                {
                    return ServiceResult<bool>.Failure("Promotivna ponuda sa datim ID-jem ne postoji.");
                }

                var vozilo = session.Load<Vozilo>(brojSasije);
                if (vozilo == null)
                {
                    return ServiceResult<bool>.Failure("Vozilo sa datim brojem šasije ne postoji.");
                }

                if (!promotivnaPonuda.Vozila.Contains(vozilo))
                {
                    return ServiceResult<bool>.Failure("Vozilo nije deo ove promotivne ponude.");
                }

                promotivnaPonuda.Vozila.Remove(vozilo);
                session.SaveOrUpdate(promotivnaPonuda);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izbacivanju vozila iz promotivne ponude: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(PromotivnaPonudaDTO promotivnaPonudaDTO)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (promotivnaPonudaDTO == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Pribavi domenski entitet
                PromotivnaPonuda oldPonuda = session.Load<PromotivnaPonuda>(promotivnaPonudaDTO.ID);

                if (oldPonuda == null)
                {
                    return ServiceResult<bool>.Failure("Promotivna ponuda sa datim ID-jem ne postoji.");
                }

                // Azuriraj property-e
                oldPonuda.NazivPromocije = promotivnaPonudaDTO.NazivPromocije;
                oldPonuda.DatumOd = promotivnaPonudaDTO.DatumOd;
                oldPonuda.DatumDo = promotivnaPonudaDTO.DatumDo;
                oldPonuda.PopustUProcentima = promotivnaPonudaDTO.PopustUProcentima;
                oldPonuda.Uslovi = promotivnaPonudaDTO.Uslovi;

                session.Update(oldPonuda);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni promotivnih ponuda: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
