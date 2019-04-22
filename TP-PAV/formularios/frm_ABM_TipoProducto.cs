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

        public frm_ABM_TipoProducto()
        {
            InitializeComponent();
        }

        private void dgv_tipoProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_tipoProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_descripcion.Text = dgv_tipoProducto.CurrentRow.Cells["Descripción"].Value.ToString();
        }

        private void frm_ABM_TipoProducto_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
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
        }

        private void limpiarCajasTexto()
        {
            txt_descripcion.Clear();
            txt_nombre.Clear();
        }

        private void btn_habilitarAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_agregarTipoProducto.Visible = true;
        }

        private void btn_agregarTipoProducto_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                if (priv_tipoProducto.altaTipoProducto(txt_nombre.Text, txt_descripcion.Text))
                {

                    MessageBox.Show("Tipo de producto registrado correctamente.");

                }
                else
                {

                    MessageBox.Show("Se ha producido un error. Por favor reintente.");
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un nombre.");
            }
            limpiarCajasTexto();
            bloquearCajasTexto();
            btn_agregarTipoProducto.Visible = false;
            dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
        }

        private void btn_habilitarModificarTipoProducto_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_modificarTipoProducto.Enabled = true;
        }

        private void btn_modificarTipoProducto_Click(object sender, EventArgs e)
        {
            int priv_id_tipo_producto = int.Parse(dgv_tipoProducto.CurrentRow.Cells["Código"].Value.ToString());

            if (txt_nombre.Text != "")
            {
                if (priv_tipoProducto.modificarTipoProducto(priv_id_tipo_producto, txt_nombre.Text, txt_descripcion.Text))
                {
                    dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
                    MessageBox.Show("Tipo de producto modificado con éxito.");

                }
                else
                {
                    MessageBox.Show("Se ha producido un error. Por favor reintente.");
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un nombre.");
            }

            limpiarCajasTexto();
            bloquearCajasTexto();
        }

        private void btn_eliminarTipoProducto_Click(object sender, EventArgs e)
        {
            int priv_id_tipo_producto = int.Parse(dgv_tipoProducto.CurrentRow.Cells["Código"].Value.ToString());

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el tipo de producto código " + priv_id_tipo_producto + " ?",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                if (priv_tipoProducto.eliminarTipoProducto(priv_id_tipo_producto))
                {
                    MessageBox.Show("Se ha eliminado el tipo de producto correctamente.");
                    dgv_tipoProducto.DataSource = priv_tipoProducto.traerTipoProducto();
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
        }
    }
}
