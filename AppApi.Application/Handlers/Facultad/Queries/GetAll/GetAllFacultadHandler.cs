using ApiPrayaga.Application.CustonPagination;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetAll
{
    public class GetAllFacultadHandler : IRequestHandler<GetAllFacultadQuery, PagedList<FacultadModel>>
    {
        private readonly IGetAllFacultadRepository _clienteRepository;

        public GetAllFacultadHandler(IGetAllFacultadRepository clienteRepository) => _clienteRepository = clienteRepository;

        public async Task<PagedList<FacultadModel>> Handle(GetAllFacultadQuery request, CancellationToken cancellationToken)
        {
            var contacList = await _clienteRepository.GetAllFacultad(request.NombreFacultad, request.CodigoFacultad);

            List<FacultadModel> contac = contacList.Select(item => new FacultadModel
            {
                FacultadId = item.Id,
                NombreFacultad = item.NombreFacultad,
                CodigoFacultad = item.CodigoFacultad,
                Estado = item.Estado
            }).ToList();
            var pagidContacto = PagedList<FacultadModel>.Create(contac, request.PageNumber, request.PageSize);
            return pagidContacto;
        }
    }
}
