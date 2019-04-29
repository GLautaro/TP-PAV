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
    public partial class uc_ABM_Vendedor : UserControl
    {
        Vendedor vendedor = new Vendedor();
        private static uc_ABM_Vendedor priv_instance;
        public static uc_ABM_Vendedor pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_ABM_Vendedor();
                return priv_instance;
            }

        }
        public uc_ABM_Vendedor()
        {
            InitializeComponent();
        }

        private void uc_ABM_vendedor_Load(object sender, EventArgs e)
        {
            this.dgv_vendedores.DataSource = vendedor.traerVendedores();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_busqueda.Text);
        }

        private void txt_busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_busqueda.Text);
        }

        private void ocultar_label_informacion(object sender, KeyEventArgs e)
        {
            this.label_informacion.ForeColor = Color.Red;
            this.label_informacion.Text = "";
            this.label_informacion.Visible = false;
        }

        private void btn_nuevoVendedor_Click(object sender, EventArgs e)
        {
            this.btn_modificar.Visible = false;
            if (this.txt_legajo.Text != "")
            {
                this.txt_legajo.Clear();
                this.txt_nombre.Clear();
                this.txt_apellido.Clear();
                this.txt_comision.Clear();
            }
            this.label_informacion.Visible = false;
            this.btn_guardar.Visible = true;
            this.btn_cancelar.Visible = true;
            modificarEstadoCajasDeTexto(true);
        }

        private bool validarFormulario()
        {
            if (this.txt_nombre.Text == "")
            {
                this.label_informacion.Text = "Ingrese nombre de vendedor";
                this.label_informacion.Visible = true;
                this.txt_nombre.Focus();
                return false;
            }
            if (this.txt_apellido.Text == "")
            {
                this.label_informacion.Text = "Ingrese apellido de vendedor";
                this.label_informacion.Visible = true;
                this.txt_apellido.Focus();
                return false;
            }
            if (this.txt_comision.Text == "")
            {
                this.label_informacion.Text = "Ingrese comision de vendedor";
                this.label_informacion.Visible = true;
                this.txt_comision.Focus();
                return false;
            }
            return true;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //obtiene el valor de la primera celda del dataGridView. En este caso es el legajo del vendedor
            //MessageBox.Show(this.dataGrid.CurrentRow.Cells[0].Value.ToString());

            //cargar los datos del dataGridView en el formulario de modificacion
            this.btn_registrar.Visible = false;
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Text = this.dgv_vendedores.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre.Text = this.dgv_vendedores.CurrentRow.Cells[1].Value.ToString();
            this.txt_apellido.Text = this.dgv_vendedores.CurrentRow.Cells[2].Value.ToString();
            this.txt_comision.Text = this.dgv_vendedores.CurrentRow.Cells[3].Value.ToString();
            if (this.dgv_vendedores.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                this.cmb_habilitado.SelectedIndex = 1;
            }
            else
            {
                this.cmb_habilitado.SelectedIndex = 0;
            }
            this.label_informacion.Visible = false;
            this.btn_guardar.Visible = true;
            this.btn_cancelar.Visible = true;
            modificarEstadoCajasDeTexto(true);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Dependiendo el valor del <textBox> de legajo este completado, se realizara la modificacion o el registro
            if (validarFormulario())
            {
                if (this.txt_legajo.Text != "")
                {
                    vendedor.modificarVendedor(this.txt_legajo.Text, this.txt_nombre.Text, this.txt_apellido.Text, this.txt_comision.Text, this.cmb_habilitado.SelectedIndex);
                    this.txt_legajo.Enabled = false;
                    this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_legajo.Text);

                    this.label_informacion.ForeColor = Color.YellowGreen;
                    this.label_informacion.Text = "Usuario modificado correctamente";
                    this.label_informacion.Visible = true;

                }else
                {
                    vendedor.insertarVendedor(this.txt_nombre.Text, this.txt_apellido.Text, this.txt_comision.Text, this.cmb_habilitado.SelectedIndex);
                    this.txt_legajo.Enabled = false;
                    this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_nombre.Text);
                    this.txt_legajo.Clear();
                    this.txt_nombre.Clear();
                    this.txt_apellido.Clear();
                    this.txt_comision.Clear();

                    this.label_informacion.ForeColor = Color.YellowGreen;
                    this.label_informacion.Text = "Usuario cargado correctamente";
                    this.label_informacion.Visible = true;
                }
                //desactivar botones de guardado y reactivar boton de modificacion y registro
                this.btn_guardar.Visible = false;
                this.btn_cancelar.Visible = false;
                this.btn_registrar.Visible = true;
                this.btn_modificar.Visible = true;
                modificarEstadoCajasDeTexto(false);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.txt_legajo.Clear();
            this.txt_nombre.Clear();
            this.txt_apellido.Clear();
            this.txt_comision.Clear();
            this.label_informacion.Visible = false;
            this.btn_guardar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_modificar.Visible = true;
            this.btn_registrar.Visible = true;
            modificarEstadoCajasDeTexto(false);
        }

        private void modificarEstadoCajasDeTexto(bool estado)
        {
            this.txt_nombre.Enabled = estado;
            this.txt_apellido.Enabled = estado;
            this.txt_comision.Enabled = estado;
            this.cmb_habilitado.Enabled = estado;
        }

        private void btn_activarBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            bool estado = this.grp_busquedaAvanzada.Visible;
            this.grp_busquedaAvanzada.Visible = !estado;
        }
    }
}
