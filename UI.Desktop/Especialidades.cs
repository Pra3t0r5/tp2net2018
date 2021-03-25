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
using Util.Filters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        private List<Especialidad> EspecialidadesList { get; set; }

        private EspecialidadLogic el = new EspecialidadLogic();

        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.EspecialidadesList = this.el.GetAll();
        }


        public void Listar()
        {
            
            this.dgvEspecialidades.DataSource = el.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsModificacion_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID,ApplicationForm.ModoForm.Modificacion);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
                formEspecialidad.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el plan", ex);
                MessageBox.Show(ex.Message, "Error eliminando: cod: " + ex.HResult, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsBuscador_TextChanged(object sender, EventArgs e)
        {
            var filter = tsBuscador.Text.ToLower();
            if (string.IsNullOrEmpty(tsBuscador.Text))
            {
                dgvEspecialidades.DataSource = this.EspecialidadesList;
            }
            else
            {
                dgvEspecialidades.DataSource = FilterDesktop.Filter(this.EspecialidadesList, filter);
            }
        }
    }
}
