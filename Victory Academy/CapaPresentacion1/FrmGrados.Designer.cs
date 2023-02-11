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
            this.GradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GradoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSinDatos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridGrados
            // 
            this.GridGrados.AllowUserToDeleteRows = false;
            this.GridGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradoId,
            this.Marcado,
            this.GradoDescripcion});
            this.GridGrados.Location = new System.Drawing.Point(12, 12);
            this.GridGrados.MultiSelect = false;
            this.GridGrados.Name = "GridGrados";
            this.GridGrados.ReadOnly = true;
            this.GridGrados.Size = new System.Drawing.Size(422, 316);
            this.GridGrados.TabIndex = 0;
            // 
            // GradoId
            // 
            this.GradoId.HeaderText = "";
            this.GradoId.Name = "GradoId";
            this.GradoId.ReadOnly = true;
            this.GradoId.Visible = false;
            // 
            // Marcado
            // 
            this.Marcado.FalseValue = "0";
            this.Marcado.HeaderText = "";
            this.Marcado.Name = "Marcado";
            this.Marcado.ReadOnly = true;
            this.Marcado.TrueValue = "1";
            this.Marcado.Width = 20;
            // 
            // GradoDescripcion
            // 
            this.GradoDescripcion.HeaderText = "Grado";
            this.GradoDescripcion.Name = "GradoDescripcion";
            this.GradoDescripcion.ReadOnly = true;
            // 
            // lblSinDatos
            // 
            this.lblSinDatos.AutoSize = true;
            this.lblSinDatos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSinDatos.Location = new System.Drawing.Point(129, 134);
            this.lblSinDatos.Name = "lblSinDatos";
            this.lblSinDatos.Size = new System.Drawing.Size(163, 24);
            this.lblSinDatos.TabIndex = 1;
            this.lblSinDatos.Text = "NO HAY DATOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.lblSinDatos);
            this.panel1.Controls.Add(this.GridGrados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 406);
            this.panel1.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(231, 334);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 45);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(121, 335);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(92, 45);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.Location = new System.Drawing.Point(13, 335);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 45);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(342, 335);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(92, 45);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Actualizar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FrmGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 406);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Marcado;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoDescripcion;
        private System.Windows.Forms.Label lblSinDatos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}