namespace CapaPresentacion1
{
    partial class FrmTiposProgramas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.GridTipoProgramas = new System.Windows.Forms.DataGridView();
            this.TipoProgramaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridBtnSel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TipoProgramaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloGrid = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.lblIzquierda = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoProgramas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.lblBusqueda);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.GridTipoProgramas);
            this.panel1.Controls.Add(this.lblTituloGrid);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblTituloDetalle);
            this.panel1.Controls.Add(this.lblIzquierda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 417);
            this.panel1.TabIndex = 0;
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(433, 170);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(174, 25);
            this.lblSinDatos.TabIndex = 13;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBusqueda.Location = new System.Drawing.Point(596, 28);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(59, 17);
            this.lblBusqueda.TabIndex = 12;
            this.lblBusqueda.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(661, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(127, 20);
            this.txtBusqueda.TabIndex = 11;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // GridTipoProgramas
            // 
            this.GridTipoProgramas.AllowUserToAddRows = false;
            this.GridTipoProgramas.AllowUserToDeleteRows = false;
            this.GridTipoProgramas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTipoProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProgramaId,
            this.GridBtnSel,
            this.TipoProgramaDescripcion});
            this.GridTipoProgramas.Location = new System.Drawing.Point(245, 62);
            this.GridTipoProgramas.Name = "GridTipoProgramas";
            this.GridTipoProgramas.ReadOnly = true;
            this.GridTipoProgramas.Size = new System.Drawing.Size(543, 348);
            this.GridTipoProgramas.TabIndex = 10;
            this.GridTipoProgramas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTipoProgramas_CellContentClick);
            this.GridTipoProgramas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridTipoProgramas_CellPainting);
            // 
            // TipoProgramaId
            // 
            this.TipoProgramaId.HeaderText = "Codigo";
            this.TipoProgramaId.Name = "TipoProgramaId";
            this.TipoProgramaId.ReadOnly = true;
            this.TipoProgramaId.Visible = false;
            // 
            // GridBtnSel
            // 
            this.GridBtnSel.HeaderText = "";
            this.GridBtnSel.Name = "GridBtnSel";
            this.GridBtnSel.ReadOnly = true;
            this.GridBtnSel.Width = 20;
            // 
            // TipoProgramaDescripcion
            // 
            this.TipoProgramaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoProgramaDescripcion.DefaultCellStyle = dataGridViewCellStyle1;
            this.TipoProgramaDescripcion.HeaderText = "Descripcion";
            this.TipoProgramaDescripcion.Name = "TipoProgramaDescripcion";
            this.TipoProgramaDescripcion.ReadOnly = true;
            // 
            // lblTituloGrid
            // 
            this.lblTituloGrid.AutoSize = true;
            this.lblTituloGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGrid.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloGrid.Location = new System.Drawing.Point(239, 16);
            this.lblTituloGrid.Name = "lblTituloGrid";
            this.lblTituloGrid.Size = new System.Drawing.Size(223, 35);
            this.lblTituloGrid.TabIndex = 9;
            this.lblTituloGrid.Text = "Lista Programas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(29, 261);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(29, 232);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Location = new System.Drawing.Point(29, 203);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(177, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
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
            // lblIzquierda
            // 
            this.lblIzquierda.BackColor = System.Drawing.Color.Black;
            this.lblIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIzquierda.Location = new System.Drawing.Point(0, 0);
            this.lblIzquierda.Name = "lblIzquierda";
            this.lblIzquierda.Size = new System.Drawing.Size(237, 417);
            this.lblIzquierda.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.Location = new System.Drawing.Point(155, 101);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.BtnLimpiar.TabIndex = 14;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmTiposProgramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTiposProgramas";
            this.Text = "Tipos de programas";
            this.Load += new System.EventHandler(this.FrmTiposProgramas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoProgramas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Label lblIzquierda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView GridTipoProgramas;
        private System.Windows.Forms.Label lblTituloGrid;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSinDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProgramaId;
        private System.Windows.Forms.DataGridViewButtonColumn GridBtnSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProgramaDescripcion;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
    }
}