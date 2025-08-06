using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class SalonService : ISalonService
    {
        private readonly IDataLayer _dataLayer;

        public SalonService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(SalonDTO salonDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Kreiraj domenski entitet
                Salon salonEntity = salonDto.CreateNewEntity();

                session.SaveOrUpdate(salonEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju salona: {ex.Message}");
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

                Salon salon = session.Load<Salon>(id);

                session.Delete(salon);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<SalonDTO> result = new List<SalonDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<SalonDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Salon> sviSaloni = session.Query<Salon>();
                foreach (var salon in sviSaloni)
                {
                    result.Add(salon.ToSalonDTO());
                }

                return ServiceResult<IList<SalonDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(SalonDTO salonDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Pribavi domenski entitet
                Salon oldSalon = session.Load<Salon>(salonDto.ID);
                
                if (oldSalon == null)
                {
                    return ServiceResult<bool>.Failure("Salon sa datim ID-jem ne postoji.");
                }

                // Azuriraj property-e
                oldSalon.Naziv = salonDto.Naziv;
                oldSalon.Adresa = salonDto.Adresa;
                oldSalon.Drzava = salonDto.Drzava;
                oldSalon.KontaktTelefon = salonDto.KontaktTelefon;
                oldSalon.Grad= salonDto.Grad;
                oldSalon.RadnoVreme = salonDto.RadnoVreme;

                session.Update(oldSalon);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}