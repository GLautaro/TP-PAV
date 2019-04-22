using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV.formularios
{
    public partial class uc_ABM_Producto : UserControl
    {

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

        private void btn_agregarEstado_Click(object sender, EventArgs e)
        {
            frm_ABM_TipoProducto frm_ABM_TipoProducto = new frm_ABM_TipoProducto();
            frm_ABM_TipoProducto.ShowDialog();
        }
    }
}
