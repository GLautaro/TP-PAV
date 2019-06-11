using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.clases;

namespace TP_PAV.formularios
{
    public partial class frm_ABM_UnidadMedida : Form
    {
        UnidadMedida priv_UnidadMedida = new UnidadMedida();
        uc_ABM_Producto priv_formularioPadre = new uc_ABM_Producto();
        int priv_selectedCmbIndex;

        public uc_ABM_Producto pub_formularioPadre
        {
            set { priv_formularioPadre = value; }
        }

        public int pub_selectedIndex
        {
            set { priv_selectedCmbIndex = value; }
        }

        public frm_ABM_UnidadMedida()
        {
            InitializeComponent();
        }

        private void dgv_tipoProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_unidadMedida.CurrentRow.Cells["nombre_u_medida"].Value.ToString();
        }

        private void frm_ABM_UnidadMedida_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_unidadMedida.DataSource = priv_UnidadMedida.traerUnidadMedida();
        }

        private void bloquearCajasTexto()
        {
            txt_nombre.Enabled = false;
            btn_modificarUnidadMedida.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void desbloquearCajasTexto()
        {
            txt_nombre.Enabled = true;
            btn_modificarUnidadMedida.Enabled = true;
            btn_cancelar.Enabled = true;
            msj_error.Visible = false;
            msj_registro_ok.Visible = false;
            msj_modificado_ok.Visible = false;
            msj_eliminado_ok.Visible = false;
        }

        private void limpiarCajasTexto()
        {
            txt_nombre.Clear();
        }

        public void habilitarBotones()
        {
            btn_habilitarAgregarUnidadMedida.Enabled = true;
            btn_habilitarModificarUnidadMedida.Enabled = true;
            btn_eliminarUnidadMedida.Enabled = true;
        }

        private void btn_habilitarAgregarUnidadMedida_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_agregarUnidadMedida.Visible = true;
            btn_habilitarModificarUnidadMedida.Enabled = false;
            btn_eliminarUnidadMedida.Enabled = false;
        }

        private void btn_agregarUnidadMedida_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                if (priv_UnidadMedida.altaUnidadMedida(txt_nombre.Text))
                {

                    msj_registro_ok.Visible = true;

                }
                else
                {

                    MessageBox.Show("Se ha producido un error. Por favor reintente.");
                }
            }
            else
            {
                msj_error.Visible = true;
            }

            limpiarCajasTexto();
            bloquearCajasTexto();
            habilitarBotones();
            btn_agregarUnidadMedida.Visible = false;
            dgv_unidadMedida.DataSource = priv_UnidadMedida.traerUnidadMedida();
        }

        private void btn_habilitarModificarUnidadMedida_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_modificarUnidadMedida.Enabled = true;
            btn_habilitarAgregarUnidadMedida.Enabled = false;
            btn_eliminarUnidadMedida.Enabled = false;
        }

        private void btn_modificarUnidadMedida_Click(object sender, EventArgs e)
        {
            int priv_id_unidad_medida = int.Parse(dgv_unidadMedida.CurrentRow.Cells["id_u_medida"].Value.ToString());

            if (txt_nombre.Text != "")
            {
                if (priv_UnidadMedida.modificarUnidadMedida(priv_id_unidad_medida, txt_nombre.Text))
                {
                    dgv_unidadMedida.DataSource = priv_UnidadMedida.traerUnidadMedida();
                    msj_modificado_ok.Visible = true;

                }
                else
                {
                    MessageBox.Show("Se ha producido un error. Por favor reintente.");
                }
            }
            else
            {
                msj_error.Visible = true;
            }

            limpiarCajasTexto();
            bloquearCajasTexto();
            habilitarBotones();
        }

        private void btn_eliminarUnidadMedida_Click(object sender, EventArgs e)
        {
            msj_error.Visible = false;

            int priv_id_unidad_medida = int.Parse(dgv_unidadMedida.CurrentRow.Cells["id_u_medida"].Value.ToString());

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la undiad de medida código " + priv_id_unidad_medida + " ?",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (priv_UnidadMedida.eliminarUnidadMedida(priv_id_unidad_medida))
                {
                    msj_eliminado_ok.Visible = true;
                    dgv_unidadMedida.DataSource = priv_UnidadMedida.traerUnidadMedida();
                    limpiarCajasTexto();
                }
                else
                {
                    MessageBox.Show("Se ha producido un error. Por favor reintente.");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            limpiarCajasTexto();
            habilitarBotones();
            btn_agregarUnidadMedida.Visible = false;
        }

        private void frm_UnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_formularioPadre.pub_cmb_unidadMedida.DataSource = priv_UnidadMedida.traerUnidadMedida();
            priv_formularioPadre.pub_cmb_unidadMedida.SelectedIndex = priv_selectedCmbIndex;
        }   

    }
}
