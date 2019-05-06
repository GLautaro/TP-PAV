using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV.clases
{
    public partial class DateTimePickerPersonal : DateTimePicker
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


        public DateTimePickerPersonal()
        {
            InitializeComponent();
        }

        public DateTimePickerPersonal(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
