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
    public partial class Planes : Form
    {
        private List<Plan> PlanesList { get; set; }
        private PlanLogic pl => new PlanLogic();
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
            this.PlanesList = pl.GetAll();
            this.Listar();

        }

        public void Listar()
        {
            dgvPlanes.DataSource = this.PlanesList;
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop frmPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            frmPlan.ShowDialog();
            this.Listar();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop frmPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            frmPlan.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop frmPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
                frmPlan.ShowDialog();
                this.Listar();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el plan", ex);
                MessageBox.Show(ex.Message, "Error eliminando: cod: " + ex.HResult, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            PlanLogic pl = new PlanLogic();
            dgvPlanes.DataSource = pl.GetAll().Select(x => x.Descripcion);
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPlanes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
        }

        private void dgvPlanes_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            if(dgv.SelectedRows.Count > 0)
            {
                int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                dgvMaterias.DataSource = this.PlanesList.FirstOrDefault(x => x.ID == ID).Materias;
                dgvMaterias.Refresh();
            }
        }
    }
}
