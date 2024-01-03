using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Update
{
    public class UpdateCarreraCommand : IRequest<Response<UpdateCarreraResponse>>
    {
        public int CarreraId { get; set; }
        public int UserUpdateId { get; set; }
        public string NombreCarrera { get; set; }
        public string CodigoCarrera { get; set; }
        public bool Estado { get; set; }

    }
    
    public class UpdateCarreraResponse
    {
        public int Id { get; set; }
    }
}
