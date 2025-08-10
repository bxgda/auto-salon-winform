using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Services.Interfaces
{
    public interface IKupacService
    {
        ServiceResult<IList<KupacDTO>> GetAll();
    }
}
