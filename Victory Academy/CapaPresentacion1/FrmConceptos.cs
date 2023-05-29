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

            //Monedas
            monedas = obj_moneda.Listar();
            cboMoneda.Items.Clear();
            cboMoneda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Seleccionar" });
            foreach(Moneda moneda in monedas)
            {
                cboMoneda.Items.Add(new OpcionCombo() { Valor = moneda.Id, Texto = moneda.Signo });
            }
            cboTipo.DisplayMember = "Texto";
            cboTipo.ValueMember = "Valor";
            cboTipo.SelectedIndex = 0;
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
                cboReferencia.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No corresponde" });
            }
            cboReferencia.DisplayMember = "Texto";
            cboReferencia.ValueMember = "Valor";
        }

        private void cboReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((OpcionCombo)cboTipo.SelectedItem).Valor) > 0)
            {
                txtDescripcion.Text = Convert.ToString(((OpcionCombo)cboReferencia.SelectedItem).Texto);
            }
            else
            {
                txtDescripcion.Text = string.Empty;
            }    
        }
    }
}
