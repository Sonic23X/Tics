using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SI
{
    class M_Proveedores
    {
        public static string Create(ProveedoresClass proveedor)
        {
            try
            {
                Conexion.Consulta(string.Format("Insert into proveedores(RFC, nombre_empresa, domicilio_fiscal, domicilio_ubicacion, telefono, email) values ('{0}','{1}','{2}', '{3}','{4}','{5}');",
                    proveedor.RFC, proveedor.nombre_empresa, proveedor.domicilio_fiscal, proveedor.domicilio_ubicacion, proveedor.telefono, proveedor.email), false);
                Conexion.conectar.Close();
                return "Agregado";
            }
            catch (Exception e)
            {
                Conexion.conectar.Close();
                return e.Message;
            }
        }

        public static List<ProveedoresClass> Read(string dato)
        {
            List<ProveedoresClass> proveedores = new List<ProveedoresClass>();
            if (Conexion.Consulta("select id, RFC, nombre_empresa, domicilio_fiscal, domicilio_ubicacion, " +
                " telefono, email  from proveedores where RFC like '%" + dato + "%' or nombre_empresa " +
                " like '%" + dato + "%' or domicilio_fiscal  like '%" + dato + "%' or email like '%" + dato +
                "%' or telefono like '%" + dato + "%';", true) != "Sin retorno")
            {
                while (Conexion.datos.Read())
                {
                    proveedores.Add(new ProveedoresClass(Conexion.datos.GetInt32(0), Conexion.datos.GetString(1), Conexion.datos.GetString(2),
                        Conexion.datos.GetString(3), Conexion.datos.GetString(4), Conexion.datos.GetInt64(5), Conexion.datos.GetString(6)));
                }
            }
            
            Conexion.conectar.Close();
            return proveedores;
        }

        public static string Update(ProveedoresClass proveedor, int id)
        {
            try
            {
                Conexion.Consulta(string.Format("update proveedores set RFC = '{0}', nombre_empresa  =  '{1}', domicilio_fiscal  =  '{2}', domicilio_ubicacion  =  '{3}', telefono  =  '{4}', email  =  '{5}'  where id = '{6}';",
                    proveedor.RFC, proveedor.nombre_empresa, proveedor.domicilio_fiscal, proveedor.domicilio_ubicacion, proveedor.telefono, proveedor.email, id), false);
                Conexion.conectar.Close();
                return "Modificado";
            }
            catch (Exception e)
            {
                Conexion.conectar.Close();
                return e.Message;
            }
        }

        public static string Delete(int descripcion)
        {
            try
            {
                Conexion.Consulta("delete from proveedores  where id like '" + descripcion + "'", false);
                Conexion.conectar.Close();
                return "Borrado";
            }
            catch (Exception e)
            {
                Conexion.conectar.Close();
                return e.Message;
            }
        }

    }
}
