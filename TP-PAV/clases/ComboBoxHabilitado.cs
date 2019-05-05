using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.clases;

/*
 * Estas comboBox sirven para aquellos cmb que no toman datos de una tabla, en nuestro caso valores tipo "bit"
 * 0 y 1 que representan booleanos. De estos cmb se deben tomar el indice seleccionado como dato para ingresar a la BD
*/
namespace TP_PAV.clases
{
    public partial class ComboBoxHabilitado : ComboBox
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

        public ComboBoxHabilitado()
        {
            InitializeComponent();
        }

        public ComboBoxHabilitado(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        
    }
}
