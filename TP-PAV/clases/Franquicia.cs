using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace TP_PAV.clases
{
    class Franquicia
    {
        
        AccesoBD priv_acceso_db = new AccesoBD();
        private int priv_id_franquicia = -1;
        private string priv_nombre_responsable;
        private string priv_apellido_responsable;
        private string priv_calle;
        private int priv_nro_calle;
        private int priv_id_barrio;
        private float priv_monto_minimo_compra = -1;
        private int priv_legajo_vendedor = -1;
        private int priv_id_tipo_franquicia = -1;
        public int pub_id_franquicia
        {
            get { return this.priv_id_franquicia; }
            set { this.priv_id_franquicia = value; }
        }
        public string pub_nombre_responsable
        {
            get { return this.priv_nombre_responsable; }
            set { this.priv_nombre_responsable = value; }
        }
        public string pub_apellido_responsable
        {
            get { return this.priv_apellido_responsable; }
            set { this.priv_apellido_responsable = value; }

        }
        public string pub_calle
        {
            get { return this.priv_calle; }
            set { this.priv_calle = value; }
        }
        public int pub_nro_calle
        {
            get { return this.priv_nro_calle; }
            set { this.priv_nro_calle = value; }
        }
        public int pub_id_barrio
        {
            get { return this.priv_id_barrio; }
            set { this.priv_id_barrio = value; }
        }
        public float pub_monto_minimo_compra
        {
            get { return this.priv_monto_minimo_compra; }
            set { this.priv_monto_minimo_compra = value; }
        }
        public int pub_legajo_vendedor
        {
            get { return this.priv_legajo_vendedor; }
            set { this.priv_legajo_vendedor = value; }
        }
        public int pub_id_tipo_franquicia
        {
            get { return this.priv_id_tipo_franquicia; }
            set { this.priv_id_tipo_franquicia = value; }
        }

        public bool altaFranquicia()
        {
            string noConsulta = String.Format(@"INSERT INTO franquicia (nombre_responsable, apellido_responsable, calle, nro_calle, 
                                                                            id_barrio, monto_minimo_compra, id_tipo_franquicia, legajo_vendedor) 
                                                VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, {7}) ", 
                                                pub_nombre_responsable,pub_apellido_responsable,pub_calle,
                                                pub_nro_calle, pub_id_barrio, pub_monto_minimo_compra, 
                                                pub_id_tipo_franquicia, pub_legajo_vendedor);                            
            
            
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
