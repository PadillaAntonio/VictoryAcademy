namespace CapaPresentacion1
{
    partial class FrmTipoCompetencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblBusquedaDisciplina = new System.Windows.Forms.Label();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.GridTipoCompetencia = new System.Windows.Forms.DataGridView();
            this.lblTituloGrid = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.CboDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoCompetenciaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridBtnSel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TipoCompetenciaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompetenciaDisciplinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCompetenciaDisciplinaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.cboBusqueda);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.lblBusqueda);
            this.panel1.Controls.Add(this.lblBusquedaDisciplina);
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.GridTipoCompetencia);
            this.panel1.Controls.Add(this.lblTituloGrid);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnRegistrar);
            this.panel1.Controls.Add(this.CboDisciplina);
            this.panel1.Controls.Add(this.lblDisciplina);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblTituloDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 390);
            this.panel1.TabIndex = 0;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.Location = new System.Drawing.Point(155, 101);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(51, 23);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(672, 31);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(116, 21);
            this.cboBusqueda.TabIndex = 16;
            this.cboBusqueda.SelectedValueChanged += new System.EventHandler(this.cboBusqueda_SelectedValueChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(661, 8);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(127, 20);
            this.txtBusqueda.TabIndex = 15;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBusqueda.Location = new System.Drawing.Point(594, 5);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(61, 19);
            this.lblBusqueda.TabIndex = 14;
            this.lblBusqueda.Text = "Buscar:";
            // 
            // lblBusquedaDisciplina
            // 
            this.lblBusquedaDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusquedaDisciplina.AutoSize = true;
            this.lblBusquedaDisciplina.BackColor = System.Drawing.Color.Transparent;
            this.lblBusquedaDisciplina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaDisciplina.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBusquedaDisciplina.Location = new System.Drawing.Point(594, 33);
            this.lblBusquedaDisciplina.Name = "lblBusquedaDisciplina";
            this.lblBusquedaDisciplina.Size = new System.Drawing.Size(80, 19);
            this.lblBusquedaDisciplina.TabIndex = 13;
            this.lblBusquedaDisciplina.Text = "Disciplina:";
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblSinDatos.Enabled = false;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(428, 206);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(174, 25);
            this.lblSinDatos.TabIndex = 12;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // GridTipoCompetencia
            // 
            this.GridTipoCompetencia.AllowUserToAddRows = false;
            this.GridTipoCompetencia.AllowUserToDeleteRows = false;
            this.GridTipoCompetencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTipoCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoCompetencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoCompetenciaId,
            this.GridBtnSel,
            this.TipoCompetenciaDescripcion,
            this.TipoCompetenciaDisciplinaId,
            this.TipoCompetenciaDisciplinaDescripcion});
            this.GridTipoCompetencia.Location = new System.Drawing.Point(243, 58);
            this.GridTipoCompetencia.Name = "GridTipoCompetencia";
            this.GridTipoCompetencia.ReadOnly = true;
            this.GridTipoCompetencia.Size = new System.Drawing.Size(545, 320);
            this.GridTipoCompetencia.TabIndex = 11;
            this.GridTipoCompetencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTipoCompetencia_CellContentClick);
            this.GridTipoCompetencia.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridTipoCompetencia_CellPainting);
            // 
            // lblTituloGrid
            // 
            this.lblTituloGrid.AutoSize = true;
            this.lblTituloGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGrid.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloGrid.Location = new System.Drawing.Point(243, 20);
            this.lblTituloGrid.Name = "lblTituloGrid";
            this.lblTituloGrid.Size = new System.Drawing.Size(318, 35);
            this.lblTituloGrid.TabIndex = 0;
            this.lblTituloGrid.Text = "Lista Tipo Competencia";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(29, 313);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(177, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEditar.IconColor = System.Drawing.Color.Black;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.Location = new System.Drawing.Point(29, 284);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(177, 23);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnRegistrar.IconColor = System.Drawing.Color.Black;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.Location = new System.Drawing.Point(29, 255);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(177, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // CboDisciplina
            // 
            this.CboDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDisciplina.FormattingEnabled = true;
            this.CboDisciplina.Location = new System.Drawing.Point(29, 228);
            this.CboDisciplina.MaxDropDownItems = 2;
            this.CboDisciplina.Name = "CboDisciplina";
            this.CboDisciplina.Size = new System.Drawing.Size(121, 21);
            this.CboDisciplina.TabIndex = 7;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.BackColor = System.Drawing.Color.Black;
            this.lblDisciplina.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.ForeColor = System.Drawing.Color.Red;
            this.lblDisciplina.Location = new System.Drawing.Point(24, 200);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(113, 25);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(29, 177);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 1;
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
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(29, 126);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TabStop = false;
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
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.BackColor = System.Drawing.Color.Black;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.Red;
            this.lblTituloDetalle.Location = new System.Drawing.Point(24, 20);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(103, 35);
            this.lblTituloDetalle.TabIndex = 0;
            this.lblTituloDetalle.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 390);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // TipoCompetenciaId
            // 
            this.TipoCompetenciaId.HeaderText = "";
            this.TipoCompetenciaId.Name = "TipoCompetenciaId";
            this.TipoCompetenciaId.ReadOnly = true;
            this.TipoCompetenciaId.Visible = false;
            // 
            // GridBtnSel
            // 
            this.GridBtnSel.HeaderText = "";
            this.GridBtnSel.Name = "GridBtnSel";
            this.GridBtnSel.ReadOnly = true;
            this.GridBtnSel.Width = 20;
            // 
            // TipoCompetenciaDescripcion
            // 
            this.TipoCompetenciaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCompetenciaDescripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipoCompetenciaDescripcion.HeaderText = "Descripción";
            this.TipoCompetenciaDescripcion.Name = "TipoCompetenciaDescripcion";
            this.TipoCompetenciaDescripcion.ReadOnly = true;
            // 
            // TipoCompetenciaDisciplinaId
            // 
            this.TipoCompetenciaDisciplinaId.HeaderText = "";
            this.TipoCompetenciaDisciplinaId.Name = "TipoCompetenciaDisciplinaId";
            this.TipoCompetenciaDisciplinaId.ReadOnly = true;
            this.TipoCompetenciaDisciplinaId.Visible = false;
            // 
            // TipoCompetenciaDisciplinaDescripcion
            // 
            this.TipoCompetenciaDisciplinaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCompetenciaDisciplinaDescripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.TipoCompetenciaDisciplinaDescripcion.HeaderText = "Disciplina";
            this.TipoCompetenciaDisciplinaDescripcion.Name = "TipoCompetenciaDisciplinaDescripcion";
            this.TipoCompetenciaDisciplinaDescripcion.ReadOnly = true;
            // 
            // FrmTipoCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTipoCompetencia";
            this.Text = "Tipos de Competencia";
            this.Load += new System.EventHandler(this.FrmTipoCompetencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoCompetencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox CboDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblBusquedaDisciplina;
        private System.Windows.Forms.Label lblSinDatos;
        private System.Windows.Forms.DataGridView GridTipoCompetencia;
        private System.Windows.Forms.Label lblTituloGrid;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompetenciaId;
        private System.Windows.Forms.DataGridViewButtonColumn GridBtnSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompetenciaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompetenciaDisciplinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCompetenciaDisciplinaDescripcion;
    }
}