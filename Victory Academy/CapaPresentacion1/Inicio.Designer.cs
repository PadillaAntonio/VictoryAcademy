namespace CapaPresentacion1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.MenuDefiniciones = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuGrados = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTipoProgramas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTipoTelefono = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTipoCompetencia = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTiposTorneos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuMonedas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuConceptos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAfiliacion = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuPersonas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTorneos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuTorneos = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuPuntosPersonas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuFinanzas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuLimpiar = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Transparent;
            this.menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDefiniciones,
            this.MenuAfiliacion,
            this.MenuTorneos,
            this.MenuFinanzas,
            this.MenuLimpiar});
            this.menuTitulo.Location = new System.Drawing.Point(0, 71);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(922, 110);
            this.menuTitulo.TabIndex = 0;
            // 
            // MenuDefiniciones
            // 
            this.MenuDefiniciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuGrados,
            this.SubMenuTipoProgramas,
            this.SubMenuTipoTelefono,
            this.SubMenuTipoCompetencia,
            this.SubMenuTiposTorneos,
            this.SubMenuMonedas,
            this.SubMenuConceptos});
            this.MenuDefiniciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDefiniciones.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.MenuDefiniciones.IconColor = System.Drawing.Color.DarkRed;
            this.MenuDefiniciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuDefiniciones.IconSize = 60;
            this.MenuDefiniciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuDefiniciones.Name = "MenuDefiniciones";
            this.MenuDefiniciones.Size = new System.Drawing.Size(104, 106);
            this.MenuDefiniciones.Text = "Definiciones";
            this.MenuDefiniciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuGrados
            // 
            this.SubMenuGrados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuGrados.IconColor = System.Drawing.Color.Black;
            this.SubMenuGrados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuGrados.Name = "SubMenuGrados";
            this.SubMenuGrados.Size = new System.Drawing.Size(219, 24);
            this.SubMenuGrados.Text = "Grados";
            this.SubMenuGrados.Click += new System.EventHandler(this.SubMenuGrados_Click);
            // 
            // SubMenuTipoProgramas
            // 
            this.SubMenuTipoProgramas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTipoProgramas.IconColor = System.Drawing.Color.Black;
            this.SubMenuTipoProgramas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTipoProgramas.Name = "SubMenuTipoProgramas";
            this.SubMenuTipoProgramas.Size = new System.Drawing.Size(219, 24);
            this.SubMenuTipoProgramas.Text = "Tipo de Programas";
            this.SubMenuTipoProgramas.Click += new System.EventHandler(this.SubMenuTipoProgramas_Click);
            // 
            // SubMenuTipoTelefono
            // 
            this.SubMenuTipoTelefono.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTipoTelefono.IconColor = System.Drawing.Color.Black;
            this.SubMenuTipoTelefono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTipoTelefono.Name = "SubMenuTipoTelefono";
            this.SubMenuTipoTelefono.Size = new System.Drawing.Size(219, 24);
            this.SubMenuTipoTelefono.Text = "Tipo de Telefono";
            this.SubMenuTipoTelefono.Click += new System.EventHandler(this.SubMenuTipoTelefono_Click);
            // 
            // SubMenuTipoCompetencia
            // 
            this.SubMenuTipoCompetencia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTipoCompetencia.IconColor = System.Drawing.Color.Black;
            this.SubMenuTipoCompetencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTipoCompetencia.Name = "SubMenuTipoCompetencia";
            this.SubMenuTipoCompetencia.Size = new System.Drawing.Size(219, 24);
            this.SubMenuTipoCompetencia.Text = "Tipo de Competencia";
            this.SubMenuTipoCompetencia.Click += new System.EventHandler(this.SubMenuTipoCompetencia_Click);
            // 
            // SubMenuTiposTorneos
            // 
            this.SubMenuTiposTorneos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTiposTorneos.IconColor = System.Drawing.Color.Black;
            this.SubMenuTiposTorneos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTiposTorneos.Name = "SubMenuTiposTorneos";
            this.SubMenuTiposTorneos.Size = new System.Drawing.Size(219, 24);
            this.SubMenuTiposTorneos.Text = "Tipos de Torneos";
            this.SubMenuTiposTorneos.Click += new System.EventHandler(this.SubMenuTiposTorneos_Click);
            // 
            // SubMenuMonedas
            // 
            this.SubMenuMonedas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuMonedas.IconColor = System.Drawing.Color.Black;
            this.SubMenuMonedas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuMonedas.Name = "SubMenuMonedas";
            this.SubMenuMonedas.Size = new System.Drawing.Size(219, 24);
            this.SubMenuMonedas.Text = "Monedas";
            this.SubMenuMonedas.Click += new System.EventHandler(this.SubMenuMonedas_Click);
            // 
            // SubMenuConceptos
            // 
            this.SubMenuConceptos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuConceptos.IconColor = System.Drawing.Color.Black;
            this.SubMenuConceptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuConceptos.Name = "SubMenuConceptos";
            this.SubMenuConceptos.Size = new System.Drawing.Size(219, 24);
            this.SubMenuConceptos.Text = "Conceptos";
            this.SubMenuConceptos.Click += new System.EventHandler(this.SubMenuConceptos_Click);
            // 
            // MenuAfiliacion
            // 
            this.MenuAfiliacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuPersonas,
            this.SubMenuUsuarios});
            this.MenuAfiliacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAfiliacion.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MenuAfiliacion.IconColor = System.Drawing.Color.DarkRed;
            this.MenuAfiliacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAfiliacion.IconSize = 60;
            this.MenuAfiliacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAfiliacion.Name = "MenuAfiliacion";
            this.MenuAfiliacion.Size = new System.Drawing.Size(99, 106);
            this.MenuAfiliacion.Text = "Afiliaciones";
            this.MenuAfiliacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuPersonas
            // 
            this.SubMenuPersonas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuPersonas.IconColor = System.Drawing.Color.Black;
            this.SubMenuPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuPersonas.Name = "SubMenuPersonas";
            this.SubMenuPersonas.Size = new System.Drawing.Size(139, 24);
            this.SubMenuPersonas.Text = "Personas";
            this.SubMenuPersonas.Click += new System.EventHandler(this.SubMenuPersonas_Click);
            // 
            // SubMenuUsuarios
            // 
            this.SubMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.SubMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuUsuarios.Name = "SubMenuUsuarios";
            this.SubMenuUsuarios.Size = new System.Drawing.Size(139, 24);
            this.SubMenuUsuarios.Text = "Usuarios";
            this.SubMenuUsuarios.Click += new System.EventHandler(this.SubMenuUsuarios_Click);
            // 
            // MenuTorneos
            // 
            this.MenuTorneos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuTorneos,
            this.SubMenuPuntosPersonas});
            this.MenuTorneos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTorneos.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.MenuTorneos.IconColor = System.Drawing.Color.DarkRed;
            this.MenuTorneos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuTorneos.IconSize = 60;
            this.MenuTorneos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuTorneos.Name = "MenuTorneos";
            this.MenuTorneos.Size = new System.Drawing.Size(75, 106);
            this.MenuTorneos.Text = "Torneos";
            this.MenuTorneos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuTorneos
            // 
            this.SubMenuTorneos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuTorneos.IconColor = System.Drawing.Color.Black;
            this.SubMenuTorneos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuTorneos.Name = "SubMenuTorneos";
            this.SubMenuTorneos.Size = new System.Drawing.Size(193, 24);
            this.SubMenuTorneos.Text = "Torneos";
            this.SubMenuTorneos.Click += new System.EventHandler(this.SubMenuTorneos_Click);
            // 
            // SubMenuPuntosPersonas
            // 
            this.SubMenuPuntosPersonas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuPuntosPersonas.IconColor = System.Drawing.Color.Black;
            this.SubMenuPuntosPersonas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuPuntosPersonas.Name = "SubMenuPuntosPersonas";
            this.SubMenuPuntosPersonas.Size = new System.Drawing.Size(193, 24);
            this.SubMenuPuntosPersonas.Text = "Puntos x Persona";
            this.SubMenuPuntosPersonas.Click += new System.EventHandler(this.SubMenuPuntosPersonas_Click);
            // 
            // MenuFinanzas
            // 
            this.MenuFinanzas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuVentas});
            this.MenuFinanzas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFinanzas.IconChar = FontAwesome.Sharp.IconChar.Dollar;
            this.MenuFinanzas.IconColor = System.Drawing.Color.DarkRed;
            this.MenuFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuFinanzas.IconSize = 60;
            this.MenuFinanzas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuFinanzas.Name = "MenuFinanzas";
            this.MenuFinanzas.Size = new System.Drawing.Size(79, 106);
            this.MenuFinanzas.Text = "Finanzas";
            this.MenuFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuVentas
            // 
            this.SubMenuVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVentas.IconColor = System.Drawing.Color.Black;
            this.SubMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVentas.Name = "SubMenuVentas";
            this.SubMenuVentas.Size = new System.Drawing.Size(124, 24);
            this.SubMenuVentas.Text = "Ventas";
            // 
            // MenuLimpiar
            // 
            this.MenuLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.MenuLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.MenuLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuLimpiar.IconSize = 60;
            this.MenuLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuLimpiar.Name = "MenuLimpiar";
            this.MenuLimpiar.Size = new System.Drawing.Size(73, 106);
            this.MenuLimpiar.Text = "Limpiar";
            this.MenuLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuLimpiar.Click += new System.EventHandler(this.MenuLimpiar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 71);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            this.lblUsuario.CausesValidation = false;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(768, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Black;
            this.lblUser.CausesValidation = false;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(831, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "lblUsuario";
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(0, 181);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(922, 404);
            this.Contenedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CapaPresentacion1.Properties.Resources.Logo_Inicio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuTitulo.ResumeLayout(false);
            this.menuTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUser;
        private FontAwesome.Sharp.IconMenuItem MenuDefiniciones;
        private FontAwesome.Sharp.IconMenuItem SubMenuGrados;
        private FontAwesome.Sharp.IconMenuItem MenuAfiliacion;
        private FontAwesome.Sharp.IconMenuItem MenuTorneos;
        private FontAwesome.Sharp.IconMenuItem MenuLimpiar;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuTipoProgramas;
        private FontAwesome.Sharp.IconMenuItem SubMenuTipoTelefono;
        private FontAwesome.Sharp.IconMenuItem SubMenuTipoCompetencia;
        private FontAwesome.Sharp.IconMenuItem SubMenuTiposTorneos;
        private FontAwesome.Sharp.IconMenuItem SubMenuMonedas;
        private FontAwesome.Sharp.IconMenuItem SubMenuConceptos;
        private FontAwesome.Sharp.IconMenuItem SubMenuPersonas;
        private FontAwesome.Sharp.IconMenuItem SubMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem SubMenuTorneos;
        private FontAwesome.Sharp.IconMenuItem SubMenuPuntosPersonas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem MenuFinanzas;
        private FontAwesome.Sharp.IconMenuItem SubMenuVentas;
    }
}