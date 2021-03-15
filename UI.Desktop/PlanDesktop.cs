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
            if (Modo == ModoForm.Alta)
            {
                Plan plan = new Plan();
                this.PlanActual = plan;
            }
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
    }
}
