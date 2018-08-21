using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SI
{
    class Crud_Proyectos
    {
        public static List<Proyecto> getAll()
        {
            List<Proyecto> proyectos = new List<Proyecto>();

            MySqlCommand comand = new MySqlCommand("SELECT * FROM proyectos", ConexionBD.ObtenerConexion());
            MySqlDataReader reader = comand.ExecuteReader();
            Console.WriteLine("Entra consulta");

            try{


                while (reader.Read())
                {
                    Console.WriteLine("se ejecuto el while");
                    proyectos.Add(new Proyecto(reader.GetInt16(0),
                                               reader.GetString(1),
                                               reader.GetString(2),
                                               reader.GetString(3),
                                               reader.GetDateTime(4).ToString(),
                                               reader.GetDateTime(5).ToString(),
                                               reader.GetDateTime(6).ToString(),
                                               reader.GetFloat(7),
                                               reader.GetInt32(8),
                                               reader.GetInt32(9),
                                               reader.GetInt32(10),
                                               reader.GetString(11)));
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            reader.Close();
            return proyectos;
        }

        public static List<Proyecto> Read(string dato)
        {
            List<Proyecto> proyectos = new List<Proyecto>();

            MySqlCommand comand = new MySqlCommand("Select p.id, p.folio_volumetria, p.proyecto, p.descripcion, p.fecha_inicio, " +
                " p.fecha_asignacion, p.fecha_cierre, p.costo_inversion, p.tipo_servicio, " +
                " c.nombre as ClienteNom, c.apellidos as ClienteAp," +
                " e.nombre as SupervisorNom, e.apellidos as SupervisorAp," +
                " ei.nombre as ResponsableNom, ei.apellidos as ResponsableAp " +
                " from proyectos as p " +
                " join clientes as c on c.id = p.cliente " +
                " join empleados as e on e.id = p.supervisor " +
                " join empleados as ei on ei.id = p.responsable " +
                "where folio_volumetria like '%" + dato + "%' or proyecto like '%" + dato + "%' or tipo_servicio like '%" + dato + "%';"
                , ConexionBD.ObtenerConexion());
            MySqlDataReader reader = comand.ExecuteReader();
            Console.WriteLine("Entra consulta");
            try
            {

                while (reader.Read())
                {
                    Console.WriteLine("se ejecuto el while");
                    proyectos.Add(new Proyecto(reader.GetInt32(0),
                                               reader.GetString(1),
                                               reader.GetString(2),
                                               reader.GetString(3),
                                               reader.GetDateTime(4).ToString(),
                                               reader.GetDateTime(5).ToString(),
                                               reader.GetDateTime(6).ToString(),
                                               reader.GetFloat(7),
                                               reader.GetString(8),
                                               reader.GetString(9),
                                               reader.GetString(10),
                                               reader.GetString(11),
                                               reader.GetString(12),
                                               reader.GetString(13),
                                               reader.GetString(14)
                                               ));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            reader.Close();
            return proyectos;
        }//acaba busqueda

        public static String insertarNuevo(Proyecto newProyecto)
        {
            string resultado = "";
            MySqlCommand comand = new MySqlCommand("INSERT INTO proyectos VALUES ("+newProyecto.Id+",'"
                +newProyecto.Folio_volumetria
                +"','"+newProyecto.Proyecto_name+"','"+newProyecto.Descripcion+"','"+newProyecto.Fecha_inicio+"','"+newProyecto.Fecha_asignacion+"','"+newProyecto.Fecha_cierre+"',"+newProyecto.Costo_inversion+","+newProyecto.Supervisor+","+newProyecto.Responsable+","+newProyecto.Cliente+",'"+newProyecto.Tipo_servicio+"')"
                , 
                ConexionBD.ObtenerConexion());

            try
            {
                comand.ExecuteNonQuery();
                resultado = "Se agrego el Proyecto";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                resultado = ex.Message;
            }

            return resultado;
        }


        public static String ActualizarProyecto(Proyecto proyecto)
        {
            string resultado = "";
            string sql = "UPDATE proyectos SET "
                + "folio_volumetria='" + proyecto.Folio_volumetria + "',"
                + "proyecto='" + proyecto.Proyecto_name + "',"
                + "descripcion='" + proyecto.Descripcion + "',"
                + "fecha_inicio='" + proyecto.Fecha_inicio + "',"
                + "fecha_asignacion='" + proyecto.Fecha_asignacion + "',"
                + "fecha_cierre='" + proyecto.Fecha_cierre + "',"
                + "costo_inversion=" + proyecto.Costo_inversion + ","
                + "supervisor=" + proyecto.Supervisor + ","
                + "responsable=" + proyecto.Responsable + ","
                + "cliente=" + proyecto.Cliente + ","
                + "tipo_servicio='" + proyecto.Tipo_servicio + "'" + " WHERE id=" + proyecto.Id;
        
            MySqlCommand comand = new MySqlCommand(sql, ConexionBD.ObtenerConexion());

            try
            {
                comand.ExecuteNonQuery();
                resultado = "Se a actualizado la informacion del proyecto";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                resultado = ex.Message;
            }


            return resultado;
        }


        public static String EliminarProyecto(int id_proyecto)
        {

            string result = "";
            MySqlCommand comand = new MySqlCommand("DELETE from proyectos where id="+id_proyecto , ConexionBD.ObtenerConexion());

            try
            {
                comand.ExecuteNonQuery();
                result = "El Proyecto fue eliminado con exito";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }

            return result;
        }


        public static Dictionary<int, string> getEmpleados()
        {
            MySqlCommand comand = new MySqlCommand("SELECT 	id,	nombre from empleados", ConexionBD.ObtenerConexion());
            MySqlDataReader reader = comand.ExecuteReader();

            Dictionary<int, string> empleados = new Dictionary<int, string>();
            try
            {
                while (reader.Read())
                {
                    empleados.Add(reader.GetInt16(0), reader.GetString(1));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            return empleados;
        }

        public static Dictionary<int, string> getClientes()
        {
            MySqlCommand comand = new MySqlCommand("SELECT 	id,	nombre from clientes", ConexionBD.ObtenerConexion());
            MySqlDataReader reader = comand.ExecuteReader();

            Dictionary<int, string> clientes = new Dictionary<int, string>();
            try
            {
                while (reader.Read())
                {
                    clientes.Add(reader.GetInt16(0), reader.GetString(1));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            return clientes;
        }

    }
}
