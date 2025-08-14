using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IJeOcenioService
    {
        ServiceResult<IList<JeOcenioDTO>> GetAll();
    }
}
