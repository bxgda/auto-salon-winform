using auto_salon.Entities;

namespace auto_salon.App.Services.Interfaces
{
    public interface IProizvodjacService
    {
        ServiceResult<IList<Proizvodjac>> GetProizvodjaciZaSalonNova(int salonId);

        ServiceResult<IList<Proizvodjac>> GetSviProizvodjaci();
    }
}
