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


        private bool validarDatosProducto()
        {
      
            if (this.txt_NombreProducto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Nombre del Producto.");
                return false;
            }

            if (this.txt_cantidadProducto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la Cantidad (segun la unidad de medida) que tiene el Producto.");
                return false;
            }
     
            if (this.cmb_unidadMedida.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Unidad de Medida.");
                return false;
            }

            if (this.txt_precioUnitario.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Precio Unitario.");
                return false;
            }

            if (this.cmb_tipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de Producto.");
                return false;
            }

            if (this.cmb_estadoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Estado de Producto.");
                return false;
            }

            return true;

        }

        private void uc_ABM_Producto_Load(object sender, EventArgs e)
        {
            this.dgv_productos.DataSource = producto.traerProductos();
            this.cmb_unidadMedida.DataSource = unidadMedida.traerUnidadMedida();
            this.cmb_unidadMedida.DisplayMember = "nombre_u_medida";
            this.cmb_unidadMedida.ValueMember = "id_u_medida";
            this.cmb_unidadMedida.SelectedIndex = -1;
            this.cmb_tipoProducto.DataSource = tipoProducto.traerTipoProducto();
            this.cmb_tipoProducto.DisplayMember = "nombre_tipo_producto";
            this.cmb_tipoProducto.ValueMember = "id_tipo_producto";
            this.cmb_tipoProducto.SelectedIndex = -1;

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
            cleanTextBox();
            modificarCajasDeTxt(true);
        }

        private void btn_modificarProducto_Click(object sender, EventArgs e)
        {
            this.btn_modificarProducto.Visible = false;
            this.btn_guardarModProducto.Visible = true;
            this.btn_cancelarModProducto.Visible = true;
            cleanTextBox();
            modificarCajasDeTxt(true);
        }

        private void btn_guardarModProducto_Click(object sender, EventArgs e)
        {           
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
            this.txt_NombreProducto.Enabled = estado;
            this.txt_cantidadProducto.Enabled = estado;
            this.cmb_unidadMedida.Enabled = estado;
            this.txt_descripcionProducto.Enabled = estado;
            this.cmb_tipoProducto.Enabled = estado;
            this.txt_precioUnitario.Enabled = estado;
            this.cmb_estadoProducto.Enabled = estado;
            this.btn_agregarTipo.Enabled = estado;
            this.btn_agregarUdeMedida.Enabled = estado;
        }

        private void cleanTextBox() 
        {
            this.txt_NombreProducto.Clear();
            this.txt_cantidadProducto.Clear();
            this.txt_descripcionProducto.Clear();
            this.txt_precioUnitario.Clear();
            this.cmb_estadoProducto.SelectedIndex = -1;
            this.cmb_unidadMedida.SelectedIndex = -1;
            this.cmb_tipoProducto.SelectedIndex = -1;

        }

        
    }
}
