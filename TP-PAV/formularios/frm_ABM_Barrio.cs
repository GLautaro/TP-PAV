﻿using System;
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
            if (txt_nombre_barrio.Text.Trim() != "")
            {
                if (priv_barrio.addBarrio(txt_nombre_barrio.Text))
                {
                    DialogResult result = MessageBox.Show("Tipo de Franquicia cargada correctamente\n¿Desea cargar otra franquicia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No)
                    {
                        resetearFormulario();
                        desbloquearBotonesPrincipales(true);
                    }
                    else
                    {
                        txt_nombre_barrio.Clear();
                        txt_nombre_barrio.Focus();

                    }
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
                }
                else
                {
                    MessageBox.Show("Error al tratar de agregar el barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre del Barrio esta vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre_barrio.Focus();
            }


        }

        private void btn_habilitarModificarBarrio_Click(object sender, EventArgs e)
        {
            if (dgv_barrio.SelectedRows.Count < 1)
            {
                MessageBox.Show("No existen franquicias cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

            if (txt_nombre_barrio.Text.Trim() != "")
            {
                Barrio priv_barrioModificar = new Barrio();
                priv_barrioModificar.pub_nombre_barrio = txt_nombre_barrio.Text;
                priv_barrioModificar.pub_id_barrio = priv_selectedCmbIndex = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
                if (priv_barrioModificar.updateBarrio())
                {
                    MessageBox.Show("Se modificó correctamente.");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();

                }
                else
                {
                    MessageBox.Show("Error al tratar de modificar el barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                resetearFormulario();

            }
            else
            {
                MessageBox.Show("El campo Nombre del Barrio es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre_barrio.Focus();
            }

        }

        private void dgv_barrio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nombre_barrio.Text = dgv_barrio.CurrentRow.Cells["nombre_barrio"].Value.ToString();
        }

        private void btn_eliminarBarrio_Click(object sender, EventArgs e)
        {
            if (dgv_barrio.SelectedRows.Count < 1)
            {
                MessageBox.Show("No existen franquicias cargadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este barrio?\n La accion no se puede deshacer",
                                                     "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Barrio priv_barrioEliminar = new Barrio();

                priv_barrioEliminar.pub_id_barrio = int.Parse(dgv_barrio.CurrentRow.Cells["id_barrio"].Value.ToString());
                if (priv_barrioEliminar.deleteBarrio())
                {
                    MessageBox.Show("Se ha eliminado correctamente");
                    dgv_barrio.DataSource = priv_barrio.recuperarBarrios();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar el barrio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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