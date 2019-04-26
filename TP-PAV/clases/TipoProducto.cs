using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace TP_PAV.clases
{
    class TipoProducto
    {
        private AccesoBD priv_acceso_db = new AccesoBD();

        public DataTable traerTipoProducto()
        {
            string query = @"SELECT * FROM tipo_producto";
            return priv_acceso_db.ejecutarConsulta(query);
        }

        public bool altaTipoProducto(string nombre, string descripcion)
        {
            string noConsulta = String.Format(@"INSERT INTO tipo_producto (nombre_tipo_producto, descripcion) 
                                                VALUES ('{0}', '{1}') ", nombre, descripcion);
            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool modificarTipoProducto(int id_tipo_producto, string nombre, string descripcion)
        {
            string noConsulta = String.Format(@"UPDATE tipo_producto 
                                                SET nombre_tipo_producto = '{0}', descripcion = '{1}'
                                                WHERE id_tipo_producto = {2}", nombre, descripcion, id_tipo_producto
                                              );
            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarTipoProducto(int id_tipo_producto)
        {
            string noConsulta = @"DELETE FROM tipo_producto WHERE id_tipo_producto=" + id_tipo_producto.ToString();
            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
