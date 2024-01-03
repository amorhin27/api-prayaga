using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.FacultadDto
{
    public class CrearFacultadDTO
    {
        public string NombreFacultad { get; set; }
        public string CodigoFacultad { get; set; }
        public bool Estado { get; set; }
        public int UsuarioCreateId { get; set; }
    }
}
