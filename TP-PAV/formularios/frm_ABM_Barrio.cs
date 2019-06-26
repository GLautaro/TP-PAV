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
    public partial class frm_ABM_Barrio : Form
    {
        Barrio priv_barrio = new Barrio();
        uc_ABM_Franquicia priv_formularioPadre = new uc_ABM_Franquicia();
        private int priv_selectedCmbIndex;
        private ComboBox priv_cmb_barrios;
        public ComboBox pub_cmb_barrios
        {
            set { priv_cmb_barrios = value; }
        }
        public int pub_selectedIndex
        {
            set { priv_selectedCmbIndex = value; }
        }
        public frm_ABM_Barrio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void desbloquearBotonesPrincipales(bool value)
        {
            btn_habilitarAgregarBarrio.Enabled = value;
            btn_habilitarModificarBarrio.Enabled = value;
            btn_handleStateBarrio.Enabled = value;
        }
        private void resetearFormulario()
        {
            btn_agregarBarrio.Visible = false;
            btn_cancelar.Enabled = false;
            btn_modificarBarrio.Visible = true;
            btn_modificarBarrio.Enabled = false;
            desbloquearBotonesPrincipales(true);
            txt_nombre_barrio.Enabled = false;
            dgv_barrio.Enabled = true;
            txt_nombre_barrio.Text = "";
        }
        private void frm_ABM_Barrio_Load(object sender, EventArgs e)
        {
            dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            resetearFormulario();

        }
        private void btn_habilitarAgregarBarrio_Click(object sender, EventArgs e)
        {
            txt_nombre_barrio.Text = "";
            btn_agregarBarrio.Visible = true;
            btn_cancelar.Enabled = true;
            btn_modificarBarrio.Visible = false;
            desbloquearBotonesPrincipales(false);
            txt_nombre_barrio.Enabled = true;
            dgv_barrio.Enabled = false;
        }
         private void label_validacion_error(bool error, string mensaje )
        {

            if(error){
                this.label_validation.ForeColor = Color.Red;
            }
            else
            {
                this.label_validation.ForeColor = Color.Green;
            }
            this.label_validation.Text = mensaje;
            this.label_validation.Visible = true;
        }
        private void btn_agregarBarrio_Click(object sender, EventArgs e)
        {
            if (txt_nombre_barrio.Text.Trim() != "")
            {
                if (priv_barrio.addBarrio(txt_nombre_barrio.Text))
                {
                    label_validacion_error(false, "Se agrego correctamente el barrio.");
                        resetearFormulario();
                        desbloquearBotonesPrincipales(true);
                    
              
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
                }
                else
                {
                    
                    
                    MessageBox.Show("Error al tratar de agregar el barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               label_validacion_error(true, "Debe ingresar un nombre de barrio.");
                txt_nombre_barrio.Focus();
            }


        }

        private void btn_habilitarModificarBarrio_Click(object sender, EventArgs e)
        {
            if (dgv_barrio.SelectedRows.Count < 1)
            {
                label_validacion_error(true, "No existen barrios cargadas");
             
                return;
            }
            txt_nombre_barrio.Text = dgv_barrio.CurrentRow.Cells["nombre_barrio"].Value.ToString();
            btn_cancelar.Enabled = true;
            btn_modificarBarrio.Visible = true;
            btn_modificarBarrio.Enabled = true;
            desbloquearBotonesPrincipales(false);
            txt_nombre_barrio.Enabled = true;
            dgv_barrio.Enabled = false;

        }

        private void btn_modificarBarrio_Click(object sender, EventArgs e)
        {

            if (txt_nombre_barrio.Text.Trim() != "")
            {
                Barrio priv_barrioModificar = new Barrio();
                priv_barrioModificar.pub_nombre_barrio = txt_nombre_barrio.Text;
                priv_barrioModificar.pub_id_barrio = priv_selectedCmbIndex = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
                if (priv_barrioModificar.updateBarrio())
                {
                    label_validacion_error(false, "Se modificó correctamente");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();

                }
                else
                {
                    MessageBox.Show("Error al tratar de modificar el barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                resetearFormulario();

            }
            else
            {
                 label_validacion_error(true, "Debe ingresar un nombre de barrio.");
                txt_nombre_barrio.Focus();
            }

        }

        private void dgv_barrio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre_barrio.Text = dgv_barrio.CurrentRow.Cells["nombre_barrio"].Value.ToString();
            actualizarTextBtnState();
        }

   
        private void actualizarTextBtnState()
        {
            if (dgv_barrio.SelectedRows.Count < 1)
            {
                return;
            }
            if (bool.Parse(dgv_barrio.CurrentRow.Cells["habilitado"].Value.ToString()))
            {
                btn_handleStateBarrio.Text = "Deshabilitar";
            }
            else
            {
                btn_handleStateBarrio.Text = "Habilitar";
            }
        }
        private void frm_ABM_Barrio_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_cmb_barrios.DataSource = priv_barrio.recuperarBarrios();
     
     
        }

        private void btn_handleStateBarrio_Click(object sender, EventArgs e)
        {
            if (dgv_barrio.SelectedRows.Count < 1)
            {
                label_validacion_error(true, "No existen barrios cargados.");
                return;
            }

            Barrio priv_barrioHandleState = new Barrio();
            priv_barrioHandleState.pub_id_barrio = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
            priv_barrioHandleState.pub_state_barrio = Convert.ToInt32(!bool.Parse(dgv_barrio.CurrentRow.Cells["habilitado"].Value.ToString()));
            if (priv_barrioHandleState.handleStateBarrio())
            {
                label_validacion_error(false, "Se ha cambiado el estado correctamente");
                dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
            }
            else
            {
                MessageBox.Show("Error al tratar de cambiar el estado del barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarTextBtnState();

        }

        private void txt_nombre_barrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            label_validation.Visible = false;
        } 


    }
}
