using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.clases;
namespace TP_PAV.formularios
{
    public partial class uc_ABM_Franquicia : UserControl
    {
        Franquicia priv_franquicia = new Franquicia();
        Barrio priv_barrio = new Barrio();
        TipoFranquicia priv_tipoFranquicia = new TipoFranquicia();

        //FORMA 2
        private static uc_ABM_Franquicia priv_instance;
        public static uc_ABM_Franquicia pub_instance {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_ABM_Franquicia();
                return priv_instance;           
            }

        }
        public uc_ABM_Franquicia()
        {
            InitializeComponent();
        }

        private void bloquearCajasTexto()
        {
            txt_apellidoResponsable.Enabled = false;
            txt_calle.Enabled = false;
            txt_legajoVendedor.Enabled = false;
            txt_nombreResponsable.Enabled = false;
            txt_nroCalle.Enabled = false;
            cmb_barrio.Enabled = false;
            cmb_tipoFranquicia.Enabled = false;
            btn_buscarVendedor.Enabled = false;
            btn_guardarNuevaFranquicia.Enabled = false;
        }

        private void desbloquearCajasTexto()
        {
            txt_apellidoResponsable.Enabled = true;
            txt_calle.Enabled = true;
            txt_legajoVendedor.Enabled = true;
            txt_nombreResponsable.Enabled = true;
            txt_nroCalle.Enabled = true;
            cmb_barrio.Enabled = true;
            cmb_tipoFranquicia.Enabled = true;
            btn_buscarVendedor.Enabled = true;
            btn_guardarNuevaFranquicia.Enabled = true;
        }
        
        private void uc_ABM_Franquicia_Load(object sender, EventArgs e)
        {
            cmb_barrio.DataSource = priv_barrio.recuperarBarrios();
            cmb_barrio.DisplayMember = "nombre_barrio";
            cmb_barrio.ValueMember = "id_barrio";
            cmb_barrio.SelectedIndex = -1;
            cmb_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            cmb_tipoFranquicia.DisplayMember = "nombre_tipo_franquicia";
            cmb_tipoFranquicia.ValueMember = "id_tipo_franquicia";
            cmb_tipoFranquicia.SelectedIndex = -1;
            dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
            
        }

        private void limpiarFormularioFranquicias()
        {
            txt_apellidoResponsable.Clear();
            txt_calle.Clear();
            txt_legajoVendedor.Clear();
            txt_nombreResponsable.Clear();
            txt_nroCalle.Clear();
            cmb_tipoFranquicia.SelectedIndex = -1;
            cmb_barrio.SelectedIndex = -1;
        }
        

