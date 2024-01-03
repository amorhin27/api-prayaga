using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Queries.GetId
{
    public class FacultadIdModel
    {
        public int FacultadId { get; set; }
        public string NombreFacultad { get; set; }
        public string CodigoFacultad { get; set; }
        public bool Estado { get; set; }
    }
    
}
