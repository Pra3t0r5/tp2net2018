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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }
        private MetodosParaControls metodoParaControles { get; set; }

        public UsuarioDesktop()
        {
            InitializeComponent();
            this.metodoParaControles = new MetodosParaControls();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
            this.UsuarioActual = ul.GetOne(ID);
            this.MapearDeDatos();
  
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
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
            if(Modo == ModoForm.Alta)
            {
                Usuario usr = new Usuario();
                this.UsuarioActual = usr;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.EMail = this.txtEmail.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                if (Modo == ModoForm.Modificacion)
                {
                    UsuarioActual.ID = Convert.ToInt32(this.txtID.Text);
                    this.txtID.ReadOnly = true;
                }
                else if (Modo == ModoForm.Alta)
                {
                    this.txtID.ReadOnly = true;
                }

             

            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }

        public override bool  Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tlpUsuario.Controls);
        }

        public override void GuardarCambios()
        {
            if(this.Validar())
            {
                this.MapearADatos();
                UsuarioLogic ul = new UsuarioLogic();
                ul.Save(this.UsuarioActual);
                this.Close();
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
