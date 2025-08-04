using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.Entities;
using NHibernate;

namespace auto_salon.App.Services
{
    public class SalonService : ISalonService
    {
        private ISession? _session;

        public ServiceResult<bool> Add(SalonTableDTO salonDto)
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

                // Prebaci u domenski entitet
                Salon salonEntity = salonDto.SalonTableToEntity();

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

        public ServiceResult<IList<SalonTableDTO>> GetAll()
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<SalonTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                var saloni = _session.Query<Salon>().ToList();
                var result = saloni.Select(salon => salon.ToSalonTableDTO()).ToList();

                return ServiceResult<IList<SalonTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonTableDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<bool> Update(SalonTableDTO salonDto)
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

                Salon oldSalon = _session.Load<Salon>(salonDto.ID);
                
                if (oldSalon == null)
                {
                    return ServiceResult<bool>.Failure("Salon sa datim ID-jem ne postoji.");
                }

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