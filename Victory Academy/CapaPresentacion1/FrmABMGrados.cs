using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class FrmABMGrados : Form
    {
        private static int GradoId;
        private static string ModoForm;
        private CN_Grado objGrado = new CN_Grado();
        public FrmABMGrados(int id, string modo)
        {
            InitializeComponent();
            GradoId = id;
            ModoForm = modo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmABMGrados_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            switch (ModoForm)
            {
                case "INS":
                    lblTitulo.Text = "Agregar Grado";
                    txtId.Text = string.Empty;
                    break;
                case "UPD":
                    lblTitulo.Text = "Modificar Grado";
                    txtId.Text = GradoId.ToString();
                    txtDescripcion.Text = objGrado.GetDescripcion(GradoId);
                    break;
                case "DLT":
                    lblTitulo.Text = "Eliminar Grado";
                    txtId.Text = GradoId.ToString();
                    txtDescripcion.Text = objGrado.GetDescripcion(GradoId);
                    txtDescripcion.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            switch(ModoForm) 
            {
                case "INS":
                    Mensaje = objGrado.Insertar(txtDescripcion.Text);
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "UPD":
                    Mensaje = objGrado.Actualizar(Convert.ToInt32(txtId.Text),txtDescripcion.Text);
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "DLT":
                    Mensaje = objGrado.Eliminar(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    break;
            }
            this.Close();
        }
    }
}
