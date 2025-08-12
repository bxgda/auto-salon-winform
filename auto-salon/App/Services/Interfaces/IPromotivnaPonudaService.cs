using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IPromotivnaPonudaService
    {
        ServiceResult<IList<PromotivnaPonudaDTO>> GetAll();
    }
}
