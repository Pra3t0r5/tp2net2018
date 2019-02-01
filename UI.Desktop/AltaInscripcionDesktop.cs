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
    public partial class AltaInscripcionDesktop : ApplicationForm
    {

        private AlumnoInscripcionLogic ainsLogic { get; set; }
        private AlumnoInscripcion inscripcionActual { get; set; }
        
        private AlumnoLogic al { get; set; }
        private Persona alumnoAInscribir { get; set; }

        private MetodosParaControls metodosParaControls { get; set; }


        public AltaInscripcionDesktop()
        {
            InitializeComponent();
            this.ainsLogic = new AlumnoInscripcionLogic();
            this.metodosParaControls = new MetodosParaControls();
            this.inscripcionActual = new AlumnoInscripcion();
            this.alumnoAInscribir = new Persona();
        }
        public AltaInscripcionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.inscripcionActual = ainsLogic.GetOne(ID);
            this.MapearDeDatos();
        }

        //public AltaInscripcionDesktop(int ID, ModoForm modo) : this()
        //{
        //    Modo = modo;
        //    AlumnoInscripcionLogic ainsLogic = new AlumnoInscripcionLogic();
        //    this.inscripcionActual = ainsLogic.GetOne(ID);
        //    this.MapearDeDatos();
        //}

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.inscripcionActual.ID.ToString();
            this.txtDescripcion.Text = this.inscripcionActual.Descripcion;
            this.nudHsSemanales.Value = this.inscripcionActual.HSSemanales;
            this.nudHsTotales.Value = this.inscripcionActual.HSTotales;
            this.cmbPlanes.DisplayMember = this.inscripcionActual.DescripcionPlan;
            this.cmbPlanes.ValueMember = this.inscripcionActual.IDPlan.ToString();
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
                Materia esp = new Materia();
                this.inscripcionActual = esp;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                inscripcionActual.Descripcion = txtDescripcion.Text;
                inscripcionActual.HSSemanales = Convert.ToInt32(nudHsSemanales.Value);
                inscripcionActual.HSTotales = Convert.ToInt32(nudHsTotales.Value);
                inscripcionActual.IDPlan = Convert.ToInt32(cmbPlanes.SelectedValue);
                if (Modo == ModoForm.Modificacion)
                {
                    inscripcionActual.ID = Convert.ToInt32(this.txtId.Text);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.inscripcionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.inscripcionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.inscripcionActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }


        public override bool Validar()
        {
            return this.metodosParaControls.validarControlesVacios(this.tblMaterias.Controls);
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                this.materiaLogic.Save(inscripcionActual);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2_netDataSet.planes);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarCombos()
        {
            MateriaLogic mt = new MateriaLogic();
            this.cmbPlanes.DataSource = mt.GetAllForCombo();
            this.cmbPlanes.DisplayMember = "Descripcion";
            this.cmbPlanes.ValueMember = "ID";
        }

        private void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int legajoIngresado = int.Parse(txtLegajo.Text);
                try
                {
                    this.alumnoAInscribir = al.GetOneByLegajo(legajoIngresado);
                    this.txtAlumno.Text = alumnoAInscribir.Nombre + " " + alumnoAInscribir.Apellido;
                    this.
                }
                catch (Exception ex)
                {
                    DialogResult eleccion = MessageBox.Show("Legajo no Encontrado", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (eleccion == DialogResult.Retry)
                    {
                        this.txtLegajo.Text = "";
                        this.txtAlumno.Text = "";
                    }
                }
            }
        }
    }
}
