using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.CarreraDto
{
    public class GetCarreraDTO
    {
        public int Id { get; set; }
        public string NombreCarrera { get; set; } = string.Empty;
        public string CodigoCarrera { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
