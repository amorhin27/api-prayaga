using ApiPrayaga.Application.DTOs.FacultadDto;

namespace ApiPrayaga.Application.Interfaces.Repository.IFacultad
{
    public interface IGetAllFacultadRepository
    {
        Task<List<GetFacultadDTO>> GetAllFacultad(string? NombreFacultad, string? CodigoFacultad);
        Task<List<GetFacultadDeleteDTO>> GetAllFacultadDelete(string? NombreFacultad, string? CodigoFacultad);
        Task<GetIdFacultadDTO> GetIdFacultad(int UsuarioId);
    }
}
