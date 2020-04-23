namespace WinProductos
{
    partial class frmProductos
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
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupboxDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
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
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(21, 330);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(253, 26);
            this.txtStock.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(17, 307);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 113);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(21, 136);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(253, 87);
            this.txtDescripcion.TabIndex = 10;
            // 
            // groupboxDatos
            // 
            this.groupboxDatos.Controls.Add(this.txtPrecio);
            this.groupboxDatos.Controls.Add(this.lblPrecio);
            this.groupboxDatos.Controls.Add(this.txtDescripcion);
            this.groupboxDatos.Controls.Add(this.txtNombre);
            this.groupboxDatos.Controls.Add(this.lblDescripcion);
            this.groupboxDatos.Controls.Add(this.txtStock);
            this.groupboxDatos.Controls.Add(this.lblStock);
            this.groupboxDatos.Controls.Add(this.lblNombre);
            this.groupboxDatos.Location = new System.Drawing.Point(16, 44);
            this.groupboxDatos.Name = "groupboxDatos";
            this.groupboxDatos.Size = new System.Drawing.Size(295, 452);
            this.groupboxDatos.TabIndex = 11;
            this.groupboxDatos.TabStop = false;
            this.groupboxDatos.Text = "Datos del Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(21, 260);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(253, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 237);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
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
            this.btnGuardar.Image = global::WinProductos.Properties.Resources.agregar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 29);
            this.btnGuardar.Text = "Nuevo";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::WinProductos.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 29);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::WinProductos.Properties.Resources.buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::WinProductos.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 29);
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinProductos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 557);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.barraTareas);
            this.Controls.Add(this.linkBlog);
            this.Controls.Add(this.linkYoutube);
            this.Controls.Add(this.groupboxDatos);
            this.Name = "frmProductos";
            this.Text = "Administración de Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
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
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
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
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}

