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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            AlumnoLogic al = new AlumnoLogic();
            this.dgvAlumnos.DataSource = al.GetAll();
        }

        private void Alumnos_Load(object sender, EventArgs e)
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
            AlumnoDesktop formAlumno = new AlumnoDesktop(ApplicationForm.ModoForm.Alta);
            formAlumno.ShowDialog();
            this.Close();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
            AlumnoDesktop formAlumno = new AlumnoDesktop(ID,ApplicationForm.ModoForm.Modificacion);
            formAlumno.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
            AlumnoDesktop formAlumno = new AlumnoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formAlumno.GuardarCambios();
            this.Listar();
        }
    }
}
