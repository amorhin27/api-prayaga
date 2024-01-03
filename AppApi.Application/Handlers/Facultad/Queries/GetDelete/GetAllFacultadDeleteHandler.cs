using ApiPrayaga.Application.CustonPagination;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetDelete
{
    public class GetAllFacultadDeleteHandler : IRequestHandler<GetAllFacultadDeleteQuery, Response<List<FacultadDeleteModel>>>
    {
        private readonly IGetAllFacultadRepository _clienteRepository;

        public GetAllFacultadDeleteHandler(IGetAllFacultadRepository clienteRepository) => _clienteRepository = clienteRepository;

        public async Task<Response<List<FacultadDeleteModel>>> Handle(GetAllFacultadDeleteQuery request, CancellationToken cancellationToken)
        {
            var contacList = await _clienteRepository.GetAllFacultadDelete(request.NombreFacultad, request.CodigoFacultad);

            List<FacultadDeleteModel> contac = contacList.Select(item => new FacultadDeleteModel
            {
                FacultadId = item.Id,
                NombreFacultad = item.NombreFacultad,
                CodigoFacultad = item.CodigoFacultad,
                Estado = item.Estado
            }).ToList();
            return new Response<List<FacultadDeleteModel>>(contac);
        }
    }
}
