namespace SI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbxContrasena = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.pbxContraseña = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxContrasena
            // 
            this.tbxContrasena.BackColor = System.Drawing.Color.DarkGray;
            this.tbxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContrasena.ForeColor = System.Drawing.Color.Black;
            this.tbxContrasena.Location = new System.Drawing.Point(186, 330);
            this.tbxContrasena.Multiline = true;
            this.tbxContrasena.Name = "tbxContrasena";
            this.tbxContrasena.PasswordChar = '*';
            this.tbxContrasena.Size = new System.Drawing.Size(223, 28);
            this.tbxContrasena.TabIndex = 2;
            this.tbxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(186, 383);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(223, 40);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.tbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.ForeColor = System.Drawing.Color.Black;
            this.tbxUsuario.Location = new System.Drawing.Point(186, 283);
            this.tbxUsuario.Multiline = true;
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(223, 28);
            this.tbxUsuario.TabIndex = 1;
            this.tbxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Ingresa el usuario";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(175, 97);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(245, 166);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(128, 279);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(32, 32);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxUsuario.TabIndex = 9;
            this.pbxUsuario.TabStop = false;
            this.pbxUsuario.Click += new System.EventHandler(this.pbxUsuario_Click);
            // 
            // pbxContraseña
            // 
            this.pbxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pbxContraseña.Image")));
            this.pbxContraseña.Location = new System.Drawing.Point(128, 326);
            this.pbxContraseña.Name = "pbxContraseña";
            this.pbxContraseña.Size = new System.Drawing.Size(32, 32);
            this.pbxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxContraseña.TabIndex = 10;
            this.pbxContraseña.TabStop = false;
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbxCerrar.Image")));
            this.pbxCerrar.Location = new System.Drawing.Point(556, 12);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCerrar.TabIndex = 11;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIniciarSesion.Location = new System.Drawing.Point(140, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(321, 57);
            this.lblIniciarSesion.TabIndex = 12;
            this.lblIniciarSesion.Text = "Iniciar Sesion";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIniciarSesion.Enabled = false;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(600, 60);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.pbxCerrar);
            this.Controls.Add(this.pbxContraseña);
            this.Controls.Add(this.pbxUsuario);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.tbxContrasena);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxContrasena;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.PictureBox pbxContraseña;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}

