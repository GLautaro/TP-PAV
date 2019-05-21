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
        private Label priv_label_error_producto;
        public Label pub_label_error_producto
        {
            get { return priv_label_error_producto; }
            set { priv_label_error_producto = value; }
        }
       
        public DataTable buscarProductos(string texto)
        {
            string consulta = @"SELECT p.id_producto, p.nombre_producto, p.cantidad_u_medida,
                                  u.nombre_u_medida, p.descripcion, u.id_u_medida, p.estado_producto, 
                                  t.nombre_tipo_producto, p.precio_unitario, t.id_tipo_producto
                                    FROM producto p
                                        JOIN unidad_medida u ON p.id_u_medida=u.id_u_medida
                                        JOIN tipo_producto t ON p.id_tipo_producto=t.id_tipo_producto
                                    WHERE nombre_producto LIKE '%" + texto + "%' OR id_producto LIKE '%" + texto + "%';";

            return db.ejecutarConsulta(consulta);
        }

        public Validar.estado_validacion validarProducto(Control.ControlCollection controles)
        {
    
            Validar validar = new Validar();
            return validar.validarUC(controles, priv_label_error_producto);
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
                                        JOIN tipo_producto t ON p.id_tipo_producto=t.id_tipo_producto";

            return db.ejecutarConsulta(sql);

        }

        public DataTable modificarEstadoProducto(string idProducto, int estado)
        {
            string consulta = @"UPDATE producto SET estado_producto = " + estado + " WHERE id_producto = " + idProducto;
            return db.ejecutarConsulta(consulta);
        }

        public DataTable busquedaAvanzada(Control.ControlCollection controles)
        {
            bool busqueda_tipoProducto = false, busqueda_precio = false, habilitado = false, deshabilitado = false;
            string nombre_tipoProducto = null;
            string precio_desde = "-1";
            string precio_hasta = "";
            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "ComboBoxPersonal":
                        if (item.Name == "cmb_busquedaSeleccionTipo")
                        {

                            nombre_tipoProducto = ((ComboBoxPersonal)item).SelectedIndex == -1 ? null : ((ComboBoxPersonal)item).SelectedValue.ToString();
                        }
                        break;
                    case "CheckBox":
                        if (item.Name == "cbx_tipoProducto")
                        {
                            busqueda_tipoProducto = ((CheckBox)item).Checked;
                        }
                        if (item.Name == "cbx_busquedaAvanzPrecio")
                        {
                            busqueda_precio = ((CheckBox)item).Checked;
                        }
                        break;
                    case "TextBoxPersonal":
                        if (item.Name == "txt_busquedaPrecioDesde")
                        {
                            precio_desde = item.Text;
                        }
                        if (item.Name == "txt_busquedaPrecioHasta")
                        {
                            precio_hasta = item.Text;
                        }
                        break;
                    case "RadioButton":
                        if (item.Name == "rbtn_habilitado")
                        {
                            habilitado = ((RadioButton)item).Checked;
                        }
                        if (item.Name == "rbtn_deshabilitado")
                        {
                            deshabilitado = ((RadioButton)item).Checked;
                        }
                        break;
                    default:
                        break;
                }
            }

            string consulta = @"SELECT p.id_producto, p.nombre_producto, p.cantidad_u_medida,
                                  u.nombre_u_medida, p.descripcion, u.id_u_medida, p.estado_producto, 
                                  t.nombre_tipo_producto, p.precio_unitario, t.id_tipo_producto
                                    FROM producto p
                                        JOIN unidad_medida u ON p.id_u_medida=u.id_u_medida
                                        JOIN tipo_producto t ON p.id_tipo_producto=t.id_tipo_producto
                                    WHERE 1=1";

            if (busqueda_precio)
            {
                if (precio_hasta == String.Empty)
                {
                    //(f.id_franquicia>=" + id_desde + ")"
                    consulta += " AND (p.precio_unitario>=" + precio_desde + ")";
                }
                else if(precio_desde == String.Empty)
                {
                    consulta += " AND (p.precio_unitario<=" + precio_hasta + ")";
                }
                else 
                {
                    consulta += " AND (p.precio_unitario BETWEEN " + precio_desde + " AND " + precio_hasta + ")";
                }
            }

            if(busqueda_tipoProducto)
            {
                if (!string.IsNullOrEmpty(nombre_tipoProducto))
                {
                    consulta += " AND (t.id_tipo_producto=" + nombre_tipoProducto + ")";
                }
            }

            if (habilitado)
            {
                consulta += " AND (p.estado_producto = 1)";
            }
            if (deshabilitado)
            {
                consulta += " AND (p.estado_producto = 0)";
            }
            
            return db.ejecutarConsulta(consulta);
        }
        
    }
}
