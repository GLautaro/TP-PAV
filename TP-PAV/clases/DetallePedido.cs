using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_PAV.clases
{
    public class DetallePedido
    {
        private int priv_id_pedido;
        private Pedido priv_pedido;
        public Pedido pub_pedido
        {
            get { return priv_pedido; }
            set { priv_pedido = value; }
        }

        public DataTable recuperarDetalleDePedido()
        {
            
            return pub_pedido.pub_acceso_db_transaccion.ejecutarConsulta(@"SELECT 
                                                        pxp.id_producto, 
                                                        pxp.cantidad, 
                                                        (pxp.precio_unitario*pxp.cantidad) AS montoTotal, 
                                                        producto.nombre_producto   
                                                        FROM pedido_x_producto pxp 
                                                        JOIN producto ON producto.id_producto = pxp.id_producto  
                                                        WHERE pxp.id_pedido=" + priv_pedido.pub_id_pedido);

        }
        public DataTable recuperarProductoXTipoProducto(int id_tipo_producto, int id_pedido)
        {
            return pub_pedido.pub_acceso_db_transaccion.ejecutarConsulta(String.Format(@"SELECT 
		                                                            id_producto, 
		                                                            nombre_producto, 
		                                                            precio_unitario 
		                                                            FROM producto p 
		                                                            JOIN tipo_producto t ON t.id_tipo_producto = p.id_tipo_producto
		                                                            WHERE id_producto NOT IN (SELECT id_producto FROM pedido_x_producto WHERE id_pedido={0} ) AND t.id_tipo_producto = {1} AND p.estado_producto=1", id_pedido, id_tipo_producto));

        }
        public bool addProductoPedido(int id_pedido, int id_producto, int cantidad, int precio_unitario)
        {
            pub_pedido.pub_acceso_db_transaccion.ejecutarNoConsulta(String.Format(@"INSERT INTO pedido_x_producto (id_pedido,id_producto, cantidad, precio_unitario) VALUES ({0},{1}, {2}, {3})", id_pedido, id_producto, cantidad, precio_unitario));
            return true;

        }


        public bool deleteProductoPedido(int id_pedido, int id_producto)
        {
           pub_pedido.pub_acceso_db_transaccion.ejecutarNoConsulta(String.Format(@"DELETE FROM pedido_x_producto WHERE id_producto={0} AND id_pedido={1}", id_producto, id_pedido));
            return true;
        }

     
    }
}
