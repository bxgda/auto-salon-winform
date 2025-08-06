using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IUgovoriService
    {
        ServiceResult<IList<UgovorTableDTO>> GetAll();

        ServiceResult<bool> Delete(int id);
    }
}
