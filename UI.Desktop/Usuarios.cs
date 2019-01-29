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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID,ApplicationForm.ModoForm.Modificacion);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
            formUsuario.ShowDialog();
            this.Listar();
        }
    }
}
