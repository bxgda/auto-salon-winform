using auto_salon.App.DTOs;

namespace auto_salon.App.Services.Interfaces
{
    public interface ITestVoznjaService
    {
        ServiceResult<bool> Add(TestVoznjaCreateDTO testVoznja);
    }
}
