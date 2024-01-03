using ApiPrayaga.Application.DTOs.FacultadDto;

namespace ApiPrayaga.Application.Interfaces.Repository.IFacultad
{
    public interface ICreateFacultadRepository
    {
        Task<int> CreateFacultad(CrearFacultadDTO facultad);
        Task<int> DeleteFacultad(DeleteFacultadDTO facultad);
        Task<int> UpdateFacultad(UpdateFacultadDTO facultad);
    }
}
