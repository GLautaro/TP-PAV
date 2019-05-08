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
            this.dgv_productos.DataSource = producto.recuperarProductos();
            this.cmb_unidadMedida.cargar("unidad_medida", "id_u_medida", "nombre_u_medida");
            this.cmb_tipoProducto.cargar("tipo_producto", "id_tipo_producto", "nombre_tipo_producto");
            cleanTextBox();
        }

        private void btn_agregarTipo_Click(object sender, EventArgs e)
        {
            frm_ABM_TipoProducto frm_ABM_TipoProducto = new frm_ABM_TipoProducto();
            frm_ABM_TipoProducto.ShowDialog();
        }

        private void btn_agregarUdeMedida_Click(object sender, EventArgs e)
        {
            frm_ABM_UnidadMedida frm_ABM_UnidadMedida = new frm_ABM_UnidadMedida();
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

                if ((tipoComponente == "TextBoxPersonal" && nombreComponente != "txt_IdProducto" )
                    || tipoComponente == "ComboBoxPersonal" || tipoComponente == "ComboBoxHabilitado")
                {
                    item.Enabled = estado;
                }
            }
            this.btn_agregarTipo.Enabled = estado;
            this.btn_agregarUdeMedida.Enabled = estado;
        }

    private void cleanTextBox ()
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

        
    }
}
