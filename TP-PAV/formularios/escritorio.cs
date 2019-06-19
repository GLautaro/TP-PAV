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
            show_page_default();
        }

        private void show_page_default()
        {
            SidePanel.Height = btn_menuPedidos.Height;
            SidePanel.Top = btn_menuPedidos.Top;
            SidePanel.Show();
            uc_Pedido uc_pedido = new uc_Pedido();
            main_panel.Controls.Add(uc_pedido);
            uc_pedido.Dock = DockStyle.Fill;
            uc_pedido.BringToFront();
        }
        private void btn_menuPedidos_Click(object sender, EventArgs e)
        {
            show_page_default();
            
        }
      

        private void btn_menuProductos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_menuProductos.Height;
            SidePanel.Top = btn_menuProductos.Top;
            SidePanel.Show();

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
            SidePanel.Height = btn_menuVendedores.Height;
            SidePanel.Top = btn_menuVendedores.Top;
            SidePanel.Show();
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
            SidePanel.Height = btn_menuFranquicias.Height;
            SidePanel.Top = btn_menuFranquicias.Top;
            SidePanel.Show();
            
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
            SidePanel.Height = btn_menuEstadisticas.Height;
            SidePanel.Top = btn_menuEstadisticas.Top;
            if (!main_panel.Controls.Contains(uc_Estadisticas.pub_instance))
            {
                main_panel.Controls.Add(uc_Estadisticas.pub_instance);
                uc_Estadisticas.pub_instance.Dock = DockStyle.Fill;
                uc_Estadisticas.pub_instance.BringToFront();
            }
            else
            {
                uc_Estadisticas.pub_instance.BringToFront();
            }
        }

        private void btn_menuHistorialPedidos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_menuHistorialPedidos.Height;
            SidePanel.Top = btn_menuHistorialPedidos.Top;
            SidePanel.Show();
            uc_HistorialPedidos uc_historial = new uc_HistorialPedidos();
            main_panel.Controls.Add(uc_historial);
            uc_historial.Dock = DockStyle.Fill;
            uc_historial.BringToFront();
        }

        private void btn_menuProductosPendientes_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_menuProductosPendientes.Height;
            SidePanel.Top = btn_menuProductosPendientes.Top;
            SidePanel.Show();
            uc_ProductosPendientes uc_pendientes = new uc_ProductosPendientes();
            main_panel.Controls.Add(uc_pendientes);
            uc_pendientes.Dock = DockStyle.Fill;
            uc_pendientes.BringToFront();
        }

        

    }
}
