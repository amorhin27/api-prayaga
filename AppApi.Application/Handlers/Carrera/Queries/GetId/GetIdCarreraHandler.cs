using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Carrera.Queries.GetId
{
    public class GetIdCarreraHandler : IRequestHandler<GetIdCarreraQuery, Response<CarreraIdModel>>
    {
        private readonly IGetAllCarreraRepository _carreraRepository;

        public GetIdCarreraHandler(IGetAllCarreraRepository carreraRepository)
        {
            _carreraRepository = carreraRepository;
        }

        public async Task<Response<CarreraIdModel>> Handle(GetIdCarreraQuery request, CancellationToken cancellationToken)
        {
            var FacultadList = await _carreraRepository.GetIdCarrera(request.CarreraId);
            if (FacultadList != null)
            {
                CarreraIdModel aplicat = new CarreraIdModel
                {
                    CarreraId = FacultadList.Id,
                    NombreCarrera = FacultadList.NombreCarrera,
                    CodigoCarrera = FacultadList.CodigoCarrera,
                    Estado = FacultadList.Estado,
                };
                return new Response<CarreraIdModel>(aplicat);
            }
            else
            {
                return new Response<CarreraIdModel>(0);
            }
        }
    }
}
