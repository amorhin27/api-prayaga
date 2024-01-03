using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Domain.Entities
{
    public class carrera
    {
        public int id { get; set; }
        public int facultad_id { get; set; }
        public string? nombre_carrera { get; set; }
        public string? codigo_carrera { get; set; }
        public bool estado { get; set; }
        public int? user_create_id { get; set; }
        public DateTime fecha_create { get; set; }
        public int? user_update_id { get; set; }
        public DateTime? fecha_update { get; set; }
        public int? user_delete_id { get; set; }
        public DateTime? fecha_delete { get; set; }
    }
}
