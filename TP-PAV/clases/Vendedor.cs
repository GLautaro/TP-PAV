using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV.clases;
using System.Windows.Forms;

namespace TP_PAV.clases
{
    class Vendedor
    {
        AccesoBD db = new AccesoBD();

        public DataTable traerVendedores()
        {
            string consulta = @"SELECT * FROM Vendedor";

            return db.ejecutarConsulta(consulta);

        }

        public DataTable VendedoresGrafico()
        {
            string consulta = @"SELECT count(*) as cantidad, habilitado FROM Vendedor group by habilitado";

            return db.ejecutarConsulta(consulta);

        }

        public DataTable MejoresVendedores()
        {
            string consulta = @"SELECT TOP 5 V.nombre_vendedor ,SUM(p.monto_final) as suma from vendedor V join pedido P on v.legajo_vendedor = P.id_vendedor WHERE p.id_estado = 1 GROUP BY P.id_vendedor, V.nombre_vendedor ORDER BY SUM(p.monto_final) desc";

            return db.ejecutarConsulta(consulta);

        }

        public DataTable buscarVendedores(string texto)
        {
            string consulta = @"SELECT * FROM Vendedor WHERE nombre_vendedor LIKE '%" + texto + "%' OR apellido_vendedor LIKE '%" + texto + "%' OR legajo_vendedor LIKE '" + texto + "%';";

            return db.ejecutarConsulta(consulta);

        }
        public DataTable insertarVendedor(string nombre, string apellido, string comision, int estado)
        {
            string consulta = @"INSERT INTO Vendedor (nombre_vendedor, apellido_vendedor, porcentaje_comision, habilitado) VALUES ('" + nombre + "','" + apellido + "','" + comision + "'," + estado + ")";
            return db.ejecutarConsulta(consulta);
        }

        public DataTable modificarVendedor(string legajo, string nombre, string apellido, string comision, int estado)
        {
            string consulta = @"UPDATE Vendedor SET nombre_vendedor = '" + nombre + "', apellido_vendedor = '" + apellido + "', porcentaje_comision = '" + comision + "' , habilitado = " + estado + " WHERE legajo_vendedor = " + legajo;
            return db.ejecutarConsulta(consulta);
        }

        public DataTable modificarDisponibilidadVendedor(string legajo, int estado)
        {
            string consulta = @"UPDATE Vendedor SET habilitado = " + estado + " WHERE legajo_vendedor = " + legajo;
            return db.ejecutarConsulta(consulta);
        }

        public DataTable busquedaAvanzada(Control.ControlCollection controles)
        {
            bool legajo = false;
            bool nomyape = false;
            bool comision = false;
            bool habilitado = false;
            bool deshabilitado = false;

            string leg_desde = "";
            string leg_hasta = "";
            string nombre ="";
            string apellido ="";
            string comision_desde ="";
            string comision_hasta ="";
            string consulta = "";
            
            //recoleccion de valores de cada control del grupo de botones correspondiente a la búsqueda avanzada
            foreach (Control item in controles)
            {
                if (item.Name == "chb_legajo")
                {
                    legajo = ((CheckBox)item).Checked;
                }
                else if (item.Name == "chb_NomyApe")
                {
                    nomyape = ((CheckBox)item).Checked;
                }
                else if (item.Name == "chb_comision")
                {
                    comision = ((CheckBox)item).Checked;
                }
                else if (item.Name == "radio_busqAvan_habilitados")
                {
                    habilitado = ((RadioButton)item).Checked;
                }
                else if (item.Name == "radio_busqAvan_deshabilitados")
                {
                   deshabilitado = ((RadioButton)item).Checked;
                }
                else if (item.Name == "txt_busqAvan_legajoDesde")
                {
                    leg_desde = item.Text;
                }
                else if (item.Name == "txt_busqAvan_legajoHasta")
                {
                    leg_hasta = item.Text;
                }
                else if (item.Name == "txt_busqAvan_nombre")
                {
                    nombre = item.Text;
                }
                else if (item.Name == "txt_busqAvan_apellido")
                {
                    apellido = item.Text;
                }
                else if (item.Name == "txt_busqAvan_comisionDesde")
                {
                    comision_desde = item.Text;
                }
                else if (item.Name == "txt_busqAvan_comisionHasta")
                {
                    comision_hasta = item.Text;
                }
            }

            //armar consulta de acuerdo a el valor de los checkbox seleccionados
            if (habilitado)
            {
                consulta = "SELECT * FROM Vendedor WHERE habilitado = 1";
            }
            else if (deshabilitado)
            {
                consulta = "SELECT * FROM Vendedor WHERE habilitado = 0";
            }
            else
            {
                //ayuda con esto, no se como solucionarlo
                consulta = "SELECT * FROM Vendedor WHERE 1=1";
            }
            if (legajo)
            {
                consulta = consulta + " AND legajo_vendedor BETWEEN " + leg_desde + " AND " + leg_hasta;
            }
            if (nomyape)
            {
                consulta = consulta + " AND nombre_vendedor LIKE '%" + nombre + "%' AND apellido_vendedor LIKE '%" + apellido + "%'";
            }
            if (comision)
            {
                consulta = consulta + " AND porcentaje_comision BETWEEN " + comision_desde + " AND " + comision_hasta;
            }

            return db.ejecutarConsulta(consulta);
        }
    }
}
