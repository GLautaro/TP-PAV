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
        private static uc_ABM_Franquicia priv_instance;

        public ComboBox pub_cmb_tipoFranquicia
        {
            get { return this.cmb_tipoFranquicia; }
        }
        
        public ComboBox pub_cmb_barrio
        {
            get { return this.cmb_barrio; }
        }
     
        //FORMA 2
        
        public static uc_ABM_Franquicia pub_instance 
        {
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

        private bool validarDatosFranquicia()
        {
            if (txt_apellidoResponsable.Text == "")
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha cargado un apellido";
                return false;
            }
            if (txt_nombreResponsable.Text == "")
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha cargado un nombre";
                return false;
            }
            if (txt_calle.Text == "")
            {
                
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha cargado una calle";
                return false;
            }
            if (cmb_barrio.SelectedIndex == -1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha seleccionado una calle";
                return false;
            }
            if (cmb_tipoFranquicia.SelectedIndex == -1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha seleccionado un tipo de franquicia";
                return false;
            }
            if (txt_legajoVendedor.Text == "")
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha cargado un legajo de vendedor";
                return false;
            }
            if (txt_nroCalle.Text == "")
            {
                
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha cargado un numero de calle";
                return false;
            }
                return true;
        }
      
        public void cambiarEstadoCajasTexto(bool estado)
        {
            txt_apellidoResponsable.Enabled = estado;
            txt_calle.Enabled = estado;
            txt_legajoVendedor.Enabled = estado;
            txt_nombreResponsable.Enabled = estado;
            txt_nroCalle.Enabled = estado;
            cmb_barrio.Enabled = estado;
            cmb_tipoFranquicia.Enabled = estado;
            btn_guardarNuevaFranquicia.Enabled = estado;
            btn_agregarTipoFranquicia.Enabled = estado;
            btn_agregarBarrio.Enabled = estado;
        }

        private void uc_ABM_Franquicia_Load(object sender, EventArgs e)
        {
            //En esta seccion se inicializan los datos necesarios para el uso del ABM
            //Primero se cargan los barrio y se setean indice inicial del cmb y miembros a mostrar y el que se toma por valor
            cmb_barrio.DataSource = priv_barrio.recuperarBarrios();
            cmb_barrio.DisplayMember = "nombre_barrio";
            cmb_barrio.ValueMember = "id_barrio";
            cmb_barrio.SelectedIndex = -1;
            //Se realiza lo mismo para los tipos de franquicia
            cmb_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
            cmb_tipoFranquicia.DisplayMember = "nombre_tipo_franquicia";
            cmb_tipoFranquicia.ValueMember = "id_tipo_franquicia";
            cmb_tipoFranquicia.SelectedIndex = -1;
            //Se carga el dgv con los datos de las franquicias cargadas en la BD
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
            if(!validarDatosFranquicia()){return;}      
            
            if (priv_franquicia.altaFranquicia(txt_nombreResponsable.Text, txt_apellidoResponsable.Text, txt_calle.Text,
                                                int.Parse(txt_nroCalle.Text), int.Parse(cmb_barrio.SelectedValue.ToString()), int.Parse(cmb_tipoFranquicia.SelectedValue.ToString()),
                                                int.Parse(txt_legajoVendedor.Text)))
            {
                limpiarFormularioFranquicias();
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                cambiarEstadoCajasTexto(false);
                btn_cancelarGuardado.Enabled = false;
                btn_cancelarGuardado.Visible = false;
                btn_guardarNuevaFranquicia.Enabled = false;
                btn_guardarNuevaFranquicia.Visible = false;
                btn_habilitarAñadirFranquicia.Enabled = true;
                btn_habilitarModificarFranquicia.Enabled = true;
                btn_modificarFranquicia.Enabled = true;
                btn_eliminarFranquicia.Enabled = true;

                
                
            }
            else
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "La franquicia no pudo ser cargada";
                return;
            }
        }

        private void btn_modificarFranquicia_Click(object sender, EventArgs e)
        {
            if (!validarDatosFranquicia()) { return; }
            Franquicia priv_franquiciaModificar = new Franquicia(int.Parse(dgv_franquicias.CurrentRow.Cells["id_franquicia"].Value.ToString()),
                                                                       txt_nombreResponsable.Text,
                                                                       txt_apellidoResponsable.Text,
                                                                       txt_calle.Text,
                                                                       int.Parse(txt_nroCalle.Text),
                                                                       int.Parse(cmb_barrio.SelectedValue.ToString()),
                                                                       int.Parse(txt_legajoVendedor.Text),
                                                                       int.Parse(cmb_tipoFranquicia.SelectedValue.ToString()));
            
            if (priv_franquiciaModificar.modificarFranquicia())
            {
                lbl_mensaje.ForeColor = Color.YellowGreen;
                lbl_mensaje.Text = "Los datos han sido modificados correctamente";

                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                cambiarEstadoCajasTexto(false); 
                limpiarFormularioFranquicias();
                btn_cancelarModificaciones.Visible = false;
                btn_cancelarModificaciones.Enabled = false;
                btn_modificarFranquicia.Visible = false;
                btn_modificarFranquicia.Enabled = false;
                btn_habilitarAñadirFranquicia.Enabled = true;
                btn_habilitarModificarFranquicia.Enabled = true;
                btn_modificarFranquicia.Enabled = true;
                btn_eliminarFranquicia.Enabled = true;
                
            }
            else
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "Ha ocurrido un error modificando los datos";

            }
            dgv_franquicias.Enabled = true;
        }

        private void btn_habilitarModificarFranquicia_Click(object sender, EventArgs e)
        {

            if (dgv_franquicias.SelectedRows.Count < 1)
            {
                lbl_mensaje.Text = "No existen franquicias cargadas";
                return;
            }
            cambiarEstadoCajasTexto(true);
            btn_habilitarAñadirFranquicia.Enabled = false;
            btn_habilitarModificarFranquicia.Enabled = false;
            btn_eliminarFranquicia.Enabled = false;

            btn_modificarFranquicia.Enabled = true;
            btn_modificarFranquicia.Visible = true;

            btn_cancelarModificaciones.Enabled = true;
            btn_cancelarModificaciones.Visible = true;
                                

            txt_nombreResponsable.Text = dgv_franquicias.CurrentRow.Cells["nombre_responsable"].Value.ToString();
            txt_apellidoResponsable.Text = dgv_franquicias.CurrentRow.Cells["apellido_responsable"].Value.ToString();
            txt_calle.Text = dgv_franquicias.CurrentRow.Cells["calle"].Value.ToString();
            txt_nroCalle.Text = dgv_franquicias.CurrentRow.Cells["nro_calle"].Value.ToString();
            txt_legajoVendedor.Text = dgv_franquicias.CurrentRow.Cells["legajo_vendedor"].Value.ToString();

            cmb_tipoFranquicia.SelectedIndex = cmb_tipoFranquicia.FindStringExact(dgv_franquicias.CurrentRow.Cells["nombre_tipo_franquicia"].Value.ToString());
            cmb_barrio.SelectedIndex = cmb_barrio.FindStringExact(dgv_franquicias.CurrentRow.Cells["nombre_barrio"].Value.ToString());
            dgv_franquicias.Enabled = false;
            
        }
        
        private void btn_cancelarModificaciones_Click(object sender, EventArgs e)
        {
            cambiarEstadoCajasTexto(false);
            lbl_mensaje.Text = "";
            limpiarFormularioFranquicias();
            btn_modificarFranquicia.Enabled = false;
            btn_modificarFranquicia.Visible = false;
            btn_cancelarModificaciones.Enabled = false;
            btn_cancelarModificaciones.Visible = false;
            btn_agregarTipoFranquicia.Enabled = false;
            dgv_franquicias.Enabled = true;
            btn_habilitarAñadirFranquicia.Enabled = true;
            btn_habilitarModificarFranquicia.Enabled = true;
            btn_modificarFranquicia.Enabled = true;
            btn_eliminarFranquicia.Enabled = true;
        }
        
        private void btn_habilitarAñadirFranquicia_Click(object sender, EventArgs e)
        {
            cambiarEstadoCajasTexto(true);
            btn_cancelarGuardado.Enabled = true;
            btn_cancelarGuardado.Visible = true;
            btn_guardarNuevaFranquicia.Enabled = true;
            btn_guardarNuevaFranquicia.Visible = true;
            btn_habilitarAñadirFranquicia.Enabled = false;
            btn_habilitarModificarFranquicia.Enabled = false;
            btn_modificarFranquicia.Enabled = false;
            btn_eliminarFranquicia.Enabled = false;
            
        }

        private void btn_cancelarGuardado_Click(object sender, EventArgs e)
        {
            cambiarEstadoCajasTexto(false);
            lbl_mensaje.Text = "";
            limpiarFormularioFranquicias();
            btn_guardarNuevaFranquicia.Visible = false;
            btn_guardarNuevaFranquicia.Enabled = false;
            btn_cancelarGuardado.Visible = false;
            btn_cancelarGuardado.Enabled = false;
            btn_agregarTipoFranquicia.Enabled = false;
            btn_habilitarAñadirFranquicia.Enabled = true;
            btn_habilitarModificarFranquicia.Enabled = true;
            btn_modificarFranquicia.Enabled = true;
            btn_eliminarFranquicia.Enabled = true;
        }

        private void btn_eliminarFranquicia_Click(object sender, EventArgs e)
        {
            if (dgv_franquicias.SelectedRows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen franquicias cargadas";
                return;
            }
            
            Franquicia franquicia_cambiar_estado = new Franquicia(int.Parse(dgv_franquicias.CurrentRow.Cells["id_franquicia"].Value.ToString()), 
            bool.Parse(dgv_franquicias.CurrentRow.Cells["habilitado"].Value.ToString()));

            if(franquicia_cambiar_estado.modificarEstadoFranquicia())
            {
                lbl_mensaje.ForeColor = Color.YellowGreen;
                lbl_mensaje.Text = "Se modifico correctamente el estado";
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
            }
            else
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "Ha ocurrido un error cambiando el estado";
            }
            }

        private void btn_agregarTipoFranquicia_click(object sender, EventArgs e)
        {
            frm_TipoFranquicia form_tipo_franquicia = new frm_TipoFranquicia();
            form_tipo_franquicia.pub_formularioPadre = this;
            form_tipo_franquicia.pub_selectedIndex = cmb_tipoFranquicia.SelectedIndex;
            form_tipo_franquicia.ShowDialog();
            
            
        }

        private void btn_agregarBarrio_Click(object sender, EventArgs e)
        {
            frm_ABM_Barrio frm_barrio = new frm_ABM_Barrio();
            frm_barrio.pub_selectedIndex = cmb_barrio.SelectedIndex;
            frm_barrio.pub_cmb_barrios = pub_cmb_barrio;
            frm_barrio.ShowDialog();

        }

        private void btn_buscarFranquicia_Click(object sender, EventArgs e)
        {
            dgv_franquicias.DataSource = priv_franquicia.buscarFranquicias(txt_buscarFranquicia.Text);
        }

        private void txt_buscarFranquicia_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_buscarFranquicia.Text == "")
            {
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                return;
            }
            dgv_franquicias.DataSource = priv_franquicia.buscarFranquicias(txt_buscarFranquicia.Text);
        }

        private void btn_busquedaAvan_Click(object sender, EventArgs e)
        {
            if (grp_busquedaAvanzada.Visible == false)
            {
                grp_busquedaAvanzada.Show();

                cmb_busquedaAvan_barrio.DataSource = priv_barrio.recuperarBarrios();
                cmb_busquedaAvan_barrio.DisplayMember = "nombre_barrio";
                cmb_busquedaAvan_barrio.ValueMember = "id_barrio";
                cmb_busquedaAvan_barrio.SelectedIndex = -1;

                cmb_busquedaAvan_tipoFranquicia.DataSource = priv_tipoFranquicia.recuperarTiposFranquicia();
                cmb_busquedaAvan_tipoFranquicia.DisplayMember = "nombre_tipo_franquicia";
                cmb_busquedaAvan_tipoFranquicia.ValueMember = "id_tipo_franquicia";
                cmb_busquedaAvan_tipoFranquicia.SelectedIndex = -1;
            }
            else
            {
                dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();
                limpiarFormularioBusqueda();
                grp_busquedaAvanzada.Hide();
            }
        }

        private void btn_cerrarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzada.Hide();
            limpiarFormularioBusqueda();
            dgv_franquicias.DataSource = priv_franquicia.recuperarFranquicias();

        }

        private void limpiarFormularioBusqueda()
        {
            txt_busquedaAvan_idDesde.Text = "";
            txt_busquedaAvan_idHasta.Text = "";
            txt_busquedaAvan_legajoDesde.Text = "";
            txt_busquedaAvan_legajoHasta.Text = "";
            txt_busquedaAvan_nombre.Text = "";
            txt_busquedaAvan_apellido.Text = "";
        }

        private void btn_busquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (validarBusquedaAvanzada())
            {
                dgv_franquicias.DataSource = priv_franquicia.busquedaAvanzada(grp_busquedaAvanzada.Controls);
                
            }
            
        }

        private void chb_id_Click(object sender, EventArgs e)
        {
            bool estado = chb_id.Checked;
            txt_busquedaAvan_idDesde.Enabled = estado;
            txt_busquedaAvan_idHasta.Enabled = estado;
            if (!estado)
            {
                txt_busquedaAvan_idDesde.Text = "";
                txt_busquedaAvan_idHasta.Text = "";
            }
        }

        private void chb_NomyApe_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = chb_NomyApe.Checked;
            txt_busquedaAvan_nombre.Enabled = estado;
            txt_busquedaAvan_apellido.Enabled = estado;
            if (!estado)
            {
                txt_busquedaAvan_apellido.Text = "";
                txt_busquedaAvan_nombre.Text = "";
            }
        }

        private void chb_legajoVendedor_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = chb_legajoVendedor.Checked;
            txt_busquedaAvan_legajoDesde.Enabled = estado;
            txt_busquedaAvan_legajoHasta.Enabled = estado;
            if (!estado)
            {
                txt_busquedaAvan_legajoDesde.Text = "";
                txt_busquedaAvan_legajoHasta.Text = "";
            }
        }

        private bool validarBusquedaAvanzada()
        {
            int leg_desde = 9999, leg_hasta = -1;
            int id_desde = 9999, id_hasta = -1;
            int.TryParse(txt_busquedaAvan_idDesde.Text, out id_desde);
            int.TryParse(txt_busquedaAvan_idHasta.Text, out id_hasta);
            int.TryParse(txt_busquedaAvan_legajoDesde.Text, out leg_desde);
            int.TryParse(txt_busquedaAvan_legajoHasta.Text, out leg_hasta);
            
            if (chb_legajoVendedor.Checked)
            {
                if (txt_busquedaAvan_legajoDesde.Text == "" && txt_busquedaAvan_legajoHasta.Text == "")
                {
                    //avisar de espacios vacios.
                    busqAvan_informacion.Text = "Legajo: Ingrese por lo menos un limite \n para la busqueda";
                    return false;
                }
                else if (leg_desde > leg_hasta && leg_hasta != 0)
                {
                    //Legajo desde no puede ser mayor que Legajo hasta
                    this.busqAvan_informacion.Text = "LEGAJO: El limite inferior debe ser \n menor que el limite superior";
                    return false;
                }
            }
            if (chb_id.Checked)
            {
                if (txt_busquedaAvan_idDesde.Text == "" && txt_busquedaAvan_idHasta.Text == "")
                {
                    //avisar de espacios vacios.
                    busqAvan_informacion.Text = "ID: Ingrese por lo menos un limite \n para la busqueda";
                    return false;
                }
                else if (id_desde > id_hasta && id_hasta != 0)
                {
                    //ID desde no puede ser mayor que ID hasta
                    this.busqAvan_informacion.Text = "ID: El limite inferior debe ser \n menor que el limite superior";
                    return false;
                }
            }
            if (chb_NomyApe.Checked)
            {
                if (txt_busquedaAvan_nombre.Text == "" && txt_busquedaAvan_apellido.Text == "")
                {
                    //avisar de espacios vacios.
                    busqAvan_informacion.Text = "Nombre y Apellido: Debe ingresar por lo menos un valor";
                    return false;
                }
            }
            return true;
        }

        private void dgv_franquicias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_franquicias.SelectedRows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen franquicias cargadas";
                return;
            }
            if (bool.Parse(dgv_franquicias.CurrentRow.Cells["habilitado"].Value.ToString()))
            {
                btn_eliminarFranquicia.Text = "Desactivar Franquicia";
            }
            else
            {
                btn_eliminarFranquicia.Text = "Activar Franquicia";
            }

        }


    }
}
