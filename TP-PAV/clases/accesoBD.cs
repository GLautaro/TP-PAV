using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
namespace TP_PAV.clases
{
    class accesoBD
    {
        // La clase accesoBD es la responsable de realizar la conexion a la base de datos.
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection conn = new OleDbConnection();
        string conn_string = "";

        private void conectar()
        {   
            // El metodo <conectar> se encarga de establecer la conexion con la base de datos
            // seteando la cadena de conexion correspondiente para luego abrir la conexion
            conn.ConnectionString = conn_string;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.Connection = conn;
        }
        private void desconectar()
        {
            // El metodo <desconectar> se encarga de cerrar la conexion con la base de datos
            conn.Close();
        }

        public DataTable ejecutarConsulta(string consulta)
        {
            // El metodo <ejecutarConsulta> se encarga de ejecutar la consulta recibida como string
            // Devuelve un objeto de tipo DataTable conteniendo el resultado de la consulta
            DataTable tabla = new DataTable();
            conectar();
            cmd.CommandText = consulta;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
    }
}
