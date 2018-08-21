using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SI
{
    public partial class Inventario : Form
    {
        private Conexion conexion;
        InventarioCRUD inventarioCRUD = new InventarioCRUD();
        InventarioModel inventario;
        public Inventario()
        {
            InitializeComponent();
            conexion = new Conexion();
            inventario = new InventarioModel();
            inventarioCRUD.mostrar(dgvInventario);
        } 

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbxRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
              /*  Menu FrmMenu = new Menu();
                FrmMenu.Show();
                this.Hide();*/
            }
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            InventarioCampos campos = new InventarioCampos();
            campos.band = "NEW";

            campos.Show();
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            InventarioCampos campos = new InventarioCampos();
            campos.band = "UPDATE";

            campos.txtID.Text = inventario.id.ToString();
            campos.txtNombre.Text = inventario.nombre;
            campos.txtMarca.Text = inventario.marca;
            campos.dateCompra.Text = inventario.fecha_compra;
            campos.cmbUnidades.Text = inventario.unidad_medida;
            campos.cbxCategoria.Text = inventario.categoria;
            campos.txtProveedor.Text = inventario.idProveedores.ToString();
            campos.txtCompra.Text = inventario.costo_compra.ToString();
            campos.txtVenta.Text = inventario.costo_venta.ToString();
            campos.txtCantidad.Text = inventario.cantidad.ToString();

            campos.Show();
        }

        private void pbxEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                inventarioCRUD.eliminar(inventario);
                inventarioCRUD.mostrar(dgvInventario);
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            try
            {
                inventarioCRUD.mostrar(dgvInventario);

                dgvInventario.Columns[0].HeaderText = "ID Material";
                dgvInventario.Columns[1].HeaderText = "Nombre";
                dgvInventario.Columns[2].HeaderText = "Marca";
                dgvInventario.Columns[3].HeaderText = "Unidad de Medida";
                dgvInventario.Columns[4].HeaderText = "Categoria";
                dgvInventario.Columns[5].HeaderText = "Fecha Compra";
                dgvInventario.Columns[6].HeaderText = "Costo Compra";
                dgvInventario.Columns[7].HeaderText = "Costo Venta";
                dgvInventario.Columns[8].HeaderText = "Cantidad";
                dgvInventario.Columns[9].HeaderText = "ID Provedor";

                dgvInventario.ClearSelection();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvInventario.Rows[index];

                inventario.id = Convert.ToInt32(row.Cells[0].Value.ToString());
                inventario.nombre = row.Cells[1].Value.ToString();
                inventario.marca = row.Cells[2].Value.ToString();
                inventario.unidad_medida = row.Cells[3].Value.ToString();
                inventario.categoria = row.Cells[4].Value.ToString();
                inventario.fecha_compra = row.Cells[5].Value.ToString();
                inventario.costo_compra = float.Parse(row.Cells[6].Value.ToString());
                inventario.costo_venta = float.Parse(row.Cells[7].Value.ToString());
                inventario.cantidad = float.Parse(row.Cells[8].Value.ToString());
                inventario.idProveedores = Convert.ToInt32(row.Cells[9].Value.ToString());
            }
            catch { }
            

            
            /*
            txtID.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtMarca.Text = row.Cells[2].Value.ToString();
            txtUnidad.Text = row.Cells[3].Value.ToString();
            cbxCategoria.Text = row.Cells[4].Value.ToString();
            dateCompra.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            txtCompra.Text = row.Cells[6].Value.ToString();
            txtVenta.Text = row.Cells[7].Value.ToString();
            txtCantidad.Text = row.Cells[8].Value.ToString();
            txtProveedor.Text = row.Cells[9].Value.ToString();
            */
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            inventarioCRUD.buscar(txtBuscar.Text, dgvInventario);
        }

    }
}
