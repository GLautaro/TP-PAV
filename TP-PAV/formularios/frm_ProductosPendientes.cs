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
    public partial class frm_ProductosPendientes : Form
    {
        Producto priv_producto = new Producto();
        
        public frm_ProductosPendientes()
        {
            InitializeComponent();
        }

        private void frm_ProductosPendientes_Load(object sender, EventArgs e)
        {
            lbl_fechaActual.Text = DateTime.Today.ToString("dd/MM/yyyy");
            DataTable productosPendientes = priv_producto.recuperarPendientes();
            if (productosPendientes.Rows.Count <= 0)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen productos pendientes a la fecha";
                return;
            }

            dgv_productosPendientes.DataSource = productosPendientes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable productosPendientes = priv_producto.recuperarPendientes();
            if (productosPendientes.Rows.Count <= 0)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No existen productos pendientes a la fecha";
                return;
            }

            dgv_productosPendientes.DataSource = productosPendientes;
        }
    }
}
