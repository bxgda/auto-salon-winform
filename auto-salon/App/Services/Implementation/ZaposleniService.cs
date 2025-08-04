using auto_salon.App.DTOs;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;
using NHibernate;

namespace auto_salon.App.Services.Implementation
{
    internal class ZaposleniService : IZaposleniService
    {
        private ISession? _session;

        public ServiceResult<IList<ZaposleniTableDTO>> GetAll()
        {
            try
            {
                _session = DataLayer.GetSession();

                if (_session == null)
                {
                    return ServiceResult<IList<ZaposleniTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                var zaposleni = _session.Query<Zaposleni>().ToList();
                var result = zaposleni.Select(z => z.ToZaposleniTableDTO()).ToList();

                return ServiceResult<IList<ZaposleniTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ZaposleniTableDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
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

        public ServiceResult<Boolean> Add(ZaposleniTableDTO zaposleniDto)
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

                // Prebaci u domenski entitet
                Zaposleni zaposleniEntity = zaposleniDto.ZaposleniTableToEntity();

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
    }
}
