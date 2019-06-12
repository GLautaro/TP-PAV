using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace TP_PAV.clases
{
    class UnidadMedida
    {
        private AccesoBD priv_acceso_db = new AccesoBD();

        public DataTable traerUnidadMedida()
        {
            string query = @"SELECT * FROM unidad_medida";
            return priv_acceso_db.ejecutarConsulta(query);
        }

        public bool altaUnidadMedida(string nombre)
        {
            string noConsulta = String.Format(@"INSERT INTO unidad_medida (nombre_u_medida) VALUES ('{0}') ", nombre);
            if (priv_acceso_db.ejecutarNoConsulta(noConsulta) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool modificarUnidadMedida(int id_unidad_medida, string nombre)
        {
            string noConsulta = String.Format(@"UPDATE unidad_medida 
                                                SET nombre_u_medida = '{0}'
                                                WHERE id_u_medida = {1}", nombre, id_unidad_medida
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

        public bool handleStateUnidadMedida(int id_unidad_medida, int estado)
        {
            string noConsulta = String.Format(@"UPDATE unidad_medida SET habilitado={0} WHERE id_u_medida={1}", estado.ToString(), id_unidad_medida.ToString());
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
