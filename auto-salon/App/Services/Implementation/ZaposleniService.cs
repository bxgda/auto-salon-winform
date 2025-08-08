using auto_salon.App.DTOs;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{
    public class ZaposleniService : IZaposleniService
    {
        private readonly IDataLayer _dataLayer;

        public ZaposleniService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<IList<ZaposleniDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Zaposleni> sviZaposleni = session.Query<Zaposleni>();
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
                session?.Close();
            }
        }

        public ServiceResult<Boolean> Delete(string jmbg)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Zaposleni zaposleni = session.Load<Zaposleni>(jmbg);
                zaposleni.Salon.BrojZaposlenih--;

                session.Delete(zaposleni);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju zaposlenog: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<Boolean> Add(ZaposleniDTO zaposleniDto, int salondId)
        {
            var session = _dataLayer.OpenSession();
            
            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                // Pribavi domenski entitet salona
                Salon salon = session.Load<Salon>(salondId);
                if (salon == null)
                {
                    return ServiceResult<bool>.Failure("Salon u koji želite da dodate novog zaposlenog ne postoji.");
                }

                // Kreiraj domenski entitet i zakaci salon (u extension metodi se salon dodeli i to je dovoljno)
                Zaposleni zaposleniEntity = zaposleniDto.CreateNewEntity(salon);

                // Ako je odmah dobio ulogu mendzera odma mu se postavlja datum postavljenja na isti datum kada je zaposlen
                if (zaposleniEntity.Uloga == Uloga.MENADZER)
                {
                    zaposleniEntity.DatumPostavljenja = zaposleniEntity.DatumZaposlenja;
                }

                salon.BrojZaposlenih++;

                session.SaveOrUpdate(zaposleniEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju zaposlenog: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ZaposleniDTO>> GetBySalonId(int salonId)
        {
            var session = _dataLayer.OpenSession();
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                IEnumerable<Zaposleni> zaposleni = session.Query<Zaposleni>().Where(z => z.Salon.ID == salonId);
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
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(ZaposleniDTO zaposleniDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                // Pribavi domenski entitet zaposlenog
                Zaposleni zaposleni = session.Load<Zaposleni>(zaposleniDto.JMBG);
                if (zaposleni == null)
                {
                    return ServiceResult<bool>.Failure("Zaposleni kojeg želite da izmenite ne postoji.");
                }

                // Ažuriraj podatke zaposlenog
                zaposleni.JMBG = zaposleniDto.JMBG;
                zaposleni.Ime = zaposleniDto.Ime;
                zaposleni.Prezime = zaposleniDto.Prezime;
                zaposleni.KontaktTelefon = zaposleniDto.KontaktTelefon;
                zaposleni.Email = zaposleniDto.Email;
                zaposleni.Adresa = zaposleniDto.Adresa;
                zaposleni.DatumZaposlenja = zaposleniDto.DatumZaposlenja;
                zaposleni.Pozicija = zaposleniDto.Pozicija;
                zaposleni.Uloga = zaposleniDto.Uloga;

                // Ako je promenjena uloga na menadžera, postavi datum postavljenja
                if (zaposleniDto.Uloga == Uloga.MENADZER)
                {
                    zaposleni.DatumPostavljenja = DateTime.Now;
                }
                else if (zaposleniDto.Uloga != Uloga.MENADZER)
                {
                    zaposleni.DatumPostavljenja = default; // Resetuj datum postavljenja ako nije menadzer
                }

                session.SaveOrUpdate(zaposleni);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju zaposlenog: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ZaposleniDTO>> GetAllProdavciKojiMoguDaProdajuVozilo(string brojSasije)
        {
            var session = _dataLayer.OpenSession();
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                // Ovo bi trebalo da vrati prodavce koji rade u salonima koji imaju vozilo sa datim brojem šasije
                // jer prodavac moze da proda samo vozilo iz salona u kojem radi
                IEnumerable<Zaposleni> prodavci = session.Query<Zaposleni>()
                    .Where(z => z.Uloga == Uloga.PRODAVAC)
                    .Where(z => z.Salon.Vozila.Any(v => v.BrojSasije == brojSasije));

                foreach (var prodavac in prodavci)
                {
                    result.Add(prodavac.ToZaposleniDTO());
                }

                return ServiceResult<IList<ZaposleniDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ZaposleniDTO>>.Failure($"Greška pri pribavljanju zaposlenih: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
