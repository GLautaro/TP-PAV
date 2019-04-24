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

        public Boolean validarDatos()
        {
            if (txt_nombre.Text.Trim() == "")
            {
                MessageBox.Show("Error en el nombre de Tipo de Franquicia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return false;
            }
            if (txt_montoMinimo.Text == "" || (int.Parse(txt_montoMinimo.Text) < 0))
            {
                MessageBox.Show("Error en el valor Monto Minimo de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_montoMinimo.Focus();
                return false;
            }
            if (txt_porcentajeDescuento.Text == "" || (int.Parse(txt_porcentajeDescuento.Text) < 0 || int.Parse(txt_porcentajeDescuento.Text) > 100))
            {
                MessageBox.Show("Error en el valor Porcentaje de Descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_porcentajeDescuento.Focus();
                return false;
            }
            return true;
        }
        private void bloquearCajasTexto()
        {
            
            txt_nombre.Enabled = false;
            txt_montoMinimo.Enabled = false;
            txt_porcentajeDescuento.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = false;
            btn_cancelar.Enabled = false;
        }
        private void desbloquearBotonesPrincipales(bool value)
        {
            btn_habilitarModificarTipoFranquicia.Enabled = value;
            btn_eliminarFranquicia.Enabled = value;
            btn_habilitarAgregarTipoFranquicia.Enabled = value;

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
            desbloquearBotonesPrincipales(false);
        }
        private void btn_agregarTipoFranquicia_Click(object sender, EventArgs e)
        {
                        if (validarDatos())
                        {
                            if (priv_tipoFranquicia.altaTipoFranquicia(int.Parse(txt_montoMinimo.Text), int.Parse(txt_porcentajeDescuento.Text), txt_nombre.Text))
                            {

                                DialogResult result = MessageBox.Show("Tipo de Franquicia cargada correctamente\n¿Desea cargar otra franquicia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.No)
                                {
                                    limpiarCajasTexto();
                                    bloquearCajasTexto();
                                    btn_agregarTipoFranquicia.Visible = false;
                                    dgv_tipoFranquicia.Enabled = true;
                                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                                    desbloquearBotonesPrincipales(true);
                                }
                                else
                                {
                                    limpiarCajasTexto();
                                    txt_nombre.Focus();
                                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error al cargar el nuevo tipo de franquicia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                           
                        }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCajasTexto();
            bloquearCajasTexto();
            dgv_tipoFranquicia.Enabled = true;
            btn_agregarTipoFranquicia.Visible = false;
            desbloquearBotonesPrincipales(true);
        }

        private void btn_habilitarModificarTipoFranquicia_Click(object sender, EventArgs e)
        {
            if (dgv_tipoFranquicia.SelectedRows.Count < 1)
            {
                MessageBox.Show("No existen franquicias cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            desbloquearCajasTexto();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            txt_porcentajeDescuento.Text = dgv_tipoFranquicia.CurrentRow.Cells["porcentaje_descuento"].Value.ToString();
            dgv_tipoFranquicia.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = true;
            btn_modificarTipoFranquicia.Visible = true;
            desbloquearBotonesPrincipales(false);

        }

        private void dgv_tipoFranquicia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            txt_porcentajeDescuento.Text = dgv_tipoFranquicia.CurrentRow.Cells["porcentaje_descuento"].Value.ToString();

        }

        private void btn_modificarTipoFranquicia_Click(object sender, EventArgs e)
        {
       

            if (validarDatos())
            {   
                TipoFranquicia priv_tipoFranquiciaModificar = new TipoFranquicia();
                priv_tipoFranquiciaModificar.pub_monto_minimo_compra = int.Parse(txt_montoMinimo.Text);
                priv_tipoFranquiciaModificar.pub_porcentaje_descuento = int.Parse(txt_porcentajeDescuento.Text);
                priv_tipoFranquiciaModificar.pub_nombre_tipo_franquicia = txt_nombre.Text;
                priv_tipoFranquiciaModificar.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                if (priv_tipoFranquiciaModificar.modificarTipoFranquicia())
                {
                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                    MessageBox.Show("Se modificó correctamente.");

                }
                else
                {
                    MessageBox.Show("Error al tratar de modificar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiarCajasTexto();
                bloquearCajasTexto();
                dgv_tipoFranquicia.Enabled = true;
                desbloquearBotonesPrincipales(true);
            }
            
             

        }

        private void btn_eliminarFranquicia_Click(object sender, EventArgs e)
        {
            if (dgv_tipoFranquicia.SelectedRows.Count < 1)
            {
                MessageBox.Show("No existen franquicias cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este tipo de franquicia\n La accion no se puede deshacer?",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                TipoFranquicia priv_tipoFranquiciaEliminar = new TipoFranquicia();
                priv_tipoFranquiciaEliminar.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                if (priv_tipoFranquiciaEliminar.eliminarFranquicia())
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar el tipo de franquicia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frm_TipoFranquicia_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_formularioPadre.pub_cmb_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            priv_formularioPadre.pub_cmb_tipoFranquicia.SelectedIndex = priv_selectedCmbIndex;
        }

        private void txt_montoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && char.IsControl(e.KeyChar) != true)
            {
                MessageBox.Show("No es un valor permitido");
                //borra el caracter no permitido
                e.Handled = true;
            }
        }


        private void txt_porcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && char.IsControl(e.KeyChar) != true)
            {
                MessageBox.Show("No es un valor permitido");
                //borra el caracter no permitido
                e.Handled = true;
            }
        }

  

        
        

     
    }
}
