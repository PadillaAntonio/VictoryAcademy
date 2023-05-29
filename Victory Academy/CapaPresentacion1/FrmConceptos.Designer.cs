namespace CapaPresentacion1
{
    partial class FrmConceptos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.GridPrecios = new System.Windows.Forms.DataGridView();
            this.PrecioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMonedaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMonedaSigno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridConceptos = new System.Windows.Forms.DataGridView();
            this.ConceptoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGrdSel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConceptoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoReferenciaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoReferenciaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloGrid = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.cboReferencia = new System.Windows.Forms.ComboBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.lblBusqueda);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.cboMoneda);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.GridPrecios);
            this.panel1.Controls.Add(this.GridConceptos);
            this.panel1.Controls.Add(this.lblTituloGrid);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnRegistrar);
            this.panel1.Controls.Add(this.cboReferencia);
            this.panel1.Controls.Add(this.lblReferencia);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblTituloDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 500);
            this.panel1.TabIndex = 0;
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(402, 177);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(174, 25);
            this.lblSinDatos.TabIndex = 22;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(621, 32);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(127, 20);
            this.txtBusqueda.TabIndex = 21;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBusqueda.Location = new System.Drawing.Point(561, 32);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(54, 17);
            this.lblBusqueda.TabIndex = 20;
            this.lblBusqueda.Text = "Buscar";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(29, 381);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 20);
            this.txtPrecio.TabIndex = 19;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Black;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Red;
            this.lblValor.Location = new System.Drawing.Point(24, 353);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(79, 25);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Precio:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(29, 332);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 17;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.Black;
            this.lblMoneda.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.Red;
            this.lblMoneda.Location = new System.Drawing.Point(24, 304);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(95, 25);
            this.lblMoneda.TabIndex = 16;
            this.lblMoneda.Text = "Moneda:";
            // 
            // GridPrecios
            // 
            this.GridPrecios.AllowUserToAddRows = false;
            this.GridPrecios.AllowUserToDeleteRows = false;
            this.GridPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrecioId,
            this.PrecioFecha,
            this.PrecioMonedaId,
            this.PrecioMonedaSigno,
            this.PrecioValor});
            this.GridPrecios.Location = new System.Drawing.Point(243, 362);
            this.GridPrecios.Name = "GridPrecios";
            this.GridPrecios.ReadOnly = true;
            this.GridPrecios.Size = new System.Drawing.Size(505, 126);
            this.GridPrecios.TabIndex = 15;
            // 
            // PrecioId
            // 
            this.PrecioId.HeaderText = "";
            this.PrecioId.Name = "PrecioId";
            this.PrecioId.ReadOnly = true;
            this.PrecioId.Visible = false;
            // 
            // PrecioFecha
            // 
            this.PrecioFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFecha.DefaultCellStyle = dataGridViewCellStyle21;
            this.PrecioFecha.HeaderText = "Fecha";
            this.PrecioFecha.Name = "PrecioFecha";
            this.PrecioFecha.ReadOnly = true;
            // 
            // PrecioMonedaId
            // 
            this.PrecioMonedaId.HeaderText = "";
            this.PrecioMonedaId.Name = "PrecioMonedaId";
            this.PrecioMonedaId.ReadOnly = true;
            this.PrecioMonedaId.Visible = false;
            // 
            // PrecioMonedaSigno
            // 
            this.PrecioMonedaSigno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioMonedaSigno.DefaultCellStyle = dataGridViewCellStyle22;
            this.PrecioMonedaSigno.HeaderText = "Signo";
            this.PrecioMonedaSigno.Name = "PrecioMonedaSigno";
            this.PrecioMonedaSigno.ReadOnly = true;
            // 
            // PrecioValor
            // 
            this.PrecioValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioValor.DefaultCellStyle = dataGridViewCellStyle23;
            this.PrecioValor.HeaderText = "Valor";
            this.PrecioValor.Name = "PrecioValor";
            this.PrecioValor.ReadOnly = true;
            // 
            // GridConceptos
            // 
            this.GridConceptos.AllowUserToAddRows = false;
            this.GridConceptos.AllowUserToDeleteRows = false;
            this.GridConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GridConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConceptoId,
            this.BtnGrdSel,
            this.ConceptoDescripcion,
            this.ConceptoTipo,
            this.ConceptoReferenciaId,
            this.ConceptoReferenciaDescripcion});
            this.GridConceptos.Location = new System.Drawing.Point(244, 59);
            this.GridConceptos.Name = "GridConceptos";
            this.GridConceptos.ReadOnly = true;
            this.GridConceptos.Size = new System.Drawing.Size(504, 297);
            this.GridConceptos.TabIndex = 14;
            // 
            // ConceptoId
            // 
            this.ConceptoId.HeaderText = "";
            this.ConceptoId.Name = "ConceptoId";
            this.ConceptoId.ReadOnly = true;
            this.ConceptoId.Visible = false;
            // 
            // BtnGrdSel
            // 
            this.BtnGrdSel.HeaderText = "";
            this.BtnGrdSel.Name = "BtnGrdSel";
            this.BtnGrdSel.ReadOnly = true;
            this.BtnGrdSel.Width = 20;
            // 
            // ConceptoDescripcion
            // 
            this.ConceptoDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceptoDescripcion.DefaultCellStyle = dataGridViewCellStyle24;
            this.ConceptoDescripcion.HeaderText = "Descripción";
            this.ConceptoDescripcion.Name = "ConceptoDescripcion";
            this.ConceptoDescripcion.ReadOnly = true;
            // 
            // ConceptoTipo
            // 
            this.ConceptoTipo.HeaderText = "";
            this.ConceptoTipo.Name = "ConceptoTipo";
            this.ConceptoTipo.ReadOnly = true;
            this.ConceptoTipo.Visible = false;
            // 
            // ConceptoReferenciaId
            // 
            this.ConceptoReferenciaId.HeaderText = "";
            this.ConceptoReferenciaId.Name = "ConceptoReferenciaId";
            this.ConceptoReferenciaId.ReadOnly = true;
            this.ConceptoReferenciaId.Visible = false;
            // 
            // ConceptoReferenciaDescripcion
            // 
            this.ConceptoReferenciaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConceptoReferenciaDescripcion.DefaultCellStyle = dataGridViewCellStyle25;
            this.ConceptoReferenciaDescripcion.HeaderText = "Referencia";
            this.ConceptoReferenciaDescripcion.Name = "ConceptoReferenciaDescripcion";
            this.ConceptoReferenciaDescripcion.ReadOnly = true;
            // 
            // lblTituloGrid
            // 
            this.lblTituloGrid.AutoSize = true;
            this.lblTituloGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGrid.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloGrid.Location = new System.Drawing.Point(243, 20);
            this.lblTituloGrid.Name = "lblTituloGrid";
            this.lblTituloGrid.Size = new System.Drawing.Size(220, 35);
            this.lblTituloGrid.TabIndex = 13;
            this.lblTituloGrid.Text = "Lista Conceptos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(29, 465);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(177, 23);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEditar.IconColor = System.Drawing.Color.Black;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.Location = new System.Drawing.Point(29, 436);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(177, 23);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnRegistrar.IconColor = System.Drawing.Color.Black;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.Location = new System.Drawing.Point(29, 407);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(177, 23);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cboReferencia
            // 
            this.cboReferencia.FormattingEnabled = true;
            this.cboReferencia.Location = new System.Drawing.Point(29, 280);
            this.cboReferencia.Name = "cboReferencia";
            this.cboReferencia.Size = new System.Drawing.Size(177, 21);
            this.cboReferencia.TabIndex = 9;
            this.cboReferencia.SelectedIndexChanged += new System.EventHandler(this.cboReferencia_SelectedIndexChanged);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Black;
            this.lblReferencia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.Color.Red;
            this.lblReferencia.Location = new System.Drawing.Point(24, 252);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(100, 25);
            this.lblReferencia.TabIndex = 8;
            this.lblReferencia.Text = "Refencia:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(29, 228);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(177, 21);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Black;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Red;
            this.lblTipo.Location = new System.Drawing.Point(24, 200);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(63, 25);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(29, 177);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(29, 126);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Black;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(130, 25);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Black;
            this.lblCodigo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(24, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.BackColor = System.Drawing.Color.Black;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblTituloDetalle.Location = new System.Drawing.Point(23, 20);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(103, 35);
            this.lblTituloDetalle.TabIndex = 1;
            this.lblTituloDetalle.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 500);
            this.label1.TabIndex = 0;
            // 
            // FrmConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConceptos";
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.FrmConceptos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView GridConceptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoId;
        private System.Windows.Forms.DataGridViewButtonColumn BtnGrdSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoReferenciaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoReferenciaDescripcion;
        private System.Windows.Forms.Label lblTituloGrid;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.ComboBox cboReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.DataGridView GridPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMonedaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMonedaSigno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioValor;
        private System.Windows.Forms.Label lblSinDatos;
    }
}