using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IKupacService
    {
        ServiceResult<IList<KupacDTO>> GetAll();

        ServiceResult<bool> AddKupac(KupacDTO kupac);
    }
}
