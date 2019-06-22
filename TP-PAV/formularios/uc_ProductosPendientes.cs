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
    public partial class uc_ProductosPendientes : UserControl
    {
        private Producto priv_producto = new Producto();
        private static uc_ProductosPendientes priv_instance;
        public static uc_ProductosPendientes pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_ProductosPendientes();
                return priv_instance;
            }

        }
        public uc_ProductosPendientes()
        {
            InitializeComponent();
        }

        private void uc_ProductosPendientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = priv_producto.recuperarPendientes();
            if(tabla.Rows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen productos pendientes a la fecha";
                return;
            }
            else
            {
                dgv_productosPendientes.DataSource = tabla;
            }
            
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            DataTable tabla = priv_producto.recuperarPendientes();
            if (tabla.Rows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen productos pendientes a la fecha";
                return;
            }
            else
            {
                dgv_productosPendientes.DataSource = tabla;
            }
        }

    }
}
