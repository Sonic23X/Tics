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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            toolTip1.SetToolTip(tbxUsuario, "Ingresa el usuario");
            toolTip1.SetToolTip(tbxContrasena, "Ingresa la contraseña");
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Menu FrmMenu = new Menu();
            FrmMenu.Show();
            this.Hide();
            /*if (tbxUsuario.Text != "" && tbxContrasena.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos", "Error");
            }*/
        }

        private void pbxUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
