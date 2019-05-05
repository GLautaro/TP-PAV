using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using TP_PAV.clases;

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

        public Validar.estado_validacion validarProducto(Control.ControlCollection controles)
        {
            Validar validar = new Validar();
            return validar.validarUC(controles);
        }

        public void grabarProducto (Control.ControlCollection controles)
        {
            db.insert_automatizado(controles, "producto");
        }

        public DataTable grabarModificaciones(string id, string nombre, string cantidad, string descripcion, string precio,
                                         int estado, string tipo, string unidad)
        {
            string consulta = String.Format(@"UPDATE producto SET 
                                                     nombre_producto='{0}',cantidad_u_medida='{1}',
                                                     id_u_medida='{2}',descripcion='{3}',id_tipo_producto={4},precio_unitario={5},
                                                     estado_producto={6} WHERE id_producto={7}",
                                        nombre, cantidad, unidad, descripcion, tipo, precio, estado, id);

            return db.ejecutarConsulta(consulta);
        }
    }
}
