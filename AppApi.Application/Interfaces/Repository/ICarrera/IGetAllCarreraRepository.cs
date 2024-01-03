using ApiPrayaga.Application.DTOs.CarreraDto;

namespace ApiPrayaga.Application.Interfaces.Repository.ICarrera
{
    public interface IGetAllCarreraRepository
    {
        Task<List<GetCarreraDTO>> GetAllCarrera(string? NombreCarrera, string? CodigoCarrera);
        Task<GetIdCarreraDTO> GetIdCarrera(int UsuarioId);
    }
}
