using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
            this.dgvProfesores.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            ProfesorLogic pr = new ProfesorLogic();
            this.dgvProfesores.DataSource = pr.GetAll();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            ProfesorDesktop formProfesor = new ProfesorDesktop(ApplicationForm.ModoForm.Alta);
            formProfesor.ShowDialog();
            this.Close();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvProfesores.SelectedRows[0].DataBoundItem).ID;
            ProfesorDesktop formProfesor = new ProfesorDesktop(ApplicationForm.ModoForm.Modificacion);
            formProfesor.ShowDialog();
            this.Close();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvProfesores.SelectedRows[0].DataBoundItem).ID;
            ProfesorDesktop formProfesor = new ProfesorDesktop(ApplicationForm.ModoForm.Modificacion);
            formProfesor.GuardarCambios();
            this.Close();
        }

        
    }
}
