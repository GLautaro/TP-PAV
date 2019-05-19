using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.formularios;

namespace TP_PAV.clases
{
    public class Pedido
    {
        private int priv_id_pedido;
        private DateTime priv_fecha_solicitud;
        private DateTime priv_fecha_entrega;
        private int priv_id_estado;
        private int priv_id_franquicia;
        private int priv_id_vendedor;
        private int priv_monto_final;
        private Label priv_pedido_label_error;
        AccesoBD priv_acceso_db = new AccesoBD();

        public int pub_id_pedido
        {
            get { return priv_id_pedido; }
            set {priv_id_pedido = value;}
        }
        public DateTime pub_fecha_solicitud
        {
            get { return priv_fecha_solicitud; }
            set { priv_fecha_solicitud = value; }
        }
        public DateTime pub_fecha_entrega
        {
            get { return priv_fecha_entrega; }
            set { priv_fecha_entrega = value; }
        }
        public int pub_id_estado
        {
            get { return priv_id_estado; }
            set { priv_id_estado = value; }
        }
        public int pub_id_franquicia
        {
            get { return priv_id_franquicia; }
            set { priv_id_franquicia = value; }
        }
        public int pub_id_vendedor
        {
            get { return priv_id_vendedor; }
            set { priv_id_vendedor = value; }
        }
        public int pub_monto_final
        {
            get { return priv_monto_final; }
            set { priv_monto_final = value; }
        }
        public Label pub_Pedido_label_error
        {
            get { return this.priv_pedido_label_error; }
            set { this.priv_pedido_label_error = value; }
        }
        public AccesoBD pub_acceso_db_transaccion
        {
            get { return priv_acceso_db; }
            set { priv_acceso_db = value; }
        }
        public void iniciar_transaccion_pedido()
        {
            priv_acceso_db.iniciar_transaccion();
        }
        public void cerrar_transaccion_pedido(bool rollback)
        {
            priv_acceso_db.cerrar_transaccion(rollback);
        }
        public Validar.estado_validacion validarPedido(Control.ControlCollection controles)
        {
            Validar validar = new Validar();
          
            return validar.validarUC(controles, priv_pedido_label_error);

        }

        public DataTable recuperarPedidosPendientes()
        {
            
            return priv_acceso_db.ejecutarConsulta(@"SELECT 
                                                     id_pedido, 
                                                     fecha_solicitud, 
                                                     id_franquicia, 
                                                     id_vendedor, 
                                                     monto_final 
                                                     FROM pedido WHERE id_estado = 1" );

        }
  
   /*     public DataTable recuperarDetalleDePedido(int idPedido)
        {
            return priv_acceso_db.ejecutarConsulta(@"SELECT 
                                                        pxp.id_producto, 
                                                        pxp.cantidad, 
                                                        (pxp.precio_unitario*pxp.cantidad) AS montoTotal, 
                                                        producto.nombre_producto   
                                                        FROM pedido_x_producto pxp 
                                                        JOIN producto ON producto.id_producto = pxp.id_producto  
                                                        WHERE pxp.id_pedido=" + idPedido);

        }
          */
        public DataTable addPedido(string fecha_solicitud, int id_estado, int id_franquicia, int id_vendedor)
        {

            return priv_acceso_db.ejecutarConsulta(String.Format(@"INSERT INTO pedido (fecha_solicitud, id_estado, id_franquicia, id_vendedor) VALUES ('{0}',{1}, {2}, {3}) SELECT @@IDENTITY as id_ultimo_pedido", fecha_solicitud, id_estado, id_franquicia, id_vendedor));

        }

        public DataTable updateMontoFinalPedido(int id_pedido)
        {
            return priv_acceso_db.ejecutarConsulta(String.Format(@"UPDATE pedido
                                                                SET pedido.monto_final=pxp.montoFinal
                                                                FROM pedido p 
                                                                JOIN (SELECT id_pedido, SUM(cantidad*precio_unitario) as montoFinal 
		                                                        FROM pedido_x_producto 
		                                                        GROUP BY id_pedido) pxp 
		                                                        ON pxp.id_pedido=p.id_pedido 
		                                                        WHERE p.id_pedido={0} SELECT monto_final FROM pedido WHERE id_pedido = {0}", id_pedido));

        }
     /*   public DataTable recuperarProductoXTipoProducto(int id_tipo_producto, int id_pedido)
        {
            return priv_acceso_db.ejecutarConsulta(String.Format(@"SELECT 
		                                                            id_producto, 
		                                                            nombre_producto, 
		                                                            precio_unitario 
		                                                            FROM producto p 
		                                                            JOIN tipo_producto t ON t.id_tipo_producto = p.id_tipo_producto
		                                                            WHERE id_producto NOT IN (SELECT id_producto FROM pedido_x_producto WHERE id_pedido={0} ) AND t.id_tipo_producto = {1}", id_pedido, id_tipo_producto));

        } */

    /*    public bool addProductoPedido(int id_pedido, int id_producto, int cantidad, int precio_unitario)
        {
            priv_acceso_db.ejecutarNoConsulta(String.Format(@"INSERT INTO pedido_x_producto (id_pedido,id_producto, cantidad, precio_unitario) VALUES ({0},{1}, {2}, {3})", id_pedido, id_producto, cantidad, precio_unitario));
            return true;

        }   */
       





    }
}
