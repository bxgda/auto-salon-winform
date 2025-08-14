using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IVoziloService
    {
        ServiceResult<IList<VoziloTableDTO>> GetAll();

        ServiceResult<IList<VoziloTableDTO>> GetBySalonId(int salonId);

        ServiceResult<Boolean> Delete(string brSasije);

        ServiceResult<Boolean> Add(VoziloTableDTO vozilo, int salonId, int proizvodjacId);

        ServiceResult<Boolean> Update(VoziloTableDTO vozilo, int newSalonId);

        ServiceResult<IList<PromotivnaPonudaDTO>> GetPonude(string brSasije);

        // Vraca sva vozila koja nisu u promotivnoj ponudi (za dodavanje u promotivnu ponudu, kako ne bi dodali isto vozilo)
        ServiceResult<IList<VoziloTableDTO>> GetVozilaNotInPonuda(int promotivnaPonudaId);

        ServiceResult<bool> AddVozilaToPonuda(int promotivnaPonudaId, List<string> brojeviSasija);
    }
}
