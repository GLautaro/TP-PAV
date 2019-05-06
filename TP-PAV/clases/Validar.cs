using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV.clases;

//Si surgen nuevos componentes propios y necesitan validacion, en esta clase tenemos que agregarlas.

namespace TP_PAV.clases
{
    class Validar
    {
        public enum estado_validacion { correcto, erroneo}

        public estado_validacion validarUC (Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBoxPersonal")
                {
                    if (((TextBoxPersonal)item)._validable == true)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show(((TextBoxPersonal)item)._mensaje_error);
                            ((TextBoxPersonal)item).Focus();
                            return estado_validacion.erroneo;
                        }
                    }
                }

                if (item.GetType().Name == "ComboBoxPersonal")
                {
                    if (((ComboBoxPersonal)item)._validable == true)
                    {
                        if (((ComboBoxPersonal)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBoxPersonal)item)._mensaje_error);
                            ((ComboBoxPersonal)item).Focus();
                            return estado_validacion.erroneo;
                        }
                    }
                }

                if (item.GetType().Name == "ComboBoxHabilitado")
                {
                    if (((ComboBoxHabilitado)item)._validable == true)
                    {
                        if (((ComboBoxHabilitado)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBoxHabilitado)item)._mensaje_error);
                            ((ComboBoxHabilitado)item).Focus();
                            return estado_validacion.erroneo;
                        }
                    }
                }
                if (item.GetType().Name == "DateTimePickerPersonal")
                {
                   
                    if (((DateTimePickerPersonal)item)._validable == true)
                    {
                        
                        if (item.Text == "")
                        {
                            MessageBox.Show(((DateTimePickerPersonal)item)._mensaje_error);
                            ((DateTimePickerPersonal)item).Focus();
                            return estado_validacion.erroneo;
                        }
                    }
                }
            }
            return estado_validacion.correcto;
        }
    }
}
