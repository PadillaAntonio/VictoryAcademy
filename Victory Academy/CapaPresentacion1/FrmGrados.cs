using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
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
        private string Mensaje = string.Empty;
        public FrmGrados()
        {
            InitializeComponent();
        }

        private void FrmGrados_Load(object sender, EventArgs e)
        {
            GridGrados.Rows.Clear();
            grados = objGrado.Listar();
            if (grados.Count != 0) 
            {
                GridGrados.Visible = true;
                lblSinDatos.Visible= false;
                foreach (Grado grado in grados)
                {
                    GridGrados.Rows.Add(new object[] { grado.Id, "", grado.Descripcion });
                }
            }
            else
            {
                GridGrados.Visible= false;
                lblSinDatos.Visible= true;
                // mensaje en el grid de que no hay nada ingresado aún
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Mensaje = objGrado.Insertar(txtDescripcion.Text);
            MessageBox.Show(Mensaje, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpiar();
            FrmGrados_Load(sender, EventArgs.Empty);
        }

        private void Limpiar() 
        {
            txtDescripcion.Text = string.Empty;
            txtCodigo.Text = string.Empty;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objGrado.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text);
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmGrados_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?","Mensaje",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes) 
            {
                Mensaje = objGrado.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmGrados_Load(sender, EventArgs.Empty);
            }
        }

        private void GridGrados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var h = Properties.Resources.Check16.Height;
                var w = Properties.Resources.Check16.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Check16, new Rectangle(x, y, w, h));
                e.Handled= true;
            }
        }

        private void GridGrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridGrados.Columns[e.ColumnIndex].Name == "GrdBtnSel") 
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridGrados.Rows[indice].Cells["GradoId"].Value.ToString();
                    txtDescripcion.Text = GridGrados.Rows[indice].Cells["GradoDescripcion"].Value.ToString();
                }
            }
        }

        private void Buscar()
        {
            if (GridGrados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridGrados.Rows)
                {
                    if (row.Cells["GradoDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else 
                    { 
                        row.Visible = false; 
                    }
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
