using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Drawing.Text;
using CapaPresentacion1.Properties;

namespace CapaPresentacion1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string usuarioClave = FuncionesGenerales.Encriptar(txtClave.Text);
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Nick == txtUsuario.Text && u.Clave == usuarioClave).FirstOrDefault();
            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtClave.Text = "";
            txtUsuario.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
