using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace TP_PAV.clases
{
    class Franquicia
    {
        AccesoBD priv_acceso_db = new AccesoBD();
        private int priv_id_franquicia;
        private string priv_nombre_responsable;
        private string priv_apellido_responsable;
        private string priv_calle;
        private int priv_nro_calle;
        private int priv_id_barrio;
        private int priv_legajo_vendedor;
        private int priv_id_tipo_franquicia;
        private bool priv_estado_franquicia = true;

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
        public bool pub_estado_franquicia { get; set; }

        public Franquicia(int id_franquicia, string nombre_responsable, string apellido_responsable, string calle, int nro_calle, int id_barrio, int legajo_vendedor, int id_tipo_franquicia)
        {
            priv_id_franquicia = id_franquicia;
            priv_nombre_responsable = nombre_responsable;
            priv_apellido_responsable = apellido_responsable;
            priv_calle = calle;
            priv_nro_calle = nro_calle;
            priv_id_barrio = id_barrio;
            priv_legajo_vendedor = legajo_vendedor;
            priv_id_tipo_franquicia = id_tipo_franquicia;
            
        }
        public Franquicia()
        {
            
        }

        public Franquicia(int id_franquicia, bool estado)
        {
            priv_id_franquicia = id_franquicia;
            priv_estado_franquicia = estado;
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
            string nonQuery = String.Format(@"UPDATE franquicia SET nombre_responsable='{0}',apellido_responsable='{1}',calle='{2}',nro_calle={3},id_barrio={4},id_tipo_franquicia={5},legajo_vendedor={6} WHERE id_franquicia={7}",
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

        public bool modificarEstadoFranquicia()
        {
            string noQuery = @"UPDATE franquicia SET habilitado='" + !priv_estado_franquicia + "' WHERE id_franquicia=" + priv_id_franquicia.ToString();
            if (priv_acceso_db.ejecutarNoConsulta(noQuery) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool modificarEstadoFranquicia(int estado)
        {
            string noQuery = @"UPDATE franquicia SET estado=" + estado.ToString() + "WHERE id_franquicia=" + priv_id_franquicia;
            if (priv_acceso_db.ejecutarNoConsulta(noQuery) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public DataTable recuperarFranquicias()
        {
            string query = @"SELECT f.id_franquicia,
	                                f.nombre_responsable,
	                                f.apellido_responsable,
	                                f.calle,
	                                f.nro_calle,
	                                b.nombre_barrio,
	                                v.legajo_vendedor,
	                                t_f.nombre_tipo_franquicia,
                                    b.id_barrio,
                                    v.nombre_vendedor,
                                    v.apellido_vendedor,
                                    t_f.id_tipo_franquicia,
                                    f.habilitado,
                                    t_f.monto_minimo_compra
	                                        FROM franquicia f
	                                                JOIN vendedor v ON v.legajo_vendedor=f.legajo_vendedor
	                                                JOIN barrio b ON b.id_barrio=f.id_barrio
	                                                JOIN tipo_franquicia t_f ON t_f.id_tipo_franquicia=f.id_tipo_franquicia
                                    WHERE f.habilitado=1";
            return priv_acceso_db.ejecutarConsulta(query);
        }
        
        public DataTable buscarFranquicias(string text)
        {
            string query = String.Format(@"SELECT f.id_franquicia,
                                                  f.nombre_responsable,
                                                  f.apellido_responsable,
                                                  f.calle,
                                                  f.nro_calle,
                                                  b.nombre_barrio,
                                                  v.legajo_vendedor,
                                                  t_f.nombre_tipo_franquicia,
                                                  b.id_barrio,
                                                  t_f.id_tipo_franquicia 
                                                        FROM franquicia f
                                                                        JOIN vendedor v ON v.legajo_vendedor=f.legajo_vendedor 
                                                                        JOIN barrio b ON b.id_barrio=f.id_barrio 
                                                                        JOIN tipo_franquicia t_f ON t_f.id_tipo_franquicia=f.id_tipo_franquicia 
                                                        WHERE f.habilitado=1 AND (f.nombre_responsable LIKE '%{0}%' 
                                                           OR f.apellido_responsable LIKE '%{1}%' 
                                                           OR f.calle LIKE '%{2}%' 
                                                           OR b.nombre_barrio LIKE '%{4}%' 
                                                           OR t_f.nombre_tipo_franquicia LIKE '%{6}%');", text, text, text, text, text, text, text);

            return priv_acceso_db.ejecutarConsulta(query);
        }
        public DataTable busquedaAvanzada(Control.ControlCollection controles)
        {
            bool busqueda_id=false, busqueda_nombre_apellido=false, busqueda_legajo_vendedor=false,
                habilitado=false,deshabilitado = false;
            string id_desde = "-1";
            string id_hasta = "";
            string nombre = "", apellido = "";
            string legajo_desde = "-1";
            string legajo_hasta = "";
            string nombre_tipo_franquicia = null;
            string nombre_barrio = null;
            foreach (Control item in controles)
            {
                switch (item.GetType().Name)
                {
                    case "ComboBoxPersonal":
                        if (item.Name == "cmb_busquedaAvan_tipoFranquicia")
                        {
                            nombre_tipo_franquicia = ((ComboBoxPersonal)item).SelectedIndex == -1 ? null : ((ComboBoxPersonal)item).SelectedValue.ToString();

                        }
                        if (item.Name == "cmb_busquedaAvan_barrio")
                        {
                            nombre_barrio = ((ComboBoxPersonal)item).SelectedIndex == -1 ? null : ((ComboBoxPersonal)item).SelectedValue.ToString();
                        }
                        break;
                    case "CheckBox":
                        if (item.Name == "chb_id")
                        {
                            busqueda_id = ((CheckBox)item).Checked;
                        }
                        if(item.Name == "chb_NomyApe")
                        {
                            busqueda_nombre_apellido = ((CheckBox)item).Checked;
                        }
                        if (item.Name == "chb_legajoVendedor")
                        {
                            busqueda_legajo_vendedor = ((CheckBox)item).Checked;
                        }
                        break;
                    case "TextBoxPersonal":
                        if (item.Name == "txt_busquedaAvan_idDesde")
                        {
                            id_desde = item.Text;
                        }
                        if (item.Name == "txt_busquedaAvan_idHasta")
                        {
                            id_hasta = item.Text;    
                        }
                        if (item.Name == "txt_busquedaAvan_nombre")
                        {
                            nombre = item.Text;
                        }
                        if (item.Name == "txt_busquedaAvan_apellido")
                        {
                            apellido = item.Text;
                        }
                        if (item.Name == "txt_busquedaAvan_legajoDesde")
                        {
                            legajo_desde = item.Text;
                        }
                        if (item.Name == "txt_busquedaAvan_legajoHasta")
                        {
                            legajo_hasta = item.Text;
                        }
                        break;
                    case "RadioButton":
                        if (item.Name == "radio_busqAvan_habilitados")
                        {
                            habilitado = ((RadioButton)item).Checked;
                        }
                        if (item.Name == "radio_busqAvan_deshabilitados")
                        {
                            deshabilitado = ((RadioButton)item).Checked;
                        }
                        break;
                    default:
                        break;
                }
            }
            string consulta = @"SELECT f.id_franquicia,
                                                  f.nombre_responsable,
                                                  f.apellido_responsable,
                                                  f.calle,
                                                  f.nro_calle,
                                                  b.nombre_barrio,
                                                  v.legajo_vendedor,
                                                  v.nombre_vendedor,
                                                  v.apellido_vendedor,
                                                  t_f.nombre_tipo_franquicia,
                                                  b.id_barrio,
                                                  t_f.id_tipo_franquicia,
                                                  f.habilitado 
                                                        FROM franquicia f
                                                                        JOIN vendedor v ON v.legajo_vendedor=f.legajo_vendedor 
                                                                        JOIN barrio b ON b.id_barrio=f.id_barrio 
                                                                        JOIN tipo_franquicia t_f ON t_f.id_tipo_franquicia=f.id_tipo_franquicia WHERE 1=1";

            if (busqueda_id)
            {
                if (id_hasta == String.Empty)
                {
                    consulta += " AND (f.id_franquicia>=" + id_desde + ")";
                }
                else if (id_desde == String.Empty)
                {
                    consulta += " AND (f.id_franquicia<=" + id_hasta + ")";
                }
                else
                {
                    consulta += " AND (f.id_franquicia BETWEEN " + id_desde + " AND " + id_hasta + ")";
                }           
                
            }
            if (busqueda_nombre_apellido)
            {
                if (apellido == "")
                {
                    consulta += " AND f.nombre_responsable LIKE '%" + nombre + "%'";
                }
                else if (nombre == "")
                {
                    consulta += " AND f.apellido_responsable LIKE '%" + apellido + "%'";
                }
                else
                {
                    consulta += " AND (f.apellido_responsable LIKE '%" + apellido + "%' AND f.nombre_responsable LIKE '%" + nombre + "%')";
                }
                
            }
            if (busqueda_legajo_vendedor)
            {
                if (legajo_hasta == String.Empty)
                {
                    consulta += " AND (f.legajo_vendedor>=" + legajo_desde + ")";
                }
                else if (legajo_desde == String.Empty)
                {
                    consulta += " AND (f.legajo_vendedor<=" + legajo_hasta + ")";
                }
                else
                {
                    consulta += " AND (f.legajo_vendedor BETWEEN " + legajo_desde + " AND " + legajo_hasta + ")";
                }
            }
            if (!string.IsNullOrEmpty(nombre_tipo_franquicia)) 
            {
                consulta += " AND (t_f.id_tipo_franquicia=" + nombre_tipo_franquicia + ")";
            }
            if (!string.IsNullOrEmpty(nombre_barrio))
            {
                consulta += " AND (b.id_barrio=" + nombre_barrio + ")";
            }

            if (habilitado)
            {
                consulta += " AND (f.habilitado=1)";
            }
            else if (deshabilitado)
            {
                consulta += " AND (f.habilitado=0)";
            }
            
            return priv_acceso_db.ejecutarConsulta(consulta);
        }

        public DataTable MejoresFranquicias(DateTime fechaDesde, DateTime fechaHasta)
        {
            string query = String.Format(@"SELECT TOP 5 F.nombre_responsable+' '+F.apellido_responsable as 'Nombre Responsable', SUM(p.monto_final) as suma 
                                FROM franquicia F 
                                JOIN pedido P ON F.id_franquicia = P.id_franquicia
                                WHERE P.id_estado = 1 AND P.fecha_entrega BETWEEN '{0}' AND '{1}'
                                GROUP BY P.id_franquicia, F.nombre_responsable, F.apellido_responsable
                                ORDER BY SUM(p.monto_final) DESC", fechaDesde.Date.ToString("dd/MM/yyyy"), fechaHasta.Date.ToString("dd/MM/yyyy"));
            return priv_acceso_db.ejecutarConsulta(query);
        }

        public DataTable PeoresFranquicias(DateTime fechaDesde, DateTime fechaHasta)
        {
            string query = String.Format(@"SELECT TOP 5 F.nombre_responsable+' '+F.apellido_responsable as 'Nombre Responsable', SUM(p.monto_final) as suma 
                                FROM franquicia F 
                                JOIN pedido P ON F.id_franquicia = P.id_franquicia
                                WHERE P.id_estado = 1 AND P.fecha_entrega BETWEEN '{0}' AND '{1}'
                                GROUP BY P.id_franquicia, F.nombre_responsable, F.apellido_responsable
                                ORDER BY SUM(p.monto_final) ASC", fechaDesde.Date.ToString("dd/MM/yyyy"), fechaHasta.Date.ToString("dd/MM/yyyy"));
            return priv_acceso_db.ejecutarConsulta(query);
        }
    }
}
