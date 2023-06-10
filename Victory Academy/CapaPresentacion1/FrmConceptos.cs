using CapaEntidad;
using CapaNegocio;
using CapaPresentacion1.Utilidades;
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
    public partial class FrmConceptos : Form
    {
        private List<Concepto> conceptos = new List<Concepto>();
        private CN_Concepto objConcepto = new CN_Concepto();
        private string Mensaje = string.Empty;
        private List<Moneda> monedas = new List<Moneda>();
        private CN_Moneda obj_moneda = new CN_Moneda();
        public FrmConceptos()
        {
            InitializeComponent();
            // Tipo de concepto
            cboTipo.Items.Clear();
            cboTipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Seleccionar" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Tipo de programa" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Tipo de torneo" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Examen" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Seminario" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 5, Texto = "Mercaderías" });
            cboTipo.Items.Add(new OpcionCombo() { Valor = 9, Texto = "Otros" });
            cboTipo.DisplayMember = "Texto";
            cboTipo.ValueMember = "Valor";
            cboTipo.SelectedIndex = 0;

            // Referencia
            cboReferencia.Items.Clear();
            cboReferencia.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Corresponde"});
            cboReferencia.DisplayMember = "Texto";
            cboReferencia.ValueMember = "Valor";
            cboReferencia.SelectedIndex = 0;

            //Monedas
            monedas = obj_moneda.Listar();
            cboMoneda.Items.Clear();
            cboMoneda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Seleccionar" });
            foreach(Moneda moneda in monedas)
            {
                cboMoneda.Items.Add(new OpcionCombo() { Valor = moneda.Id, Texto = moneda.Signo });
            }
            cboMoneda.DisplayMember = "Texto";
            cboMoneda.ValueMember = "Valor";
            cboMoneda.SelectedIndex = 0;

            // Check Precio
            panelPrecio.Visible = false;
        }

        private void FrmConceptos_Load(object sender, EventArgs e)
        {


            conceptos = objConcepto.Listar();
            GridConceptos.Rows.Clear();
            if (conceptos.Count > 0 )
            {
                GridConceptos.Visible = true;
                lblSinDatos.Visible = false;
                foreach(Concepto concepto in conceptos)
                {
                    GridConceptos.Rows.Add(new object[] { concepto.Id, "", concepto.Descripcion, concepto.Tipo, concepto.Referencia });
                }
            }
            else
            { 
                GridConceptos.Visible = false; 
                GridPrecios.Visible = false;
                lblSinDatos.Visible = true;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<(int, string)> Lista = new List<(int, string)>();
            ReferenciaConcepto obj_refConcepto = new ReferenciaConcepto();
            int tipoSeleccionado = Convert.ToInt32(((OpcionCombo)cboTipo.SelectedItem).Valor);
            string tipoTextoSeleccionado = Convert.ToString(((OpcionCombo)cboTipo.SelectedItem).Texto), mensaje = string.Empty;
            cboReferencia.Items.Clear();
            if (tipoSeleccionado == 1 || tipoSeleccionado == 2)
            {
                txtDescripcion.Enabled = false;
                Lista = obj_refConcepto.Listar(tipoSeleccionado);
                if (Lista.Count > 0)
                {
                    foreach ((int, string) tipo in Lista)
                    {
                        cboReferencia.Items.Add(new OpcionCombo() { Valor = tipo.Item1, Texto = tipo.Item2 });
                    }
                }
                else
                {
                    mensaje = "No se ingresó ningún " + tipoTextoSeleccionado;
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Enabled = true;
                }
            }
            else
            {
                txtDescripcion.Enabled = true;
                txtDescripcion.Text = string.Empty;
                cboReferencia.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No corresponde" });
            }
            cboReferencia.DisplayMember = "Texto";
            cboReferencia.ValueMember = "Valor";
            cboReferencia.SelectedIndex = 0;
        }

        private void cboReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 1 || cboTipo.SelectedIndex == 2)//(Convert.ToInt32(((OpcionCombo)cboTipo.SelectedIndex).Valor) > 0)
            {
                txtDescripcion.Text = Convert.ToString(((OpcionCombo)cboReferencia.SelectedItem).Texto);
            }
            else
            {
                txtDescripcion.Text = string.Empty;
            }    
        }

        private void chkPrecio_Click(object sender, EventArgs e)
        {
            MostrarPrecio(0);
        }

        private void MostrarPrecio(int bandera)
        {
            if (chkPrecio.Checked == true)
            {
                panelPrecio.Visible = true;
            }
            else
            {
                panelPrecio.Visible = false;
            }

            if (bandera == 1) // Quiere decir que hay datos en los txt del panel
            {

            }
            else
            {
                cboMoneda.SelectedIndex = 0;
                txtPrecio.Text = string.Empty;
            }
        }

        private void GridConceptos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        /* Esto en principio no sería necesario
        private void GridPrecios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        }*/
    }
}
