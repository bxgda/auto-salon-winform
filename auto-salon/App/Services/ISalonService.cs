using auto_salon.App.DTOs;

namespace auto_salon.App.Services
{
    public interface ISalonService
    {
        ServiceResult<IList<SalonTableDTO>> GetAll();

        ServiceResult<Boolean> Delete(int id);

        ServiceResult<Boolean> Add(SalonTableDTO salon);
    }
}
