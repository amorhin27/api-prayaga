using ApiPrayaga.Application.CustonPagination;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Carrera.Queries.GetAll
{
    public class GetAllCarreraQuery : IRequest<PagedList<CarreraModel>>
    {
        public string? NombreCarrera { get; set; }
        public string? CodigoCarrera { get; set; }
        //paginacion
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllCarreraQuery(string nombreCarrera, string codigoCarrera, int pageNumber, int pageSize)
        {
            NombreCarrera = nombreCarrera;
            CodigoCarrera = codigoCarrera;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        //public GetAllContactoQuery(int Id) => (IdUser) = (IdUser);
    }
}
