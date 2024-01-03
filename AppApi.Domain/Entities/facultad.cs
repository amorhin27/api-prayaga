using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiPrayaga.Domain.Entities
{
    public class facultad 
    {
        public int id { get; set; }
        public string? nombre_facultad { get; set; }
        public string? codigo_facultad { get; set; }
        public bool estado { get; set; }
        public int? user_create_id { get; set; }
        public DateTime fecha_create { get; set; }
        public int? user_update_id { get; set; }
        public DateTime? fecha_update { get; set; }
        public int? user_delete_id { get; set; }
        public DateTime? fecha_delete { get; set; }
    }
}
