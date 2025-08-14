using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IPromotivnaPonudaService
    {
        ServiceResult<IList<PromotivnaPonudaDTO>> GetAll();

        ServiceResult<IList<VoziloTableDTO>> GetVozilaPromotivnePonude(int idPonude);

        ServiceResult<bool> Delete(int id);

        ServiceResult<bool> Add(PromotivnaPonudaDTO promotivnaPonudaDTO);

        ServiceResult<bool> Update(PromotivnaPonudaDTO promotivnaPonudaDTO);
    }
}
