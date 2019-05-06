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
        Pedido priv_pedido = new Pedido();
        Franquicia priv_franquicia = new Franquicia();

        public uc_Pedido()
        {
            InitializeComponent();
        }
        private static uc_Pedido priv_instance;
        public static uc_Pedido pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_Pedido();
                return priv_instance;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxHabilitado1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_Pedido_Load(object sender, EventArgs e)
        {

            dgv_pedidos.DataSource = priv_pedido.recuperarPedidosPendientes();
            dgv_detallePedido.DataSource = "";
            cmb_franquicia.DataSource = priv_franquicia.recuperarFranquicias();
            cmb_franquicia.DisplayMember = "id_franquicia";
            cmb_franquicia.ValueMember = "id_franquicia";
            cmb_franquicia.SelectedIndex = 0;


        }

        private void cmb_franquicia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row_selected = (DataRowView)cmb_franquicia.SelectedItem;

            txt_legajoVendedor.Text = row_selected.Row["legajo_vendedor"].ToString();
        }

        private void btn_addPedido_Click(object sender, EventArgs e)
        {
            if (priv_pedido.validarPedido(grp_crearPedido.Controls) == Validar.estado_validacion.correcto)
            {
                Pedido nuevo_pedido = new Pedido();
                if (nuevo_pedido.addPedido(grp_crearPedido.Controls))
                {
                    dgv_pedidos.DataSource = priv_pedido.recuperarPedidosPendientes();
                    MessageBox.Show("Se agregó correctamente!");
                    
                }
            }
            
        }

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_detallePedido.DataSource = priv_pedido.recuperarDetalleDePedido(int.Parse(dgv_pedidos.CurrentRow.Cells["id_pedido"].Value.ToString()));
        }
    }
}