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
                label_validacion_error(true,"Error en el nombre de Tipo de Franquicia");
                txt_nombre.Focus();
                return false;
            }
            if (txt_montoMinimo.Text == "" || (int.Parse(txt_montoMinimo.Text) < 0))
            {
                label_validacion_error(true, "Error en el valor Monto Minimo de compra");
                txt_montoMinimo.Focus();
                return false;
            }
         
            return true;
        }
        private void bloquearCajasTexto()
        {
            
            txt_nombre.Enabled = false;
            txt_montoMinimo.Enabled = false;

            btn_modificarTipoFranquicia.Enabled = false;
            btn_cancelar.Enabled = false;
        }
        private void desbloquearBotonesPrincipales(bool value)
        {
            btn_habilitarModificarTipoFranquicia.Enabled = value;
            btn_handleStateTipoFranquicia.Enabled = value;
            btn_habilitarAgregarTipoFranquicia.Enabled = value;

        }
        private void limpiarCajasTexto()
        {
            txt_montoMinimo.Clear();
            txt_nombre.Clear();

        }

        private void desbloquearCajasTexto()
        {
            txt_nombre.Enabled = true;
            txt_montoMinimo.Enabled = true;

            btn_cancelar.Enabled = true;
            btn_cancelar.Visible = true;
            
        }
        private void frm_TipoFranquicia_Load(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            actualizarTextBtnState();

            
            
        }
        private void label_validacion_error(bool error, string mensaje )
        {

            if(error){
                label_validation.ForeColor = Color.Red;
            }
            else
            {
                label_validation.ForeColor = Color.Green;
            }
            label_validation.Text = mensaje;
            label_validation.Visible = true;
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
                            if (priv_tipoFranquicia.altaTipoFranquicia(int.Parse(txt_montoMinimo.Text),txt_nombre.Text))
                            {
                                label_validacion_error(false, "Se agrego el Tipo Franquicia correctamente.");
                                    limpiarCajasTexto();
                                    bloquearCajasTexto();
                                    btn_agregarTipoFranquicia.Visible = false;
                                    dgv_tipoFranquicia.Enabled = true;
                                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                                    desbloquearBotonesPrincipales(true);
                                
                         
                               
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
                label_validacion_error(true, "No existen tipos de franquicias cargadas.");
                return;
            }
            desbloquearCajasTexto();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            dgv_tipoFranquicia.Enabled = false;
            btn_modificarTipoFranquicia.Enabled = true;
            btn_modificarTipoFranquicia.Visible = true;
            desbloquearBotonesPrincipales(false);

        }

        private void dgv_tipoFranquicia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre.Text = dgv_tipoFranquicia.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString();
            txt_montoMinimo.Text = dgv_tipoFranquicia.CurrentRow.Cells["monto_minimo_compra"].Value.ToString();
            actualizarTextBtnState();
          
        }
        private void actualizarTextBtnState()
        {
            if (dgv_tipoFranquicia.SelectedRows.Count < 1)
            {
               
                return;
            }
            if (bool.Parse(dgv_tipoFranquicia.CurrentRow.Cells["habilitado_tipo_franquicia"].Value.ToString()))
            {
                btn_handleStateTipoFranquicia.Text = "Deshabilitar";
            }
            else
            {
                btn_handleStateTipoFranquicia.Text = "Habilitar";
            }
        }
        private void btn_modificarTipoFranquicia_Click(object sender, EventArgs e)
        {
       

            if (validarDatos())
            {   
                TipoFranquicia priv_tipoFranquiciaModificar = new TipoFranquicia();
                priv_tipoFranquiciaModificar.pub_monto_minimo_compra = int.Parse(txt_montoMinimo.Text);
                priv_tipoFranquiciaModificar.pub_nombre_tipo_franquicia = txt_nombre.Text;
                priv_tipoFranquiciaModificar.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                if (priv_tipoFranquiciaModificar.modificarTipoFranquicia())
                {
                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                    label_validacion_error(false, "Se modificó correctamente");

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

        private void btn_hanldeStateTipoFranquicia_Click(object sender, EventArgs e)
        {
            if (dgv_tipoFranquicia.SelectedRows.Count < 1)
            {
                label_validacion_error(true, "No existen tipos de franquicias cargadas.");
                return;
            }

                TipoFranquicia priv_tipoFranquiciaHandleState = new TipoFranquicia();
                priv_tipoFranquiciaHandleState.pub_id_tipo_franquicia = int.Parse(dgv_tipoFranquicia.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                priv_tipoFranquiciaHandleState.pub_state_tipo_franquicia = Convert.ToInt32(!bool.Parse(dgv_tipoFranquicia.CurrentRow.Cells["habilitado_tipo_franquicia"].Value.ToString()));
                if (priv_tipoFranquiciaHandleState.handleStateTipoFranquicia())
                {
                    label_validacion_error(false,"Se ha cambiado el estado correctamente");
                    dgv_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar el tipo de franquicia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarTextBtnState();

           
        }
        private void frm_TipoFranquicia_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_formularioPadre.pub_cmb_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            priv_formularioPadre.pub_cmb_tipoFranquicia.SelectedIndex = priv_selectedCmbIndex;
        }

        private void txt_montoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.label_validation.Visible = false;
            if (char.IsDigit(e.KeyChar) != true && char.IsControl(e.KeyChar) != true)
            {
                label_validacion_error(true,"No es un valor permitido");
                
                //borra el caracter no permitido
                e.Handled = true;
            }
        }


      

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.label_validation.Visible = false;
        }

  

        
        

     
    }
}
