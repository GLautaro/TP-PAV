using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV.clases
{
    class Pedido
    {
        
        AccesoBD priv_acceso_db = new AccesoBD();
        private int priv_id_pedido;
        private DateTime priv_fecha_solicitud;
        private DateTime priv_fecha_entrega;
        private int priv_id_estado;
        private int priv_id_franquicia;
        private int priv_id_vendedor;
        private int priv_monto_final;

        public int pub_id_pedido
        {
            get { return this.priv_id_pedido; }
            set {this.priv_id_pedido = value;}
        }
        public DateTime pub_fecha_solicitud
        {
            get { return this.pub_fecha_solicitud; }
            set { this.pub_fecha_solicitud = value; }
        }
        public DateTime pub_fecha_entrega
        {
            get { return this.pub_fecha_entrega; }
            set { this.pub_fecha_entrega = value; }
        }
        public int pub_id_estado
        {
            get { return this.pub_id_estado; }
            set { this.pub_id_estado = value; }
        }
        public int pub_id_franquicia
        {
            get { return this.pub_id_franquicia; }
            set { this.pub_id_franquicia = value; }
        }
        public int pub_id_vendedor
        {
            get { return this.pub_id_vendedor; }
            set { this.pub_id_vendedor = value; }
        }
        public int pub_monto_final
        {
            get { return this.pub_monto_final; }
            set { this.pub_monto_final = value; }
        }


        public Validar.estado_validacion validarPedido(Control.ControlCollection controles)
        {
            Validar validar = new Validar();
            return validar.validarUC(controles);

        }

        public DataTable recuperarPedidosPendientes()
        {
            return priv_acceso_db.ejecutarConsulta("SELECT id_pedido, fecha_solicitud, id_franquicia, id_vendedor, monto_final FROM pedido WHERE id_estado ="+1 );

        }
        public DataTable recuperarDetalleDePedido(int idPedido)
        {
            return priv_acceso_db.ejecutarConsulta("SELECT pxp.id_producto, pxp.cantidad, (pxp.precio_unitario*pxp.cantidad) AS montoTotal, producto.nombre_producto   FROM pedido_x_producto pxp JOIN producto ON producto.id_producto = pxp.id_producto  WHERE pxp.id_pedido=" + idPedido);

        }
        public bool addPedido(Control.ControlCollection controles)
        {

            priv_acceso_db.insert_automatizado(controles, "pedido");
            return true;

        }
       





    }
}
