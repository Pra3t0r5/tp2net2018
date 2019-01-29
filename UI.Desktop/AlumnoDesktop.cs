using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace UI.Desktop
{
    public partial class AlumnoDesktop : ApplicationForm
    {
        Persona AlumnoActual { get; set; }
        private MetodosParaControls metodoParaControles { get; set; }
        

        public AlumnoDesktop()
        {
            InitializeComponent();
            this.metodoParaControles = new MetodosParaControls();
        }

        public AlumnoDesktop(ModoForm modo): this()
        {
            Modo = modo;
        }

        public AlumnoDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            AlumnoLogic al = new AlumnoLogic();
            this.AlumnoActual = al.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.AlumnoActual.ID.ToString();
            this.txtNombre.Text = this.AlumnoActual.Nombre;
            this.txtApellido.Text = this.AlumnoActual.Apellido;
            this.txtTelefono.Text = this.AlumnoActual.Telefono;
            this.txtLegajo.Text = this.AlumnoActual.Legajo.ToString();
            this.txtEmail.Text = this.AlumnoActual.Email;
            this.dtpFechaNacimiento.Value = this.AlumnoActual.FechaNacimiento;
            //Falta crear abmplanes;

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Persona persona = new Persona();
                this.AlumnoActual = persona;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                AlumnoActual.Nombre = this.txtNombre.Text;
                AlumnoActual.Apellido = this.txtApellido.Text;
                AlumnoActual.Direccion = this.txtDireccion.Text;
                AlumnoActual.Email = this.txtEmail.Text;
                AlumnoActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                AlumnoActual.Telefono = this.txtLegajo.Text;
                AlumnoActual.FechaNacimiento = this.dtpFechaNacimiento.Value.Date;
                if (Modo == ModoForm.Modificacion)
                {
                    AlumnoActual.ID = Convert.ToInt32(this.txtId.Text);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.AlumnoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.AlumnoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.AlumnoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        
        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tableLayoutPanel1.Controls);
        }

        public override void GuardarCambios()
        {
            if(this.Validar())
            {
                this.MapearADatos();
                AlumnoLogic al = new AlumnoLogic();
                al.Save(this.AlumnoActual);
                this.Close();
            }
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
