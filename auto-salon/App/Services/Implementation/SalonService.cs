using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{
    public class SalonService : ISalonService
    {
        private ISession? _session;

        public ServiceResult<bool> Add(SalonDTO salonDto)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Kreiraj domenski entitet
                Salon salonEntity = salonDto.CreateNewEntity();

                _session.SaveOrUpdate(salonEntity);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju salona: {ex.Message}");
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

                Salon salon = _session.Load<Salon>(id);

                _session.Delete(salon);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju salona: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<IList<SalonDTO>> GetAll()
        {
            IList<SalonDTO> result = new List<SalonDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<SalonDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Salon> sviSaloni = _session.Query<Salon>();
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
                _session?.Close();
            }
        }

        public ServiceResult<bool> Update(SalonDTO salonDto)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Pribavi domenski entitet
                Salon oldSalon = _session.Load<Salon>(salonDto.ID);
                
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

                _session.Update(oldSalon);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni salona: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}