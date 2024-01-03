using ApiPrayaga.Application.DTOs.CarreraDto;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Wrappers;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Create
{

    public class CreateCarreraHandler : IRequestHandler<CreateCarreraCommand, Response<CreateCarreraResponse>>
    {
        private readonly ICreateCarreraRepository _carreraRepository;
        private readonly ILogger<CreateCarreraHandler> _logger;

        public CreateCarreraHandler(ICreateCarreraRepository carreraRepository,  ILogger<CreateCarreraHandler> logger)
        {
            _carreraRepository = carreraRepository;
            _logger = logger;
        }

        public async Task<Response<CreateCarreraResponse>> Handle(CreateCarreraCommand request, CancellationToken cancellationToken)
        {
            CrearCarreraDTO contacto = new CrearCarreraDTO
            {
                FacultadId = request.FacultadId,
                UsuarioCreateId = request.UsuarioCreateId,
                NombreCarrera = request.NombreCarrera,
                CodigoCarrera = request.CodigoCarrera,
                Estado = request.Estado
            };
            var id = await _carreraRepository.CreateCarrera(contacto);
            if (id != 0)
            {
                return new Response<CreateCarreraResponse>(new CreateCarreraResponse { Id = id }, "Se registró correctamente la carrera");
            }
            else
            {
                return new Response<CreateCarreraResponse>(new CreateCarreraResponse { Id = id }, "Error al registar la carrera");
            }
        }
    }
}
