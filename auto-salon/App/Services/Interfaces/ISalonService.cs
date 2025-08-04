using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface ISalonService
    {
        ServiceResult<IList<SalonDTO>> GetAll();

        ServiceResult<bool> Delete(int id);

        ServiceResult<bool> Add(SalonDTO salon);

        ServiceResult<bool> Update(SalonDTO salon);
    }
}
