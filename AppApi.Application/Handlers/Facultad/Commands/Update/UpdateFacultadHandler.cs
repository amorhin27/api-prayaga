using ApiPrayaga.Application.DTOs.FacultadDto;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Update
{
    public class UpdateFacultadHandler : IRequestHandler<UpdateFacultadCommand, Response<UpdateFacultadResponse>>
    {
        private readonly ICreateFacultadRepository _facuRepository;
        public UpdateFacultadHandler(ICreateFacultadRepository facuRepository) => _facuRepository = facuRepository;


        public async Task<Response<UpdateFacultadResponse>> Handle(UpdateFacultadCommand request, CancellationToken cancellationToken)
        {
            UpdateFacultadDTO uFacultad = new UpdateFacultadDTO
            {
                Id = request.FacultadId,
                UserUpdateId = request.UserUpdateId,
                NombreFacultad = request.NombreFacultad,
                CodigoFacultad = request.CodigoFacultad,
                Estado = request.Estado
                //GruposUpdate = request.GrupoActualizar.Select(group => new GrupoUpdates { ContactoGrupoId=group.ContactoGrupoId, GrupoId = group.GrupoId}).ToList(),
            };

            int result = await _facuRepository.UpdateFacultad(uFacultad);

            if (result == uFacultad.Id)
            {
                return new Response<UpdateFacultadResponse>(new UpdateFacultadResponse { Id = uFacultad.Id }, "Se actualizo correctamente la facultad.");
            }
            else
            {
                return new Response<UpdateFacultadResponse>(new UpdateFacultadResponse { Id = uFacultad.Id }, "No es posible actualizar la facultad.");
            }

        }
    }
}
