using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP_PAV.clases;

namespace TP_PAV.formularios
{
    public partial class uc_Estadisticas : UserControl
    {
        Vendedor vendedor = new Vendedor();
        Franquicia franquicia = new Franquicia();
        Producto producto = new Producto();
        private static uc_Estadisticas priv_instance;
        public static uc_Estadisticas pub_instance
        {
            get
            {
                if (priv_instance == null)
                    priv_instance = new uc_Estadisticas();
                return priv_instance;
            }

        }
        public uc_Estadisticas()
        {
            InitializeComponent();
        }

        private void uc_Reportes_Load(object sender, EventArgs e)
        {
            grafico.Series.Clear();
        }

        private void llenarGrafico(DataTable tablaDatos, string titulo, string tituloLeyenda, ChartColorPalette color)
        {
            if (tablaDatos.Rows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha sido posible recuperar los datos";
                return;
            }
            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Palette = color;
            grafico.Titles.Add(titulo);
            
            List<string> series = new List<string> { };
            List<int> puntos = new List<int> { };

            for (int i = 0; i < tablaDatos.Rows.Count; i++)
            {
                series.Add(tablaDatos.Rows[i][0].ToString());
                puntos.Add(int.Parse(tablaDatos.Rows[i][1].ToString()));
            }
            for (int i = 0; i < series.Count; i++)
            {
                Series serie;
                serie = grafico.Series.Add(series[i].ToString());
                serie.Label = "$ " + puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
            
            grafico.ChartAreas[0].AxisY.Minimum = 0;
            grafico.ChartAreas[0].AxisY.Maximum = (puntos.Max() - puntos.Max() % 1000) + 1000;
            
        }

        //Para no hacer tantos grupos puse todos en el mismo grupo, pero solo muestra las opciones que corresponde segun el boton que tocan
        private void btn_estVendedores_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Vendedores";
            grp_estadisticas.Visible = true;
            btn_estFranquicias.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaVendedorPedidos.Visible = true;
        }

        private void btn_estFranquicias_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Franquicias";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaFranquiciaPedidos.Visible = true;
        }

        private void btn_estProductos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Productos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_productoMasVendido.Visible = true;
        }

        private void btn_estPedidos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Pedidos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estProductos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
        }

        private void btn_cerrarGrupo_Click(object sender, EventArgs e)
        {
            //Si quieren pueden hacer un ciclo que lo automatice pero un viaje
            btn_estVendedores.Visible = true;
            btn_estFranquicias.Visible = true;
            btn_estPedidos.Visible = true;
            btn_estProductos.Visible = true;
            //Hay que sacarle la visibilidad a todos los botones del grupo si no cuando 
            //abrimos otra opcion sigue quedando el boton de la opcion anterior
            btn_EstadisticaFranquiciaPedidos.Visible = false;
            btn_EstadisticaVendedorPedidos.Visible = false;
            btn_productoMasVendido.Visible = false;
            grp_estadisticas.Visible = false;
            grp_estadisticas.Text = "";
        }


        private void btn_EstadisticaVendedorPedidos_Click(object sender, EventArgs e)
        {
            llenarGrafico(vendedor.MejoresVendedores(), "MEJORES VENDEDORES: ","Nombre y apellido del vendedor", ChartColorPalette.SeaGreen);
        }

        private void btn_EstadisticaFranquiciaPedidos_Click(object sender, EventArgs e)
        {
            llenarGrafico(franquicia.MejoresFranquicias(), "MEJORES FRANQUICIAS: ", "Nombre y apellido del representante", ChartColorPalette.SeaGreen);
        }

        private void btn_productoMasVendido_Click(object sender, EventArgs e)
        {
            llenarGrafico(producto.productosMasVendidosHistorico(), "PRODUCTOS MAS VENDIDOS", "Nombre del producto", ChartColorPalette.SeaGreen);
        }

    }
}
