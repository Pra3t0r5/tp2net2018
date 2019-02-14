using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using Util;

namespace UI.Desktop
{
    public partial class ProfesorDesktop : ApplicationForm
    {
        public Persona ProfesorActual {get; set; }
        private MetodosParaControls metodoParaControles { get; set; }
        
        public ProfesorDesktop()
        {
            InitializeComponent();
            this.metodoParaControles = new MetodosParaControls();
            llenarCombo();
        }

        public ProfesorDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }
        public ProfesorDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ProfesorLogic ul = new ProfesorLogic();
            this.ProfesorActual = ul.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos() {
            this.txtID.Text = this.ProfesorActual.ID.ToString();
            this.txtNombre.Text = this.ProfesorActual.Nombre;
            this.txtApellido.Text = this.ProfesorActual.Apellido;
            this.txtEmail.Text = this.ProfesorActual.Email;
            this.txtTelefono.Text = this.ProfesorActual.Telefono;
            this.dtpFechaNac.Value = this.ProfesorActual.FechaNacimiento;
            this.cmbPlanes.SelectedValue = this.ProfesorActual.IDPlan;

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
                Persona prf = new Persona();
                this.ProfesorActual = prf;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ProfesorActual.Nombre = this.txtNombre.Text;
                ProfesorActual.Apellido = this.txtApellido.Text;
                ProfesorActual.Email = this.txtEmail.Text;
                ProfesorActual.Direccion = this.txtDireccion.Text;
                ProfesorActual.Telefono = this.txtTelefono.Text;
                ProfesorActual.FechaNacimiento = dtpFechaNac.Value.Date;
                ProfesorActual.IDPlan = Convert.ToInt32(cmbPlanes.SelectedValue);
                if (Modo == ModoForm.Modificacion)
                {
                    ProfesorActual.ID = Convert.ToInt32(this.txtID.Text);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.ProfesorActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.ProfesorActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.ProfesorActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tableLayoutPanel1.Controls);
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                ProfesorLogic pl = new ProfesorLogic();
                pl.Save(this.ProfesorActual);
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

        private void llenarCombo()
        {
            PlanLogic pl = new PlanLogic();
            this.cmbPlanes.DataSource = pl.GetAllForCombo();
            this.cmbPlanes.DisplayMember = "Descripcion";
            this.cmbPlanes.ValueMember = "ID";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
