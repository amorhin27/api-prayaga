using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.CarreraDto
{
    public class DeleteCarreraDTO
    {
        public int CarreraId { get; set; }
        public bool Estado { get; set; }
        public int UserDeleteId { get; set; }
    }
}
