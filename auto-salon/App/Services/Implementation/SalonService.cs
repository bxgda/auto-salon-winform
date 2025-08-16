using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;
using NHibernate.Util;
using static System.Windows.Forms.AxHost;

namespace auto_salon.App.Services.Implementation
{
    public class SalonService : ISalonService
    {
        private readonly IDataLayer _dataLayer;

        public SalonService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(SalonDTO salonDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Kreiraj domenski entitet
                Salon salonEntity = salonDto.CreateNewEntity();

                session.SaveOrUpdate(salonEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri kreiranju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> AddSaloniToNudi(int proizvodjacId, IList<int> salonIds)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");

                Proizvodjac proizvodjac = session.Load<Proizvodjac>(proizvodjacId);

                if (proizvodjac == null)
                    return ServiceResult<bool>.Failure("Proizvodjac ne postoji.");

                // Dodaj salone u promotivnu ponudu
                foreach (var salonId in salonIds)
                {
                    SalonNova salon = session.Load<SalonNova>(salonId);
                    if (salon == null)
                        return ServiceResult<bool>.Failure($"Salon sa ID {salonId} ne postoji.");

                    // Proveri da li salon već postoji u promotivnoj ponudi
                    if (salon.Proizvodjaci.Any(p => p.ID == proizvodjacId))
                        continue; // Salon je već dodat u ovu ponudu

                    // Dodaj salon u promotivnu ponudu
                    proizvodjac.Saloni.Add(salon);
                }

                session.SaveOrUpdate(proizvodjac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri dodavanju salona u ponudu: {ex.Message}");
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

                Salon salon = session.Load<Salon>(id);

                session.Delete(salon);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonDTO>> GetAll()
        {
            var session = _dataLayer.OpenSession();
            IList<SalonDTO> result = new List<SalonDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<SalonDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Salon> sviSaloni = session.Query<Salon>();
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
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonComboboxDTO>> GetAllByStanjeVozila(string stanje)
        {
            var session = _dataLayer.OpenSession();

            IList<SalonComboboxDTO> result = new List<SalonComboboxDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<SalonComboboxDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Salon> sviSaloni = session.Query<Salon>();

                if (stanje == "Novo")
                {
                    // Izdvoj samo salone koji su tipa SalonNova ili SalonKombinovan
                    result = sviSaloni
                        .Where(s => s is SalonNova || s is SalonKombinovan)
                        .Select(s => new SalonComboboxDTO
                        {
                            ID = s.ID,
                            Naziv = s.Naziv
                        })
                        .ToList();
                }
                else if (stanje == "Polovno")
                {
                    // Izdvoj samo salone koji su tipa SalonPolovna ili SalonKombinovan
                    result = sviSaloni
                        .Where(s => s is SalonPolovna || s is SalonKombinovan)
                        .Select(s => new SalonComboboxDTO
                        {
                            ID = s.ID,
                            Naziv = s.Naziv
                        })
                        .ToList();
                }

                return ServiceResult<IList<SalonComboboxDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonComboboxDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonComboboxDTO>> GetAllForCombobox()
        {
            var session = _dataLayer.OpenSession();

            IList<SalonComboboxDTO> result = new List<SalonComboboxDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<SalonComboboxDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }

                IEnumerable<Salon> sviSaloni = session.Query<Salon>();
                foreach (var salon in sviSaloni)
                {
                    result.Add(salon.ToSalonComboboxDTO());
                }

                return ServiceResult<IList<SalonComboboxDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonComboboxDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonDTO>> GetSaloniInNudi(int proizvodjacId)
        {
            var session = _dataLayer.OpenSession();
            IList<SalonDTO> result = new List<SalonDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<SalonDTO>>.Failure("Nema konekcije sa bazom podataka.");

                Proizvodjac proizvodjac = session.Load<Proizvodjac>(proizvodjacId);

                if (proizvodjac == null)
                    return ServiceResult<IList<SalonDTO>>.Failure("Proizvodjac sa datim ID-jem ne postoji.");

                IEnumerable<SalonNova> saloni = session.Query<SalonNova>()
                    .Where(s => !s.Proizvodjaci.Any(p => p.ID == proizvodjacId));

                foreach (var salon in saloni)
                    result.Add(salon.ToSalonDTO());

                return ServiceResult<IList<SalonDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<SalonDTO>>.Failure($"Greška pri dohvatanju salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ZaposleniDTO>> GetZaposleniSalona(int salonId)
        {
            var session = _dataLayer.OpenSession();
            
            IList<ZaposleniDTO> result = new List<ZaposleniDTO>();

            try
            {
                if (session == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Nema konekcije sa bazom podataka.");
                }
            
                Salon salon = session.Load<Salon>(salonId);
                if (salon == null)
                {
                    return ServiceResult<IList<ZaposleniDTO>>.Failure("Salon sa datim ID-jem ne postoji.");
                }
                
                foreach (var zaposleni in salon.Zaposleni)
                {
                    result.Add(zaposleni.ToZaposleniDTO());
                }
                
                return ServiceResult<IList<ZaposleniDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ZaposleniDTO>>.Failure($"Greška pri dohvatanju zaposlenih salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(SalonDTO salonDto)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                {
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");
                }

                if (salonDto == null)
                {
                    return ServiceResult<bool>.Failure("Salon ne može biti null.");
                }

                // Pribavi domenski entitet
                Salon oldSalon = session.Load<Salon>(salonDto.ID);
                
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

                session.Update(oldSalon);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izmeni salona: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}