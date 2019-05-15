using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace TP_PAV.clases
{
    class TipoFranquicia
    {
        private AccesoBD priv_acceso_db = new AccesoBD();
        private int priv_id_tipo_franquicia = -1;
        private float priv_monto_minimo_compra;
        private float priv_porcentaje_descuento;
        private string priv_nombre_tipo_franquicia;
        private int priv_state_tipo_franquicia;
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
        public int pub_state_tipo_franquicia
        {
            get { return this.priv_state_tipo_franquicia; }
            set { this.priv_state_tipo_franquicia = value;}   
        }
       

        public DataTable recuperarTiposFranquicia()
        {
            string query = @"SELECT * FROM tipo_franquicia";
            return priv_acceso_db.ejecutarConsulta(query);
        }
        public DataTable recuperarTiposFranquiciaHabilitados()
        {
            string query = @"SELECT * FROM tipo_franquicia WHERE habilitado=1";
            return priv_acceso_db.ejecutarConsulta(query);
        }
     
        public bool altaTipoFranquicia(int montoMinimo, int porcentajeDescuento, string nombre)
        {
            string noConsulta = String.Format(@"INSERT INTO tipo_franquicia (monto_minimo_compra, porcentaje_descuento, nombre_tipo_franquicia) 
                                                VALUES ({0}, {1}, '{2}') ",
                                                montoMinimo, porcentajeDescuento, nombre);
            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }else{
                return false;
            }

        }
        public bool modificarTipoFranquicia()
        {
            string noConsulta = String.Format(@"UPDATE tipo_franquicia 
                                    SET monto_minimo_compra={0},
	                                    porcentaje_descuento={1},
	                                    nombre_tipo_franquicia = '{2}'                           
		                                        WHERE id_tipo_franquicia = {3}",
                                        pub_monto_minimo_compra.ToString(),pub_porcentaje_descuento.ToString(),pub_nombre_tipo_franquicia,pub_id_tipo_franquicia.ToString()
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

        public bool handleStateTipoFranquicia()
        {
            string noConsulta = String.Format(@"UPDATE tipo_franquicia SET habilitado={0} WHERE id_tipo_franquicia={1}", priv_state_tipo_franquicia.ToString(), priv_id_tipo_franquicia.ToString());
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
