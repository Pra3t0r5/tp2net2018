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
        public Usuario ProfesorActual {get; set; }
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
            UsuarioLogic ul = new UsuarioLogic();
            this.ProfesorActual = ul.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos() {
            this.txtID.Text = this.ProfesorActual.ID.ToString();
            this.chkHabilitado.Checked = this.ProfesorActual.Habilitado;
            this.txtNombre.Text = this.ProfesorActual.Nombre;
            this.txtApellido.Text = this.ProfesorActual.Apellido;
            this.txtEmail.Text = this.ProfesorActual.EMail;
            this.txtUsuario.Text = this.ProfesorActual.NombreUsuario;
            this.txtClave.Text = this.ProfesorActual.Clave;
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
                Usuario prf = new Usuario();
                this.ProfesorActual = prf;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ProfesorActual.Nombre = this.txtNombre.Text;
                ProfesorActual.Apellido = this.txtApellido.Text;
                ProfesorActual.EMail = this.txtEmail.Text;
                ProfesorActual.NombreUsuario = this.txtUsuario.Text;
                ProfesorActual.Clave = this.txtClave.Text;
                ProfesorActual.Habilitado = this.chkHabilitado.Checked;
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
                UsuarioLogic ul = new UsuarioLogic();
                ul.Save(this.ProfesorActual);
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
    }
}
