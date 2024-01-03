using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.CarreraDto
{
    public class UpdateCarreraDTO
    {
        public int Id { get; set; }
        public string NombreCarrera { get; set; }
        public string CodigoCarrera { get; set; }
        public bool Estado { get; set; }
        public int UserUpdateId { get; set; }
    }    
}
