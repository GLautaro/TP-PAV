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

            for (int i = 0; i < tablaDatos.Columns.Count; i++)
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
        private void btn_EstadisticaVendedorPedidos_Click(object sender, EventArgs e)
        {
            llenarGrafico(vendedor.MejoresVendedores(), "MEJORES VENDEDORES: ","Nombre y apellido del vendedor", ChartColorPalette.SeaGreen);
        }

        private void btn_EstadisticaFranquiciaPedidos_Click(object sender, EventArgs e)
        {
            llenarGrafico(franquicia.MejoresFranquicias(), "MEJORES FRANQUICIAS: ", "Nombre y apellido del representante", ChartColorPalette.SeaGreen);
        }
    }
}
