using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeskTopAngelValdiviezo
{
    public class clsConexion
    {
        public static SqlCommand CrearConexion()
        {
            SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            conexion.Open();
            return conexion.CreateCommand();
        }
    }
}
