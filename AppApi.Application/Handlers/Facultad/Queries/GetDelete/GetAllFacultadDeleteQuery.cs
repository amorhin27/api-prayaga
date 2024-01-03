using ApiPrayaga.Application.Wrappers;
using MediatR;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetDelete
{
    public class GetAllFacultadDeleteQuery : IRequest<Response<List<FacultadDeleteModel>>>
    {
        public string? NombreFacultad { get; set; }
        public string? CodigoFacultad { get; set; }
        //paginacion
        //public int PageNumber { get; set; }
        //public int PageSize { get; set; }

        //public GetAllFacultadDeleteQuery(string nombreFacultad, string codigoFacultad, int pageNumber, int pageSize)
        //{
        //    NombreFacultad = nombreFacultad;
        //    CodigoFacultad = codigoFacultad;
        //    PageNumber = pageNumber;
        //    PageSize = pageSize;
        //}
        public GetAllFacultadDeleteQuery(string nombreFacultad, string codigoFacultad) => (NombreFacultad, CodigoFacultad) = (nombreFacultad, codigoFacultad);
    }
}
