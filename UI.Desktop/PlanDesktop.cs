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
    public partial class PlanDesktop : ApplicationForm
    {
        private Plan PlanActual { get; set; }
        private MetodosParaControls metodoParaControles { get; set; }

        public PlanDesktop()
        {
            InitializeComponent();
            this.CargarCombos();
            this.dgvMaterias.AutoGenerateColumns = false;
            this.PlanActual = new Plan();
            this.metodoParaControles = new MetodosParaControls();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic pl = new PlanLogic();
            PlanActual = pl.GetOne(ID);
            this.MapearDeDatos();
        }

        public void CargarCombos()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.cmbEspecialidad.DataSource = el.GetAllForCombo();
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.ValueMember = "ID";
        }

        public override void MapearDeDatos()
        {
            txtID.Text = this.PlanActual.ID.ToString();
            txtDescripcion.Text = this.PlanActual.Descripcion;
            cmbEspecialidad.SelectedItem = this.PlanActual.IDEspecialidad;
            this.dgvMaterias.DataSource = this.PlanActual.Materias.ToList();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnGuardar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnGuardar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = this.txtDescripcion.Text;
                PlanActual.IDEspecialidad = (int)this.cmbEspecialidad.SelectedValue;
            }
            if (Modo == ModoForm.Modificacion)
            {
                PlanActual.ID = Convert.ToInt32(this.txtID.Text);
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.PlanActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.PlanActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.PlanActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tlpPlanes.Controls);
        }

        public override void GuardarCambios()
        {
            try
            {
                this.MapearADatos();
                PlanLogic pl = new PlanLogic();
                pl.Save(this.PlanActual);
                this.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error al guardar el plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            var result = formMateria.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(this.PlanActual.Materias == null)
                    this.PlanActual.Materias = new List<Materia>();
                this.PlanActual.Materias.Add(formMateria.MateriaActual);
                this.dgvMaterias.DataSource = this.PlanActual.Materias;
            }
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            int? ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            var materia = this.PlanActual.Materias.First(x => x.ID == ID);
            materia.State = BusinessEntity.States.Deleted;
            this.PlanActual.Materias.Remove(materia);
            this.dgvMaterias.DataSource = this.PlanActual.Materias;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Modificacion);
            var result = formMateria.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (this.PlanActual.Materias == null)
                    this.PlanActual.Materias = new List<Materia>();
                int index = this.PlanActual.Materias.IndexOf(this.PlanActual.Materias.Find(x => x.ID == formMateria.MateriaActual.ID));
                this.PlanActual.Materias[index] = formMateria.MateriaActual;
                this.dgvMaterias.DataSource = this.PlanActual.Materias;
            }
        }
    }
}
