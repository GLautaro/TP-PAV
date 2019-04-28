using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_PAV.clases
{
    class Producto
    {
        AccesoBD db = new AccesoBD();

        public DataTable traerProductos()
        {
            string consulta = @"SELECT * FROM producto";

            return db.ejecutarConsulta(consulta);
        }

        public DataTable buscarProductos(string texto)
        {
            string consulta = @"SELECT * FROM producto WHERE nombre_producto LIKE '%" + texto + "%' OR id_producto LIKE '%" + texto + "%';";

            return db.ejecutarConsulta(consulta);
        }

/*        public DataTable insertarproducto(string nombre, string cantidad, string id_tipo_producto)
        {
            string consulta = @"insert into producto (nombre_producto, cantidad_u_medida, 
                                id_u_medida, descripcion, id_tipo_producto, precio_unitario, estado_producto) 
                                values ('" + nombre + "','" + cantidad + "','" + id_tipo_producto + "')";
            return db.ejecutarConsulta(consulta);
        }
*/       
        
    }
}
