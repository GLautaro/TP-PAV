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
        public DataTable recuperarBarrios()
        {
            string query = @"SELECT * FROM barrio";
            return priv_acceso_bd.ejecutarConsulta(query);
        }
    }
}
