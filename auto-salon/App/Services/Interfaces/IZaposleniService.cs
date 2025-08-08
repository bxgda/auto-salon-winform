using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Implementation
{
    public interface IZaposleniService
    {
        ServiceResult<IList<ZaposleniDTO>> GetAll();

        ServiceResult<IList<ZaposleniDTO>> GetBySalonId(int salonId);

        ServiceResult<IList<ZaposleniDTO>> GetAllProdavciKojiMoguDaProdajuVozilo(string brojSasije);

        ServiceResult<Boolean> Delete(string jmbg);

        ServiceResult<Boolean> Add(ZaposleniDTO zaposleniDto, int salonId);

        ServiceResult<Boolean> Update(ZaposleniDTO zaposleniDto); // TODO: omoguciti izmenu salona u kome radi zaposleni
    }
}
