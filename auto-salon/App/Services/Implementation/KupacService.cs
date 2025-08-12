using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{
    public class KupacService : IKupacService
    {
        private readonly IDataLayer _dataLayer;

        public KupacService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> AddKupac(KupacDTO kupacDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Nema konekcije sa bazom podataka.");
                }
                    
                // Mora biti ili fizicko lice ili pravno lice (jedno mora da bude null)
                if (kupacDto == null ||
                    (kupacDto.FizickoLice == null && kupacDto.PravnoLice == null) ||
                    ((kupacDto.FizickoLice != null && kupacDto.PravnoLice != null)))
                {
                    return ServiceResult<bool>.Failure("Kupac ne može biti null.");
                }

                // Kreiraj domenski entitet kupac
                Kupac newKupac = kupacDto.CreateNewEntity();

                if (kupacDto.FizickoLice != null)
                {
                    // Kreiraj domenski entitet fizicko lice i zakaci za kupca
                    FizickoLice fizickoLice = kupacDto.FizickoLice.CreateNewEntity();
                    fizickoLice.Kupac = newKupac;
                    newKupac.FizickoLice = fizickoLice;
                }
                else if (kupacDto.PravnoLice != null)
                {
                    // Pravno lice mora da ima zakacenog kupca jer je u entitetu required Kupac
                    PravnoLice pravnoLice = kupacDto.PravnoLice.CreateNewEntity(newKupac);
                    newKupac.PravnoLice = pravnoLice;
                }

                session.SaveOrUpdate(newKupac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri dodavanju zaposlenog: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<KupacDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();

            IList<KupacDTO> result = new List<KupacDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<KupacDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Kupac> sviKupci = session.Query<Kupac>();
                foreach (var kupac in sviKupci)
                {
                    result.Add(kupac.ToKupacDTO());
                }

                return ServiceResult<IList<KupacDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<KupacDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> UpdateKupac(KupacDTO kupacDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (kupacDto == null)
                {
                    return ServiceResult<bool>.Failure("Kupac ne može biti null.");
                }

                // Pribavi domenski entitet
                Kupac oldKupac = session.Get<Kupac>(kupacDto.ID);

                if (oldKupac == null)
                {
                    return ServiceResult<bool>.Failure("Ovaj kupac u bazi ne postoji.");
                }

                // Azuriraj property-e u zavisnosti od tipa kupca
                if (kupacDto.FizickoLice != null)
                {
                    // Azuriraj fizicko lice
                    if (oldKupac.FizickoLice == null)
                    {
                        return ServiceResult<bool>.Failure("Ovaj kupac nije fizicko lice.");
                    }

                    oldKupac.FizickoLice.JMBG = kupacDto.FizickoLice.JMBG;
                    oldKupac.FizickoLice.Ime = kupacDto.FizickoLice.Ime;
                    oldKupac.FizickoLice.Prezime = kupacDto.FizickoLice.Prezime;
                    oldKupac.FizickoLice.Email = kupacDto.FizickoLice.Email;
                    oldKupac.FizickoLice.KontaktTelefon = kupacDto.FizickoLice.KontaktTelefon;
                    oldKupac.FizickoLice.Adresa = kupacDto.FizickoLice.Adresa;
                }
                else if (kupacDto.PravnoLice != null)
                {
                    // Azuriraj pravno lice
                    if (oldKupac.PravnoLice == null)
                    {
                        return ServiceResult<bool>.Failure("Ovaj kupac nije pravno lice.");
                    }
                    
                    oldKupac.PravnoLice.PIB = kupacDto.PravnoLice.PIB;
                    oldKupac.PravnoLice.NazivFirme = kupacDto.PravnoLice.NazivFirme;
                    oldKupac.PravnoLice.Email = kupacDto.PravnoLice.Email;
                    oldKupac.PravnoLice.Telefon = kupacDto.PravnoLice.Telefon;
                    oldKupac.PravnoLice.Sediste = kupacDto.PravnoLice.Sediste;
                    oldKupac.PravnoLice.KontaktOsoba = kupacDto.PravnoLice.KontaktOsoba;
                }
                else
                {
                    return ServiceResult<bool>.Failure("Nije moguće izmeniti ovog kupca.");
                }

                session.SaveOrUpdate(oldKupac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni kupca: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
