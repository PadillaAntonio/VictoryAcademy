using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class FrmGrados : Form
    {
        private List<Grado> grados = new List<Grado>();
        private CN_Grado objGrado = new CN_Grado();
        public FrmGrados()
        {
            InitializeComponent();
        }

        private void FrmGrados_Load(object sender, EventArgs e)
        {
            grados = objGrado.Listar();
            if (grados.Count != 0) 
            {
                GridGrados.Visible = true;
                lblSinDatos.Visible= false;
                foreach (Grado grado in grados)
                {
                    GridGrados.Rows.Add(new object[] { grado.Id, 0, grado.Descripcion });
                }
                GridGrados.Refresh();
            }
            else
            {
                GridGrados.Visible= false;
                lblSinDatos.Visible= true;
                // mensaje en el grid de que no hay nada ingresado aún
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmABMGrados AbmGrados = new FrmABMGrados(0,"INS");
            AbmGrados.ShowDialog();
            AbmGrados.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            FrmGrados_Load(sender, e);
        }
    }
}
