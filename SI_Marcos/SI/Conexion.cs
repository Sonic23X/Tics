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
        public static MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bd_tics; Uid=root; pwd=Mike9593;");
        public static MySqlDataReader datos;

        public static string Consulta(string q, bool bandera_Retorno)
        {
            try
            {
                Console.WriteLine("en ejecucion conectar");
                MySqlCommand Query = new MySqlCommand(q, conectar);
                conectar.Open();

                datos = null;


                if (bandera_Retorno)
                {
                    datos = Query.ExecuteReader(); Console.WriteLine("CONSULTA");
                    if (!datos.Read())
                    {
                        return "Sin retorno";//Sin retorno
                        Console.WriteLine("sin retorno");
                    }

                }
                else
                    Query.ExecuteReader();
                return "Correcto"; //Correcto
            }
            catch(Exception e)
            {
                return e.Message;
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
