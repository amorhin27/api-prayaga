using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.DTOs.CarreraDto
{
    public class CrearCarreraDTO
    {
        public int FacultadId { get; set; }
        public string NombreCarrera { get; set; }
        public string CodigoCarrera { get; set; }
        public bool Estado { get; set; }
        public int UsuarioCreateId { get; set; }
    }
}
