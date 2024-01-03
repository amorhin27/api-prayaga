using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.FacultadDto
{
    public class DeleteFacultadDTO
    {
        public int FacultadId { get; set; }
        public bool Estado { get; set; }
        public int UserDeleteId { get; set; }
    }
}
