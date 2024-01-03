using ApiPrayaga.Domain.Globals;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Infrastucture.Connections.ConnectMySql
{
    public class MySql //: BaseMySql
    {
        //public MySql  (IConfiguration _configuration) : base(_configuration) => _mysqlConfiguration = _configuration;

        ////static internal IDbConnection ObtenerConexion(string databaseName)
        ////{
        ////    return new SqlConnection(ConfigurarCadenaConexion(databaseName));
        ////}
        //private static string ConfigurarCadenaConexion(string databaseName)
        //{
        //    var dapperConnectionString = _mysqlConfiguration["ConnectionStrings:MySqlConnection"];
        //    dapperConnectionString = dapperConnectionString.Replace(Constants.DefaultConexion.ReemplazarBaseDatos, databaseName);

        //    if (Constants.MySqlServidorBaseDatosLista.DbDataCliente.Contains(databaseName))
        //        dapperConnectionString = dapperConnectionString.Replace(Constants.DefaultConexion.ReemplazarServidor, Constants.SQLServidores.DbCliente);

        //    if (string.IsNullOrEmpty(dapperConnectionString))
        //        throw new ArgumentException("El parámetro connectionStringSql se encuentra nulo.");

        //    if (string.IsNullOrEmpty(dapperConnectionString))
        //        throw new ArgumentException("No se ha especificado el nombre del servidor.");

        //    //return dapperConnectionProd01;
        //    return dapperConnectionString;
        //}
    }
}
