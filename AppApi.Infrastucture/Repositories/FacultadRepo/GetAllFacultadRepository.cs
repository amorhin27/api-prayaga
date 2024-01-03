using ApiPrayaga.Application.DTOs.FacultadDto;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Infrastucture.Connections.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace ApiPrayaga.Infrastructure.Repositories.FacultadRepo
{
    public class GetAllFacultadRepository : IGetAllFacultadRepository
    {
        private readonly ILogger<CreateFacultadRepository> _log;
        protected readonly PrayagaDbContext _context;
        //private readonly MySQLConfiguration _connectionString;

        public GetAllFacultadRepository(ILogger<CreateFacultadRepository> log, PrayagaDbContext dbContext)
        {
            _log = log;
            _context = dbContext;
        }

        public async Task<List<GetFacultadDTO>> GetAllFacultad(string? NombreFacultad, string? CodigoFacultad)
        {
            try
            {
                List<GetFacultadDTO> result =
                    await (from t1 in _context.Facultad.Where(x => x.estado == true)
                           where (NombreFacultad == null || t1.nombre_facultad.Contains(NombreFacultad))
                           && (CodigoFacultad == null || t1.codigo_facultad.Contains(CodigoFacultad))
                           select new GetFacultadDTO
                           {
                               Id = t1.id,
                               NombreFacultad = t1.nombre_facultad,
                               CodigoFacultad = t1.codigo_facultad,
                               Estado = t1.estado
                           }).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<GetIdFacultadDTO> GetIdFacultad(int FacultadId)
        {
            //GetIdFacultadDTO result = new GetIdFacultadDTO();
            try
            {
                GetIdFacultadDTO result =
                    await (from f in _context.Facultad.Where(x => x.id.Equals(FacultadId) && x.estado.Equals(true))
                           select new GetIdFacultadDTO
                           {
                               Id = f.id,
                               NombreFacultad = f.nombre_facultad,
                               CodigoFacultad = f.codigo_facultad,
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

        public async Task<List<GetFacultadDeleteDTO>> GetAllFacultadDelete(string? NombreFacultad, string? CodigoFacultad)
        {
            try
            {
                List<GetFacultadDeleteDTO> result =
                    await(from t1 in _context.Facultad.Where(x => x.estado == false)
                          where (NombreFacultad == null || t1.nombre_facultad.Contains(NombreFacultad))
                          && (CodigoFacultad == null || t1.codigo_facultad.Contains(CodigoFacultad))
                          select new GetFacultadDeleteDTO
                          {
                              Id = t1.id,
                              NombreFacultad = t1.nombre_facultad,
                              CodigoFacultad = t1.codigo_facultad,
                              Estado = t1.estado
                          }).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
