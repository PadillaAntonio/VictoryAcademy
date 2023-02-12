namespace CapaPresentacion1
{
    partial class FrmGrados
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
            this.GridGrados = new System.Windows.Forms.DataGridView();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblGradoId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.GradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdBtnSel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GradoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridGrados
            // 
            this.GridGrados.AllowUserToAddRows = false;
            this.GridGrados.AllowUserToDeleteRows = false;
            this.GridGrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradoId,
            this.GrdBtnSel,
            this.GradoDescripcion});
            this.GridGrados.Location = new System.Drawing.Point(243, 67);
            this.GridGrados.MultiSelect = false;
            this.GridGrados.Name = "GridGrados";
            this.GridGrados.ReadOnly = true;
            this.GridGrados.Size = new System.Drawing.Size(218, 257);
            this.GridGrados.TabIndex = 0;
            this.GridGrados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridGrados_CellPainting);
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(277, 160);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(163, 24);
            this.lblSinDatos.TabIndex = 1;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnRegistrar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblGradoId);
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.GridGrados);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 336);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(23, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 35);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Detalle grados";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 177);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 5;
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
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(24, 126);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblGradoId
            // 
            this.lblGradoId.AutoSize = true;
            this.lblGradoId.BackColor = System.Drawing.Color.Black;
            this.lblGradoId.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradoId.ForeColor = System.Drawing.Color.Red;
            this.lblGradoId.Location = new System.Drawing.Point(24, 98);
            this.lblGradoId.Name = "lblGradoId";
            this.lblGradoId.Size = new System.Drawing.Size(86, 25);
            this.lblGradoId.TabIndex = 2;
            this.lblGradoId.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 336);
            this.label1.TabIndex = 6;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.Location = new System.Drawing.Point(24, 279);
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
            this.BtnEditar.Location = new System.Drawing.Point(24, 250);
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
            this.BtnRegistrar.Location = new System.Drawing.Point(24, 221);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(177, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // GradoId
            // 
            this.GradoId.HeaderText = "";
            this.GradoId.Name = "GradoId";
            this.GradoId.ReadOnly = true;
            this.GradoId.Visible = false;
            // 
            // GrdBtnSel
            // 
            this.GrdBtnSel.DividerWidth = 2;
            this.GrdBtnSel.HeaderText = "";
            this.GrdBtnSel.Name = "GrdBtnSel";
            this.GrdBtnSel.ReadOnly = true;
            this.GrdBtnSel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBtnSel.Width = 25;
            // 
            // GradoDescripcion
            // 
            this.GradoDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradoDescripcion.DividerWidth = 2;
            this.GradoDescripcion.HeaderText = "Grado";
            this.GradoDescripcion.Name = "GradoDescripcion";
            this.GradoDescripcion.ReadOnly = true;
            // 
            // FrmGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 336);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGrados";
            this.Text = "FrmGrados";
            this.Load += new System.EventHandler(this.FrmGrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGrados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridGrados;
        private System.Windows.Forms.Label lblSinDatos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblGradoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoId;
        private System.Windows.Forms.DataGridViewButtonColumn GrdBtnSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoDescripcion;
    }
}