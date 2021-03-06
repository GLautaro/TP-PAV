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

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido_seleccionado = new Pedido();
            pedido_seleccionado.pub_id_pedido = int.Parse(dgv_pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());
            DetallePedido detalle_pedido_seleccionado = new DetallePedido();
            detalle_pedido_seleccionado.pub_pedido = pedido_seleccionado;
            dgv_detallePedido.DataSource = detalle_pedido_seleccionado.recuperarDetalleDePedido();
        }
        
        private void btn_busquedaAvanzadaPedido_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzadaPedido.Visible = true;

            this.cmb_franquicias.cargar("franquicia", "id_franquicia", "id_franquicia");
            this.cmb_franquicias.SelectedIndex = -1;

            this.cmb_vendedores.cargar("vendedor", "legajo_vendedor", "legajo_vendedor");
            this.cmb_vendedores.SelectedIndex = -1;

            lbl_msjErrorBusquedaAv.Visible = false;
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
        private void cbx_estado_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = cbx_estado.Checked;
            rbtn_pendiente.Enabled = estado;
            rbtn_entregado.Enabled = estado;
            rbtn_cancelado.Enabled = estado;
            if (!estado)
            {
                rbtn_pendiente.Checked = false;
                rbtn_entregado.Checked = false;
                rbtn_cancelado.Checked = false;
            }
        }

        private void btn_cerrarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            grp_busquedaAvanzadaPedido.Visible = false;
            dgv_pedidos.DataSource = priv_pedido.recuperarPedidos();
            dgv_detallePedido.DataSource = "";
        }

        private void btn_BuscarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if(validarBusquedaAvanzada())
            {
                this.dgv_pedidos.DataSource = priv_pedido.busquedaAvanzada(grp_busquedaAvanzadaPedido.Controls);
            }
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            if (txt_busquedaProducto.Text != "")
            {
                this.dgv_pedidos.DataSource = priv_pedido.buscarPedidosPorID(int.Parse(txt_busquedaProducto.Text));
            }
            else
            {
                dgv_pedidos.DataSource = priv_pedido.recuperarPedidos();
            }
        }

        private bool validarBusquedaAvanzada()
        {
            int precio_desde = -1, precio_hasta = 9999;
            int.TryParse(txt_desde_monto.Text, out precio_desde);
            int.TryParse(txt_hasta_monto.Text, out precio_hasta);

            if (cbx_franquicia.Checked)
            {
                if (cmb_franquicias.SelectedIndex == -1)
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = cmb_franquicias._mensaje_error;
                    lbl_msjErrorBusquedaAv.Show();
                    return false;
                }
            }
            if (cbx_vendedor.Checked)
            {
                if (cmb_vendedores.SelectedIndex == -1)
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = cmb_vendedores._mensaje_error;
                    lbl_msjErrorBusquedaAv.Show();
                    return false;
                }
            }
            if (cbx_monto.Checked)
            {
                if (txt_desde_monto.Text == "" && txt_hasta_monto.Text == "")
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = "MONTO: Ingrese al menos un limite \n para la busqueda.";
                    lbl_msjErrorBusquedaAv.Show();
                    txt_desde_monto.Focus();
                    return false;
                }
                else if (precio_desde > precio_hasta && precio_hasta != 0)
                {
                    lbl_msjErrorBusquedaAv.ForeColor = Color.Red;
                    lbl_msjErrorBusquedaAv.Text = "MONTO: El limite inferior debe ser menor \n que el limite superior.";
                    lbl_msjErrorBusquedaAv.Show();
                    txt_desde_monto.Focus();
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
