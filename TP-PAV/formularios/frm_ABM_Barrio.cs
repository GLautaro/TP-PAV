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
    public partial class frm_ABM_Barrio : Form
    {
        Barrio priv_barrio = new Barrio();
        uc_ABM_Franquicia priv_formularioPadre = new uc_ABM_Franquicia();
        private int priv_selectedCmbIndex;
        private ComboBox priv_cmb_barrios;
        public ComboBox pub_cmb_barrios
        {
            set { priv_cmb_barrios = value; }
        }
        public int pub_selectedIndex
        {
            set { priv_selectedCmbIndex = value; }
        }
        public frm_ABM_Barrio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void desbloquearBotonesPrincipales(bool value)
        {
            btn_habilitarAgregarBarrio.Enabled = value;
            btn_habilitarModificarBarrio.Enabled = value;
            btn_eliminarBarrio.Enabled = value;
        }
        private void resetearFormulario()
        {
            btn_agregarBarrio.Visible = false;
            btn_cancelar.Enabled = false;
            btn_modificarBarrio.Visible = true;
            btn_modificarBarrio.Enabled = false;
            desbloquearBotonesPrincipales(true);
            txt_nombre_barrio.Enabled = false;
            dgv_barrio.Enabled = true;
            txt_nombre_barrio.Text = "";
        }
        private void frm_ABM_Barrio_Load(object sender, EventArgs e)
        {
            dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            resetearFormulario();

        }
        private void btn_habilitarAgregarBarrio_Click(object sender, EventArgs e)
        {
            txt_nombre_barrio.Text = "";
            btn_agregarBarrio.Visible = true;
            btn_cancelar.Enabled = true;
            btn_modificarBarrio.Visible = false;
            desbloquearBotonesPrincipales(false);
            txt_nombre_barrio.Enabled = true;
            dgv_barrio.Enabled = false;
        }

        private void btn_agregarBarrio_Click(object sender, EventArgs e)
        {
            if (txt_nombre_barrio.Text != "")
            {
                priv_barrio.pub_nombre_barrio = txt_nombre_barrio.Text;
                if (priv_barrio.addBarrio())
                {
                    MessageBox.Show("Se agregó correctamente.");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();

                }
                else
                {
                    MessageBox.Show("Error al tratar de agregar el barrio.");
                }

                resetearFormulario();

            }
            else
            {
                MessageBox.Show("El campo Nombre del Barrio es obligatorio.");
            }
        }

        private void btn_habilitarModificarBarrio_Click(object sender, EventArgs e)
        {
            txt_nombre_barrio.Text = dgv_barrio.CurrentRow.Cells["nombre_barrio"].Value.ToString();
            btn_cancelar.Enabled = true;
            btn_modificarBarrio.Visible = true;
            btn_modificarBarrio.Enabled = true;
            desbloquearBotonesPrincipales(false);
            txt_nombre_barrio.Enabled = true;
            dgv_barrio.Enabled = false;

        }

        private void btn_modificarBarrio_Click(object sender, EventArgs e)
        {
            if (txt_nombre_barrio.Text != "")
            {
                priv_barrio.pub_nombre_barrio = txt_nombre_barrio.Text;
                priv_barrio.pub_id_barrio = priv_selectedCmbIndex = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
                if (priv_barrio.updateBarrio())
                {
                    MessageBox.Show("Se modificó correctamente.");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();

                }
                else
                {
                    MessageBox.Show("Error al tratar de modificar el barrio.");
                }

                resetearFormulario();

            }
            else
            {
                MessageBox.Show("El campo Nombre del Barrio es obligatorio.");
            }

        }

        private void dgv_barrio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre_barrio.Text = dgv_barrio.CurrentRow.Cells["nombre_barrio"].Value.ToString();
        }

        private void btn_eliminarBarrio_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este barrio?\n La accion no se puede deshacer",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                priv_barrio.pub_id_barrio = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
                if (priv_barrio.deleteBarrio())
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void frm_ABM_Barrio_FormClosing(object sender, FormClosingEventArgs e)
        {
            priv_cmb_barrios.DataSource = priv_barrio.recuperarBarrios();
            priv_cmb_barrios.SelectedIndex = priv_selectedCmbIndex;
     
        }

      


    }
}
