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

namespace CapaPresentacion1
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUser.Text = usuarioActual.Nick.Trim();
        }
    }
}
