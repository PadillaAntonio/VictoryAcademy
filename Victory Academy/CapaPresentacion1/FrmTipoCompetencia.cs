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
    public partial class FrmTipoCompetencia : Form
    {
        private List<TipoCompetencia> TiposCompetencias = new List<TipoCompetencia>();
        private CN_TipoCompetencia objTipoCompetencia = new CN_TipoCompetencia();
        private string Mensaje = string.Empty;
        public FrmTipoCompetencia()
        {
            InitializeComponent();
            cboBusqueda.Items.Clear();
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Combate" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Formas" });
            cboBusqueda.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Armas" });
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            CboDisciplina.Items.Clear();
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Seleccionar" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Combate" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Formas" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Armas" });
            CboDisciplina.DisplayMember = "Texto";
            CboDisciplina.ValueMember = "Valor";
            CboDisciplina.SelectedIndex = 0;
        }

        private void FrmTipoCompetencia_Load(object sender, EventArgs e)
        {
            /*
            CboDisciplina.Items.Clear();
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Seleccionar" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Combate" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Formas" });
            CboDisciplina.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Armas" });
            CboDisciplina.DisplayMember = "Texto";
            CboDisciplina.ValueMember = "Valor";
            CboDisciplina.SelectedIndex = 0;
            */
            GridTipoCompetencia.Rows.Clear();
            TiposCompetencias = objTipoCompetencia.Listar();
            if (TiposCompetencias.Count != 0)
            {
                GridTipoCompetencia.Visible = true;
                lblSinDatos.Visible = false;

                foreach (TipoCompetencia tipoCompetencia in TiposCompetencias)
                {
                    GridTipoCompetencia.Rows.Add(new object[] { tipoCompetencia.Id, "", tipoCompetencia.Descripcion, tipoCompetencia.disciplina, "" });
                }
                // Para que se muestre la descripción de la disciplina y no el valor entero
                foreach (DataGridViewRow row in GridTipoCompetencia.Rows)
                {
                    if (row.Cells["TipoCompetenciaDisciplinaId"].Value != null)
                    {
                        switch (Convert.ToInt32(row.Cells["TipoCompetenciaDisciplinaId"].Value.ToString().Trim()))
                        {
                            case 1:
                                row.Cells["TipoCompetenciaDisciplinaDescripcion"].Value = "COMBATE";
                                break;
                            case 2:
                                row.Cells["TipoCompetenciaDisciplinaDescripcion"].Value = "FORMAS";
                                break;
                            case 3:
                                row.Cells["TipoCompetenciaDisciplinaDescripcion"].Value = "ARMAS";
                                break;
                        }
                    }

                }
            }
            else
            {
                GridTipoCompetencia.Visible = false;
                lblSinDatos.Visible = true;
                // mensaje en el grid de que no hay nada ingresado aún
            }
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            CboDisciplina.SelectedIndex = 0;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((OpcionCombo)CboDisciplina.SelectedItem).Valor) == 0)
            {
                MessageBox.Show("Debe seleccionar una disciplina", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Mensaje = objTipoCompetencia.Insertar(txtDescripcion.Text, Convert.ToInt32(((OpcionCombo)CboDisciplina.SelectedItem).Valor));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTipoCompetencia_Load(sender, EventArgs.Empty);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((OpcionCombo)CboDisciplina.SelectedItem).Valor) == 0)
            {
                MessageBox.Show("Debe seleccionar una disciplina", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult res = MessageBox.Show("Se va a modificar el registro. \n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    Mensaje = objTipoCompetencia.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, Convert.ToInt32(((OpcionCombo)CboDisciplina.SelectedItem).Valor));
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    FrmTipoCompetencia_Load(sender, EventArgs.Empty);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Mensaje = objTipoCompetencia.Eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                FrmTipoCompetencia_Load(sender, EventArgs.Empty);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (GridTipoCompetencia.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridTipoCompetencia.Rows)
                {
                    if (row.Cells["TipoCompetenciaDescripcion"].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

        private void cboBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (GridTipoCompetencia.Rows.Count > 0)
            {
                int Filtro = Convert.ToInt32(((OpcionCombo)cboBusqueda.SelectedItem).Valor);
                foreach (DataGridViewRow row in GridTipoCompetencia.Rows)
                {
                    if (row.Cells["TipoCompetenciaDisciplinaId"].Value != null &&
                        (Convert.ToInt32(row.Cells["TipoCompetenciaDisciplinaId"].Value.ToString().Trim()) == Filtro || Filtro == 0))
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

        private void GridTipoCompetencia_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridTipoCompetencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridTipoCompetencia.Columns[e.ColumnIndex].Name == "GridBtnSel")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCodigo.Text = GridTipoCompetencia.Rows[indice].Cells["TipoCompetenciaId"].Value.ToString();
                    txtDescripcion.Text = GridTipoCompetencia.Rows[indice].Cells["TipoCompetenciaDescripcion"].Value.ToString();
                    foreach (OpcionCombo op in CboDisciplina.Items)
                    {
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(GridTipoCompetencia.Rows[indice].Cells["TipoCompetenciaDisciplinaId"].Value))
                        {
                            int indiceOp = CboDisciplina.Items.IndexOf(op);
                            CboDisciplina.SelectedIndex = indiceOp;
                        }
                    }
                }
            }
        }
    }
}
