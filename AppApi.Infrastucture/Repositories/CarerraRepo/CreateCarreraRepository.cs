using ApiPrayaga.Application.DTOs.CarreraDto;
using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Domain.Entities;
using ApiPrayaga.Infrastucture.Connections.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ApiPrayaga.Infrastructure.Repositories.CarerraRepo
{
    public class CreateCarreraRepository : ICreateCarreraRepository
    {
        private readonly ILogger<CreateCarreraRepository> _log;
        protected readonly PrayagaDbContext _context;

        public CreateCarreraRepository(ILogger<CreateCarreraRepository> log, PrayagaDbContext dbContext)
        {
            _log = log;
            _context = dbContext;
        }

        public async Task<int> CreateCarrera(CrearCarreraDTO facultad)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                int idNew = 0;
                int IdNewCarrera = 0;
                var cellfo = _context.Carrera.Where(x => x.codigo_carrera == facultad.CodigoCarrera).FirstOrDefault();
                if (cellfo != null)
                {
                    int idd = cellfo.id;
                    return 0;
                }
                else
                {
                    var resp = await _context.Carrera.OrderByDescending(x => x.id).FirstOrDefaultAsync();
                    IdNewCarrera = (resp == null ? 1 : resp.id + 1);

                    carrera f = new carrera();
                    f.facultad_id = facultad.FacultadId;
                    f.nombre_carrera = facultad.NombreCarrera;
                    f.codigo_carrera = facultad.CodigoCarrera;
                    f.estado = facultad.Estado;
                    f.user_create_id = facultad.UsuarioCreateId;
                    f.fecha_create = DateTime.Now;
                    var rr = _context.Carrera.AddAsync(f);
                    await _context.SaveChangesAsync();
                }
                idNew = IdNewCarrera;
                myTransaction.Commit();
                return idNew;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                throw ex;
            }
            finally { _context.Dispose(); }
        }

        public async Task<int> DeleteCarrera(DeleteCarreraDTO request)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                var dCarrera = await _context.Carrera.FindAsync(request.CarreraId);
                if (dCarrera.estado == true)
                {
                    //var dFacultad = await _context.Facultad.FindAsync(facultad.FacultadId);
                    dCarrera.estado = false;
                    dCarrera.user_delete_id = request.UserDeleteId;
                    dCarrera.fecha_delete = DateTime.Now;
                    _context.SaveChanges();
                    myTransaction.Commit();
                    return request.CarreraId;
                }
                else { return 0; }



            }
            catch (Exception)
            {
                myTransaction.Rollback();
                throw;
            }
            finally { _context.Dispose(); }
        }

        public async Task<int> UpdateCarrera(UpdateCarreraDTO query)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                var uCarrera = await _context.Carrera.FindAsync(query.Id);
                uCarrera.nombre_carrera = query.NombreCarrera;
                uCarrera.codigo_carrera = query.CodigoCarrera;
                uCarrera.estado = true;
                uCarrera.user_update_id = query.UserUpdateId;
                uCarrera.fecha_update = DateTime.Now;
                _context.SaveChanges();
                myTransaction.Commit();
                return query.Id;
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                throw ex;
            }
        }
    }
}
