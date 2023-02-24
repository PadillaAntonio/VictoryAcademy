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
    public partial class FrmTiposProgramas : Form
    {
        private List<TipoPrograma> lTipoPrograma = new List<TipoPrograma>();
        private CN_TipoProgramas objTipoPrograma = new CN_TipoProgramas();
        private string Mensaje = string.Empty;
        public FrmTiposProgramas()
        {
            InitializeComponent();
        }

        private void FrmTiposProgramas_Load(object sender, EventArgs e)
        {
            GridTipoProgramas.Rows.Clear();
            lTipoPrograma = objTipoPrograma.Listar();
            if (lTipoPrograma.Count > 0 )
            {
                lblSinDatos.Visible= false;
                GridTipoProgramas.Visible= true;
                foreach (TipoPrograma tpoprograma in lTipoPrograma)
                {
                    GridTipoProgramas.Rows.Add(new object[] { tpoprograma.Id, "", tpoprograma.Descripcion });
                }
            }
            else
            {
                lblSinDatos.Visible= true;
                GridTipoProgramas.Visible= false;
            }
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtCodigo.Text = "";
        }

        private void GridTipoProgramas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridTipoProgramas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridTipoProgramas.Columns[e.ColumnIndex].Name == "GridBtnSel")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridTipoProgramas.Rows[indice].Cells["TipoProgramaId"].Value.ToString();
                    txtDescripcion.Text = GridTipoProgramas.Rows[indice].Cells["TipoProgramaDescripcion"].Value.ToString();
                }
            }
        }

        private void Buscar()
        {
            if (GridTipoProgramas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridTipoProgramas.Rows)
                {
                    if (row.Cells["TipoProgramaDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Mensaje = objTipoPrograma.Insertar(txtDescripcion.Text);
            MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpiar();
            FrmTiposProgramas_Load(sender, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoPrograma.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text);
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposProgramas_Load(sender, EventArgs.Empty);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoPrograma.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposProgramas_Load(sender, EventArgs.Empty);
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
