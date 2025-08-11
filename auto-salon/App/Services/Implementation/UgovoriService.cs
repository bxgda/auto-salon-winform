using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using NHibernate.Linq;

namespace auto_salon.App.Services.Implementation
{
    public class UgovoriService : IUgovoriService
    {
        private readonly IDataLayer _dataLayer;

        public UgovoriService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<UgovorTableDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<UgovorTableDTO> result = new List<UgovorTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<UgovorTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<KupoprodajniUgovor> sviUgovori = session.Query<KupoprodajniUgovor>();
                foreach (var ugovor in sviUgovori)
                {
                    result.Add(ugovor.ToUgovorTableDTO());
                }

                return ServiceResult<IList<UgovorTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<UgovorTableDTO>>.Failure($"Greška pri dohvatanju ugovora: {ex.Message}");
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

                KupoprodajniUgovor ugovor = session.Load<KupoprodajniUgovor>(id);

                session.Delete(ugovor);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<UgovorDetailsDTO> GetDetails(int id)
        {
            using var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<UgovorDetailsDTO>.Failure("Nema konekcije sa bazom podataka.");
                }

                var ugovor = session.Query<KupoprodajniUgovor>()
                    .Fetch(x => x.Vozilo)
                    .Fetch(x => x.Prodavac)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.FizickoLice)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.PravnoLice)
                    .FirstOrDefault(x => x.ID == id);

                if (ugovor == null)
                {
                    return ServiceResult<UgovorDetailsDTO>.Failure("Ugovor nije pronađen.");
                }

                // Mapiranje u novi DTO
                var result = ugovor.ToUgovorDetailsDTO();

                return ServiceResult<UgovorDetailsDTO>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<UgovorDetailsDTO>.Failure($"Greška pri dohvatanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Create(UgovorCreateDTO ugovorDto)
        {
            using var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }

                // Pribavi domenski entitet vozila
                Vozilo vozilo = session.Load<Vozilo>(ugovorDto.BrojSasije);

                // Pribavi prodavca
                Zaposleni prodavac = session.Load<Zaposleni>(ugovorDto.JmbgProdavca);

                // Pribavi kupca
                Kupac kupac;
                if (!string.IsNullOrEmpty(ugovorDto.JmbgFizickogKupca))
                {
                    kupac = session.Load<FizickoLice>(ugovorDto.JmbgFizickogKupca).Kupac!;
                }
                else if (!string.IsNullOrEmpty(ugovorDto.PIBPravnogKupca))
                {
                    kupac = session.Load<PravnoLice>(ugovorDto.PIBPravnogKupca).Kupac!;
                }
                else
                {
                    return ServiceResult<bool>.Failure("Kupac nije naveden.");
                }

                // Kreiraj novi ugovor
                KupoprodajniUgovor noviUgovor = new KupoprodajniUgovor
                {
                    NacinPlacanja = ugovorDto.NacinPlacanja,
                    DodatnaOprema = ugovorDto.DodatnaOprema,
                    KonacnaOcena = ugovorDto.KonacnaOcena,
                    OcenaProdavca = ugovorDto.OcenaProdavca,
                    Vozilo = vozilo,
                    Prodavac = prodavac,
                    Kupac = kupac
                };

                // Sačuvaj novi ugovor u bazi
                session.Save(noviUgovor);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri dohvatanju ugovora: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
