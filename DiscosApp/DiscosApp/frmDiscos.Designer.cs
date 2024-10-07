namespace DiscosApp
{
    partial class frmDiscos
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltrarAvanzado = new System.Windows.Forms.TextBox();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.picBxDisco = new System.Windows.Forms.PictureBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.grpBxBotones = new System.Windows.Forms.GroupBox();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpBxFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.grpBxDetalleDisco = new System.Windows.Forms.GroupBox();
            this.txtActivoDet = new System.Windows.Forms.TextBox();
            this.txtTipoEdicionDet = new System.Windows.Forms.TextBox();
            this.txtEstiloDet = new System.Windows.Forms.TextBox();
            this.txtURLDet = new System.Windows.Forms.TextBox();
            this.txtIFechaLanzamientoDet = new System.Windows.Forms.TextBox();
            this.txtCantidadCancionesDet = new System.Windows.Forms.TextBox();
            this.txtTituloDet = new System.Windows.Forms.TextBox();
            this.txtIDDet = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDisco)).BeginInit();
            this.grpBxBotones.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            this.grpBxFiltroAvanzado.SuspendLayout();
            this.grpBxDetalleDisco.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AllowUserToAddRows = false;
            this.dgvDiscos.AllowUserToDeleteRows = false;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(111, 72);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.ReadOnly = true;
            this.dgvDiscos.Size = new System.Drawing.Size(245, 258);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(9, 60);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(9, 100);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 3;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(34, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarAvanzado
            // 
            this.txtFiltrarAvanzado.Location = new System.Drawing.Point(461, 19);
            this.txtFiltrarAvanzado.Name = "txtFiltrarAvanzado";
            this.txtFiltrarAvanzado.Size = new System.Drawing.Size(106, 20);
            this.txtFiltrarAvanzado.TabIndex = 6;
            this.txtFiltrarAvanzado.TextChanged += new System.EventHandler(this.txtFiltrarAvanzado_TextChanged);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(125, 19);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar.TabIndex = 7;
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(159, 19);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 8;
            // 
            // picBxDisco
            // 
            this.picBxDisco.Location = new System.Drawing.Point(362, 72);
            this.picBxDisco.Name = "picBxDisco";
            this.picBxDisco.Size = new System.Drawing.Size(205, 258);
            this.picBxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDisco.TabIndex = 9;
            this.picBxDisco.TabStop = false;
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(23, 19);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 10;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // grpBxBotones
            // 
            this.grpBxBotones.Controls.Add(this.btnEliminar);
            this.grpBxBotones.Controls.Add(this.btnAgregar);
            this.grpBxBotones.Controls.Add(this.btnEditar);
            this.grpBxBotones.Controls.Add(this.btnInactivar);
            this.grpBxBotones.Location = new System.Drawing.Point(12, 108);
            this.grpBxBotones.Name = "grpBxBotones";
            this.grpBxBotones.Size = new System.Drawing.Size(93, 183);
            this.grpBxBotones.TabIndex = 11;
            this.grpBxBotones.TabStop = false;
            this.grpBxBotones.Text = "Acciones";
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.btnFiltrar);
            this.grpBxFiltro.Controls.Add(this.txtFiltrar);
            this.grpBxFiltro.Location = new System.Drawing.Point(12, 11);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(249, 55);
            this.grpBxFiltro.TabIndex = 12;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Busqueda";
            // 
            // grpBxFiltroAvanzado
            // 
            this.grpBxFiltroAvanzado.Controls.Add(this.txtFiltrarAvanzado);
            this.grpBxFiltroAvanzado.Controls.Add(this.cmbCampo);
            this.grpBxFiltroAvanzado.Controls.Add(this.cmbCriterio);
            this.grpBxFiltroAvanzado.Location = new System.Drawing.Point(276, 12);
            this.grpBxFiltroAvanzado.Name = "grpBxFiltroAvanzado";
            this.grpBxFiltroAvanzado.Size = new System.Drawing.Size(573, 54);
            this.grpBxFiltroAvanzado.TabIndex = 13;
            this.grpBxFiltroAvanzado.TabStop = false;
            this.grpBxFiltroAvanzado.Text = "Busqueda avanzada";
            // 
            // grpBxDetalleDisco
            // 
            this.grpBxDetalleDisco.Controls.Add(this.txtActivoDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtTipoEdicionDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtEstiloDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtURLDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtIFechaLanzamientoDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtCantidadCancionesDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtTituloDet);
            this.grpBxDetalleDisco.Controls.Add(this.txtIDDet);
            this.grpBxDetalleDisco.Controls.Add(this.lblActivo);
            this.grpBxDetalleDisco.Controls.Add(this.lblTipoEdicion);
            this.grpBxDetalleDisco.Controls.Add(this.lblEstilo);
            this.grpBxDetalleDisco.Controls.Add(this.lblURL);
            this.grpBxDetalleDisco.Controls.Add(this.lblFechaLanzamiento);
            this.grpBxDetalleDisco.Controls.Add(this.lblCantidadCanciones);
            this.grpBxDetalleDisco.Controls.Add(this.lblTitulo);
            this.grpBxDetalleDisco.Controls.Add(this.lblId);
            this.grpBxDetalleDisco.Location = new System.Drawing.Point(573, 72);
            this.grpBxDetalleDisco.Name = "grpBxDetalleDisco";
            this.grpBxDetalleDisco.Size = new System.Drawing.Size(276, 258);
            this.grpBxDetalleDisco.TabIndex = 14;
            this.grpBxDetalleDisco.TabStop = false;
            this.grpBxDetalleDisco.Text = "Detalle del Disco";
            // 
            // txtActivoDet
            // 
            this.txtActivoDet.Location = new System.Drawing.Point(75, 220);
            this.txtActivoDet.Name = "txtActivoDet";
            this.txtActivoDet.ReadOnly = true;
            this.txtActivoDet.Size = new System.Drawing.Size(88, 20);
            this.txtActivoDet.TabIndex = 15;
            // 
            // txtTipoEdicionDet
            // 
            this.txtTipoEdicionDet.Location = new System.Drawing.Point(75, 193);
            this.txtTipoEdicionDet.Name = "txtTipoEdicionDet";
            this.txtTipoEdicionDet.ReadOnly = true;
            this.txtTipoEdicionDet.Size = new System.Drawing.Size(195, 20);
            this.txtTipoEdicionDet.TabIndex = 14;
            // 
            // txtEstiloDet
            // 
            this.txtEstiloDet.Location = new System.Drawing.Point(75, 165);
            this.txtEstiloDet.Name = "txtEstiloDet";
            this.txtEstiloDet.ReadOnly = true;
            this.txtEstiloDet.Size = new System.Drawing.Size(195, 20);
            this.txtEstiloDet.TabIndex = 13;
            // 
            // txtURLDet
            // 
            this.txtURLDet.Location = new System.Drawing.Point(75, 138);
            this.txtURLDet.Name = "txtURLDet";
            this.txtURLDet.ReadOnly = true;
            this.txtURLDet.Size = new System.Drawing.Size(195, 20);
            this.txtURLDet.TabIndex = 12;
            // 
            // txtIFechaLanzamientoDet
            // 
            this.txtIFechaLanzamientoDet.Location = new System.Drawing.Point(75, 112);
            this.txtIFechaLanzamientoDet.Name = "txtIFechaLanzamientoDet";
            this.txtIFechaLanzamientoDet.ReadOnly = true;
            this.txtIFechaLanzamientoDet.Size = new System.Drawing.Size(195, 20);
            this.txtIFechaLanzamientoDet.TabIndex = 11;
            // 
            // txtCantidadCancionesDet
            // 
            this.txtCantidadCancionesDet.Location = new System.Drawing.Point(75, 85);
            this.txtCantidadCancionesDet.Name = "txtCantidadCancionesDet";
            this.txtCantidadCancionesDet.ReadOnly = true;
            this.txtCantidadCancionesDet.Size = new System.Drawing.Size(195, 20);
            this.txtCantidadCancionesDet.TabIndex = 10;
            // 
            // txtTituloDet
            // 
            this.txtTituloDet.Location = new System.Drawing.Point(75, 59);
            this.txtTituloDet.Name = "txtTituloDet";
            this.txtTituloDet.ReadOnly = true;
            this.txtTituloDet.Size = new System.Drawing.Size(195, 20);
            this.txtTituloDet.TabIndex = 9;
            // 
            // txtIDDet
            // 
            this.txtIDDet.Location = new System.Drawing.Point(75, 31);
            this.txtIDDet.Name = "txtIDDet";
            this.txtIDDet.ReadOnly = true;
            this.txtIDDet.Size = new System.Drawing.Size(88, 20);
            this.txtIDDet.TabIndex = 8;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(10, 223);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(40, 13);
            this.lblActivo.TabIndex = 7;
            this.lblActivo.Text = "Activo:";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(9, 196);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(51, 13);
            this.lblTipoEdicion.TabIndex = 6;
            this.lblTipoEdicion.Text = "Formato: ";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(9, 168);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 5;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(10, 141);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(10, 115);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(29, 13);
            this.lblFechaLanzamiento.TabIndex = 3;
            this.lblFechaLanzamiento.Text = "Año:";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(10, 88);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(60, 13);
            this.lblCantidadCanciones.TabIndex = 2;
            this.lblCantidadCanciones.Text = "Canciones:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(10, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 346);
            this.Controls.Add(this.grpBxDetalleDisco);
            this.Controls.Add(this.grpBxFiltroAvanzado);
            this.Controls.Add(this.picBxDisco);
            this.Controls.Add(this.dgvDiscos);
            this.Controls.Add(this.grpBxBotones);
            this.Controls.Add(this.grpBxFiltro);
            this.MaximizeBox = false;
            this.Name = "frmDiscos";
            this.Text = "Catalogo de Discos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCatalogoDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDisco)).EndInit();
            this.grpBxBotones.ResumeLayout(false);
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            this.grpBxFiltroAvanzado.ResumeLayout(false);
            this.grpBxFiltroAvanzado.PerformLayout();
            this.grpBxDetalleDisco.ResumeLayout(false);
            this.grpBxDetalleDisco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltrarAvanzado;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.PictureBox picBxDisco;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.GroupBox grpBxBotones;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.GroupBox grpBxFiltroAvanzado;
        private System.Windows.Forms.GroupBox grpBxDetalleDisco;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtActivoDet;
        private System.Windows.Forms.TextBox txtTipoEdicionDet;
        private System.Windows.Forms.TextBox txtEstiloDet;
        private System.Windows.Forms.TextBox txtURLDet;
        private System.Windows.Forms.TextBox txtIFechaLanzamientoDet;
        private System.Windows.Forms.TextBox txtCantidadCancionesDet;
        private System.Windows.Forms.TextBox txtTituloDet;
        private System.Windows.Forms.TextBox txtIDDet;
        private System.Windows.Forms.Label lblActivo;
    }
}

