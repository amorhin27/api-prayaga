using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.FacultadDto
{
    public class GetIdFacultadDTO
    {
        public int Id { get; set; }
        public string NombreFacultad { get; set; } = string.Empty;
        public string CodigoFacultad { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
    
}
