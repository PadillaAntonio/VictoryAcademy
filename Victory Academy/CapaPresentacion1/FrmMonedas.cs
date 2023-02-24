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
    public partial class FrmMonedas : Form
    {
        private List<Moneda> monedas = new List<Moneda>();
        private CN_Moneda objMoneda = new CN_Moneda();
        private string Mensaje = string.Empty;
        public FrmMonedas()
        {
            InitializeComponent();
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            GridMonedas.Rows.Clear();
            monedas = objMoneda.Listar();
            if (monedas.Count > 0 )
            {
                GridMonedas.Visible = true;
                lblSinDatos.Visible = false;
                foreach (Moneda moneda in monedas)
                {
                    GridMonedas.Rows.Add(new object[] {moneda.Id, "", moneda.Descripcion, moneda.Signo });
                }
            }
            else
            {
                GridMonedas.Visible = false;
                lblSinDatos.Visible = true;
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtSigno.Text = string.Empty;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Mensaje = objMoneda.Insertar(txtDescripcion.Text, txtSigno.Text);
            MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpiar();
            FrmMonedas_Load(sender, EventArgs.Empty);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objMoneda.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, txtSigno.Text);
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmMonedas_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objMoneda.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmMonedas_Load(sender, EventArgs.Empty);
            }
        }

        private void GridMonedas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridMonedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridMonedas.Columns[e.ColumnIndex].Name == "GrdBtnSel")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridMonedas.Rows[indice].Cells["MonedaId"].Value.ToString();
                    txtDescripcion.Text = GridMonedas.Rows[indice].Cells["MonedaDescripcion"].Value.ToString();
                    txtSigno.Text = GridMonedas.Rows[indice].Cells["MonedaSigno"].Value.ToString();
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (GridMonedas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridMonedas.Rows)
                {
                    if (row.Cells["MonedaDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
