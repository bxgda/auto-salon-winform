using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Services.Interfaces
{
    public interface IProizvodjacService
    {
        ServiceResult<IList<ProizvodjacDTO>> GetProizvodjaciZaSalonNova(int salonId);

        ServiceResult<IList<ProizvodjacDTO>> GetSviProizvodjaci();
    }
}
