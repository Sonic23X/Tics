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
    public partial class Menu : Form
    {
        public Menu()
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
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Login FrmLogin = new Login();
                FrmLogin.Show();
                this.Hide();
            }
        }

        private void pbxInventario_Click(object sender, EventArgs e)
        {
            Inventario FrmInventario = new Inventario();
            FrmInventario.Show();
            this.Hide();
        }

        private void pbxProyectos_Click(object sender, EventArgs e)
        {
            Proyectos FrmProyectos = new Proyectos();
            FrmProyectos.Show();
            this.Hide();
        }

        private void pbxClientes_Click(object sender, EventArgs e)
        {
            Clientes FrmClientes = new Clientes();
            FrmClientes.Show();
            this.Hide();
        }

        private void pbxProveedores_Click(object sender, EventArgs e)
        {
            Proveedores FrmProveedores = new Proveedores();
            FrmProveedores.Show();
            this.Hide();
        }

        private void pbxEmpleados_Click(object sender, EventArgs e)
        {
            Empleados FrmEmpleados = new Empleados();
            FrmEmpleados.Show();
            this.Hide();
        }
    }
}
