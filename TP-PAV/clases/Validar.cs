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
    public class Validar
    {
        public enum estado_validacion { correcto, erroneo}

        public estado_validacion validarUC (Control.ControlCollection controles, Label lbl_error)
        {
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBoxPersonal")
                {
                    if (((TextBoxPersonal)item)._validable == true)
                    {
                        if (item.Text == "")
                        {
                                     
                          lbl_error.Text = ((TextBoxPersonal)item)._mensaje_error;
                            lbl_error.Visible = true;
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
                            lbl_error.Text = ((ComboBoxPersonal)item)._mensaje_error;
                            lbl_error.Visible = true;
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
                            lbl_error.Text = ((ComboBoxHabilitado)item)._mensaje_error;
                            lbl_error.Visible = true;
                            ((ComboBoxHabilitado)item).Focus();
                            return estado_validacion.erroneo;
                        }
                    }
                }
                if (item.GetType().Name == "DateTimePickerPersonal")
                {
                   
                    if (((DateTimePickerPersonal)item)._validable == true)
                    {
                        //AGUS!!! Tenes que crear un label en tu UC y pasarlo a esta funcion!! Porque los mensajes de error ahora
                        //van con un label.
                      
                        if (item.Text == "")
                        {
                            lbl_error.Text = ((DateTimePickerPersonal)item)._mensaje_error;
                            lbl_error.Visible = true;
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
