using ApiPrayaga.Application.DTOs.CarreraDto;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Infrastucture.Connections.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace ApiPrayaga.Infrastructure.Repositories.CarerraRepo
{
    public class GetAllCarreraRepository : IGetAllCarreraRepository
    {
        private readonly ILogger<CreateCarreraRepository> _log;
        protected readonly PrayagaDbContext _context;
        //private readonly MySQLConfiguration _connectionString;

        public GetAllCarreraRepository(ILogger<CreateCarreraRepository> log, PrayagaDbContext dbContext)
        {
            _log = log;
            _context = dbContext;
        }

        public async Task<List<GetCarreraDTO>> GetAllCarrera(string? NombreCarrera, string? CodigoCarrera)
        {
            try
            {
                List<GetCarreraDTO> result =
                    await (from t1 in _context.Carrera.Where(x => x.estado == true)
                           where (NombreCarrera == null || t1.nombre_carrera.Contains(NombreCarrera))
                           && (CodigoCarrera == null || t1.codigo_carrera.Contains(CodigoCarrera))
                           select new GetCarreraDTO
                           {
                               Id = t1.id,
                               NombreCarrera = t1.nombre_carrera,
                               CodigoCarrera = t1.codigo_carrera,
                               Estado = t1.estado
                           }).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<GetIdCarreraDTO> GetIdCarrera(int CarreraId)
        {
            //GetIdFacultadDTO result = new GetIdFacultadDTO();
            try
            {
                GetIdCarreraDTO result =
                    await (from f in _context.Carrera.Where(x => x.id.Equals(CarreraId) && x.estado.Equals(true))
                           select new GetIdCarreraDTO
                           {
                               Id = f.id,
                               NombreCarrera = f.nombre_carrera,
                               CodigoCarrera = f.codigo_carrera,
                               Estado = f.estado
                           }).FirstOrDefaultAsync();

                if (result != null)
                {

                return result;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
