namespace ApiPrayaga.Domain.Globals
{
    public class Constants
    {
        public static class MySqlBaseDeDatos
        {
            public const string dataCliente = "cliente";
        }

        public static class SQLServidores
        {
            public const string DbCliente = "DbCliente";
        }

        public static class MySqlServidorBaseDatosLista
        {
            public static readonly string[] DbDataCliente = {
                MySqlBaseDeDatos.dataCliente
            };

        }

        public static class DefaultConexion
        {
            public static string ReemplazarBaseDatos = "DefaultDataBase";
            public static string ReemplazarServidor = "DefaultServer";
            public static string ReemplazarUsuario = "DefaultUser";
            public static string ReemplazarContrasena = "DefaultPassword";

            public static string IpServidorEncrypt = "5AyCSFt52NLAiKh+36NwLQ==";
            public static string UsuarioEncrypt = "g4cmhf7yP48=";
            public static string ContrasenaEncrypt = "pr5W5PA7dFBmBP4IeKJ3tQ==";
            public static string BaseDatosEncrypt = "TtZmdF0ZwlpphFiER53z3SOGccltNzzJ";
        }        
    }
}
