using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Update
{
    public class UpdateFacultadCommand : IRequest<Response<UpdateFacultadResponse>>
    {
        public int FacultadId { get; set; }
        public int UserUpdateId { get; set; }
        public string NombreFacultad { get; set; }
        public string CodigoFacultad { get; set; }
        public bool Estado { get; set; }

    }
    
    public class UpdateFacultadResponse
    {
        public int Id { get; set; }
    }
}
