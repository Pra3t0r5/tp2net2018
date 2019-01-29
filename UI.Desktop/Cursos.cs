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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            this.Listar();
        }



        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            this.dgvCursos.DataSource = cl.GetAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formCurso.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", ex);
                MessageBox.Show(ex.Message, "Error eliminando: cod: " + ex.HResult, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
