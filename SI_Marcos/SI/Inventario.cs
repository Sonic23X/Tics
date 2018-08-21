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
        public Inventario()
        {
            InitializeComponent();
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
                Menu FrmMenu = new Menu();
                FrmMenu.Show();
                this.Hide();
            }
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "" || tbxMarca.Text  != "" || tbxUnidad.Text != "" || cbxCategoria.Text != "" || cbxProveedor.Text != "" || tbxCCompra.Text != "" || tbxCVenta.Text != "" || tbxCantidad.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "" || tbxMarca.Text != "" || tbxUnidad.Text != "" || cbxCategoria.Text != "" || cbxProveedor.Text != "" || dateRegistro.Text != "" || dateCompra.Text != "" || tbxCCompra.Text != "" || tbxCVenta.Text != "" || tbxCantidad.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

            }
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (Char.IsNumber(e.KeyChar))
            {
                tbxNombre.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxCCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                tbxCCompra.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxCVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                tbxCVenta.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                tbxCantidad.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
