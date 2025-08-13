using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Services.Implementation
{

    public class VoziloService : IVoziloService
    {
        private readonly IDataLayer _dataLayer;

        public VoziloService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(VoziloTableDTO voziloTableDTO, int salonId, int proizvodjacId)
        {
            var session = _dataLayer.OpenSession();
            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Salon salon = session.Load<Salon>(salonId);
                if (salon == null)
                {
                    return ServiceResult<bool>.Failure("Salon u koji želite da dodate nova vozila ne postoji.");
                }

                Proizvodjac proizvodjac = session.Load<Proizvodjac>(proizvodjacId);
                if (salon == null)
                {
                    return ServiceResult<bool>.Failure("Proizvodjac ne postoji.");
                }

                Vozilo voziloEntity = voziloTableDTO.CreateNewEntity(salon, proizvodjac);

                session.SaveOrUpdate(voziloEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Delete(string brSasije)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                Vozilo vozilo = session.Load<Vozilo>(brSasije);

                session.Delete(vozilo);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> svaVozila = session.Query<Vozilo>();
                foreach (var vozilo in svaVozila)
                {
                    result.Add(vozilo.ToVoziloTableDTO());
                }

                return ServiceResult<IList<VoziloTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<VoziloTableDTO>>.Failure($"Greška pri dohvatanju zaposlenih: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<VoziloTableDTO>> GetBySalonId(int salonId)
        {
            var session = _dataLayer.OpenSession();
            IList<VoziloTableDTO> result = new List<VoziloTableDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<VoziloTableDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Vozilo> vozila = session.Query<Vozilo>().Where(v => v.Salon.ID == salonId);
                foreach (var v in vozila)
                {
                    result.Add(v.ToVoziloTableDTO());
                }

                return ServiceResult<IList<VoziloTableDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<VoziloTableDTO>>.Failure($"Greška pri pribavljanju vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(VoziloTableDTO vozilo, int newSalonId)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                // Pribavi domenski entitet
                Vozilo oldVozilo;

                if (vozilo.Stanje == "Novo")
                {
                    oldVozilo = session.Load<NovoVozilo>(vozilo.BrojSasije);
                }
                else
                {
                    oldVozilo = session.Load<PolovnoVozilo>(vozilo.BrojSasije);
                }

                if (oldVozilo == null)
                {
                    return ServiceResult<bool>.Failure("Vozilo ne postoji.");
                }

                // Azuriraj basic property-e
                oldVozilo.Cena = vozilo.Cena;
                oldVozilo.BrojVrata = vozilo.BrojVrata;
                oldVozilo.Boja = vozilo.Boja;
                oldVozilo.GodinaProizvodnje = vozilo.GodinaProizvodnje;
                oldVozilo.Kilometraza = vozilo.Kilometraza;
                oldVozilo.Model = vozilo.Model;
                oldVozilo.SnagaMotora = vozilo.SnagaMotora;
                oldVozilo.TipGoriva = vozilo.TipGoriva;
                
                if (oldVozilo is PolovnoVozilo polovnoVozilo)
                {
                    polovnoVozilo.BrojVlasnika = vozilo.BrojVlasnika;
                    polovnoVozilo.DatumRegistracije = vozilo.DatumRegistracije ?? DateTime.Now;
                }

                // Proveri da li je salon promenjen
                if (oldVozilo.Salon.ID != newSalonId)
                {
                    Salon newSalon = session.Load<Salon>(newSalonId);
                    if (newSalon == null)
                    {
                        return ServiceResult<bool>.Failure("Salon u koji želite da prebacite vozilo ne postoji.");
                    }

                    // Ako se prebacuje u novi salon pitaj da li taj salon nudi vozila tog proizvodjaca
                    if (newSalon is SalonNova newNoviSalon)
                    {
                        if (newNoviSalon.Proizvodjaci.All(p => p.ID != oldVozilo.Proizvodjac.ID))
                        {
                            return ServiceResult<bool>.Failure("Novi salon ne nudi vozila ovog proizvodjaca.");
                        }
                    }

                    // Zakaci novi salon za domenski entitet (Inverse je u vozilu znaci on mora da vodi racuna o vezi)
                    oldVozilo.Salon = newSalon;
                }

                session.SaveOrUpdate(oldVozilo);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni vozila: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
