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
    public partial class uc_Pedido : UserControl
    {
        Franquicia priv_franquicia = new Franquicia();
        Pedido priv_pedido = new Pedido();
       
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
                priv_frm_detallePedido.pub_pedido = nuevo_pedido;
                priv_frm_detallePedido.ShowDialog();
                //nuevo_pedido.cerrar_transaccion_pedido(false);
                dgv_pedidos.DataSource = nuevo_pedido.recuperarPedidosPendientes();
            }
            
        }

  
        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgv_detallePedido.DataSource = priv_pedido.recuperarDetalleDePedido(int.Parse(dgv_pedidos.CurrentRow.Cells["id_pedido"].Value.ToString()));
        }

      
    }
}
