namespace WinClientes
{
    partial class frmClientes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupboxDatos = new System.Windows.Forms.GroupBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.linkYoutube = new System.Windows.Forms.LinkLabel();
            this.linkBlog = new System.Windows.Forms.LinkLabel();
            this.barraTareas = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupboxDatos.SuspendLayout();
            this.barraTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(21, 134);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 175);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(21, 198);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(253, 26);
            this.dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 301);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 324);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(253, 87);
            this.txtDireccion.TabIndex = 10;
            // 
            // groupboxDatos
            // 
            this.groupboxDatos.Controls.Add(this.txtNroDocumento);
            this.groupboxDatos.Controls.Add(this.lblNroDocumento);
            this.groupboxDatos.Controls.Add(this.txtDireccion);
            this.groupboxDatos.Controls.Add(this.txtNombre);
            this.groupboxDatos.Controls.Add(this.dtpFechaNacimiento);
            this.groupboxDatos.Controls.Add(this.lblDireccion);
            this.groupboxDatos.Controls.Add(this.txtApellido);
            this.groupboxDatos.Controls.Add(this.lblApellido);
            this.groupboxDatos.Controls.Add(this.lblFecha);
            this.groupboxDatos.Controls.Add(this.lblNombre);
            this.groupboxDatos.Location = new System.Drawing.Point(16, 44);
            this.groupboxDatos.Name = "groupboxDatos";
            this.groupboxDatos.Size = new System.Drawing.Size(295, 452);
            this.groupboxDatos.TabIndex = 11;
            this.groupboxDatos.TabStop = false;
            this.groupboxDatos.Text = "Datos Personales";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(21, 259);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(253, 26);
            this.txtNroDocumento.TabIndex = 12;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(17, 237);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(143, 20);
            this.lblNroDocumento.TabIndex = 11;
            this.lblNroDocumento.Text = "Nro de Documento";
            // 
            // linkYoutube
            // 
            this.linkYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkYoutube.AutoSize = true;
            this.linkYoutube.LinkColor = System.Drawing.Color.Black;
            this.linkYoutube.Location = new System.Drawing.Point(1053, 9);
            this.linkYoutube.Name = "linkYoutube";
            this.linkYoutube.Size = new System.Drawing.Size(141, 20);
            this.linkYoutube.TabIndex = 12;
            this.linkYoutube.TabStop = true;
            this.linkYoutube.Text = "Canal de YouTube";
            this.linkYoutube.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkBlog
            // 
            this.linkBlog.AutoSize = true;
            this.linkBlog.BackColor = System.Drawing.SystemColors.Control;
            this.linkBlog.LinkColor = System.Drawing.Color.Black;
            this.linkBlog.Location = new System.Drawing.Point(12, 9);
            this.linkBlog.Name = "linkBlog";
            this.linkBlog.Size = new System.Drawing.Size(71, 20);
            this.linkBlog.TabIndex = 13;
            this.linkBlog.TabStop = true;
            this.linkBlog.Text = "Ir al Blog";
            this.linkBlog.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // barraTareas
            // 
            this.barraTareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraTareas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraTareas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnCancelar,
            this.toolStripSeparator5,
            this.btnBuscar,
            this.toolStripSeparator4,
            this.btnEliminar});
            this.barraTareas.Location = new System.Drawing.Point(0, 519);
            this.barraTareas.Name = "barraTareas";
            this.barraTareas.Size = new System.Drawing.Size(1206, 38);
            this.barraTareas.TabIndex = 14;
            this.barraTareas.Text = "barraTareas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::WinClientes.Properties.Resources.agregar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 33);
            this.btnGuardar.Text = "Nuevo";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::WinClientes.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 33);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::WinClientes.Properties.Resources.buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::WinClientes.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 33);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(317, 44);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(877, 452);
            this.dgv.TabIndex = 15;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinClientes.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 557);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.barraTareas);
            this.Controls.Add(this.linkBlog);
            this.Controls.Add(this.linkYoutube);
            this.Controls.Add(this.groupboxDatos);
            this.Name = "frmClientes";
            this.Text = "Administración de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupboxDatos.ResumeLayout(false);
            this.groupboxDatos.PerformLayout();
            this.barraTareas.ResumeLayout(false);
            this.barraTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox groupboxDatos;
        private System.Windows.Forms.LinkLabel linkYoutube;
        private System.Windows.Forms.LinkLabel linkBlog;
        private System.Windows.Forms.ToolStrip barraTareas;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
    }
}

