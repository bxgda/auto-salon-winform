using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class ServisnaStavkaService : IServisnaStavkaService
    {
        private readonly IDataLayer _dataLayer;

        public ServisnaStavkaService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> AddServisnaStavkaToVozilo(ServisnaStavkaDTO servisnaStavka, string brojSasije)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }

                // Pribavi domenski entitet vozila na osnovu broja šasije
                PolovnoVozilo vozilo = session.Load<PolovnoVozilo>(brojSasije);
                if (vozilo == null)
                {
                    return ServiceResult<bool>.Failure("Vozilo kojem želite da dodate servisnu stavku ne postoji.");
                }

                // Kreiraj novu servisnu stavku
                ServisnaStavka novaStavka = servisnaStavka.CreateNewEntity(vozilo);

                session.SaveOrUpdate(novaStavka);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri pribavljanju servisne istorije: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ServisnaStavkaDTO>> GetAllByBrojSasije(string brojSasije)
        {
            var session = _dataLayer.OpenSession();

            IList<ServisnaStavkaDTO> result = new List<ServisnaStavkaDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<ServisnaStavkaDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<ServisnaStavka> servisnaIstorijaVozila = session.Query<ServisnaStavka>().Where(s => s.Vozilo.BrojSasije == brojSasije);
                if (servisnaIstorijaVozila == null || !servisnaIstorijaVozila.Any())
                {
                    return ServiceResult<IList<ServisnaStavkaDTO>>.Failure("Nema servisnih stavki za navedeni broj šasije.");
                }

                foreach (var stavka in servisnaIstorijaVozila)
                {
                    result.Add(stavka.ToServisnaStavkaDTO());
                }

                return ServiceResult<IList<ServisnaStavkaDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ServisnaStavkaDTO>>.Failure($"Greška pri pribavljanju servisne istorije: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
