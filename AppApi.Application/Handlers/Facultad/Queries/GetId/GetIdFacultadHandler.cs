using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetId
{
    public class GetIdFacultadHandler : IRequestHandler<GetIdFacultadQuery, Response<FacultadIdModel>>
    {
        private readonly IGetAllFacultadRepository _clienteRepository;

        public GetIdFacultadHandler(IGetAllFacultadRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Response<FacultadIdModel>> Handle(GetIdFacultadQuery request, CancellationToken cancellationToken)
        {
            var FacultadList = await _clienteRepository.GetIdFacultad(request.FacultadId);
            if (FacultadList != null)
            {
                FacultadIdModel aplicat = new FacultadIdModel
                {
                    FacultadId = FacultadList.Id,
                    NombreFacultad = FacultadList.NombreFacultad,
                    CodigoFacultad = FacultadList.CodigoFacultad,
                    Estado = FacultadList.Estado,
                };
                return new Response<FacultadIdModel>(aplicat);
            }
            else
            {
                return new Response<FacultadIdModel>(0);
            }
        }
    }
}
