﻿using System;
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
    public partial class uc_Pedido : UserControl
    {
        Franquicia priv_franquicia = new Franquicia();
        Pedido priv_pedido = new Pedido();
       
        public uc_Pedido()
        {
            InitializeComponent();
        }
       

        private void uc_Pedido_Load(object sender, EventArgs e)
        {
            
            dgv_pedidos.DataSource = priv_pedido.recuperarPedidosPendientes();
            dgv_detallePedido.DataSource = "";
            cmb_franquicia.DataSource = priv_franquicia.recuperarFranquicias();
            cmb_franquicia.DisplayMember = "id_franquicia";
            cmb_franquicia.ValueMember = "id_franquicia";
            cmb_franquicia.SelectedIndex = -1;


        }

        private void cmb_franquicia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cmb_franquicia.SelectedIndex.ToString()) == -1)
            {
                txt_legajoVendedor.Text = "";
            }
            if (int.Parse(cmb_franquicia.SelectedIndex.ToString()) != -1)
            {
                DataRowView row_selected = (DataRowView)cmb_franquicia.SelectedItem;

                txt_legajoVendedor.Text = row_selected["legajo_vendedor"].ToString();
            }
            
        }
        private void cleanMensaje()
        {
            label_error.ForeColor = Color.Red;
            label_error.Text = "";
            label_error.Visible = false;
        }
        private void mostrarMensaje(string value, bool error)
        {
            if (error)
            {
                label_error.ForeColor = Color.Red;
            }
            else
            {
                label_error.ForeColor = Color.Green;
            }
            label_error.Text = value;
            label_error.Visible = true;
        }
        private void btn_addPedido_Click(object sender, EventArgs e)
        {
            priv_pedido.pub_Pedido_label_error = this.label_error;
            if (priv_pedido.validarPedido(grp_crearPedido.Controls) == Validar.estado_validacion.correcto)
            {
                frm_DetallePedido priv_frm_detallePedido = new frm_DetallePedido();
                Pedido nuevo_pedido = new Pedido();               
                nuevo_pedido.iniciar_transaccion_pedido();
                DataTable result = nuevo_pedido.addPedido(dt_fechaSolicitada.Text.ToString(), 1, int.Parse(cmb_franquicia.SelectedValue.ToString()), int.Parse(txt_legajoVendedor.Text.ToString()));
                
                priv_frm_detallePedido.pub_id_pedido = int.Parse(result.Rows[0]["id_ultimo_pedido"].ToString());

                DataRowView row_selected = (DataRowView)cmb_franquicia.SelectedItem;
                priv_frm_detallePedido.pub_monto_minimo = int.Parse(row_selected["monto_minimo_compra"].ToString());

                priv_frm_detallePedido.pub_pedido = nuevo_pedido;
                
                
                priv_frm_detallePedido.ShowDialog();
                //nuevo_pedido.cerrar_transaccion_pedido(false);
                dgv_pedidos.DataSource = nuevo_pedido.recuperarPedidosPendientes();
                cleanMensaje();
            }
            
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

        private void cmb_franquicia_Click(object sender, EventArgs e)
        {
            dgv_pedidos.DataSource = priv_pedido.recuperarPedidosPendientes();

        }

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
                    dgv_pedidos.DataSource = priv_pedido.recuperarPedidosPendientes();
                    dgv_detallePedido.DataSource = "";
                    mostrarMensaje("Se cambio el estado del pedido!", false);
                }
            }

        }

        private void btn_busquedaAvanzadaPedido_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzadaPedido.Visible = true;

            this.cmb_franquicias.cargar("franquicia", "id_franquicia", "nombre_responsable");
            this.cmb_franquicias.SelectedIndex = -1;

            this.cmb_vendedores.cargar("vendedor", "legajo_vendedor", "nombre_vendedor");
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

        private void cbx_fechaSolicitud_CheckedChanged(object sender, EventArgs e)
        {
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
            bool estado = cbx_fechaEntrega.Checked;
            dtp_desde_fechaEntrega.Enabled = estado;
            dtp_hasta_fechaEntrega.Enabled = estado;
            if (!estado)
            {
                dtp_desde_fechaEntrega.Text = "";
                dtp_hasta_fechaEntrega.Text = "";
            }
        }

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
      
    }
}
