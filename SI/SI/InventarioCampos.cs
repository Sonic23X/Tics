using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI
{
    public partial class InventarioCampos : Form
    {

        public string band { get; set; }
        InventarioModel inventario;
        InventarioCRUD crud;

        public InventarioCampos()
        {
            InitializeComponent();
            inventario = new InventarioModel();
            crud = new InventarioCRUD();
            dateCompra.Value = DateTime.Now;
        }

        private void InventarioCampos_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && !(char.IsPunctuation(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsSeparator(e.KeyChar));
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && !(char.IsPunctuation(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtMarca.Text != "" && cmbUnidades.Text != "" && cbxCategoria.Text != "" && txtProveedor.Text != "" && txtCompra.Text != "" && txtVenta.Text != "" && txtCantidad.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    crearDatos();

                    if (band == "UPDATE")
                    {
                        crud.actualizar(inventario);
                    }
                    else if (band == "NEW")
                    {
                        crud.nuevo(inventario);
                    }

                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ListaProveedores proveedores = new ListaProveedores();
            proveedores.datosProveedor += new ListaProveedores.EnviarDatos(RecepcionProveedor);
            proveedores.Show();
        }

        public void RecepcionProveedor(string datos)
        {
            txtProveedor.Text = datos;
        }

        public void crearDatos()
        {
            if (txtID.Text == "")
                txtID.Text = "0";

            inventario.id = Convert.ToInt32(txtID.Text);
            inventario.nombre = txtNombre.Text;
            inventario.marca = txtMarca.Text;
            inventario.fecha_compra = dateCompra.Text;
            inventario.unidad_medida = cmbUnidades.Text;
            inventario.categoria = cbxCategoria.Text;
            inventario.costo_compra = float.Parse(txtCompra.Text);
            inventario.costo_venta = float.Parse(txtVenta.Text);
            inventario.cantidad = float.Parse(txtCantidad.Text);
            inventario.idProveedores = Convert.ToInt32(txtProveedor.Text);
        }
    }
}
