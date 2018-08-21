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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        public int row = -1;

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
            try
            {
                if (tbxRFC.Text != "" || tbxNombreE.Text != "" || tbxDomicilioFiscal.Text != "" || tbxTelefono.Text != "" || tbxCorreo.Text != "" || tbxDomicilioU.Text != "")
                {
                    if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ProveedoresClass nuevoProveedor = new ProveedoresClass();
                        nuevoProveedor.RFC = tbxRFC.Text;
                        nuevoProveedor.nombre_empresa = tbxNombreE.Text;
                        nuevoProveedor.domicilio_fiscal = tbxDomicilioFiscal.Text;
                        nuevoProveedor.domicilio_ubicacion = tbxDomicilioU.Text;
                        nuevoProveedor.telefono = Convert.ToInt64(tbxTelefono.Text);
                        nuevoProveedor.email = tbxCorreo.Text;

                        MessageBox.Show(M_Proveedores.Create(nuevoProveedor));
                    }

                }
                else
                {
                    MessageBox.Show("Por favor ingresa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            if (tbxRFC.Text != "" || tbxNombreE.Text != "" || tbxDomicilioFiscal.Text != "" || tbxTelefono.Text != "" || tbxCorreo.Text != "" || tbxDomicilioU.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (row > -1)
                    {
                        ProveedoresClass nuevoProveedor = new ProveedoresClass();
                        nuevoProveedor.RFC = tbxRFC.Text;
                        nuevoProveedor.nombre_empresa = tbxNombreE.Text;
                        nuevoProveedor.domicilio_fiscal = tbxDomicilioFiscal.Text;
                        nuevoProveedor.domicilio_ubicacion = tbxDomicilioU.Text;
                        nuevoProveedor.telefono = Convert.ToInt64(tbxTelefono.Text);
                        nuevoProveedor.email = tbxCorreo.Text;

                        DataGridViewRow Fila = dgvPreveedores.Rows[row];
                        MessageBox.Show(M_Proveedores.Update(nuevoProveedor, Convert.ToInt32(Fila.Cells[0].Value.ToString())));
                    }
                    else
                    {
                        MessageBox.Show("Seleccione algun elemento a eliminar");
                    }
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
                if (row > -1)
                {
                    DataGridViewRow Fila = dgvPreveedores.Rows[row];
                    MessageBox.Show(M_Proveedores.Delete(Convert.ToInt32(Fila.Cells[0].Value.ToString())));
                    List<ProveedoresClass> listAux = M_Proveedores.Read(tbxBuscar.Text);
                    dgvPreveedores.DataSource = listAux;
                    row = -1;
                }
                else
                {
                    MessageBox.Show("Seleccione algun elemento a eliminar");
                }
            }
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            if(tbxBuscar.Text != "")
            {
                List<ProveedoresClass> listAux = M_Proveedores.Read(tbxBuscar.Text);                    
                dgvPreveedores.DataSource = listAux;
            }
            else
            {
                row = -1;
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

        private void dgvPreveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                row = e.RowIndex;
                DataGridViewRow fila = new DataGridViewRow();
                fila = this.dgvPreveedores.Rows[e.RowIndex];
                tbxRFC.Text = fila.Cells["RFC"].Value.ToString();
                tbxNombreE.Text = fila.Cells["nombre_empresa"].Value.ToString();
                tbxDomicilioFiscal.Text = fila.Cells["domicilio_fiscal"].Value.ToString();
                tbxDomicilioU.Text = fila.Cells["domicilio_ubicacion"].Value.ToString();
                tbxTelefono.Text = fila.Cells["telefono"].Value.ToString();
                tbxCorreo.Text = fila.Cells["email"].Value.ToString();
            }
            else
            {
                row = -1;
            }
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
