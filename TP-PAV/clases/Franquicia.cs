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
        private string priv_nombre_responsable = "";
        private string priv_apellido_responsable = "";
        private string priv_calle = "";
        private int priv_nro_calle = -1;
        private int priv_id_barrio = -1;
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

        public Franquicia(){}
        public Franquicia(int id_franquicia, string nombre_responsable, string apellido_responsable, string calle, int nro_calle, int id_barrio, int legajo_vendedor, int id_tipo_franquicia)
        {
            int priv_id_franquicia = id_franquicia;
            string priv_nombre_responsable = nombre_responsable;
            string priv_apellido_responsable = apellido_responsable;
            string priv_calle = calle;
            int priv_nro_calle = nro_calle;
            int priv_id_barrio = id_barrio;
            int priv_legajo_vendedor = legajo_vendedor;
            int priv_id_tipo_franquicia = id_tipo_franquicia;
            
        }
        
        
        
        public bool altaFranquicia(string nombre_responsable,string apellido_responsable,string calle,
                                                int nro_calle, int id_barrio, 
                                                int id_tipo_franquicia, int legajo_vendedor)
        {
            string noConsulta = String.Format(@"INSERT INTO franquicia (nombre_responsable, apellido_responsable, calle, nro_calle, 
                                                                            id_barrio, id_tipo_franquicia, legajo_vendedor) 
                                                VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}) ", 
                                                nombre_responsable,apellido_responsable,calle,
                                                nro_calle, id_barrio, 
                                                id_tipo_franquicia, legajo_vendedor);

            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        
        public bool modificarFranquicia()
        {
            string nonQuery = String.Format(@"UPDATE franquicia 
                                    SET nombre_responsable='{0}',
	                                    apellido_responsable='{1}',
	                                    calle='{2}',
	                                    nro_calle={3},
	                                    id_barrio={4},
                                    	id_tipo_franquicia={5},
	                                    legajo_vendedor={6} 
		                                        WHERE id_franquicia = {7}",
                                        priv_nombre_responsable,
                                        priv_apellido_responsable,
                                        priv_calle,
                                        priv_nro_calle.ToString(),
                                        priv_id_barrio.ToString(),
                                        priv_id_tipo_franquicia.ToString(),
                                        priv_legajo_vendedor.ToString(),
                                        priv_id_franquicia.ToString()
                                        );
            if (priv_acceso_db.ejecutarNoConsulta(nonQuery) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarFranquicia()
        {
            string noQuery = @"DELETE FROM franquicia WHERE id_franquicia=" + priv_id_franquicia;
            if (priv_acceso_db.ejecutarNoConsulta(noQuery) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public DataTable recuperarFranquicias()
        {
            string query = @"SELECT franquicia.id_franquicia,
	                                franquicia.nombre_responsable,
	                                franquicia.apellido_responsable,
	                                franquicia.calle,
	                                franquicia.nro_calle,
	                                barrio.nombre_barrio,
	                                vendedor.legajo_vendedor,
	                                tipo_franquicia.nombre_tipo_franquicia,
                                    barrio.id_barrio,
                                    tipo_franquicia.id_tipo_franquicia 
	                                        FROM franquicia
	                                                JOIN vendedor ON vendedor.legajo_vendedor=franquicia.legajo_vendedor
	                                                JOIN barrio ON barrio.id_barrio=franquicia.id_barrio
	                                                JOIN tipo_franquicia ON tipo_franquicia.id_tipo_franquicia=franquicia.id_tipo_franquicia";
            return priv_acceso_db.ejecutarConsulta(query);
        }
        
        public DataTable buscarFranquicias(string text)
        {
            string query = String.Format(@"SELECT franquicia.id_franquicia,
                                                  franquicia.nombre_responsable,
                                                  franquicia.apellido_responsable,
                                                  franquicia.calle,
                                                  franquicia.nro_calle,
                                                  barrio.nombre_barrio,
                                                  vendedor.legajo_vendedor,
                                                  tipo_franquicia.nombre_tipo_franquicia,
                                                  barrio.id_barrio,
                                                  tipo_franquicia.id_tipo_franquicia 
                                                        FROM franquicia JOIN vendedor ON vendedor.legajo_vendedor=franquicia.legajo_vendedor 
                                                                        JOIN barrio ON barrio.id_barrio=franquicia.id_barrio 
                                                                        JOIN tipo_franquicia ON tipo_franquicia.id_tipo_franquicia=franquicia.id_tipo_franquicia 
                                                        WHERE franquicia.nombre_responsable LIKE '%{0}%' 
                                                           OR franquicia.apellido_responsable LIKE '%{1}%' 
                                                           OR franquicia.calle LIKE '%{2}%' 
                                                           OR barrio.nombre_barrio LIKE '%{4}%' 
                                                           OR tipo_franquicia.nombre_tipo_franquicia LIKE '%{6}%' 
                                                           OR barrio.nombre_barrio LIKE '%{7}%' 
                                                           OR tipo_franquicia.nombre_tipo_franquicia LIKE '%{8}%';", text, text, text, text, text, text, text, text, text);

            return priv_acceso_db.ejecutarConsulta(query);
        }
    }
}
