using CapaEntidad;
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
        public FrmGrados()
        {
            InitializeComponent();
        }

        private void FrmGrados_Load(object sender, EventArgs e)
        {
            if (grados != null) 
            {
                GridGrados.Visible = true;
                lblSinDatos.Visible= false;
                foreach (Grado grado in grados)
                {
                    GridGrados.Rows.Add(new object[] { grado.Id, 0, grado.Descripcion });
                }
            }
            else
            {
                GridGrados.Visible= false;
                lblSinDatos.Visible= true;
                // mensaje en el grid de que no hay nada ingresado aún
            }
        }
    }
}
