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

        private void btn_EstadisticaVendedorPedidos_Click(object sender, EventArgs e)
        {
            DataTable datosEstadisticos = vendedor.MejoresVendedores();

            List<string> series = new List<string> { };
            List<int> puntos = new List<int> { };

            for (int i = 0; i < datosEstadisticos.Columns.Count; i++)
            {
                series.Add(datosEstadisticos.Rows[i][0].ToString());
            }
            for (int i = 0; i < datosEstadisticos.Columns.Count; i++)
            {
                puntos.Add(int.Parse(datosEstadisticos.Rows[i][1].ToString()));
            }

            //cambiar la combinacion de colores
            grafico.Palette = ChartColorPalette.SeaGreen;

            grafico.Series.Clear();
            
            grafico.Titles.Clear();
            grafico.Titles.Add("MEJORES VENDEDORES:");
            

            for (int i = 0; i < series.Count; i++)
            {
                Series serie;
                serie = grafico.Series.Add(series[i].ToString());
                serie.Label = "$ " + puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
