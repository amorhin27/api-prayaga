using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Queries.GetId
{
    public class GetIdCarreraQuery : IRequest<Response<CarreraIdModel>>
    {
        public int CarreraId {get;set;}

        public GetIdCarreraQuery(int carreraId)
        {
            CarreraId = carreraId;
        }
    }
}
