using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IVoziloService
    {
        ServiceResult<IList<VoziloTableDTO>> GetAll();

        ServiceResult<Boolean> Delete(string brSasije);

        ServiceResult<Boolean> Add(VoziloTableDTO vozilo);
    }
}
