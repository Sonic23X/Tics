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
    public partial class ListaProveedores : Form
    {
        InventarioCRUD inventarioCRUD;
        String idProveedor;

        public delegate void EnviarDatos(string datos);
        public event EnviarDatos datosProveedor;

        public ListaProveedores()
        {
            InitializeComponent();
            inventarioCRUD = new InventarioCRUD();
            dgvProveedores.MultiSelect = false;
            dgvProveedores.RowHeadersVisible = false;
            
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            inventarioCRUD.mostrarProveedores(dgvProveedores);

            dgvProveedores.Columns[0].HeaderText = "ID Provedor";
            dgvProveedores.Columns[1].HeaderText = "Nombre Provedor";

            dgvProveedores.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inventarioCRUD.buscarProveedor(txtBuscar.Text, dgvProveedores);
            }
            catch { }
            
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvProveedores.Rows[index];

                idProveedor = row.Cells[0].Value.ToString();

            }
            catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datosProveedor(idProveedor);
                this.Close();
            }
            catch { }
            
        }
    }
}
