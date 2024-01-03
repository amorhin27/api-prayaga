
using ApiPrayaga.Application.DTOs.FacultadDto;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Delete
{
    internal class DeleteFacultadHandler : IRequestHandler<DeleteFacultadCommand, Response<DeleteFacultadResponse>>
    {
        private readonly ICreateFacultadRepository _facultadRepository;

        public DeleteFacultadHandler(ICreateFacultadRepository facultadRepository) => _facultadRepository = facultadRepository;        

        public async Task<Response<DeleteFacultadResponse>> Handle(DeleteFacultadCommand request, CancellationToken cancellationToken)
        {
            DeleteFacultadDTO dFacultad = new DeleteFacultadDTO
            {
                UserDeleteId = request.UserDeleteId,
                 FacultadId = request.FacultadId,
                 Estado = false
            };
            int result = await _facultadRepository.DeleteFacultad(dFacultad);
            if (result == request.FacultadId)
            {
                return new Response<DeleteFacultadResponse>(new DeleteFacultadResponse { Id = dFacultad.FacultadId }, "Se eliminó correctamente la facultad.");
            }            
            else
            {
                return new Response<DeleteFacultadResponse>(new DeleteFacultadResponse { Id = dFacultad.FacultadId }, "No se encuentra el registro que quiere eliminar.");
            }
        }
    }
}
