using ApiPrayaga.Application.Wrappers;
using ApiPrayaga.Domain.Entities;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Create
{
    public class CreateFacultadCommand : IRequest<Response<CreateFacultadResponse>>
    {
        public string NombreFacultad { get; set; }
        public string CodigoFacultad { get; set; }
        public bool Estado { get; set; }
        public int UsuarioCreateId { get; set; }
    }

    
    public class CreateFacultadResponse
    {
        public int Id { get; set; }
    }
}
