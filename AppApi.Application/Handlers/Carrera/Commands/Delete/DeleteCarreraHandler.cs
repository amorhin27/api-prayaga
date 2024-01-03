using ApiPrayaga.Application.DTOs.CarreraDto;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Delete
{
    internal class DeleteCarreraHandler : IRequestHandler<DeleteCarreraCommand, Response<DeleteCarreraResponse>>
    {
        private readonly ICreateCarreraRepository _carrera;

        public DeleteCarreraHandler(ICreateCarreraRepository carrera) => _carrera = carrera;

        public async Task<Response<DeleteCarreraResponse>> Handle(DeleteCarreraCommand request, CancellationToken cancellationToken)
        {
            DeleteCarreraDTO dCarrera = new DeleteCarreraDTO
            {
                UserDeleteId = request.UserDeleteId,
                CarreraId = request.CarreraId,
                Estado = false
            };
            int result = await _carrera.DeleteCarrera(dCarrera);
            if (result == request.CarreraId)
            {
                return new Response<DeleteCarreraResponse>(new DeleteCarreraResponse { Id = dCarrera.CarreraId }, "Se eliminó correctamente la carrera.");
            }
            else
            {
                return new Response<DeleteCarreraResponse>(new DeleteCarreraResponse { Id = dCarrera.CarreraId }, "No se encuentra el registro que quiere eliminar.");
            }
        }
    }
}
