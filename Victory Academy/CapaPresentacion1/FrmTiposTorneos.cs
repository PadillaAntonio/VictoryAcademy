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
    public partial class FrmTiposTorneos : Form
    {
        private List<TipoTorneo> TiposTorneos = new List<TipoTorneo>();
        private CN_TipoTorneo objTipoTorneo = new CN_TipoTorneo();
        private string Mensaje = string.Empty;
        public FrmTiposTorneos()
        {
            InitializeComponent();
        }

        private void FrmTiposTorneos_Load(object sender, EventArgs e)
        {
            GridTipoTorneo.Rows.Clear();
            TiposTorneos = objTipoTorneo.Listar();
            if (TiposTorneos.Count > 0 )
            {
                GridTipoTorneo.Visible = true;
                lblSinDatos.Visible = false;
                foreach (TipoTorneo tipoTorneo in TiposTorneos)
                {
                    GridTipoTorneo.Rows.Add(new object[] {tipoTorneo.Id, "", tipoTorneo.Descripcion, tipoTorneo.primerLugarPuntos,
                                                          tipoTorneo.segundoLugarPuntos, tipoTorneo.tercerLugarPuntos});
                }
            }
            else 
            {
                GridTipoTorneo.Visible = false;
                lblSinDatos.Visible = true;
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPuntos1.Text = string.Empty;
            txtPuntos2.Text = string.Empty;
            txtPuntos3.Text = string.Empty;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int puntos1 = Convert.ToInt32(txtPuntos1.Text);
            int puntos2 = Convert.ToInt32(txtPuntos2.Text);
            int puntos3 = Convert.ToInt32(txtPuntos3.Text);
            Mensaje = objTipoTorneo.Insertar(txtDescripcion.Text, puntos1, puntos2, puntos3);
            MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpiar();
            FrmTiposTorneos_Load(sender, EventArgs.Empty);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int puntos1 = Convert.ToInt32(txtPuntos1.Text);
            int puntos2 = Convert.ToInt32(txtPuntos2.Text);
            int puntos3 = Convert.ToInt32(txtPuntos3.Text);
            DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoTorneo.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, puntos1, puntos2, puntos3);
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposTorneos_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoTorneo.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposTorneos_Load(sender, EventArgs.Empty);
            }
        }

        private void GridTipoTorneo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                e.Handled = true;
            }
        }

        private void GridTipoTorneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridTipoTorneo.Columns[e.ColumnIndex].Name == "GrdBtnSel")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridTipoTorneo.Rows[indice].Cells["TipoTorneoId"].Value.ToString();
                    txtDescripcion.Text = GridTipoTorneo.Rows[indice].Cells["TipoTorneoDescripcion"].Value.ToString();
                    txtPuntos1.Text = GridTipoTorneo.Rows[indice].Cells["TipoTorneoPuntos1"].Value.ToString();
                    txtPuntos2.Text = GridTipoTorneo.Rows[indice].Cells["TipoTorneoPuntos2"].Value.ToString();
                    txtPuntos3.Text = GridTipoTorneo.Rows[indice].Cells["TipoTorneoPuntos3"].Value.ToString();
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (GridTipoTorneo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridTipoTorneo.Rows)
                {
                    if (row.Cells["TipoTorneoDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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
    }
}
