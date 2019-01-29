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
    public partial class Materias : Form
    {
        private MateriaLogic materiaLogic { get; set; }
       
        public Materias()
        {
            InitializeComponent();
            this.materiaLogic = new MateriaLogic();
            this.Listar();
        }

        public void Listar()
        {         
            this.dgvMaterias.DataSource = materiaLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop formEspecialidad = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsModificacion_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formEspecialidad = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formEspecialidad = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            formEspecialidad.ShowDialog();
            this.Listar();
        }
    }
}
