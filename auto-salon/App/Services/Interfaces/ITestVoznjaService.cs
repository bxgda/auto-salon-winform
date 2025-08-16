using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface ITestVoznjaService
    {
        ServiceResult<IList<TestVoznjaTableDTO>> GetAll();

        ServiceResult<TestVoznjaDetailsDTO> GetDetails(int id);

        ServiceResult<bool> Add(TestVoznjaCreateDTO testVoznja);
    }
}
