using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using TP_PAV.clases;
using TP_PAV.formularios;

namespace TP_PAV.clases
{
    class Producto
    {
        
        AccesoBD db = new AccesoBD();
        /*
        public DataTable traerProductos()
        {
            string consulta = @"SELECT * FROM producto";

            return db.ejecutarConsulta(consulta);
        }
        */
        public DataTable buscarProductos(string texto)
        {
            string consulta = @"SELECT * FROM producto WHERE nombre_producto LIKE '%" + texto + "%' OR id_producto LIKE '%" + texto + "%';";

            return db.ejecutarConsulta(consulta);
        }

        public Validar.estado_validacion validarProducto(Control.ControlCollection controles)
        {
            uc_ABM_Producto form_padre_abmProducto = new uc_ABM_Producto();  
            Validar validar = new Validar();
            return validar.validarUC(controles, form_padre_abmProducto.pub_label_error);
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

        // TODO: Terminar funcion


        public DataTable recuperarProductos() 
        {
            string sql = @"SELECT p.id_producto, p.nombre_producto, p.cantidad_u_medida,
                                  u.nombre_u_medida, p.descripcion, u.id_u_medida, p.estado_producto, 
                                  t.nombre_tipo_producto, p.precio_unitario, t.id_tipo_producto
                                    FROM producto p
                                        JOIN unidad_medida u ON p.id_u_medida=u.id_u_medida
                                        JOIN tipo_producto t ON p.id_tipo_producto=t.id_tipo_producto 
                                    WHERE p.estado_producto=1";

            return db.ejecutarConsulta(sql);

        }
    }
}
