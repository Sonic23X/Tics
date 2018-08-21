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
    public partial class Empleados : Form
    {
        public Empleados()
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
            if (MessageBox.Show("¿Esta seguro de salir de esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Menu FrmMenu = new Menu();
                FrmMenu.Show();
                this.Hide();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                tbxNombre.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                tbxApellidos.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

            }
        }
        private void pbxEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

            }
        }

        private void pbxEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

            }
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                tbxTelefono.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxTelefono_KeyPress(sender, e);
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
