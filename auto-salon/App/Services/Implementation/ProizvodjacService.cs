using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Entities;

namespace auto_salon.App.Services.Implementation
{
    public class ProizvodjacService : IProizvodjacService
    {
        private readonly IDataLayer _dataLayer;

        public ProizvodjacService(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public ServiceResult<bool> Add(ProizvodjacDTO proizvodjacDTO)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");

                if (proizvodjacDTO == null)
                    return ServiceResult<bool>.Failure("Proizvodjac ne može biti null.");

                // Kreiraj domenski entitet
                Proizvodjac proizvodjacEntity = proizvodjacDTO.CreateNewEntity();

                session.SaveOrUpdate(proizvodjacEntity);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri dodavanju proizvodjača: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Delete(int proizvodjacId)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");

                var proizvodjac = session.Load<Proizvodjac>(proizvodjacId);

                if (proizvodjac == null)
                    return ServiceResult<bool>.Failure("Proizvodjac sa datim ID ne postoji.");

                session.Delete(proizvodjac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri brisanju proizvodjača: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> DeleteSalonFromProizvodjac(int proizvodjacId, int salonId)
        {
            var session = _dataLayer.OpenSession();

            try
            {
                if (session == null)
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");

                var proizvodjac = session.Load<Proizvodjac>(proizvodjacId);

                if (proizvodjac == null)
                    return ServiceResult<bool>.Failure("Proizvodjac sa datim ID-jem ne postoji.");

                SalonNova salon = session.Load<SalonNova>(salonId);

                if (salon == null)
                    return ServiceResult<bool>.Failure("Salon sa datim ID-jem ne postoji.");

                if (!proizvodjac.Saloni.Contains(salon))
                    return ServiceResult<bool>.Failure("Salon nije deo ove ponude.");

                proizvodjac.Saloni.Remove(salon);
                session.SaveOrUpdate(proizvodjac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri izbacivanju salona iz ponude: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<ProizvodjacDTO>> GetProizvodjaciZaSalonNova(int salonId)
        {
            var session = _dataLayer.OpenSession();
            
            IList<ProizvodjacDTO> result = new List<ProizvodjacDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema konekcije sa bazom.");

                // Povuci samo proizvodjace koji nude u salon sa ID salonId
                IEnumerable<Proizvodjac> proizvodjaci = session.Query<Proizvodjac>()
                    .Where(p => p.Saloni.Any(s => s.ID == salonId));

                foreach (var proizvodjac in proizvodjaci)
                {
                    result.Add(proizvodjac.ToProizvodjacDTO());
                }

                if (result.Count == 0)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema pronađenih proizvodjača za dati salon.");

                return ServiceResult<IList<ProizvodjacDTO>>.Success(result);
            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ProizvodjacDTO>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<IList<SalonDTO>> GetSaloniZaProizvodjaca(int proizvodjacId)
        {
            var session = _dataLayer.OpenSession();

            IList<SalonDTO> result = new List<SalonDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<SalonDTO>>.Failure("Nema konekcije sa bazom.");

                IEnumerable<SalonNova> saloni = session.Query<SalonNova>()
                    .Where(s => s.Proizvodjaci.Any(p => p.ID == proizvodjacId));

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

        public ServiceResult<IList<ProizvodjacDTO>> GetSviProizvodjaci()
        {
            var session = _dataLayer.OpenSession();

            IList<ProizvodjacDTO> result = new List<ProizvodjacDTO>();

            try
            {
                if (session == null)
                    return ServiceResult<IList<ProizvodjacDTO>>.Failure("Nema konekcije sa bazom.");

                IEnumerable<Proizvodjac> sviProizvodjaci = session.Query<Proizvodjac>();
                foreach (var proizvodjac in sviProizvodjaci)
                {
                    result.Add(proizvodjac.ToProizvodjacDTO());
                }

                return ServiceResult<IList<ProizvodjacDTO>>.Success(result);

            }
            catch (Exception ex)
            {
                return ServiceResult<IList<ProizvodjacDTO>>.Failure($"Greška: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }

        public ServiceResult<bool> Update(ProizvodjacDTO proizvodjacDTO)
        {
            var session = _dataLayer.OpenSession();
            try
            {
                if (session == null)
                    return ServiceResult<bool>.Failure("Greška prilikom uspostavljanja sesije.");

                if (proizvodjacDTO == null)
                    return ServiceResult<bool>.Failure("Proizvodjac ne može biti null.");

                // Proveri da li proizvodjac postoji
                var oldProizvodjac = session.Load<Proizvodjac>(proizvodjacDTO.ID);
                
                if (oldProizvodjac == null)
                    return ServiceResult<bool>.Failure("Proizvodjac sa datim ID ne postoji.");

                // Ažuriraj entitet
                oldProizvodjac.Naziv = proizvodjacDTO.Naziv;

                session.Update(oldProizvodjac);
                session.Flush();

                return ServiceResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.Failure($"Greška pri ažuriranju proizvodjača: {ex.Message}");
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
