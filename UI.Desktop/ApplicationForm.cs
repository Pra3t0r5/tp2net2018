using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace UI.Desktop
{

    public partial class ApplicationForm : Form
    {
        public enum ModoForm { Alta, Baja, Modificacion, Consulta }
        public ModoForm Modo{ get; set; }



        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
       
        public virtual bool Validar() {

            Type tipoClase = null;
            PropertyInfo[] propiedadesClase = null;

            tipoClase = this.GetType();
            propiedadesClase = tipoClase.GetProperties();
            
            foreach (PropertyInfo propiedad in propiedadesClase)
            {
                if(propiedad.GetValue(tipoClase, null) != null)
                {
                    string valorProp = propiedad.GetValue(tipoClase, null).ToString();

                    if (propiedad.Name == "txtClave" && valorProp.Length < 8)
                    {
                        this.Notificar("Atencion", "La clave no puede tener menos de 8 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else if (propiedad.Name == "txtEmail" && !valorProp.Contains("@"))
                    {
                        this.Notificar("Atencion", "Formato para Email invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    return true;
                }
                else
                {
                    this.Notificar("Atencion", "Existen campos nulos, revise el formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            this.Notificar("Error", "Algo ha salido mal, listado vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public ApplicationForm()
        {
            InitializeComponent();
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
    }
}
