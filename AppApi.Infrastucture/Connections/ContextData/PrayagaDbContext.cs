using ApiPrayaga.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Infrastucture.Connections.ContextData
{
    public class PrayagaDbContext : DbContext
    {
        //public MensajeriaDbContext() //: base()
        //{ }

        public PrayagaDbContext(DbContextOptions<PrayagaDbContext> options) : base(options) { }

        public DbSet<facultad> Facultad { get; set; }
        public DbSet<carrera> Carrera { get; set; }
        }
}
