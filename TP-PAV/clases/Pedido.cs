﻿using System;
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
                                                     CONVERT(VARCHAR(10),fecha_solicitud,103) as 'fecha_solicitud', 
                                                     id_franquicia, 
                                                     id_vendedor, 
                                                     monto_final,
                                                     id_estado
                                                     FROM pedido WHERE id_estado = 1 ORDER BY id_pedido DESC");

        }

        public DataTable recuperarPedidos()
        {

            return priv_acceso_db.ejecutarConsulta(@"SELECT 
                                                     P.id_pedido,  
                                                     P.id_franquicia, 
                                                     P.id_vendedor, 
                                                    CONVERT(VARCHAR(10),P.fecha_solicitud,103) as 'fecha_solicitud',
                                                    CONVERT(VARCHAR(10),P.fecha_entrega,103) as 'fecha_entrega',
                                                     P.monto_final,
                                                     E.nombre_estado
                                                     FROM pedido P
                                                     JOIN estado_pedido E ON E.id_estado=P.id_estado");

        }

        public DataTable buscarPedidosPorID(int id_pedido)
        {

            return priv_acceso_db.ejecutarConsulta(@"SELECT P.id_pedido, P.id_franquicia, P.id_vendedor, P.fecha_solicitud, P.monto_final
                                                    FROM pedido P
                                                    WHERE P.id_pedido =" + id_pedido);

        }

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
        public DataTable updateMontoFinalCero(int id_pedido)
        {
            return priv_acceso_db.ejecutarConsulta(String.Format(@"UPDATE pedido
                                                                SET pedido.monto_final=0
                                                                FROM pedido p                                                             
		                                                        WHERE p.id_pedido={0} ", id_pedido));

        }


        public DataTable estadoPedido()
        {
            return priv_acceso_db.ejecutarConsulta("SELECT * FROM estado_pedido");
        }

        public bool updateEstadoPedido()
        {
            if (priv_id_estado == 2)
            {
                priv_acceso_db.ejecutarNoConsulta(String.Format(@"UPDATE pedido SET id_estado={0},fecha_entrega=CONVERT(DATE,GETDATE()) WHERE id_pedido={1}", priv_id_estado, priv_id_pedido));
                return true;
            }

            priv_acceso_db.ejecutarNoConsulta(String.Format(@"UPDATE pedido SET id_estado={0} WHERE id_pedido={1}", priv_id_estado, priv_id_pedido));
            return true;
        }

        public DataTable busquedaAvanzada(Control.ControlCollection controles)
        {
            bool busqueda_franquicia = false, busqueda_vendedor = false, busqueda_monto = false, busqueda_estado = false, pendiente = false, entregado = false, cancelado = false;
            string monto_desde = "-1";
            string monto_hasta = "-1";
            string franquicia_seleccionada = null;
            string vendedor_seleccionado = null;

            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "ComboBoxPersonal":
                        if (item.Name == "cmb_franquicias")
                        {
                            franquicia_seleccionada = ((ComboBoxPersonal)item).SelectedIndex == -1 ? null : ((ComboBoxPersonal)item).SelectedValue.ToString();
                        }
                        if (item.Name == "cmb_vendedores")
                        {
                            vendedor_seleccionado = ((ComboBoxPersonal)item).SelectedIndex == -1 ? null : ((ComboBoxPersonal)item).SelectedValue.ToString();
                        }
                        break;
                    case "CheckBox":
                        if (item.Name == "cbx_franquicia")
                        {
                            busqueda_franquicia = ((CheckBox)item).Checked;
                        }
                        if (item.Name == "cbx_vendedor")
                        {
                            busqueda_vendedor = ((CheckBox)item).Checked;
                        }
                        if (item.Name == "cbx_monto")
                        {
                            busqueda_monto = ((CheckBox)item).Checked;
                        }
                        if (item.Name == "cbx_estado")
                        {
                            busqueda_estado = ((CheckBox)item).Checked;
                        }
                        break;
                    case "TextBoxPersonal":
                        if (item.Name == "txt_desde_monto")
                        {
                            monto_desde = item.Text;
                        }
                        if (item.Name == "txt_hasta_monto")
                        {
                            monto_hasta = item.Text;
                        }
                        break;
                    case "RadioButton":
                        if (item.Name == "rbtn_pendiente")
                        {
                            pendiente = ((RadioButton)item).Checked;
                        }
                        if (item.Name == "rbtn_entregado")
                        {
                            entregado = ((RadioButton)item).Checked;
                        }
                        if (item.Name == "rbtn_cancelado")
                        {
                            cancelado = ((RadioButton)item).Checked;
                        }
                        break;
                    default:
                        break;
                }
            }

            string consulta = @"SELECT P.id_pedido, P.id_franquicia, P.id_vendedor, P.fecha_solicitud, P.monto_final
                                    FROM pedido P
                                        JOIN estado_pedido EP ON P.id_estado = EP.id_estado
                                        JOIN franquicia F ON P.id_franquicia = F.id_franquicia
                                        JOIN vendedor V ON P.id_vendedor = V.legajo_vendedor
                                    WHERE 1=1";

            if (busqueda_franquicia)
            {
                consulta += " AND P.id_franquicia = " + franquicia_seleccionada;
            }
            if (busqueda_vendedor)
            {
                consulta += " AND P.id_vendedor = " + vendedor_seleccionado;
            }
            if (busqueda_monto)
            {
                if (monto_desde != "" && monto_hasta != "")
                {
                    consulta += " AND P.monto_final BETWEEN " + monto_desde + "AND " + monto_hasta;
                }
                else if (monto_desde != "")
                {
                    consulta += " AND P.monto_final >= " + monto_desde;
                }
                else if (monto_hasta != "")
                {
                    consulta += " AND P.monto_final <= " + monto_hasta;
                }
            }
            if (busqueda_estado)
            {
                if (pendiente)
                {
                    consulta += " AND P.id_estado = " + 1;
                }
                if (entregado)
                {
                    consulta += " AND P.id_estado = " + 2;
                }
                if (cancelado)
                {
                    consulta += " AND P.id_estado = " + 3;
                }
            }
            return priv_acceso_db.ejecutarConsulta(consulta);
        }



        public DataTable CantidadPedidosSolicitadosXRangoFecha(DateTime fDesde, DateTime fHasta)
        {
            string consulta = String.Format(@"SELECT DATENAME(mm, p.fecha_solicitud)+' '+DATENAME(YYYY, p.fecha_solicitud) as 'Mes y Año', COUNT(*) as 'Cantidad' 
                                FROM pedido p 
                                WHERE p.fecha_solicitud between '{0}' AND '{1}'  
                                GROUP BY DATENAME(mm, p.fecha_solicitud), DATENAME(YYYY, p.fecha_solicitud), MONTH(p.fecha_solicitud), YEAR(p.fecha_solicitud) ORDER BY YEAR(p.fecha_solicitud) ASC, MONTH(p.fecha_solicitud) ASC", fDesde, fHasta);
            return priv_acceso_db.ejecutarConsulta(consulta);
        }

        public DataTable CantidadPedidosEntregadosXRangoFecha(DateTime fDesde, DateTime fHasta)
        {
            string consulta = String.Format(@"SELECT DATENAME(mm, p.fecha_entrega)+' '+DATENAME(YYYY, p.fecha_entrega) as 'Mes y Año', COUNT(*) as 'Cantidad' 
                                FROM pedido p 
                                WHERE p.fecha_entrega between '{0}' AND '{1}' 
                                GROUP BY DATENAME(mm, p.fecha_entrega), DATENAME(YYYY, p.fecha_entrega)", fDesde, fHasta);
            return priv_acceso_db.ejecutarConsulta(consulta);
        }
    }
}
