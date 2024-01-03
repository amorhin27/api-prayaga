using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetId
{
    public class GetIdFacultadQuery : IRequest<Response<FacultadIdModel>>
    {
        public int FacultadId {get;set;}

        public GetIdFacultadQuery(int facultadId)
        {
            FacultadId = facultadId;
        }
    }
}
