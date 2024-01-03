using ApiPrayaga.Application.DTOs.FacultadDto;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using ApiPrayaga.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Create
{

    public class CreateFacultadHandler : IRequestHandler<CreateFacultadCommand, Response<CreateFacultadResponse>>
    {
        private readonly ICreateFacultadRepository _facultadRepository;
        private readonly ILogger<CreateFacultadHandler> _logger;

        public CreateFacultadHandler(ICreateFacultadRepository clienteRepository, ILogger<CreateFacultadHandler> logger)
        {
            _facultadRepository = clienteRepository;
            _logger = logger;
        }

        public async Task<Response<CreateFacultadResponse>> Handle(CreateFacultadCommand request, CancellationToken cancellationToken)
        {
            CrearFacultadDTO contacto = new CrearFacultadDTO
            {                
                UsuarioCreateId = request.UsuarioCreateId,
                NombreFacultad = request.NombreFacultad,
                CodigoFacultad = request.CodigoFacultad,
                Estado = request.Estado
            };
            var id = await _facultadRepository.CreateFacultad(contacto);
            if (id != 0)
            {
                return new Response<CreateFacultadResponse>(new CreateFacultadResponse { Id = id }, "Se registró correctamente la facultad");
            }
            else
            {
                return new Response<CreateFacultadResponse>(new CreateFacultadResponse { Id = id }, "Error al registar la facultad");
            }
        }
    }
}
