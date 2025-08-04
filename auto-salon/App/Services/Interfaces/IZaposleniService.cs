using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Implementation
{
    public interface IZaposleniService
    {
        ServiceResult<IList<ZaposleniDTO>> GetAll();

        ServiceResult<Boolean> Delete(string jmbg);

        ServiceResult<Boolean> Add(ZaposleniDTO zaposleni);
    }
}
