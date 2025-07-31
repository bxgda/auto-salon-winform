using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Services
{
    public interface ISalonService
    {
        IList<SalonTableDTO> GetAll();
    }
}
