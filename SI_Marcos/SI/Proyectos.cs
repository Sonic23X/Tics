using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SI
{
    public partial class Proyectos : Form
    {
        public Proyectos()
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
            if (tbxProyecto.Text != "" && tbxDescripcion.Text != "" && cb_cliente.SelectedItem.ToString() != "" && comBox_supervisor.SelectedItem.ToString() != "" && comBox_responsable.SelectedItem.ToString() != "" && cbxServicio.SelectedItem.ToString() != "" && tbxFolio.Text != "" && tbxInversión.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Proyecto newProyecto = new Proyecto();
                    newProyecto.Proyecto_name = tbxProyecto.Text;
                    newProyecto.Descripcion = tbxDescripcion.Text;
                    newProyecto.Cliente = ((KeyValuePair<int,string>)cb_cliente.SelectedItem).Key;
                    newProyecto.Supervisor = ((KeyValuePair<int, string>)comBox_supervisor.SelectedItem).Key;
                    newProyecto.Responsable = ((KeyValuePair<int, string>)comBox_responsable.SelectedItem).Key;
                    newProyecto.Tipo_servicio = cbxServicio.SelectedItem.ToString();
                    newProyecto.Folio_volumetria = tbxFolio.Text;
                    newProyecto.Costo_inversion = float.Parse( tbxInversión.Text);
                    newProyecto.Fecha_inicio = dateInicio.Value.ToString("yyyy-MM-dd");
                    newProyecto.Fecha_asignacion = dateAsignación.Value.ToString("yyyy-MM-dd");
                    newProyecto.Fecha_cierre = dateCierre.Value.ToString("yyyy-MM-dd");
                    //yyyy-MM-dd
                    string resultado = Crud_Proyectos.insertarNuevo(newProyecto);

                    MessageBox.Show(resultado);

                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            if (tbxProyecto.Text != "" || tbxDescripcion.Text != "" || cb_cliente.Text != "" || comBox_supervisor.Text != "" || comBox_responsable.Text != "" || cbxServicio.Text != "" || tbxFolio.Text != "" || tbxInversión.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de realizar este cambio?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    Proyecto newProyecto = new Proyecto();
                    newProyecto.Id = Int16.Parse(lb_id.Text);
                    newProyecto.Proyecto_name = tbxProyecto.Text;
                    newProyecto.Descripcion = tbxDescripcion.Text;
                    newProyecto.Cliente = ((KeyValuePair<int, string>)cb_cliente.SelectedItem).Key;
                    newProyecto.Supervisor = ((KeyValuePair<int, string>)comBox_supervisor.SelectedItem).Key;
                    newProyecto.Responsable = ((KeyValuePair<int, string>)comBox_responsable.SelectedItem).Key;
                    newProyecto.Tipo_servicio = cbxServicio.SelectedItem.ToString();
                    newProyecto.Folio_volumetria = tbxFolio.Text;
                    newProyecto.Costo_inversion = float.Parse(tbxInversión.Text);
                    newProyecto.Fecha_inicio = dateInicio.Value.ToString("yyyy-MM-dd");
                    newProyecto.Fecha_asignacion = dateAsignación.Value.ToString("yyyy-MM-dd");
                    newProyecto.Fecha_cierre = dateCierre.Value.ToString("yyyy-MM-dd");

                    string resultado = Crud_Proyectos.ActualizarProyecto(newProyecto);

                    MessageBox.Show(resultado);


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
                if (dg_proyectos.SelectedRows.Count > 0 && Int16.Parse(lb_id.Text) > 0)
                {
                    string resultado = Crud_Proyectos.EliminarProyecto(Int16.Parse(lb_id.Text));
                    MessageBox.Show(resultado,"Info",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            if(tbxBuscar.Text != "")
            {
                List<Proyecto> listAux = Crud_Proyectos.Read(tbxBuscar.Text);
                dg_proyectos.DataSource = listAux;
            }
        }

        private void tbxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                cb_cliente.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                comBox_supervisor.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxInversión_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                tbxInversión.Text = " ";
                MessageBox.Show("¡Error! solo se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            /*List<Proyecto> proyectos = new List<Proyecto>();
            proyectos = Crud_Proyectos.getAll();

            DataGridViewRow row = new DataGridViewRow();
            Console.WriteLine("se esta ejecutando?"+ proyectos.Count);

            dg_proyectos.DataSource = proyectos;*/

            loadResponsables();
            loadClientes();
            loadSupervisor();
            loadTipoServicio();

        }

        private void loadTipoServicio()
        {
            cbxServicio.Items.Add("Inmediato");
            cbxServicio.Items.Add("Baja Prioridad");
        }

        private void loadResponsables()
        {
            Dictionary<int, string> comboSource = Crud_Proyectos.getEmpleados();

            if (comboSource.Count > 0)
            {
                comBox_responsable.DataSource = new BindingSource(comboSource, null);
            }   
        }

        private void loadSupervisor()
        {
            Dictionary<int, string> comboSourceSuper = Crud_Proyectos.getEmpleados();

            if (comboSourceSuper.Count > 0)
            {
                comBox_supervisor.DataSource = new BindingSource(comboSourceSuper, null);
            }
        }

        private void loadClientes()
        {
            Dictionary<int, string> comboSourceClientes = Crud_Proyectos.getClientes();

            if (comboSourceClientes.Count > 0)
            {
                cb_cliente.DataSource = new BindingSource(comboSourceClientes, null);
            }
        }

        private void dg_proyectos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //row = e.RowIndex;
                DataGridViewRow fila = new DataGridViewRow();
                fila = this.dg_proyectos.Rows[e.RowIndex];
                lb_id.Text = fila.Cells["id"].Value.ToString();
                tbxProyecto.Text = fila.Cells["Proyecto_name"].Value.ToString();
                tbxDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
                cb_cliente.Text = fila.Cells["clienteNom"].Value.ToString() + " " + fila.Cells["clienteApe"].Value.ToString();
                comBox_supervisor.Text = fila.Cells["superNom"].Value.ToString() + " " + fila.Cells["superApe"].Value.ToString();
                comBox_responsable.Text = fila.Cells["empleadoNom"].Value.ToString() + " " + fila.Cells["empleadoApe"].Value.ToString();
                cbxServicio.Text = fila.Cells["tipo_servicio"].Value.ToString();
                tbxFolio.Text = fila.Cells["folio_volumetria"].Value.ToString();
                tbxInversión.Text = fila.Cells["costo_inversion"].Value.ToString();

                //01/01/2018 12:00:00 a. m.
                string dateIni = fila.Cells["fecha_inicio"].Value.ToString();
                string dateAsig = fila.Cells["fecha_asignacion"].Value.ToString();
                string dateCie = fila.Cells["fecha_cierre"].Value.ToString();
                string dateNewInicio = dateIni.Substring(0, 10);
                string dateNewAsig = dateAsig.Substring(0, 10);
                string dateNewCie= dateCie.Substring(0, 10);


                DateTime dt = DateTime.ParseExact(dateNewInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtAsig = DateTime.ParseExact(dateNewAsig, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtCie = DateTime.ParseExact(dateNewCie, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dateInicio.Value = dt;
                dateAsignación.Value = dtAsig;
                dateCierre.Value = dtCie;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
