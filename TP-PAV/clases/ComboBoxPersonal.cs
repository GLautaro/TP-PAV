using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TP_PAV.clases;

namespace TP_PAV.clases
{
    public partial class ComboBoxPersonal : ComboBox
    {

        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;


        public string _nombre_tabla
        {
            get { return nombre_tabla; }
            set { nombre_tabla = value; }
        }
        public string _campo
        {
            get { return campo; }
            set { campo = value; }
        }
        public string _mensaje_error
        {
            get { return mensaje_error; }
            set { mensaje_error = value; }
        }
        public bool _validable
        {
            get { return validable; }
            set { validable = value; }
        }

        public ComboBoxPersonal()
        {
            InitializeComponent();
        }

        public ComboBoxPersonal(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //Las dos cargar hacen lo mismo. Elegir una!!! (La que deje es la mas intuitiva).

        public void cargar(string nombre_tabla, string pk, string descriptor)
        {
            AccesoBD _BD = new AccesoBD();
            this.DataSource = _BD.ejecutarConsulta("SELECT * FROM " + nombre_tabla);
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }

        /*public void cargar(DataTable tabla, string pk, string descriptor)
        {
            this.DataSource = tabla;
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }*/
    }
}
