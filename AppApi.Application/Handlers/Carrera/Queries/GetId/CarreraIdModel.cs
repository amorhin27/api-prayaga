using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Queries.GetId
{
    public class CarreraIdModel
    {
        public int CarreraId { get; set; }
        public string NombreCarrera { get; set; }
        public string CodigoCarrera { get; set; }
        public bool Estado { get; set; }
    }
    
}
