using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV.clases;
using System.Data;
namespace TP_PAV.clases
{
    class Barrio
    {
        AccesoBD priv_acceso_bd = new AccesoBD();
        
        private int priv_id_barrio = -1;
        
        private string priv_nombre_barrio = "";

        private int priv_state_barrio;
        public int pub_id_barrio
        {
            get { return this.priv_id_barrio; }
            set { this.priv_id_barrio = value; }
        }
        public string pub_nombre_barrio
        {
            get { return this.priv_nombre_barrio; }
            set { this.priv_nombre_barrio = value; }
        }
        public int pub_state_barrio
        {
            get { return this.priv_state_barrio; }
            set { this.priv_state_barrio = value; }
        }
        public DataTable recuperarBarrios()
        {
            string query = @"SELECT * FROM barrio";
            return priv_acceso_bd.ejecutarConsulta(query);
        }
        public DataTable recuperarBarriosHabilitados()
        {
            string query = @"SELECT * FROM barrio WHERE habilitado=1";
            return priv_acceso_bd.ejecutarConsulta(query);
        }

        public bool addBarrio(string nombre)
        {
            string consulta = String.Format(@"INSERT INTO barrio (nombre_barrio) VALUES ('{0}')", nombre);
            return priv_acceso_bd.ejecutarNoConsulta(consulta) == 1 ? true :   false;

        }
        public bool updateBarrio()
        {
            string consulta = String.Format(@"UPDATE barrio SET nombre_barrio='{0}' WHERE id_barrio={1}", pub_nombre_barrio, pub_id_barrio.ToString());
            return priv_acceso_bd.ejecutarNoConsulta(consulta) == 1 ? true : false;

        }
        public bool handleStateBarrio()
        {
            string noConsulta = String.Format(@"UPDATE barrio SET habilitado={0} WHERE id_barrio={1}", priv_state_barrio.ToString(), priv_id_barrio.ToString());
            if (priv_acceso_bd.ejecutarNoConsulta(noConsulta) == 1)
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
