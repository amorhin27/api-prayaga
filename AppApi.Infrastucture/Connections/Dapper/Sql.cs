using ApiPrayaga.Domain.Globals;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ApiPrayaga.Infrastructure.Connections.Dapper
{
    public class Sql //: Base
    {
        //public Sql(IConfiguration _configuration) : base(_configuration) => _dapperConfiguration = _configuration;

        //static internal IDbConnection ObtenerConexion(string databaseName)
        //{
        //    return new SqlConnection(ConfigurarCadenaConexion(databaseName));
        //}
        //private static string ConfigurarCadenaConexion(string databaseName)
        //{
        //    var dapperConnectionString = _dapperConfiguration["ConnectionStrings:ConnectionSqlServer"];
        //    dapperConnectionString = dapperConnectionString.Replace(Constants.DefaultConexion.ReemplazarBaseDatos, databaseName);

        //    if (Constants.SQLServidorBaseDatosLista.DbServerK8.Contains(databaseName))
        //        dapperConnectionString = dapperConnectionString.Replace(Constants.DefaultConexion.ReemplazarServidor, Constants.SQLServidores.DbServer2k8);         

        //    if (string.IsNullOrEmpty(dapperConnectionString))
        //        throw new ArgumentException("El parámetro connectionStringSql se encuentra nulo.");

        //    if (string.IsNullOrEmpty(dapperConnectionString))
        //        throw new ArgumentException("No se ha especificado el nombre del servidor.");

        //    //return dapperConnectionProd01;
        //    return dapperConnectionString;
        //}

    }
}
