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

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            LoginLogic login = new LoginLogic();
            user = login.ValidateUser(this.txtUsuario.Text, this.txtClave.Text);
            if (!string.IsNullOrEmpty(user.NombreUsuario))
            {
                this.Hide();
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal(user);
                pantallaPrincipal.FormClosed += (s, args) => this.Close();
                pantallaPrincipal.Show();
            }
            else
            {
                DialogResult eleccion = MessageBox.Show("Usuario o Contraseña incorrectos, si no tienes una cuenta puedes registrarte.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(eleccion == DialogResult.Retry)
                {
                    this.txtUsuario.Text = "";
                    this.txtClave.Text = "";
                }
            }          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.FormClosed += (s, args) => this.Close();
            formUsuario.Show();
        }
    }
}
