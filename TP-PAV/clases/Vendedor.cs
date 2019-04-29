using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
    }
}
