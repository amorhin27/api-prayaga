using ApiPrayaga.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Delete
{
    public class DeleteCarreraCommand : IRequest<Response<DeleteCarreraResponse>>
    {
        public int CarreraId { get; set; }
        public int UserDeleteId { get; set; }
    }
    public class DeleteCarreraResponse
    {
        public int Id { get; set; }
    }
}
