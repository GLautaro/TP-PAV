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
        public frm_TipoFranquicia()
        {
            InitializeComponent();
        }

        private void bloquearCajasTexto()
        {
            txt_nombre.Enabled = false;
            txt_montoMinimo.Enabled = false;
            txt_porcentajeDescuento.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = false;
            btn_cancelar.Enabled = false;

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
        }
        private void frm_TipoFranquicia_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();          

        }

        private void btn_habilitarAgregarTipoFranquicia_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_agregarTipoFranquicia.Visible = true;

        }

        private void btn_agregarTipoFranquicia_Click(object sender, EventArgs e)
        {
            priv_tipoFranquicia.pub_nombre_tipo_franquicia = txt_nombre.Text;
            priv_tipoFranquicia.pub_monto_minimo_compra = int.Parse(txt_montoMinimo.Text);
            priv_tipoFranquicia.pub_porcentaje_descuento = int.Parse(txt_porcentajeDescuento.Text);
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
            dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia(); 

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCajasTexto();
            bloquearCajasTexto();
            btn_agregarTipoFranquicia.Visible = false;
        }

        private void btn_habilitarModificarTipoFranquicia_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_modificarTipoFranquicia.Enabled = true;

            

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

     
    }
}
