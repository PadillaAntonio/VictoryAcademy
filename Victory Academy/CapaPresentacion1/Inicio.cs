using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion1
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUser.Text = usuarioActual.Nick.Trim();
            if (!usuarioActual.EsAdmin) 
            {
                MenuDefiniciones.Visible = false;
                MenuAfiliacion.Visible = false; 
                MenuFinanza.Visible= false;
            }
        }

        private void AbrirFormulario (IconMenuItem menu, Form formulario) 
        {
            if (MenuActivo != null) 
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            if (FormularioActivo != null) 
            { 
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel= false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void SubMenuGrados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmGrados());
        }

        private void SubMenuTipoProgramas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FrmTiposProgramas());
        }

        private void SubMenuTipoTelefono_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmTiposTelefonos());
        }

        private void SubMenuTipoCompetencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmTiposCompetencias());
        }

        private void SubMenuTiposTorneos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmTiposTorneos());
        }

        private void SubMenuMonedas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmMonedas());
        }

        private void SubMenuConceptos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmConceptos());
        }

        private void SubMenuPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmPersonas());
        }

        private void SubMenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void SubMenuTorneos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmTorneos());
        }

        private void SubMenuPuntosPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmPuntosXPersona());
        }

        private void SubMenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmVentas());
        }
    }
}
