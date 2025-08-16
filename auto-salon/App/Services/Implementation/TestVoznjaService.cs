using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using NHibernate.Linq;

namespace auto_salon.App.Services.Implementation
{
    public class TestVoznjaService : ITestVoznjaService
    {
        private readonly IDataLayer _dataLayer;

        public TestVoznjaService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(TestVoznjaCreateDTO testVoznjaDto)
        {
            using var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }

                // Pribavi domenski entitet vozila
                Vozilo vozilo = session.Load<Vozilo>(testVoznjaDto.BrojSasije);

                // Pribavi zaposlenog
                Zaposleni zaposleni = session.Load<Zaposleni>(testVoznjaDto.JmbgZaposlenog);

                // Pribavi kupca
                Kupac kupac;
                if (!string.IsNullOrEmpty(testVoznjaDto.JmbgFizickogKupca))
                {
                    kupac = session.Load<FizickoLice>(testVoznjaDto.JmbgFizickogKupca).Kupac!;
                }
                else if (!string.IsNullOrEmpty(testVoznjaDto.PIBPravnogKupca))
                {
                    kupac = session.Load<PravnoLice>(testVoznjaDto.PIBPravnogKupca).Kupac!;
                }
                else
                {
                    return ServiceResult<bool>.Failure("Kupac nije naveden.");
                }

                // Kreiraj novu test vožnju
                TestVoznja testVoznja = new TestVoznja
                {
                    Datum = testVoznjaDto.Datum,
                    Vreme = testVoznjaDto.Vreme,
                    Ocena = testVoznjaDto.Ocena,
                    Zakljucak = testVoznjaDto.Zakljucak,
                    Vozilo = vozilo,
                    Zaposleni = zaposleni,
                    Kupac = kupac
                };

                session.SaveOrUpdate(testVoznja);
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

        public ServiceResult<IList<TestVoznjaTableDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();

            IList<TestVoznjaTableDTO> result = new List<TestVoznjaTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<TestVoznjaTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<TestVoznja> sveTestVoznje = session.Query<TestVoznja>();
                foreach (var testVoznja in sveTestVoznje)
                {
                    result.Add(testVoznja.ToTestVoznjaTableDTO());
                }

                return ServiceResult<IList<TestVoznjaTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<TestVoznjaTableDTO>>.Failure($"Greška pri dohvatanju test vožnji: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<TestVoznjaDetailsDTO> GetDetails(int id)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<TestVoznjaDetailsDTO>.Failure("Nema konekcije sa bazom podataka.");
                }

                var testVoznja = session.Query<TestVoznja>()
                    .Fetch(x => x.Vozilo)
                    .Fetch(x => x.Zaposleni)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.FizickoLice)
                    .Fetch(x => x.Kupac)
                    .ThenFetch(k => k.PravnoLice)
                    .FirstOrDefault(x => x.ID == id);

                if (testVoznja == null)
                    return ServiceResult<TestVoznjaDetailsDTO>.Failure("Test vožnja nije pronađen.");

                // Mapiranje u novi DTO
                var result = testVoznja.ToTestVoznjaDetailsDTO();

                return ServiceResult<TestVoznjaDetailsDTO>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<TestVoznjaDetailsDTO>.Failure($"Greška pri dohvatanju detalja test vožnje: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
