
using ApiPrayaga.Application.DTOs.CarreraDto;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Update
{
    public class UpdateCarreraHandler : IRequestHandler<UpdateCarreraCommand, Response<UpdateCarreraResponse>>
    {
        private readonly ICreateCarreraRepository _carrera;
        public UpdateCarreraHandler(ICreateCarreraRepository carrera) => _carrera = carrera;


        public async Task<Response<UpdateCarreraResponse>> Handle(UpdateCarreraCommand request, CancellationToken cancellationToken)
        {
            //string contactoString = JsonConvert.SerializeObject(request);

            UpdateCarreraDTO uCarrera = new UpdateCarreraDTO
            {
                Id = request.CarreraId,
                UserUpdateId = request.UserUpdateId,
                NombreCarrera = request.NombreCarrera,
                CodigoCarrera = request.CodigoCarrera,
                Estado = request.Estado
                //GruposUpdate = request.GrupoActualizar.Select(group => new GrupoUpdates { ContactoGrupoId=group.ContactoGrupoId, GrupoId = group.GrupoId}).ToList(),
            };

            int result = await _carrera.UpdateCarrera(uCarrera);

            if (result == uCarrera.Id)
            {
                return new Response<UpdateCarreraResponse>(new UpdateCarreraResponse { Id = uCarrera.Id }, "Se actualizo correctamente la carrera.");
            }
            else
            {
                return new Response<UpdateCarreraResponse>(new UpdateCarreraResponse { Id = uCarrera.Id }, "No es posible actualizar la carrera.");
            }

        }
    }
}
