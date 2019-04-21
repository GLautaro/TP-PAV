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
    public partial class frm_TipoFranquicia : Form
    {
        TipoFranquicia priv_tipoFranquicia = new TipoFranquicia();
        uc_ABM_Franquicia priv_formularioPadre = new uc_ABM_Franquicia();
        int priv_selectedCmbIndex;
        public frm_TipoFranquicia()
        {
            InitializeComponent();
        }
        public uc_ABM_Franquicia pub_formularioPadre
        {
            set { priv_formularioPadre = value; }
        }
        public int pub_selectedIndex
        {
            set { priv_selectedCmbIndex = value; }
        }
        private void bloquearCajasTexto()
        {
            txt_nombre.Enabled = false;
            txt_montoMinimo.Enabled = false;
            txt_porcentajeDescuento.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = false;
            btn_modificarTipoFranquicia.Visible = false;
            btn_cancelar.Enabled = false;
            btn_cancelar.Visible = false;
        }

        private void limpiarCajasTexto()
        {
            txt_montoMinimo.Clear();
            txt_nombre.Clear();
            txt_porcentajeDescuento.Clear();
        }

        private void desbloquearCajasTexto()
        {
            txt_nombre.Enabled = true;
            txt_montoMinimo.Enabled = true;
            txt_porcentajeDescuento.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_cancelar.Visible = true;
            
        }
        private void frm_TipoFranquicia_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            
            
        }

        private void btn_habilitarAgregarTipoFranquicia_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            limpiarCajasTexto();
            btn_agregarTipoFranquicia.Visible = true;
            btn_agregarTipoFranquicia.Enabled = true;
            dgv_tipoFranquicia.Enabled = false;
        }

        private void btn_agregarTipoFranquicia_Click(object sender, EventArgs e)
        {
            priv_tipoFranquicia.pub_nombre_tipo_franquicia = txt_nombre.Text;
            if (txt_porcentajeDescuento.Text != "")
            {
                priv_tipoFranquicia.pub_porcentaje_descuento = int.Parse(txt_porcentajeDescuento.Text);
            }
            if (txt_montoMinimo.Text != "")
            {
                priv_tipoFranquicia.pub_monto_minimo_compra = int.Parse(txt_montoMinimo.Text);
                
            }
            
            if (priv_tipoFranquicia.altaTipoFranquicia())
            {
  
                MessageBox.Show("Se cargo correctamente!");

            }
            else
            {
             
                MessageBox.Show("Error!");
            }
            limpiarCajasTexto();
            bloquearCajasTexto();
            btn_agregarTipoFranquicia.Visible = false;
            dgv_tipoFranquicia.Enabled = true;
            dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia(); 

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCajasTexto();
            bloquearCajasTexto();
            dgv_tipoFranquicia.Enabled = true;
            btn_agregarTipoFranquicia.Visible = false;
        }

        private void btn_habilitarModificarTipoFranquicia_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            txt_porcentajeDescuento.Text = dgv_tipoFranquicia.CurrentRow.Cells["porcentaje_descuento"].Value.ToString();
            dgv_tipoFranquicia.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = true;
            btn_modificarTipoFranquicia.Visible = true;
            

        }

        private void dgv_tipoFranquicia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            txt_porcentajeDescuento.Text = dgv_tipoFranquicia.CurrentRow.Cells["porcentaje_descuento"].Value.ToString();

        }

        private void btn_modificarTipoFranquicia_Click(object sender, EventArgs e)
        {
            priv_tipoFranquicia.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
            priv_tipoFranquicia.pub_nombre_tipo_franquicia = txt_nombre.Text;
            priv_tipoFranquicia.pub_monto_minimo_compra = int.Parse(txt_montoMinimo.Text);
            priv_tipoFranquicia.pub_porcentaje_descuento = int.Parse(txt_porcentajeDescuento.Text);
            if (priv_tipoFranquicia.modificarTipoFranquicia())
            {
                dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia(); 
                MessageBox.Show("Se Modifico");

            }
            else
            {
                MessageBox.Show("Error");
            }
            limpiarCajasTexto();
            bloquearCajasTexto();
        }

        private void frm_TipoFranquicia_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_formularioPadre.pub_cmb_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            priv_formularioPadre.pub_cmb_tipoFranquicia.SelectedIndex = priv_selectedCmbIndex;
        }

        private void btn_eliminarFranquicia_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este tipo de franquicia\n La accion no se puede deshacer?",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                priv_tipoFranquicia.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                if (priv_tipoFranquicia.eliminarFranquicia())
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        

     
    }
}
