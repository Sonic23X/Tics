using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace SI
{
    class InventarioCRUD
    {
        MySqlConnection con = new MySqlConnection("SERVER=localhost; DATABASE=tics; UID=root; PASSWORD=1234;");
        bool band = false;
        public InventarioCRUD()
        {
        }

        public void nuevo(InventarioModel inventario)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO tics.inventario(nombre, marca, unidad_medida, categoria, fecha_compra, costo_compra, costo_venta, cantidad, idProveedores)" +
                    "VALUES ('" + inventario.nombre +
                    "','" + inventario.marca +
                    "','" + inventario.unidad_medida +
                    "','" + inventario.categoria +
                    "','" + inventario.fecha_compra +
                    "'," + inventario.costo_compra +
                    "," + inventario.costo_venta +
                    "," + inventario.cantidad + 
                    "," + inventario.idProveedores + ");";

                MySqlCommand cm = new MySqlCommand(query, con);

                cm.ExecuteNonQuery();

                MessageBox.Show("Registro Exitoso");
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }

        public void buscar(String keyword, DataGridView grid)
        {
            try
            {
                string query = "SELECT id, nombre, marca, unidad_medida, categoria, fecha_compra, costo_compra, costo_venta, cantidad, idProveedores FROM tics.inventario WHERE nombre LIKE CONCAT('" + keyword + "', '%') AND estatus = '1';";
                MySqlCommand cm = new MySqlCommand(query, con);

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cm);
                DataTable dtDatos = new DataTable();

                mdaDatos.Fill(dtDatos);

                grid.DataSource = dtDatos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void eliminar(InventarioModel inventario)
        {
            try
            {
                con.Open();

                string query = "UPDATE tics.inventario SET estatus = '0' WHERE id =" + inventario.id + ";";

                MySqlCommand cm = new MySqlCommand(query, con);

                cm.ExecuteNonQuery();

                MessageBox.Show("Eliminación Exitosa");
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void actualizar(InventarioModel inventario)
        {
            try
            {
                con.Open();

                string query = "UPDATE tics.inventario " +
                    "SET nombre = '" + inventario.nombre + "', " +
                    "marca = '" + inventario.marca + "', " +
                    "unidad_medida = '" + inventario.unidad_medida + "', " +
                    "categoria = '" + inventario.categoria + "', " +
                    "fecha_compra = '" + inventario.fecha_compra + "', " +
                    "costo_compra = " + inventario.costo_compra + ", " +
                    "costo_venta = " + inventario.costo_venta + ", " +
                    "cantidad = " + inventario.cantidad + ", " +
                    "idProveedores = " + inventario.idProveedores + " WHERE id = " + inventario.id + ";";

                MessageBox.Show(query);
                MySqlCommand cm = new MySqlCommand(query, con);

                cm.ExecuteNonQuery();

                MessageBox.Show("Actualizacion Exitosa");
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void mostrar(DataGridView grid)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand("SELECT id, nombre, marca, unidad_medida, categoria, fecha_compra, costo_compra, costo_venta, cantidad, idProveedores FROM tics.inventario WHERE estatus = '1';", con);

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cm);
                DataTable dtDatos = new DataTable();

                mdaDatos.Fill(dtDatos);

                grid.DataSource = dtDatos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error en Mostrar");
            }
            
        }

        public void mostrarProveedores(DataGridView grid)
        {
            try
            {
                string query = "SELECT id, nombre_empresa FROM tics.proveedores;";
                MySqlCommand cm = new MySqlCommand(query,con);

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cm);
                DataTable dtDatos = new DataTable();

                mdaDatos.Fill(dtDatos);

                grid.DataSource = dtDatos;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void buscarProveedor(String keyword, DataGridView grid)
        {
            try
            {
                string query = "SELECT id, nombre_empresa FROM tics.proveedores WHERE nombre_empresa LIKE  CONCAT('" + keyword + "', '%');";
                MySqlCommand cm = new MySqlCommand(query, con);

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cm);
                DataTable dtDatos = new DataTable();

                mdaDatos.Fill(dtDatos);

                grid.DataSource = dtDatos;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void abrir()
        {
            if (band == false)
            {
                con.Open();
                band = true;
            }
        }
    }
}
