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
    public partial class uc_ABM_Franquicia : UserControl
    {
        //FORMA 2
        private static uc_ABM_Franquicia priv_instance;
        public static uc_ABM_Franquicia pub_instance {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_ABM_Franquicia();
                return priv_instance;           
            }

        }
        public uc_ABM_Franquicia()
        {
            InitializeComponent();
        }
    }
}
