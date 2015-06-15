using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;

namespace Utils
{
    public static class DBHelper
    {
        private static NameValueCollection listaConexiones;

        public static NameValueCollection ListaConexiones
        {
            get
            {
                if (listaConexiones == null)
                    listaConexiones = (NameValueCollection)ConfigurationManager.GetSection("ConexionesBD");
                return listaConexiones;
            }
        }

        public static SqlConnection Connect(String db)
        {
            var config = ListaConexiones[db];
            return new SqlConnection(config);
        }
    }
}