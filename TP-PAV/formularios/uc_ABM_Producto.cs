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
    public partial class uc_ABM_Producto : UserControl
    {
        Producto producto = new Producto();
        TipoProducto tipoProducto = new TipoProducto();
        UnidadMedida unidadMedida = new UnidadMedida();
        private static uc_ABM_Producto priv_instance;

        public static uc_ABM_Producto pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_ABM_Producto();
                return priv_instance;
            }
        }

        public ComboBox pub_cmb_tipo_producto
        {
            get { return this.cmb_tipoProducto; }

        }

        public ComboBox pub_cmb_unidadMedida
        {
            get { return this.cmb_unidadMedida; }
        }

        public ComboBox pub_cmb_estadoProducto
        {
            get { return this.cmb_estadoProducto; }
        }

        public uc_ABM_Producto()
        {
            InitializeComponent();
        }

        private void uc_ABM_Producto_Load(object sender, EventArgs e)
        {
            producto.pub_label_error_producto = this.lbl_mensajeError;
            this.dgv_productos.DataSource = producto.recuperarProductos();
            this.cmb_unidadMedida.cargar("unidad_medida", "id_u_medida", "nombre_u_medida");
            this.cmb_tipoProducto.cargar("tipo_producto", "id_tipo_producto", "nombre_tipo_producto");
            cleanTextBox();
        }

        private void btn_agregarTipo_Click(object sender, EventArgs e)
        {
            frm_ABM_TipoProducto frm_ABM_TipoProducto = new frm_ABM_TipoProducto();
            frm_ABM_TipoProducto.pub_formularioPadre = this;
            frm_ABM_TipoProducto.pub_selectedIndex = cmb_tipoProducto.SelectedIndex;
            frm_ABM_TipoProducto.ShowDialog();
        }

        private void btn_agregarUdeMedida_Click(object sender, EventArgs e)
        {
            frm_ABM_UnidadMedida frm_ABM_UnidadMedida = new frm_ABM_UnidadMedida();
            frm_ABM_UnidadMedida.pub_formularioPadre = this;
            frm_ABM_UnidadMedida.pub_selectedIndex = cmb_unidadMedida.SelectedIndex;
            frm_ABM_UnidadMedida.ShowDialog();
        }

        private void btn_registrarProducto_Click(object sender, EventArgs e)
        {
            this.btn_modificarProducto.Visible = false;
            this.btn_guardarModProducto.Visible = true;
            this.btn_cancelarModProducto.Visible = true;
            this.txt_IdProducto.Enabled = false;
            this.txt_NombreProducto.Focus();
            cleanTextBox();
            modificarCajasDeTxt(true);
        }

        private void btn_modificarProducto_Click(object sender, EventArgs e)
        {

            this.btn_registrarProducto.Visible = false;
            this.btn_guardarModProducto.Visible = true;
            this.btn_cancelarModProducto.Visible = true;
            this.txt_IdProducto.Enabled = false;
            this.txt_NombreProducto.Focus();
            cleanTextBox();
            modificarCajasDeTxt(true);
            txt_IdProducto.Text = dgv_productos.CurrentRow.Cells["id_producto"].Value.ToString();
            txt_NombreProducto.Text = dgv_productos.CurrentRow.Cells["nombre_producto"].Value.ToString();
            txt_cantidadProducto.Text = dgv_productos.CurrentRow.Cells["cantidad_u_medida"].Value.ToString();
            txt_descripcionProducto.Text = dgv_productos.CurrentRow.Cells["descripcion"].Value.ToString();
            txt_precioUnitario.Text = dgv_productos.CurrentRow.Cells["precio_unitario"].Value.ToString();
            cmb_unidadMedida.SelectedValue = dgv_productos.CurrentRow.Cells["id_u_medida"].Value.ToString();
            cmb_tipoProducto.SelectedValue = dgv_productos.CurrentRow.Cells["id_tipo_producto"].Value.ToString();

            if (this.dgv_productos.CurrentRow.Cells["estado_producto"].Value.ToString() == "True")
            {
                this.cmb_estadoProducto.SelectedIndex = 1;
            }
            else
            {
                this.cmb_estadoProducto.SelectedIndex = 0;
            }


        }

        private void btn_guardarModProducto_Click(object sender, EventArgs e)
        {

            if (producto.validarProducto(this.Controls) == Validar.estado_validacion.correcto)
            {
                if (this.txt_IdProducto.Text == "")
                {
                    producto.grabarProducto(this.Controls);
                    MessageBox.Show("Se grabo correctamente el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    producto.grabarModificaciones(this.txt_IdProducto.Text, this.txt_NombreProducto.Text, this.txt_cantidadProducto.Text,
                        this.txt_descripcionProducto.Text, this.txt_precioUnitario.Text, this.cmb_estadoProducto.SelectedIndex, this.cmb_tipoProducto.SelectedValue.ToString(), this.cmb_unidadMedida.SelectedValue.ToString()
                        );

                }
            }
            this.dgv_productos.DataSource = producto.recuperarProductos();
            cleanTextBox();
            modificarCajasDeTxt(false);
            this.btn_guardarModProducto.Visible = false;
            this.btn_cancelarModProducto.Visible = false;
            this.btn_modificarProducto.Visible = true;
            this.btn_registrarProducto.Visible = true;

        }

        private void btn_cancelarModProducto_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            modificarCajasDeTxt(false);
            this.btn_guardarModProducto.Visible = false;
            this.btn_cancelarModProducto.Visible = false;
            this.btn_modificarProducto.Visible = true;
            this.btn_registrarProducto.Visible = true;

        }


        private void modificarCajasDeTxt(bool estado)
        {
            foreach (Control item in this.Controls)
            {
                string tipoComponente = item.GetType().Name;
                string nombreComponente = item.Name;

                if ((tipoComponente == "TextBoxPersonal" && nombreComponente != "txt_IdProducto")
                    || tipoComponente == "ComboBoxPersonal" || tipoComponente == "ComboBoxHabilitado")
                {
                    item.Enabled = estado;
                }
            }
            this.btn_agregarTipo.Enabled = estado;
            this.btn_agregarUdeMedida.Enabled = estado;
        }

        private void cleanTextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().Name == "TextBoxPersonal")
                {
                    item.Text = "";
                }
                if (item.GetType().Name == "ComboBoxPersonal")
                {
                    ((ComboBoxPersonal)item).SelectedIndex = -1;
                }
                if (item.GetType().Name == "ComboBoxHabilitado")
                {
                    ((ComboBoxHabilitado)item).SelectedIndex = -1;
                }
            }
        }

        private void btn_busquedaAvanzadaProducto_Click(object sender, EventArgs e)
        {
            if (grp_busquedaAvanzadaProducto.Visible == false)
            {
                grp_busquedaAvanzadaProducto.Show();

                this.cmb_busquedaSeleccionTipo.cargar("tipo_producto", "id_tipo_producto", "nombre_tipo_producto");
                this.cmb_busquedaSeleccionTipo.SelectedIndex = -1;
            }
            else
            {
                this.dgv_productos.DataSource = producto.recuperarProductos();
                grp_busquedaAvanzadaProducto.Hide();
            }
        }

        private void btn_cerrarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            this.dgv_productos.DataSource = producto.recuperarProductos();
            grp_busquedaAvanzadaProducto.Hide();
            lbl_msjErrorBusquedaAv.Hide();

        }

        private void cbx_tipoProducto_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_tipoProducto.Checked;
            cmb_busquedaSeleccionTipo.Enabled = estado;
            if (!estado)
            {
                cmb_busquedaSeleccionTipo.SelectedIndex = -1;
            }

        }

        private void cbx_busquedaAvanzPrecio_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_busquedaAvanzPrecio.Checked;
            txt_busquedaPrecioDesde.Enabled = estado;
            txt_busquedaPrecioHasta.Enabled = estado;
            if (!estado)
            {
                txt_busquedaPrecioDesde.Text = "";
                txt_busquedaPrecioHasta.Text = "";
            }
        }

        private void btn_activarDesactivar_Click(object sender, EventArgs e)
        {
            string nomproducto = this.dgv_productos.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = DialogResult.No;
            int estado = 0;
            if (this.dgv_productos.CurrentRow.Cells["estado_producto"].Value.ToString() == "True")
            {
                result = MessageBox.Show("¿Desea desactivar al producto: " + nomproducto + " ?",
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                estado = 0;
            }
            else
            {
                result = MessageBox.Show("¿Desea activar al producto: " + nomproducto + " ?",
                   "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                estado = 1;
            }

            if (result == DialogResult.Yes)
            {
                producto.modificarEstadoProducto(this.dgv_productos.CurrentRow.Cells["id_producto"].Value.ToString(), estado);
                this.dgv_productos.DataSource = producto.recuperarProductos();
                actualizarBotonActivarDesactivar();
            }
        }



        private void actualizarBotonActivarDesactivar()
        {
            if (this.dgv_productos.SelectedRows.Count < 1)
            {
                return;
            }
            if (this.dgv_productos.CurrentRow.Cells["estado_producto"].Value.ToString() == "True")
            {
                this.btn_activarDesactivar.Text = "Desactivar";
            }
            else
            {
                this.btn_activarDesactivar.Text = "Activar";
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdProducto.Text = dgv_productos.CurrentRow.Cells["id_producto"].Value.ToString();
            txt_NombreProducto.Text = dgv_productos.CurrentRow.Cells["nombre_producto"].Value.ToString();
            txt_cantidadProducto.Text = dgv_productos.CurrentRow.Cells["cantidad_u_medida"].Value.ToString();
            txt_descripcionProducto.Text = dgv_productos.CurrentRow.Cells["descripcion"].Value.ToString();
            txt_precioUnitario.Text = dgv_productos.CurrentRow.Cells["precio_unitario"].Value.ToString();
            cmb_unidadMedida.SelectedValue = dgv_productos.CurrentRow.Cells["id_u_medida"].Value.ToString();
            cmb_tipoProducto.SelectedValue = dgv_productos.CurrentRow.Cells["id_tipo_producto"].Value.ToString();

            if (this.dgv_productos.CurrentRow.Cells["estado_producto"].Value.ToString() == "True")
            {
                this.cmb_estadoProducto.SelectedIndex = 1;
            }
            else
            {
                this.cmb_estadoProducto.SelectedIndex = 0;
            }

            actualizarBotonActivarDesactivar();
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            this.dgv_productos.DataSource = producto.buscarProductos(this.txt_busquedaProducto.Text);
        }

        private void txt_busquedaProducto_KeyUp(object sender, KeyEventArgs e)
        {
            this.dgv_productos.DataSource = producto.buscarProductos(this.txt_busquedaProducto.Text);
            actualizarBotonActivarDesactivar();
        }

        private void btn_BuscarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (validarBusquedaAvanzada())
            {
                this.dgv_productos.DataSource = producto.busquedaAvanzada(grp_busquedaAvanzadaProducto.Controls);
            }
        }

        private bool validarBusquedaAvanzada()
        {
            int precio_desde = -1, precio_hasta = 9999;
            int.TryParse(txt_busquedaPrecioDesde.Text, out precio_desde);
            int.TryParse(txt_busquedaPrecioHasta.Text, out precio_hasta);

            if (cbx_tipoProducto.Checked)
            {
                if (cmb_busquedaSeleccionTipo.SelectedIndex == -1) 
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = cmb_busquedaSeleccionTipo._mensaje_error;
                    lbl_msjErrorBusquedaAv.Show();
                    return false;
                }
            }
            if (cbx_busquedaAvanzPrecio.Checked)
            {
                if(txt_busquedaPrecioDesde.Text == "" && txt_busquedaPrecioHasta.Text == "")
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = "PRECIO: Ingrese al menos un limite \n para la busqueda.";
                    lbl_msjErrorBusquedaAv.Show();
                    txt_busquedaPrecioDesde.Focus();
                    return false;
                }
                else if (precio_desde > precio_hasta && precio_hasta != 0)
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = "PRECIO: El limite inferior debe ser menor \n que el limite superior.";
                    lbl_msjErrorBusquedaAv.Show();
                    txt_busquedaPrecioDesde.Focus();
                    return false;
                }
            }

            lbl_msjErrorBusquedaAv.ForeColor = Color.Green;
            lbl_msjErrorBusquedaAv.Text = "¡Busqueda Exitosa!";
            lbl_msjErrorBusquedaAv.Show();
            return true;

        }
    }
}
