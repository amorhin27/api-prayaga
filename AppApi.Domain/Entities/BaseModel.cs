namespace ApiPrayaga.Domain.Entities
{
    public class BaseModelInsert
    {
        public int UsuarioIdRegistra { get; set; }
        //public DateTime? FechaRegistra { get; set; }
        //public DateTime? FechaModifica { get; set; }
        public bool Estado { get; set; }
    }

    public class BaseModelUpdate
    {
        //public DateTime? FechaRegistra { get; set; }
        public int UsuarioIdModifica { get; set; }
        //public DateTime? FechaModifica { get; set; }
        public bool Estado { get; set; }
    }
}
