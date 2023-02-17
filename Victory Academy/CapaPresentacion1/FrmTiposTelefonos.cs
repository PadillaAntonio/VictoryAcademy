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
    public partial class FrmTiposTelefonos : Form
    {
        private List<TipoTelefono> TiposTelefonos = new List<TipoTelefono>();
        private CN_TipoTelefono objTipoTelefono = new CN_TipoTelefono();
        private string Mensaje = string.Empty;
        public FrmTiposTelefonos()
        {
            InitializeComponent();
        }

        private void FrmTiposTelefonos_Load(object sender, EventArgs e)
        {
            GridTipoTelefonos.Rows.Clear();
            TiposTelefonos = objTipoTelefono.Listar();
            if (TiposTelefonos.Count > 0)
            {
                GridTipoTelefonos.Visible= true;
                lblSinDatos.Visible= false;
                foreach (TipoTelefono telefono in TiposTelefonos)
                {
                    GridTipoTelefonos.Rows.Add(new object[] { telefono.Id, "", telefono.Descripcion });
                }
            }
            else
            {
                GridTipoTelefonos.Visible= false;
                lblSinDatos.Visible = true;
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Mensaje = objTipoTelefono.Insertar(txtDescripcion.Text);
            MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Limpiar();
            FrmTiposTelefonos_Load(sender, EventArgs.Empty);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoTelefono.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text);
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposTelefonos_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoTelefono.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTiposTelefonos_Load(sender, EventArgs.Empty);
            }
        }

        private void GridTipoTelefonos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridTipoTelefonos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridTipoTelefonos.Columns[e.ColumnIndex].Name == "GrdBtnSel")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridTipoTelefonos.Rows[indice].Cells["TipoTelefonoId"].Value.ToString();
                    txtDescripcion.Text = GridTipoTelefonos.Rows[indice].Cells["TipoTelefonoDescripcion"].Value.ToString();
                }
            }
        }

        private void Buscar()
        {
            if (GridTipoTelefonos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridTipoTelefonos.Rows)
                {
                    if (row.Cells["TipoTelefonoDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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
    }
}
