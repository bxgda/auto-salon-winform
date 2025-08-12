using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface IServisnaStavkaService
    {
        ServiceResult<IList<ServisnaStavkaDTO>> GetAllByBrojSasije(string brojSasije);

        ServiceResult<bool> AddServisnaStavkaToVozilo(ServisnaStavkaDTO servisnaStavka, string brojSasije);
    }
}
