using ApiPrayaga.Application.Wrappers;
using ApiPrayaga.Domain.Entities;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Create
{
    public class CreateCarreraCommand : IRequest<Response<CreateCarreraResponse>>
    {
        public int FacultadId { get; set; }
        public string NombreCarrera { get; set; }
        public string CodigoCarrera { get; set; }
        public bool Estado { get; set; }
        public int UsuarioCreateId { get; set; }
    }

    
    public class CreateCarreraResponse
    {
        public int Id { get; set; }
    }
}