        private void btn_guardarNuevaFranquicia_Click(object sender, EventArgs e)
        {
            priv_franquicia.pub_apellido_responsable = txt_apellidoResponsable.Text;
            priv_franquicia.pub_nombre_responsable = txt_nombreResponsable.Text;
            priv_franquicia.pub_calle = txt_calle.Text;
            if (cmb_barrio.SelectedIndex != -1)
            {
                priv_franquicia.pub_id_barrio = int.Parse(cmb_barrio.SelectedValue.ToString());
            }
            if (cmb_tipoFranquicia.SelectedIndex != -1)
            {
                priv_franquicia.pub_id_tipo_franquicia = int.Parse(cmb_tipoFranquicia.SelectedValue.ToString());
            }
            if (txt_legajoVendedor.Text != "")
            {
                priv_franquicia.pub_legajo_vendedor = int.Parse(txt_legajoVendedor.Text);
            }
            if (txt_nroCalle.Text != "")
            {
                priv_franquicia.pub_nro_calle = int.Parse(txt_nroCalle.Text);
            }
            

            if (priv_franquicia.altaFranquicia())
            {
                limpiarFormularioFranquicias();
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                DialogResult result = MessageBox.Show("Franquicia cargada correctamente\n¿Desea cargar otra franquicia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    bloquearCajasTexto();
                    btn_cancelarGuardado.Enabled = false;
                    btn_cancelarGuardado.Visible = false;
                    btn_guardarNuevaFranquicia.Enabled = false;
                    btn_guardarNuevaFranquicia.Visible = false;
                }
                
                
            }
            else
            {
                MessageBox.Show("La franquicia no pudo ser cargada", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        

        private void btn_buscarVendedor_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btn_modificarFranquicia_Click(object sender, EventArgs e)
        {
            
            Franquicia priv_franquiciaNueva = new Franquicia();
            priv_franquiciaNueva.pub_id_franquicia = int.Parse(dgv_franquicias.CurrentRow.Cells["id_franquicia"].Value.ToString());
            priv_franquiciaNueva.pub_nombre_responsable = txt_nombreResponsable.Text;
            priv_franquiciaNueva.pub_apellido_responsable = txt_apellidoResponsable.Text;
            priv_franquiciaNueva.pub_calle = txt_calle.Text;
            priv_franquiciaNueva.pub_nro_calle = int.Parse(txt_nroCalle.Text);
            priv_franquiciaNueva.pub_id_barrio = int.Parse(cmb_barrio.SelectedValue.ToString());
            priv_franquiciaNueva.pub_id_tipo_franquicia = int.Parse(cmb_tipoFranquicia.SelectedValue.ToString());
            priv_franquiciaNueva.pub_legajo_vendedor = int.Parse(txt_legajoVendedor.Text);
            
            if (priv_franquiciaNueva.modificarFranquicia())
            {
                MessageBox.Show("Los datos han sido modificados correctamente.");
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                bloquearCajasTexto();
                limpiarFormularioFranquicias();
                btn_cancelarModificaciones.Visible = false;
                btn_cancelarModificaciones.Enabled = false;
                btn_modificarFranquicia.Visible = false;
                btn_modificarFranquicia.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error modificando los datos.");

            }
            dgv_franquicias.Enabled = true;
        }



        private void btn_habilitarModificarFranquicia_Click(object sender, EventArgs e)
        {
            string mensaje = @"¿Esta seguro que desea editar la franquicia con ID: " + dgv_franquicias.CurrentRow.Cells["id_franquicia"].Value.ToString() +
                                ".\nA cargo de " + dgv_franquicias.CurrentRow.Cells["nombre_responsable"].Value.ToString() + " " + dgv_franquicias.CurrentRow.Cells["apellido_responsable"].Value.ToString();
            DialogResult result = MessageBox.Show(mensaje, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                desbloquearCajasTexto();
                btn_modificarFranquicia.Enabled = true;
                btn_modificarFranquicia.Visible = true;
                btn_cancelarModificaciones.Enabled = true;
                btn_cancelarModificaciones.Visible = true;
                btn_buscarVendedor.Enabled = true;
                desbloquearCajasTexto();
                txt_nombreResponsable.Text = dgv_franquicias.CurrentRow.Cells["nombre_responsable"].Value.ToString();
                txt_apellidoResponsable.Text = dgv_franquicias.CurrentRow.Cells["apellido_responsable"].Value.ToString();
                txt_calle.Text = dgv_franquicias.CurrentRow.Cells["calle"].Value.ToString();
                txt_nroCalle.Text = dgv_franquicias.CurrentRow.Cells["nro_calle"].Value.ToString();
                txt_legajoVendedor.Text = dgv_franquicias.CurrentRow.Cells["legajo_vendedor"].Value.ToString();

                cmb_tipoFranquicia.SelectedIndex = cmb_tipoFranquicia.FindStringExact(dgv_franquicias.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString());
                cmb_barrio.SelectedIndex = cmb_barrio.FindStringExact(dgv_franquicias.CurrentRow.Cells["nombre_barrio"].Value.ToString());
                
                dgv_franquicias.Enabled = false;
            }
            else
            {
                return;
            }

        }
        private void btn_cancelarModificaciones_Click(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            limpiarFormularioFranquicias();
            btn_modificarFranquicia.Enabled = false;
            btn_modificarFranquicia.Visible = false;
            btn_cancelarModificaciones.Enabled = false;
            btn_cancelarModificaciones.Visible = false;
            btn_buscarVendedor.Enabled = false;
            dgv_franquicias.Enabled = true;
        }
        

        private void btn_habilitarAñadirFranquicia_Click(object sender, EventArgs e)
        {
            desbloquearCajasTexto();
            btn_cancelarGuardado.Enabled = true;
            btn_cancelarGuardado.Visible = true;
            btn_guardarNuevaFranquicia.Enabled = true;
            btn_guardarNuevaFranquicia.Visible = true;
        }
        private void btn_cancelarGuardado_Click(object sender, EventArgs e)
        {
            bloquearCajasTexto();
            limpiarFormularioFranquicias();
            btn_guardarNuevaFranquicia.Visible = false;
            btn_guardarNuevaFranquicia.Enabled = false;
            btn_cancelarGuardado.Visible = false;
            btn_cancelarGuardado.Enabled = false;
            btn_buscarVendedor.Enabled = false;

        }

        private void btn_eliminarFranquicia_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar esta franquicia. Esta accion no se puede revertir", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Franquicia priv_franquiciaNueva = new Franquicia();
                priv_franquiciaNueva.pub_id_franquicia = int.Parse(dgv_franquicias.CurrentRow.Cells["id_franquicia"].Value.ToString());
                priv_franquiciaNueva.pub_nombre_responsable = dgv_franquicias.CurrentRow.Cells["nombre_responsable"].Value.ToString();
                priv_franquiciaNueva.pub_apellido_responsable = dgv_franquicias.CurrentRow.Cells["apellido_responsable"].Value.ToString();
                priv_franquiciaNueva.pub_calle = dgv_franquicias.CurrentRow.Cells["calle"].Value.ToString();
                priv_franquiciaNueva.pub_nro_calle = int.Parse(dgv_franquicias.CurrentRow.Cells["nro_calle"].Value.ToString());
                priv_franquiciaNueva.pub_legajo_vendedor = int.Parse(dgv_franquicias.CurrentRow.Cells["legajo_vendedor"].Value.ToString());
                

                priv_franquiciaNueva.pub_id_barrio = int.Parse(dgv_franquicias.CurrentRow.Cells["id_barrio"].Value.ToString());
                priv_franquiciaNueva.pub_id_tipo_franquicia = int.Parse(dgv_franquicias.CurrentRow.Cells["id_tipo_franquicia"].Value.ToString());
                if (priv_franquiciaNueva.eliminarFranquicia())
                {
                    MessageBox.Show("La franquicia fue eliminada correctamente");
                    dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar la franquicia");
                    dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                }
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_TipoFranquicia form_tipo_franquicia = new frm_TipoFranquicia();
            form_tipo_franquicia.ShowDialog();
        }


    }
}
