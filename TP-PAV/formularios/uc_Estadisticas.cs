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
        Pedido pedido = new Pedido();
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

        private void llenarGrafico(DataTable tablaDatos, string titulo, string tituloLeyenda, string separador)
        {
            
            if (tablaDatos.Rows.Count < 1)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No ha sido posible recuperar los datos";
                return;
            }
            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Palette = ChartColorPalette.SeaGreen;
            
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
                serie.Label = separador + puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
            grafico.ResetAutoValues();
            grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            grafico.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            grafico.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
      
        }
        private void visibilidadFechas(bool estado){

            dtp_fechaHasta.Visible = estado;
            dtp_fechaDesde.Visible = estado;
            lbl_fechaDesde.Visible = estado;
            lbl_fechaHasta.Visible = estado;

        }
        //Para no hacer tantos grupos puse todos en el mismo grupo, pero solo muestra las opciones que corresponde segun el boton que tocan
        private void btn_estVendedores_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Vendedores";
            grp_estadisticas.Visible = true;
            btn_estFranquicias.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            btn_cantFranquiciasXVendedor.Visible = true;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaVendedorPedidos.Visible = true;
            btn_vendedoresConMenosPedidos.Visible = true;
            visibilidadFechas(true);
        }

        private void btn_estFranquicias_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Franquicias";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estProductos.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            visibilidadFechas(true);
            btn_franquiciaMasPedidosEnPeriodo.Visible = true;
            btn_franquiciaMenosPedidosEnPeriodo.Visible = true;
           
        }

        private void btn_estProductos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Productos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estPedidos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_productoPorFranquicia.Visible = true;
            btn_productoMasVendidoPeriodo.Visible = true;
            btn_productosMenosVendidos.Visible = true;
            visibilidadFechas(true);
        }

        private void btn_estPedidos_Click(object sender, EventArgs e)
        {
            grp_estadisticas.Text = "Estadisticas de Pedidos";
            grp_estadisticas.Visible = true;
            btn_estVendedores.Visible = false;
            btn_estProductos.Visible = false;
            btn_estFranquicias.Visible = false;
            //Activar la visibilidad de sus botones que muestran la estadistica 
            btn_EstadisticaCantPedidosPend.Visible = true;
            btn_EstadisticaCantPedidosEnt.Visible = true;
            visibilidadFechas(true);
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

            //Vendedores
            btn_EstadisticaVendedorPedidos.Visible = false;
            btn_vendedoresConMenosPedidos.Visible = false;
            btn_cantFranquiciasXVendedor.Visible = false;

            //Franquicias
            btn_franquiciaMenosPedidosEnPeriodo.Visible = false;
            btn_franquiciaMasPedidosEnPeriodo.Visible = false;
            btn_EstadisticaVendedorPedidos.Visible = false;

            //Productos
            btn_productoMasVendidoPeriodo.Visible = false;
            btn_productosMenosVendidos.Visible = false;
            btn_productoPorFranquicia.Visible = false;
            lbl_franquicia_producto.Visible = false;
            cmb_franquicias.Visible = false;

            //Pedidos
            btn_EstadisticaCantPedidosPend.Visible = false;
            btn_EstadisticaCantPedidosEnt.Visible = false;

            //Gráfico 
            grp_estadisticas.Visible = false;
            grp_estadisticas.Text = "";
            lbl_mensaje.Text = "";
            visibilidadFechas(false);
            grafico.DataSource = null;
            grafico.Series.Clear();
            grafico.Titles.Clear();
        }


        private bool validarFechas()
        {
            if (dtp_fechaHasta.Value.Date < dtp_fechaDesde.Value.Date)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No se puede seleccionar una Fecha Hasta menor a la Fecha Desde.";
                return false;
            }
            if (dtp_fechaHasta.Value.Date > DateTime.Now.Date)
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No se puede seleccionar una Fecha Hasta mayor a la fecha actual.";
                return false;
            }
            return true;
        }

        private void btn_EstadisticaVendedorPedidos_Click(object sender, EventArgs e)
        {
            visibilidadFechas(true);
            if (validarFechas())
            {
                llenarGrafico(vendedor.MejoresVendedores(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "VENDEDORES CON MÁS PEDIDOS ENTREGADOS: ", "Nombre y apellido del vendedor", "$");
            }
        }

        private void btn_vendedoresConMenosPedidos_Click(object sender, EventArgs e)
        {
            visibilidadFechas(true);
            if (validarFechas())
            {
                llenarGrafico(vendedor.PeoresVendedores(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "VENDEDORES CON MENOS PEDIDOS ENTREGADOS: ", "Nombre y apellido del vendedor", "$");
            }
        }

        private void btn_EstadisticaCantPedidosPend_Click(object sender, EventArgs e)
        {
            if (dtp_fechaDesde.Value.Date <= dtp_fechaHasta.Value.Date)
            {
                llenarGrafico(pedido.CantidadPedidosSolicitadosXRangoFecha(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "CANTIDAD DE PEDIDOS SOLICITADOS", "Mes y cantidad de pedidos", " ");
            }
            else
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "No se puede seleccionar una Fecha Hasta menor a la Fecha Desde.";
            }
       }

        private void btn_EstadisticaCantPedidosEnt_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(pedido.CantidadPedidosEntregadosXRangoFecha(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "CANTIDAD DE PEDIDOS ENTREGADOS", "Mes y cantidad de pedidos", " ");

            }

        }
        private void btn_productoMasVendidoPeriodo_Click(object sender, EventArgs e)
        {
            if(validarFechas())
            {
                llenarGrafico(producto.ProductosMasVendidosXTiempo(dtp_fechaDesde.Value.Date.ToShortDateString(), 
                    dtp_fechaHasta.Value.Date.ToShortDateString()),
                    "PRODUCTOS MAS VENDIDOS EN UN PERIODO", "Nombre del producto"," ");
            }
        }

        private void btn_productosMenosVendidos_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(producto.ProductosMenosVendidosXTiempo(dtp_fechaDesde.Value.Date.ToShortDateString(),
                    dtp_fechaHasta.Value.Date.ToShortDateString()),
                    "PRODUCTOS MENOS VENDIDOS EN UN PERIODO", "Nombre del producto", " ");
            }
        }

        private void btn_franquiciaMenosPedidosEnPeriodo_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(franquicia.PeoresFranquicias(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "PEORES FRANQUICIAS EN PERIODO: ", "Nombre y apellido del representante","$ ");
            }
        }

        private void btn_franquiciaMasPedidosEnPeriodo_Click(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(franquicia.MejoresFranquicias(dtp_fechaDesde.Value, dtp_fechaHasta.Value), "MEJORES FRANQUICIAS EN PERIODO:", "Nombre y apellido del representante","$ ");
            }
        }
        private void btn_productoPorFranquicia_Click(object sender, EventArgs e)
        {
            lbl_franquicia_producto.Visible = true;
            cmb_franquicias.Visible = true;
            this.cmb_franquicias.cargar("franquicia", "id_franquicia", "id_franquicia");
            this.cmb_franquicias.SelectedIndex = -1;
        }

        private void estadistica_productoPorFranquicia(object sender, EventArgs e)
        {
            if (validarFechas())
            {
                llenarGrafico(producto.ProductosMasCompradoXFranquiciaXTiempo(dtp_fechaDesde.Value, dtp_fechaHasta.Value, cmb_franquicias.SelectedValue.ToString()), "PRODUCTOS MÁS COMPRADOS POR UNA FRANQUICIA EN UN PERIODO:", "Nombre del producto", " ");
            }
        }

        private void btn_cantFranquiciasXVendedor_Click(object sender, EventArgs e)
        {
            visibilidadFechas(false);
            llenarGrafico(vendedor.CantidadFranquiciasXVendedor(), "CANTIDAD DE FRANQUICIAS POR VENDEDOR:", "Legajo del vendedor", " ");
        } 
    }
}
