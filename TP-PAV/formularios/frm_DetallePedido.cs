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
    public partial class frm_DetallePedido : Form
    {
        TipoProducto priv_tipo_producto = new TipoProducto();
        Producto priv_producto = new Producto();
       
        
        private int priv_id_pedido;
        private int priv_monto_minimo;
        private Pedido priv_pedido;
        public Pedido pub_pedido
        {
            get { return priv_pedido; }
            set { priv_pedido = value; }
        }
        public int pub_id_pedido
        {
            get { return priv_id_pedido; }
            set { priv_id_pedido = value; }
        }
        public int pub_monto_minimo
        {
            get { return priv_monto_minimo; }
            set { priv_monto_minimo = value; }
        }
        public frm_DetallePedido()
        {
            InitializeComponent();
        }

        private void frm_DetallePedido_Load(object sender, EventArgs e)
        {
            txt_montoMinimo.Text = pub_monto_minimo.ToString();
            txt_id_pedido.Text = priv_id_pedido.ToString();
            cmb_tipoProducto.DisplayMember = "nombre_tipo_producto";
            cmb_tipoProducto.ValueMember = "id_tipo_producto";
            cmb_tipoProducto.DataSource = priv_tipo_producto.traerTipoProducto();
            cmb_tipoProducto.SelectedIndex = -1;

            priv_pedido.pub_id_pedido = priv_id_pedido;
  
        }

        private void mostrarMensaje(string value, bool error)
        {
            if (error)
            {
                lbl_error.ForeColor = Color.Red;
            }
            else
            {
                lbl_error.ForeColor = Color.Green;
            }
            lbl_error.Text = value;
            lbl_error.Visible = true;
        }
        private void clearForm()
        {
            txt_cantidad.Clear();
            txt_precio_unitario.Clear();
            cmb_tipoProducto.SelectedIndex = -1;
            cmb_Producto.SelectedIndex = -1;
        }

        private void btn_addProductoPedido_Click(object sender, EventArgs e)
        {
            //dgv_detallePedido.Rows.Cast<DataGridViewRow>().Any(x => int.Parse(x.Cells["id_producto"].Value.ToString()) == int.Parse(cmb_Producto.SelectedValue.ToString()))
            priv_pedido.pub_Pedido_label_error = lbl_error;
            
            DetallePedido detalle_pedido = new DetallePedido();
            detalle_pedido.pub_pedido = priv_pedido;
            if (priv_pedido.validarPedido(this.Controls) == Validar.estado_validacion.correcto) {
                if (detalle_pedido.addProductoPedido(int.Parse(txt_id_pedido.Text.ToString()), int.Parse(cmb_Producto.SelectedValue.ToString()), int.Parse(txt_cantidad.Text.ToString()), int.Parse(txt_precio_unitario.Text.ToString())))
            {
                dgv_detallePedido.DataSource = detalle_pedido.recuperarDetalleDePedido();
                lbl_montoTotal.Text = priv_pedido.updateMontoFinalPedido(priv_id_pedido).Rows[0]["monto_final"].ToString();
               clearForm();
            }
            }


        }


        private void frm_DetallePedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_pedido.cerrar_transaccion_pedido(true);
        }

        private void btn_descartarPedido_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void btn_guardarPedido_Click(object sender, EventArgs e)
        {
            DetallePedido detalle_pedido = new DetallePedido();
            detalle_pedido.pub_pedido = priv_pedido;
            if (dgv_detallePedido.RowCount > 0  )
            {
                if (int.Parse(lbl_montoTotal.Text.ToString()) < priv_monto_minimo)
                {
                    mostrarMensaje("El pedido no supera el monto minimo de compra!", true);
                    return;
                }
                
                priv_pedido.cerrar_transaccion_pedido(false);
                Close();
            }
            else
            {
                mostrarMensaje("Necesita agregar productos al pedido!" , true);
                return;

            }
            
  
        }
       
    

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            if (dgv_detallePedido.RowCount > 0)
            {
                DetallePedido detallePedido_itemEliminar = new DetallePedido();
                detallePedido_itemEliminar.pub_pedido = priv_pedido;
                priv_pedido.pub_id_pedido = priv_id_pedido;
                if (detallePedido_itemEliminar.deleteProductoPedido(int.Parse(priv_id_pedido.ToString()),int.Parse(dgv_detallePedido.CurrentRow.Cells["id_producto"].Value.ToString())))
                {

                   dgv_detallePedido.DataSource = detallePedido_itemEliminar.recuperarDetalleDePedido();
                   if (dgv_detallePedido.RowCount == 0)
                   {
                       priv_pedido.updateMontoFinalCero(priv_id_pedido);
                       lbl_montoTotal.Text = "0";

                   }
                   else
                   {
                       lbl_montoTotal.Text = priv_pedido.updateMontoFinalPedido(priv_id_pedido).Rows[0]["monto_final"].ToString();  
                   }
                  
                    
                }
              
            }
            else
            {
                mostrarMensaje("No existe ningun producto en el pedido", true);
            }

        }

        private void cmb_tipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cmb_Producto.SelectedIndex.ToString()) == -1)
            {
                cmb_Producto.DataSource = null;
            }
            if (int.Parse(cmb_tipoProducto.SelectedIndex.ToString()) != -1)
            {
                DetallePedido detalle_pedido = new DetallePedido();
                detalle_pedido.pub_pedido = priv_pedido;
                cmb_Producto.DataSource = detalle_pedido.recuperarProductoXTipoProducto(int.Parse(cmb_tipoProducto.SelectedValue.ToString()), priv_id_pedido);
                cmb_Producto.DisplayMember = "nombre_producto";
                cmb_Producto.ValueMember = "id_producto";
                cmb_Producto.SelectedIndex = -1;

            }
        }

        private void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (int.Parse(cmb_Producto.SelectedIndex.ToString()) == -1)
            {
                txt_precio_unitario.Text = "";
            }
            if (int.Parse(cmb_Producto.SelectedIndex.ToString()) != -1)
            {
                int result = int.Parse(((DataRowView)cmb_Producto.SelectedItem).Row["precio_unitario"].ToString());
                txt_precio_unitario.Text = result.ToString();
            }
        }

    }
}
