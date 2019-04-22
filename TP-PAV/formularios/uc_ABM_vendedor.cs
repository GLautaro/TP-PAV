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

        private void dgv_vendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtiene el valor de la primera celda del dataGridView. En este caso es el legajo del vendedor
            //MessageBox.Show(this.dataGrid.CurrentRow.Cells[0].Value.ToString());

            //cargar los datos del dataGridView en el formulario de modificacion
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Text = this.dgv_vendedores.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre.Text = this.dgv_vendedores.CurrentRow.Cells[1].Value.ToString();
            this.txt_apellido.Text = this.dgv_vendedores.CurrentRow.Cells[2].Value.ToString();
            this.txt_comision.Text = this.dgv_vendedores.CurrentRow.Cells[3].Value.ToString();
            this.label_informacion.Visible = false;
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
            else
            {
                if (validarFormulario())
                {
                    vendedor.insertarVendedor(this.txt_nombre.Text, this.txt_apellido.Text, this.txt_comision.Text);
                    this.txt_legajo.Enabled = false;
                    MessageBox.Show("Usuario registrado con exito");
                    this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_nombre.Text);
                    this.txt_legajo.Clear();
                    this.txt_nombre.Clear();
                    this.txt_apellido.Clear();
                    this.txt_comision.Clear();

                    this.label_informacion.ForeColor = Color.YellowGreen;
                    this.label_informacion.Text = "Usuario cargado correctamente";
                    this.label_informacion.Visible = true;
                }
            }
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
            if (this.txt_legajo.Text != "")
            {
                if (validarFormulario())
                {
                    vendedor.modificarVendedor(this.txt_legajo.Text, this.txt_nombre.Text, this.txt_apellido.Text, this.txt_comision.Text);
                    this.txt_legajo.Enabled = false;
                    this.dgv_vendedores.DataSource = vendedor.buscarVendedores(this.txt_legajo.Text);

                    this.label_informacion.ForeColor = Color.YellowGreen;
                    this.label_informacion.Text = "Usuario modificado correctamente";
                    this.label_informacion.Visible = true;
                }
            }
        }

        private void dgv_vendedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //obtiene el valor de la primera celda del dataGridView. En este caso es el legajo del vendedor
            //MessageBox.Show(this.dataGrid.CurrentRow.Cells[0].Value.ToString());

            //cargar los datos del dataGridView en el formulario de modificacion
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Text = this.dgv_vendedores.CurrentRow.Cells[0].Value.ToString();
            this.txt_nombre.Text = this.dgv_vendedores.CurrentRow.Cells[1].Value.ToString();
            this.txt_apellido.Text = this.dgv_vendedores.CurrentRow.Cells[2].Value.ToString();
            this.txt_comision.Text = this.dgv_vendedores.CurrentRow.Cells[3].Value.ToString();
            this.btn_modificar.Visible = true;
        }
    }
}
