using ApiPrayaga.Application.DTOs.CarreraDto;

namespace ApiPrayaga.Application.Interfaces.Repository.ICarrera
{
    public interface ICreateCarreraRepository
    {
        Task<int> CreateCarrera(CrearCarreraDTO facultad);
        Task<int> DeleteCarrera(DeleteCarreraDTO facultad);
        Task<int> UpdateCarrera(UpdateCarreraDTO facultad);
    }
}
