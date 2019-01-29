using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Util
{
    public class MetodosParaControls
    {
        public bool validarControlesVacios(Control.ControlCollection ccl)
        {
            foreach (Control control in ccl)
            {
                switch (control.GetType().Name)
                {
                    case "Label":
                        continue;


                    case "TextBox":
                        if (control.Enabled == false) continue;
                        if (((TextBox)control).ReadOnly == true) continue;
                        if (control.Text == string.Empty) { this.Avisar(); return false; }
                        else
                        {
                            switch (((TextBox)control).Name)
                            {
                                case "txtClave":
                                    if (((TextBox)control).TextLength >= 8)
                                    {
                                        Control[] controlEnc = ccl.Find("txtConfirmarClave",false);
                                        string confirmaClave = controlEnc[0].Text;
                                        string clave = ((TextBox)control).Text;
                                        if (clave == confirmaClave)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            this.AvisarClavesNoCoincidentes();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        this.AvisarClave();
                                        return false;
                                    }
                                    

                                case "txtEmail":
                                    string email = ((TextBox)control).Text;
                                    if (validarMail(email))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        this.AvisarEmail();
                                        return false;
                                    }
                                    
                            }
                        }
                        
                        continue;
                        

                    case "ComboBox":
                        if (((ComboBox)control).Items.Count == 0) { this.Avisar(); return false; }
                        else continue;

                    case "NumericUpDown":
                        if (((NumericUpDown)control).Value == 0) { this.AvisarNumericUpDownCero(); return false; }
                        else continue;

                    default:
                        continue;
                }
            }
            return true;
        }

        private static bool validarMail(string email)
        {

            return email != null && Regex.IsMatch(email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$");

        }

        private void AvisarClavesNoCoincidentes()
        {
            MessageBox.Show("Las claves no coinciden", "Error, clave erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AvisarEmail()
        {
            MessageBox.Show("El email ingresado es incorrecto", "Error, formato de email incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Avisar()
        {
            MessageBox.Show("Asegurese de todos los campos esten completados", "Error, campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AvisarClave()
        {
            MessageBox.Show("La clave debe poseer al menos 8 caracteres de longitud", "Error, clave demasiado corta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AvisarNumericUpDownCero()
        {
            MessageBox.Show("Asegurese de que los campos numericos no esten en su valor por defecto (Cero)", "Error, campos inalterados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
