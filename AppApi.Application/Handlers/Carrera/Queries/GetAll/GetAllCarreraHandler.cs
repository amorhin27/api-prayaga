using ApiPrayaga.Application.CustonPagination;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Queries.GetAll
{
    public class GetAllCarreraHandler : IRequestHandler<GetAllCarreraQuery, PagedList<CarreraModel>>
    {
        private readonly IGetAllCarreraRepository _carreraRepository;

        public GetAllCarreraHandler(IGetAllCarreraRepository carreraRepository) => _carreraRepository = carreraRepository;

        public async Task<PagedList<CarreraModel>> Handle(GetAllCarreraQuery request, CancellationToken cancellationToken)
        {
            var contacList = await _carreraRepository.GetAllCarrera(request.NombreCarrera, request.CodigoCarrera);

            List<CarreraModel> contac = contacList.Select(item => new CarreraModel
            {
                CarreraId = item.Id,
                NombreCarrera = item.NombreCarrera,
                CodigoCarrera = item.CodigoCarrera,
                Estado = item.Estado
            }).ToList();
            var pagidContacto = PagedList<CarreraModel>.Create(contac, request.PageNumber, request.PageSize);
            return pagidContacto;
        }
    }
}
