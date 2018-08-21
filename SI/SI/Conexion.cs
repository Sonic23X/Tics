using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SI
{
    class Conexion
    {
        public static MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=tics; Uid=root; pwd=1234;");
        public static MySqlDataReader datos;

        public static string Consulta(string q, bool bandera_Retorno)
        {
            try
            {
                MySqlCommand Query = new MySqlCommand(q, conectar);
                conectar.Open();
    
                if (bandera_Retorno)
                {
                    datos = Query.ExecuteReader();
                    if (!datos.Read())
                        return "Sin retorno";//Sin retorno
                }
                else
                    Query.ExecuteReader();
                return "Correcto"; //Correcto
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
