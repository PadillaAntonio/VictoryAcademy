namespace CapaPresentacion1
{
    partial class FrmTiposTorneos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPuntosXLugar = new System.Windows.Forms.Label();
            this.lblPrimerLugar = new System.Windows.Forms.Label();
            this.lblSegundoLugar = new System.Windows.Forms.Label();
            this.lblTercerLugar = new System.Windows.Forms.Label();
            this.txtPuntos1 = new System.Windows.Forms.TextBox();
            this.txtPuntos2 = new System.Windows.Forms.TextBox();
            this.txtPuntos3 = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblTituloGrid = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.GridTipoTorneo = new System.Windows.Forms.DataGridView();
            this.TipoTorneoPuntos3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTorneoPuntos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTorneoPuntos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTorneoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdBtnSel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TipoTorneoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoTorneo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 432);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.lblTituloDetalle.TabIndex = 0;
            this.lblTituloDetalle.Text = "Detalle";
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(24, 126);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 177);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblPuntosXLugar
            // 
            this.lblPuntosXLugar.AutoSize = true;
            this.lblPuntosXLugar.BackColor = System.Drawing.Color.Black;
            this.lblPuntosXLugar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosXLugar.ForeColor = System.Drawing.Color.Red;
            this.lblPuntosXLugar.Location = new System.Drawing.Point(24, 200);
            this.lblPuntosXLugar.Name = "lblPuntosXLugar";
            this.lblPuntosXLugar.Size = new System.Drawing.Size(186, 25);
            this.lblPuntosXLugar.TabIndex = 6;
            this.lblPuntosXLugar.Text = "Puntos por Lugar:";
            // 
            // lblPrimerLugar
            // 
            this.lblPrimerLugar.AutoSize = true;
            this.lblPrimerLugar.BackColor = System.Drawing.Color.Black;
            this.lblPrimerLugar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerLugar.ForeColor = System.Drawing.Color.Red;
            this.lblPrimerLugar.Location = new System.Drawing.Point(24, 225);
            this.lblPrimerLugar.Name = "lblPrimerLugar";
            this.lblPrimerLugar.Size = new System.Drawing.Size(113, 25);
            this.lblPrimerLugar.TabIndex = 7;
            this.lblPrimerLugar.Text = "1er Lugar:";
            // 
            // lblSegundoLugar
            // 
            this.lblSegundoLugar.AutoSize = true;
            this.lblSegundoLugar.BackColor = System.Drawing.Color.Black;
            this.lblSegundoLugar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoLugar.ForeColor = System.Drawing.Color.Red;
            this.lblSegundoLugar.Location = new System.Drawing.Point(24, 250);
            this.lblSegundoLugar.Name = "lblSegundoLugar";
            this.lblSegundoLugar.Size = new System.Drawing.Size(117, 25);
            this.lblSegundoLugar.TabIndex = 8;
            this.lblSegundoLugar.Text = "2do Lugar:";
            // 
            // lblTercerLugar
            // 
            this.lblTercerLugar.AutoSize = true;
            this.lblTercerLugar.BackColor = System.Drawing.Color.Black;
            this.lblTercerLugar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTercerLugar.ForeColor = System.Drawing.Color.Red;
            this.lblTercerLugar.Location = new System.Drawing.Point(24, 275);
            this.lblTercerLugar.Name = "lblTercerLugar";
            this.lblTercerLugar.Size = new System.Drawing.Size(113, 25);
            this.lblTercerLugar.TabIndex = 9;
            this.lblTercerLugar.Text = "3er Lugar:";
            // 
            // txtPuntos1
            // 
            this.txtPuntos1.Location = new System.Drawing.Point(143, 230);
            this.txtPuntos1.Name = "txtPuntos1";
            this.txtPuntos1.Size = new System.Drawing.Size(25, 20);
            this.txtPuntos1.TabIndex = 10;
            // 
            // txtPuntos2
            // 
            this.txtPuntos2.Location = new System.Drawing.Point(143, 254);
            this.txtPuntos2.Name = "txtPuntos2";
            this.txtPuntos2.Size = new System.Drawing.Size(25, 20);
            this.txtPuntos2.TabIndex = 11;
            // 
            // txtPuntos3
            // 
            this.txtPuntos3.Location = new System.Drawing.Point(143, 278);
            this.txtPuntos3.Name = "txtPuntos3";
            this.txtPuntos3.Size = new System.Drawing.Size(25, 20);
            this.txtPuntos3.TabIndex = 12;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnRegistrar.IconColor = System.Drawing.Color.Black;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.Location = new System.Drawing.Point(24, 313);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(177, 23);
            this.BtnRegistrar.TabIndex = 13;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEditar.IconColor = System.Drawing.Color.Black;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.Location = new System.Drawing.Point(24, 342);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(177, 23);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(24, 371);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(177, 23);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblTituloGrid
            // 
            this.lblTituloGrid.AutoSize = true;
            this.lblTituloGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGrid.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloGrid.Location = new System.Drawing.Point(243, 20);
            this.lblTituloGrid.Name = "lblTituloGrid";
            this.lblTituloGrid.Size = new System.Drawing.Size(278, 35);
            this.lblTituloGrid.TabIndex = 16;
            this.lblTituloGrid.Text = "Lista Tipo de Torneo";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBusqueda.Location = new System.Drawing.Point(556, 32);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(59, 17);
            this.lblBusqueda.TabIndex = 17;
            this.lblBusqueda.Text = "Buscar:";
            // 
            // GridTipoTorneo
            // 
            this.GridTipoTorneo.AllowUserToAddRows = false;
            this.GridTipoTorneo.AllowUserToDeleteRows = false;
            this.GridTipoTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTipoTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoTorneo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoTorneoId,
            this.GrdBtnSel,
            this.TipoTorneoDescripcion,
            this.TipoTorneoPuntos1,
            this.TipoTorneoPuntos2,
            this.TipoTorneoPuntos3});
            this.GridTipoTorneo.Location = new System.Drawing.Point(243, 58);
            this.GridTipoTorneo.Name = "GridTipoTorneo";
            this.GridTipoTorneo.ReadOnly = true;
            this.GridTipoTorneo.Size = new System.Drawing.Size(505, 362);
            this.GridTipoTorneo.TabIndex = 18;
            this.GridTipoTorneo.TabStop = false;
            this.GridTipoTorneo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTipoTorneo_CellContentClick);
            this.GridTipoTorneo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridTipoTorneo_CellPainting);
            // 
            // TipoTorneoPuntos3
            // 
            this.TipoTorneoPuntos3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoTorneoPuntos3.HeaderText = "3er Lugar";
            this.TipoTorneoPuntos3.Name = "TipoTorneoPuntos3";
            this.TipoTorneoPuntos3.ReadOnly = true;
            this.TipoTorneoPuntos3.Width = 77;
            // 
            // TipoTorneoPuntos2
            // 
            this.TipoTorneoPuntos2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoTorneoPuntos2.HeaderText = "2do Lugar";
            this.TipoTorneoPuntos2.Name = "TipoTorneoPuntos2";
            this.TipoTorneoPuntos2.ReadOnly = true;
            this.TipoTorneoPuntos2.Width = 80;
            // 
            // TipoTorneoPuntos1
            // 
            this.TipoTorneoPuntos1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoTorneoPuntos1.HeaderText = "1er Lugar";
            this.TipoTorneoPuntos1.Name = "TipoTorneoPuntos1";
            this.TipoTorneoPuntos1.ReadOnly = true;
            this.TipoTorneoPuntos1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoTorneoPuntos1.Width = 77;
            // 
            // TipoTorneoDescripcion
            // 
            this.TipoTorneoDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoTorneoDescripcion.HeaderText = "Descripción";
            this.TipoTorneoDescripcion.Name = "TipoTorneoDescripcion";
            this.TipoTorneoDescripcion.ReadOnly = true;
            // 
            // GrdBtnSel
            // 
            this.GrdBtnSel.HeaderText = "";
            this.GrdBtnSel.Name = "GrdBtnSel";
            this.GrdBtnSel.ReadOnly = true;
            this.GrdBtnSel.Width = 20;
            // 
            // TipoTorneoId
            // 
            this.TipoTorneoId.HeaderText = "";
            this.TipoTorneoId.Name = "TipoTorneoId";
            this.TipoTorneoId.ReadOnly = true;
            this.TipoTorneoId.Visible = false;
            this.TipoTorneoId.Width = 19;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(621, 32);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(127, 20);
            this.txtBusqueda.TabIndex = 19;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(403, 200);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(174, 25);
            this.lblSinDatos.TabIndex = 20;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.GridTipoTorneo);
            this.panel1.Controls.Add(this.lblBusqueda);
            this.panel1.Controls.Add(this.lblTituloGrid);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnRegistrar);
            this.panel1.Controls.Add(this.txtPuntos3);
            this.panel1.Controls.Add(this.txtPuntos2);
            this.panel1.Controls.Add(this.txtPuntos1);
            this.panel1.Controls.Add(this.lblTercerLugar);
            this.panel1.Controls.Add(this.lblSegundoLugar);
            this.panel1.Controls.Add(this.lblPrimerLugar);
            this.panel1.Controls.Add(this.lblPuntosXLugar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblTituloDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 432);
            this.panel1.TabIndex = 0;
            // 
            // FrmTiposTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 432);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTiposTorneos";
            this.Text = "Tipo de torneos";
            this.Load += new System.EventHandler(this.FrmTiposTorneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoTorneo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPuntosXLugar;
        private System.Windows.Forms.Label lblPrimerLugar;
        private System.Windows.Forms.Label lblSegundoLugar;
        private System.Windows.Forms.Label lblTercerLugar;
        private System.Windows.Forms.TextBox txtPuntos1;
        private System.Windows.Forms.TextBox txtPuntos2;
        private System.Windows.Forms.TextBox txtPuntos3;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.Label lblTituloGrid;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView GridTipoTorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTorneoId;
        private System.Windows.Forms.DataGridViewButtonColumn GrdBtnSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTorneoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTorneoPuntos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTorneoPuntos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTorneoPuntos3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblSinDatos;
        private System.Windows.Forms.Panel panel1;
    }
}