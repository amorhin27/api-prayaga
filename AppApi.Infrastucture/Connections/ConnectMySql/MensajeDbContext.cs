using ApiPrayaga.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiPrayaga.Infrastucture.Connections.ConnectMySql
{
    public class MensajeDbContext : DbContext
    {
        public MensajeDbContext(DbContextOptions<MensajeDbContext> options) : base(options) { }
        
        public DbSet<facultad> Facultad {  get; set; }    
        
    }
}
