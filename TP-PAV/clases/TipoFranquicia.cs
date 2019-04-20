using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace TP_PAV.clases
{
    class TipoFranquicia
    {
        private AccesoBD priv_acceso_db = new AccesoBD();
        private int priv_id_tipo_franquicia = -1;
        private float priv_monto_minimo_compra;
        private float priv_porcentaje_descuento;
        private string priv_nombre_tipo_franquicia;
        public int pub_id_tipo_franquicia
        {
            get { return this.priv_id_tipo_franquicia; }
            set { this.priv_id_tipo_franquicia = value; }
        }
        public float pub_monto_minimo_compra
        {
            get { return this.priv_monto_minimo_compra; }
            set { this.priv_monto_minimo_compra = value; }
        }
        public float pub_porcentaje_descuento
        {
            get { return this.priv_porcentaje_descuento; }
            set { this.priv_porcentaje_descuento = value; }
        }
        public string pub_nombre_tipo_franquicia
        {
            get { return this.priv_nombre_tipo_franquicia; }
            set { this.priv_nombre_tipo_franquicia = value; }
        }
        public DataTable recuperarTiposFranquicia()
        {
            string query = @"SELECT * FROM tipo_franquicia";
            return priv_acceso_db.ejecutarConsulta(query);
        }
    }
}
