using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.formularios;

namespace TP_PAV
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
            SidePanel.Hide();
           
        }

        private void btn_menuPedidos_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuPedidos.Height;
            SidePanel.Top = btn_menuPedidos.Top;
            if (!main_panel.Controls.Contains(uc_Pedido.pub_instance))
            {
                main_panel.Controls.Add(uc_Pedido.pub_instance);
                uc_Pedido.pub_instance.Dock = DockStyle.Fill;
                uc_Pedido.pub_instance.BringToFront();
            }
            else
            {

                uc_Pedido.pub_instance.BringToFront();

            }
        }
      

        private void btn_menuProductos_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuProductos.Height;
            SidePanel.Top = btn_menuProductos.Top;

            if (!main_panel.Controls.Contains(uc_ABM_Producto.pub_instance)) 
            {
                main_panel.Controls.Add(uc_ABM_Producto.pub_instance);
                uc_ABM_Producto.pub_instance.Dock = DockStyle.Fill;
                uc_ABM_Producto.pub_instance.BringToFront();
            }
            else 
            {
                uc_ABM_Producto.pub_instance.BringToFront();
            }
            
        }

        private void btn_menuVendedores_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuVendedores.Height;
            SidePanel.Top = btn_menuVendedores.Top;
            if (!main_panel.Controls.Contains(uc_ABM_Vendedor.pub_instance))
            {
                main_panel.Controls.Add(uc_ABM_Vendedor.pub_instance);
                uc_ABM_Vendedor.pub_instance.Dock = DockStyle.Fill;
                uc_ABM_Vendedor.pub_instance.BringToFront();
  
            }
            else
            {
                uc_ABM_Vendedor.pub_instance.BringToFront();
            }
        }

        private void btn_menuFranquicias_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuFranquicias.Height;
            SidePanel.Top = btn_menuFranquicias.Top;
            
             if (!main_panel.Controls.Contains(uc_ABM_Franquicia.pub_instance))
            {
                main_panel.Controls.Add(uc_ABM_Franquicia.pub_instance);
                uc_ABM_Franquicia.pub_instance.Dock = DockStyle.Fill;
                uc_ABM_Franquicia.pub_instance.BringToFront();
                

            }
            else
            {
                uc_ABM_Franquicia.pub_instance.BringToFront();
                
            
            }
        }

        private void btn_menuEstadisticas_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuEstadisticas.Height;
            SidePanel.Top = btn_menuEstadisticas.Top;
        }

        private void btn_menuReportes_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btn_menuReportes.Height;
            SidePanel.Top = btn_menuReportes.Top;
        }

        

    }
}
