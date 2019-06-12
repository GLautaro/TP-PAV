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
    public partial class uc_HistorialPedidos : UserControl
    {
        Pedido priv_pedido = new Pedido();
        private static uc_HistorialPedidos priv_instance;
        private static uc_Pedido priv_uc_pedido;

        public uc_HistorialPedidos()
        {
            InitializeComponent();
        }

        public static uc_HistorialPedidos pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_HistorialPedidos();
                return priv_instance;
            }
        }

        private void uc_HistorialPedidos_Load(object sender, EventArgs e)
        {
            dgv_pedidos.DataSource = priv_pedido.recuperarPedidos();
            dgv_detallePedido.DataSource = "";
        }

        //Desde acá

        private void cleanMensaje()
        {
            label_error.ForeColor = Color.Red;
            label_error.Text = "";
            label_error.Visible = false;
        }


        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido_seleccionado = new Pedido();
            pedido_seleccionado.pub_id_pedido = int.Parse(dgv_pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());
            DetallePedido detalle_pedido_seleccionado = new DetallePedido();
            detalle_pedido_seleccionado.pub_pedido = pedido_seleccionado;
            dgv_detallePedido.DataSource = detalle_pedido_seleccionado.recuperarDetalleDePedido();

            cmb_estadoPedido.DataSource = pedido_seleccionado.estadoPedido();
            cmb_estadoPedido.DisplayMember = "nombre_estado";
            cmb_estadoPedido.ValueMember = "id_estado";
            cmb_estadoPedido.SelectedValue = int.Parse(dgv_pedidos.CurrentRow.Cells["id_estado"].Value.ToString());
            cleanMensaje();    
        }
        //Hasta acá se copiaron y pegaron métodos de uc_Pedidos

        private void btn_modificarEstado_Click(object sender, EventArgs e)
        {
            priv_pedido.pub_Pedido_label_error = this.label_error;
            if (priv_pedido.validarPedido(grp_modificar.Controls) == Validar.estado_validacion.correcto)
            {
                Pedido pedido_seleccionado = new Pedido();
                pedido_seleccionado.pub_id_pedido = int.Parse(dgv_pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());
                pedido_seleccionado.pub_id_estado = int.Parse(cmb_estadoPedido.SelectedValue.ToString());
                if (pedido_seleccionado.updateEstadoPedido())
                {
                    dgv_pedidos.DataSource = priv_pedido.recuperarPedidos();
                    dgv_detallePedido.DataSource = "";
                    label_error.Visible = true;
                }
            }
        }
        

        private void btn_busquedaAvanzadaPedido_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzadaPedido.Visible = true;

            this.cmb_franquicias.cargar("franquicia", "id_franquicia", "id_franquicia");
            this.cmb_franquicias.SelectedIndex = -1;

            this.cmb_vendedores.cargar("vendedor", "legajo_vendedor", "legajo_vendedor");
            this.cmb_vendedores.SelectedIndex = -1;

        }

        private void cbx_franquicia_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_franquicia.Checked;
            cmb_franquicias.Enabled = estado;
            if (!estado)
            {
                cmb_franquicias.SelectedIndex = -1;
            }
        }

        private void cbx_vendedor_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_vendedor.Checked;
            cmb_vendedores.Enabled = estado;
            if (!estado)
            {
                cmb_vendedores.SelectedIndex = -1;
            }
        }

        private void cbx_monto_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_monto.Checked;
            txt_desde_monto.Enabled = estado;
            txt_hasta_monto.Enabled = estado;
            if (!estado)
            {
                txt_desde_monto.Text = "";
                txt_hasta_monto.Text = "";
            }
        }

        /*

        private void cbx_fechaSolicitud_desde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_fechaSolicitud_hasta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_fechaEntrega_desde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_fechaEntrega_hasta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_fechaSolicitud_CheckedChanged(object sender, EventArgs e)
        {
            /*
            bool estado = cbx_fechaSolicitud.Checked;
            dtp_desde_fechaSolicitud.Enabled = estado;
            dtp_hasta_fechaSolicitud.Enabled = estado;
            if (!estado)
            {
                dtp_desde_fechaSolicitud.Text = "";
                dtp_hasta_fechaSolicitud.Text = "";
            }
             
        }

        private void cbx_fechaEntrega_CheckedChanged(object sender, EventArgs e)
        {
            /*
            bool estado = cbx_fechaEntrega.Checked;
            dtp_desde_fechaEntrega.Enabled = estado;
            dtp_hasta_fechaEntrega.Enabled = estado;
            if (!estado)
            {
                dtp_desde_fechaEntrega.Text = "";
                dtp_hasta_fechaEntrega.Text = "";
            }
            
        }
         */
        private void cbx_estado_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_pendiente.Enabled = true;
            rbtn_entregado.Enabled = true;
            rbtn_cancelado.Enabled = true;
        }

        private void btn_cerrarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzadaPedido.Visible = false;
        }

        private void btn_BuscarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            this.dgv_pedidos.DataSource = priv_pedido.busquedaAvanzada(grp_busquedaAvanzadaPedido.Controls);
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            if (txt_busquedaProducto.Text != "")
            {
                error_buscar.Visible = false;
                this.dgv_pedidos.DataSource = priv_pedido.buscarPedidosPorID(int.Parse(txt_busquedaProducto.Text));
            }
            else
            {
                error_buscar.Visible = true;
            }
        }

    }
}
