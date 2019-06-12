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
    public partial class frm_ABM_TipoProducto : Form
    {
        TipoProducto priv_tipoProducto = new TipoProducto();
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

        public frm_ABM_TipoProducto()
        {
            InitializeComponent();
        }

        private void dgv_tipoProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_tipoProducto.CurrentRow.Cells["nombre_tipo_producto"].Value.ToString();
            txt_descripcion.Text = dgv_tipoProducto.CurrentRow.Cells["descripcion"].Value.ToString();
            actualizarTextBtnState();
        }

        private void frm_ABM_TipoProducto_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
            actualizarTextBtnState();
        }

        private void bloquearCajasTexto()
        {
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            btn_modificarTipoProducto.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void desbloquearCajasTexto()
        {
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
            btn_modificarTipoProducto.Enabled = true;
            btn_cancelar.Enabled = true;
            msj_error.Visible = false;
            msj_registro_ok.Visible = false;
            msj_modificado_ok.Visible = false;
            msj_eliminado_ok.Visible = false;
        }

        private void limpiarCajasTexto()
        {
            txt_descripcion.Clear();
            txt_nombre.Clear();

        }

        public void habilitarBotones()
        {
            btn_habilitarAgregarTipoProducto.Enabled = true;
            btn_habilitarModificarTipoProducto.Enabled = true;
            btn_habilitarTipoProducto.Enabled = true;
        }

        private void btn_habilitarAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_agregarTipoProducto.Visible = true;
            btn_habilitarModificarTipoProducto.Enabled = false;
            btn_habilitarTipoProducto.Enabled = false;
        }

        private void btn_agregarTipoProducto_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text != "")
            {
                if (priv_tipoProducto.altaTipoProducto(txt_nombre.Text, txt_descripcion.Text))
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
            btn_agregarTipoProducto.Visible = false;
            dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
        }

        private void btn_habilitarModificarTipoProducto_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_modificarTipoProducto.Enabled = true;
            btn_habilitarAgregarTipoProducto.Enabled = false;
            btn_habilitarTipoProducto.Enabled = false;
        }

        private void btn_modificarTipoProducto_Click(object sender, EventArgs e)
        {
            int priv_id_tipo_producto = int.Parse(dgv_tipoProducto.CurrentRow.Cells["id_tipo_producto"].Value.ToString());

            if (txt_nombre.Text != "")
            {
                if (priv_tipoProducto.modificarTipoProducto(priv_id_tipo_producto, txt_nombre.Text, txt_descripcion.Text))
                {
                    dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
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

        private void actualizarTextBtnState()
        {
            if (dgv_tipoProducto.SelectedRows.Count < 1)
            {

                return;
            }
            if (bool.Parse(dgv_tipoProducto.CurrentRow.Cells["habilitado"].Value.ToString()))
            {
                btn_habilitarTipoProducto.Text = "Deshabilitar";
            }
            else
            {
                btn_habilitarTipoProducto.Text = "Habilitar";
            }
        }

        private void btn_eliminarTipoProducto_Click(object sender, EventArgs e)
        {
            msj_error.Visible = false;

            int priv_id_tipo_producto = int.Parse(dgv_tipoProducto.CurrentRow.Cells["id_tipo_producto"].Value.ToString());
            int priv_estado = Convert.ToInt32(!bool.Parse(dgv_tipoProducto.CurrentRow.Cells["habilitado"].Value.ToString()));

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea habilitar/deshabilitar el tipo de producto código " + priv_id_tipo_producto + " ?",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (priv_tipoProducto.handleStateTipoProducto(priv_id_tipo_producto, priv_estado))
                {
                    msj_eliminado_ok.Visible = true;
                    dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
                    limpiarCajasTexto();
                    actualizarTextBtnState();
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
            btn_agregarTipoProducto.Visible = false;
        }

        private void frm_TipoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_formularioPadre.pub_cmb_tipo_producto.DataSource = priv_tipoProducto.traerTipoProducto();
            priv_formularioPadre.pub_cmb_tipo_producto.SelectedIndex = priv_selectedCmbIndex;
        }
    }
}
