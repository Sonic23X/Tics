using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SI
{
    class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bddatos; Uid=root; pwd=Mike9593;");
            conectar.Open();
            return conectar;
        }
    }
}
