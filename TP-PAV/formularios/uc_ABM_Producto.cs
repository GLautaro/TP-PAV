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



        public uc_ABM_Producto()
        {
            InitializeComponent();
        }

        private void uc_ABM_Producto_Load(object sender, EventArgs e)
        {
            this.dgv_productos.DataSource = producto.traerProductos();
        }

        private void btn_agregarTipo_Click(object sender, EventArgs e)
        {
            frm_ABM_TipoProducto frm_ABM_TipoProducto = new frm_ABM_TipoProducto();
            frm_ABM_TipoProducto.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        
    }
}
