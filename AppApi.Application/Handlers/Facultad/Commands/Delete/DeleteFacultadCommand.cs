using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Delete
{
    public class DeleteFacultadCommand : IRequest<Response<DeleteFacultadResponse>>
    {
        public int FacultadId { get; set; }
        public int UserDeleteId { get; set; }
    }
    public class DeleteFacultadResponse
    {
        public int Id { get; set; }
    }
}
