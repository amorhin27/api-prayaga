using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Globals
{
    public class DirectorioActivo
    {
        public DirectorioModel FuncionDirectorio()
        {
            DirectorioModel directorio = new DirectorioModel();
            directorio._path1 = "LDAP://10.0.10.11/DC=pe280, DC=bally, DC=local";
            directorio._path2 = "LDAP://10.0.10.13/DC=pe280, DC=bally, DC=local";
            return directorio;
        }
    }

    public class DirectorioModel
    {
        public string _path1 { get; set; } = string.Empty;
        public string _path2 { get; set; } = string.Empty;
    }
}
