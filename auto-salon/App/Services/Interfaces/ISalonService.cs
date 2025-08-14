using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface ISalonService
    {
        ServiceResult<IList<SalonDTO>> GetAll();

        ServiceResult<bool> Delete(int id);

        ServiceResult<bool> Add(SalonDTO salon);

        ServiceResult<bool> Update(SalonDTO salon);

        // Vraca sve salone gde vozilo sa odredjenim stanjem moze da se premesti
        ServiceResult<IList<SalonComboboxDTO>> GetAllByStanjeVozila(string stanje);

        ServiceResult<IList<SalonDTO>> GetSaloniInNudi(int proizvodjacId);

        ServiceResult<bool> AddSaloniToNudi(int proizvodjacId, IList<int> salonIds);
    }
}
