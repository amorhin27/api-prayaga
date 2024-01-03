using ApiPrayaga.Application.CustonPagination;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetAll
{
    public class GetAllFacultadQuery : IRequest<PagedList<FacultadModel>>
    {
        public string? NombreFacultad { get; set; }
        public string? CodigoFacultad { get; set; }
        //paginacion
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllFacultadQuery(string nombreFacultad, string codigoFacultad, int pageNumber, int pageSize)
        {
            NombreFacultad = nombreFacultad;
            CodigoFacultad = codigoFacultad;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        //public GetAllContactoQuery(int Id) => (IdUser) = (IdUser);
    }
}
