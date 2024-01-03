using ApiPrayaga.Application.DTOs.FacultadDto;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Domain.Entities;
using ApiPrayaga.Infrastucture.Connections.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ApiPrayaga.Infrastructure.Repositories.FacultadRepo
{
    public class CreateFacultadRepository : ICreateFacultadRepository
    {
        private readonly ILogger<CreateFacultadRepository> _log;
        protected readonly PrayagaDbContext _context;

        public CreateFacultadRepository(ILogger<CreateFacultadRepository> log, PrayagaDbContext dbContext)
        {
            _log = log;
            _context = dbContext;
        }

        public async Task<int> CreateFacultad(CrearFacultadDTO facultad)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                int idNew = 0;
                int IdNewUser = 0;
                var cellfo = _context.Facultad.Where(x => x.codigo_facultad == facultad.CodigoFacultad).FirstOrDefault();
                if (cellfo != null)
                {
                    int idd = cellfo.id;
                    return 0;
                }
                else
                {
                    var resp = await _context.Facultad.OrderByDescending(x => x.id).FirstOrDefaultAsync();
                    IdNewUser = (resp == null ? 1 : resp.id + 1);

                    facultad f = new facultad();
                    f.nombre_facultad = facultad.NombreFacultad;
                    f.codigo_facultad = facultad.CodigoFacultad;
                    f.estado = facultad.Estado;
                    f.user_create_id = facultad.UsuarioCreateId;
                    f.fecha_create = DateTime.Now;
                    var rr = _context.Facultad.AddAsync(f);
                    await _context.SaveChangesAsync();
                }
                idNew = IdNewUser;
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

        public async Task<int> DeleteFacultad(DeleteFacultadDTO facultad)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                var dFacultad = await _context.Facultad.FindAsync(facultad.FacultadId);
                if (dFacultad.estado == true)
                {
                    //var dFacultad = await _context.Facultad.FindAsync(facultad.FacultadId);
                    dFacultad.estado = false;
                    dFacultad.user_delete_id = facultad.UserDeleteId;
                    dFacultad.fecha_delete = DateTime.Now;
                    _context.SaveChanges();
                    myTransaction.Commit();
                    return facultad.FacultadId;
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

        public async Task<int> UpdateFacultad(UpdateFacultadDTO query)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                var uFacultad = await _context.Facultad.FindAsync(query.Id);
                uFacultad.nombre_facultad = query.NombreFacultad;
                uFacultad.codigo_facultad = query.CodigoFacultad;
                uFacultad.estado = true;
                uFacultad.user_update_id = query.UserUpdateId;
                uFacultad.fecha_update = DateTime.Now;
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
