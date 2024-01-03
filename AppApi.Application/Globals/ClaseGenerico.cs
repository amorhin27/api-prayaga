using ApiPrayaga.Application.Interfaces.Repository;

namespace ApiPrayaga.Application.Globals
{
    public class ClaseGenerico : IOperacionesGenericos
    {
        public DirectorioModel FuncionDirectorio()
        {
            DirectorioModel directorio = new DirectorioModel();
            directorio._path1 = "LDAP://10.0.10.11/DC=pe280, DC=bally, DC=local";
            directorio._path2 = "LDAP://10.0.10.13/DC=pe280, DC=bally, DC=local";
            return directorio;
        }

    }
}
