using auto_salon.App.DTOs;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{
    internal class ZaposleniService : IZaposleniService
    {
        private ISession? _session;

        public ServiceResult<IList<ZaposleniDTO>> GetAll()
        {
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Zaposleni> sviZaposleni = _session.Query<Zaposleni>();
                foreach (var zaposleni in sviZaposleni)
                {
                    result.Add(zaposleni.ToZaposleniDTO());
                }

                return ServiceResult<IList<ZaposleniDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ZaposleniDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<Boolean> Delete(string jmbg)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Zaposleni zaposleni = _session.Load<Zaposleni>(jmbg);

                _session.Delete(zaposleni);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju zaposlenog: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<Boolean> Add(ZaposleniDTO zaposleniDto, int salondId)
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (zaposleniDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Pribavi domenski entitet salona
                Salon salon = _session.Load<Salon>(salondId);
                if (salon == null)
                {
                    return ServiceResult<bool>.Failure("Salon u koji želite da dodate novog zaposlenog ne postoji.");
                }

                // Kreiraj domenski entitet i zakaci salon
                Zaposleni zaposleniEntity = zaposleniDto.CreateNewEntity(salon);

                _session.SaveOrUpdate(zaposleniEntity);
                _session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju zaposlenog: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }

        public ServiceResult<IList<ZaposleniDTO>> GetBySalonId(int salonId)
        {
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                IEnumerable<Zaposleni> zaposleni = _session.Query<Zaposleni>().Where(z => z.Salon.ID == salonId);
                foreach (var z in zaposleni)
                {
                    result.Add(z.ToZaposleniDTO());
                }

                return ServiceResult<IList<ZaposleniDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ZaposleniDTO>>.Failure($"Greška pri pribavljanju zaposlenih: {ex.Message}");
            }
            finally
            {
                _session?.Close();
            }
        }
    }
}
