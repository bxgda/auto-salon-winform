using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IProizvodjacService
    {
        ServiceResult<IList<ProizvodjacDTO>> GetProizvodjaciZaSalonNova(int salonId);

        ServiceResult<IList<SalonDTO>> GetSaloniZaProizvodjaca(int proizvodjacId);

        ServiceResult<IList<ProizvodjacDTO>> GetSviProizvodjaci();
    }
}
