namespace SI
{
    partial class Proyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyectos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBox_supervisor = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.comBox_responsable = new System.Windows.Forms.ComboBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.tbxFolio = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dateCierre = new System.Windows.Forms.DateTimePicker();
            this.dateAsignación = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFCierre = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tbxInversión = new System.Windows.Forms.TextBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblCInversion = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.tbxProyecto = new System.Windows.Forms.TextBox();
            this.lblFAsignacion = new System.Windows.Forms.Label();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.cbxServicio = new System.Windows.Forms.ComboBox();
            this.dg_proyectos = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pbxBuscar = new System.Windows.Forms.PictureBox();
            this.pbxEliminar = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxGuardar = new System.Windows.Forms.PictureBox();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            this.lb_idProyecto = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_proyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.lb_idProyecto);
            this.groupBox1.Controls.Add(this.comBox_supervisor);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.comBox_responsable);
            this.groupBox1.Controls.Add(this.lblFolio);
            this.groupBox1.Controls.Add(this.tbxFolio);
            this.groupBox1.Controls.Add(this.tbxDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.dateCierre);
            this.groupBox1.Controls.Add(this.dateAsignación);
            this.groupBox1.Controls.Add(this.dateInicio);
            this.groupBox1.Controls.Add(this.lblFCierre);
            this.groupBox1.Controls.Add(this.lblResponsable);
            this.groupBox1.Controls.Add(this.lblProyecto);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.tbxInversión);
            this.groupBox1.Controls.Add(this.lblSupervisor);
            this.groupBox1.Controls.Add(this.lblCInversion);
            this.groupBox1.Controls.Add(this.lblServicio);
            this.groupBox1.Controls.Add(this.tbxProyecto);
            this.groupBox1.Controls.Add(this.lblFAsignacion);
            this.groupBox1.Controls.Add(this.lblFInicio);
            this.groupBox1.Controls.Add(this.cbxServicio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(803, 473);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proyecto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comBox_supervisor
            // 
            this.comBox_supervisor.FormattingEnabled = true;
            this.comBox_supervisor.Location = new System.Drawing.Point(29, 300);
            this.comBox_supervisor.Name = "comBox_supervisor";
            this.comBox_supervisor.Size = new System.Drawing.Size(333, 31);
            this.comBox_supervisor.TabIndex = 40;
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(28, 232);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(333, 31);
            this.cb_cliente.TabIndex = 39;
            // 
            // comBox_responsable
            // 
            this.comBox_responsable.FormattingEnabled = true;
            this.comBox_responsable.Location = new System.Drawing.Point(28, 370);
            this.comBox_responsable.Name = "comBox_responsable";
            this.comBox_responsable.Size = new System.Drawing.Size(333, 31);
            this.comBox_responsable.TabIndex = 38;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(423, 27);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(174, 23);
            this.lblFolio.TabIndex = 36;
            this.lblFolio.Text = "Folio Volumetría:";
            // 
            // tbxFolio
            // 
            this.tbxFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFolio.Location = new System.Drawing.Point(428, 57);
            this.tbxFolio.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFolio.Name = "tbxFolio";
            this.tbxFolio.Size = new System.Drawing.Size(332, 32);
            this.tbxFolio.TabIndex = 37;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(28, 165);
            this.tbxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(332, 32);
            this.tbxDescripcion.TabIndex = 35;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(24, 129);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(128, 23);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // dateCierre
            // 
            this.dateCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCierre.Location = new System.Drawing.Point(428, 252);
            this.dateCierre.Margin = new System.Windows.Forms.Padding(4);
            this.dateCierre.Name = "dateCierre";
            this.dateCierre.Size = new System.Drawing.Size(332, 32);
            this.dateCierre.TabIndex = 33;
            this.dateCierre.Value = new System.DateTime(2018, 7, 9, 2, 22, 20, 0);
            // 
            // dateAsignación
            // 
            this.dateAsignación.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAsignación.Location = new System.Drawing.Point(428, 190);
            this.dateAsignación.Margin = new System.Windows.Forms.Padding(4);
            this.dateAsignación.Name = "dateAsignación";
            this.dateAsignación.Size = new System.Drawing.Size(332, 32);
            this.dateAsignación.TabIndex = 32;
            this.dateAsignación.Value = new System.DateTime(2018, 7, 9, 2, 22, 20, 0);
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInicio.Location = new System.Drawing.Point(428, 123);
            this.dateInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(332, 32);
            this.dateInicio.TabIndex = 31;
            this.dateInicio.Value = new System.DateTime(2018, 7, 9, 2, 22, 20, 0);
            // 
            // lblFCierre
            // 
            this.lblFCierre.AutoSize = true;
            this.lblFCierre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCierre.Location = new System.Drawing.Point(423, 226);
            this.lblFCierre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFCierre.Name = "lblFCierre";
            this.lblFCierre.Size = new System.Drawing.Size(173, 23);
            this.lblFCierre.TabIndex = 27;
            this.lblFCierre.Text = "Fecha de Cierre:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(25, 334);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(141, 23);
            this.lblResponsable.TabIndex = 25;
            this.lblResponsable.Text = "Responsable:";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(25, 66);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(103, 23);
            this.lblProyecto.TabIndex = 2;
            this.lblProyecto.Text = "Proyecto:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(24, 204);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(84, 23);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // tbxInversión
            // 
            this.tbxInversión.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInversión.Location = new System.Drawing.Point(601, 311);
            this.tbxInversión.Margin = new System.Windows.Forms.Padding(4);
            this.tbxInversión.Name = "tbxInversión";
            this.tbxInversión.Size = new System.Drawing.Size(159, 32);
            this.tbxInversión.TabIndex = 15;
            this.tbxInversión.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInversión_KeyPress);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(24, 266);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(113, 23);
            this.lblSupervisor.TabIndex = 4;
            this.lblSupervisor.Text = "Supervisor:";
            // 
            // lblCInversion
            // 
            this.lblCInversion.AutoSize = true;
            this.lblCInversion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCInversion.Location = new System.Drawing.Point(423, 319);
            this.lblCInversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCInversion.Name = "lblCInversion";
            this.lblCInversion.Size = new System.Drawing.Size(163, 23);
            this.lblCInversion.TabIndex = 14;
            this.lblCInversion.Text = "Costo Inversión:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(24, 404);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(166, 23);
            this.lblServicio.TabIndex = 5;
            this.lblServicio.Text = "Tipo de Servicio:";
            // 
            // tbxProyecto
            // 
            this.tbxProyecto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProyecto.Location = new System.Drawing.Point(28, 93);
            this.tbxProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.tbxProyecto.Name = "tbxProyecto";
            this.tbxProyecto.Size = new System.Drawing.Size(332, 32);
            this.tbxProyecto.TabIndex = 6;
            // 
            // lblFAsignacion
            // 
            this.lblFAsignacion.AutoSize = true;
            this.lblFAsignacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFAsignacion.Location = new System.Drawing.Point(423, 160);
            this.lblFAsignacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFAsignacion.Name = "lblFAsignacion";
            this.lblFAsignacion.Size = new System.Drawing.Size(222, 23);
            this.lblFAsignacion.TabIndex = 12;
            this.lblFAsignacion.Text = "Fecha de Asignación:";
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicio.Location = new System.Drawing.Point(423, 94);
            this.lblFInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(165, 23);
            this.lblFInicio.TabIndex = 10;
            this.lblFInicio.Text = "Fecha de Inicio:";
            // 
            // cbxServicio
            // 
            this.cbxServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServicio.FormattingEnabled = true;
            this.cbxServicio.Location = new System.Drawing.Point(28, 431);
            this.cbxServicio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Size = new System.Drawing.Size(332, 31);
            this.cbxServicio.TabIndex = 9;
            // 
            // dg_proyectos
            // 
            this.dg_proyectos.AllowUserToAddRows = false;
            this.dg_proyectos.AllowUserToDeleteRows = false;
            this.dg_proyectos.AllowUserToOrderColumns = true;
            this.dg_proyectos.AllowUserToResizeColumns = false;
            this.dg_proyectos.AllowUserToResizeRows = false;
            this.dg_proyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_proyectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dg_proyectos.BackgroundColor = System.Drawing.Color.White;
            this.dg_proyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_proyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_proyectos.Location = new System.Drawing.Point(13, 600);
            this.dg_proyectos.Margin = new System.Windows.Forms.Padding(4);
            this.dg_proyectos.MultiSelect = false;
            this.dg_proyectos.Name = "dg_proyectos";
            this.dg_proyectos.ReadOnly = true;
            this.dg_proyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_proyectos.Size = new System.Drawing.Size(901, 217);
            this.dg_proyectos.TabIndex = 39;
            this.dg_proyectos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_proyectos_CellContentDoubleClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(33, 569);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(173, 23);
            this.lblBuscar.TabIndex = 37;
            this.lblBuscar.Text = "Buscar Proyecto:";
            // 
            // pbxBuscar
            // 
            this.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbxBuscar.Image")));
            this.pbxBuscar.Location = new System.Drawing.Point(783, 543);
            this.pbxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxBuscar.Name = "pbxBuscar";
            this.pbxBuscar.Size = new System.Drawing.Size(53, 49);
            this.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscar.TabIndex = 43;
            this.pbxBuscar.TabStop = false;
            // 
            // pbxEliminar
            // 
            this.pbxEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbxEliminar.Image")));
            this.pbxEliminar.Location = new System.Drawing.Point(837, 368);
            this.pbxEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxEliminar.Name = "pbxEliminar";
            this.pbxEliminar.Size = new System.Drawing.Size(80, 74);
            this.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEliminar.TabIndex = 42;
            this.pbxEliminar.TabStop = false;
            this.pbxEliminar.Click += new System.EventHandler(this.pbxEliminar_Click);
            // 
            // pbxEditar
            // 
            this.pbxEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbxEditar.Image")));
            this.pbxEditar.Location = new System.Drawing.Point(837, 257);
            this.pbxEditar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(80, 74);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 41;
            this.pbxEditar.TabStop = false;
            this.pbxEditar.Click += new System.EventHandler(this.pbxEditar_Click);
            // 
            // pbxGuardar
            // 
            this.pbxGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbxGuardar.Image")));
            this.pbxGuardar.Location = new System.Drawing.Point(837, 143);
            this.pbxGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxGuardar.Name = "pbxGuardar";
            this.pbxGuardar.Size = new System.Drawing.Size(80, 74);
            this.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGuardar.TabIndex = 40;
            this.pbxGuardar.TabStop = false;
            this.pbxGuardar.Click += new System.EventHandler(this.pbxGuardar_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscar.Location = new System.Drawing.Point(214, 560);
            this.tbxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(549, 32);
            this.tbxBuscar.TabIndex = 34;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProyectos.Font = new System.Drawing.Font("Century Gothic", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProyectos.Location = new System.Drawing.Point(120, 0);
            this.lblProyectos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(649, 72);
            this.lblProyectos.TabIndex = 46;
            this.lblProyectos.Text = "Registro de Proyectos";
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(875, 15);
            this.pbxCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCerrar.TabIndex = 45;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProyectos.Enabled = false;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Location = new System.Drawing.Point(0, 0);
            this.btnProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(933, 74);
            this.btnProyectos.TabIndex = 47;
            this.btnProyectos.UseVisualStyleBackColor = false;
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRegresar.Image = ((System.Drawing.Image)(resources.GetObject("pbxRegresar.Image")));
            this.pbxRegresar.Location = new System.Drawing.Point(16, 15);
            this.pbxRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(43, 39);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 48;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // lb_idProyecto
            // 
            this.lb_idProyecto.AutoSize = true;
            this.lb_idProyecto.Location = new System.Drawing.Point(25, 29);
            this.lb_idProyecto.Name = "lb_idProyecto";
            this.lb_idProyecto.Size = new System.Drawing.Size(167, 23);
            this.lb_idProyecto.TabIndex = 41;
            this.lb_idProyecto.Text = "ID del Proyecto:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(198, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 23);
            this.lb_id.TabIndex = 42;
            this.lb_id.Text = "0";
            this.lb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 830);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.pbxCerrar);
            this.Controls.Add(this.btnProyectos);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.pbxBuscar);
            this.Controls.Add(this.pbxEliminar);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxGuardar);
            this.Controls.Add(this.dg_proyectos);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Proyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Proyectos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_proyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFCierre;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbxInversión;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblCInversion;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox tbxProyecto;
        private System.Windows.Forms.Label lblFAsignacion;
        private System.Windows.Forms.Label lblFInicio;
        private System.Windows.Forms.ComboBox cbxServicio;
        private System.Windows.Forms.DateTimePicker dateCierre;
        private System.Windows.Forms.DateTimePicker dateAsignación;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DataGridView dg_proyectos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox pbxBuscar;
        private System.Windows.Forms.PictureBox pbxEliminar;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxGuardar;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.PictureBox pbxRegresar;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox tbxFolio;
        private System.Windows.Forms.ComboBox comBox_responsable;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox comBox_supervisor;
        private System.Windows.Forms.Label lb_idProyecto;
        private System.Windows.Forms.Label lb_id;
    }
}