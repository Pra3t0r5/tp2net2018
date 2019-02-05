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
        private Especialidad especialidadActual { get; set; }
        private List<Materia> materiasActuales { get; set; }
        private Comision comisiones { get; set; }        
        private AlumnoLogic alumLogic { get; set; }
        private Persona alumnoAInscribir { get; set; }
        private MetodosParaControls metodosParaControls { get; set; }
        private CursoLogic curLogic { get; set; }
        private Curso cursoSeleccionado { get; set; }

        EspecialidadLogic especialidadCombo = new EspecialidadLogic();
        MateriaLogic materiaCombo = new MateriaLogic();
        ComisionLogic comisionCombo = new ComisionLogic();

        public AltaInscripcionDesktop()
        {
            InitializeComponent();
            this.ainsLogic = new AlumnoInscripcionLogic();
            this.metodosParaControls = new MetodosParaControls();
            this.inscripcionActual = new AlumnoInscripcion();
            this.alumnoAInscribir = new Persona();
            this.alumLogic = new AlumnoLogic();
            this.curLogic = new CursoLogic();
            this.cursoSeleccionado = new Curso();
            
        }
        public AltaInscripcionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.txtLegajo.Text = "";
            this.txtAlumno.Text = "";
            this.cmbComision.Text = "";
            this.cmbEspecialidad.Text = "";
            this.cmbMateria.Text = "";
        }

        public void MapearAlumnoDeDatos()
        {
            this.txtAlumno.Text = this.alumnoAInscribir.Nombre.ToString()+" "+ this.alumnoAInscribir.Apellido.ToString();
            this.txtLegajo.Text = this.alumnoAInscribir.Legajo.ToString();
            this.cmbEspecialidad.Text = this.especialidadActual.ToString();
            this.cmbMateria.Text = this.materiasActuales.ToString();
            this.cmbComision.Text = this.comisiones.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int legajoIngresado = int.Parse(txtLegajo.Text);
                try
                {
                    this.alumnoAInscribir = alumLogic.GetOneByLegajo(Convert.ToInt32(txtLegajo.Text));
                    this.MapearAlumnoDeDatos();

                    String especialidadSeleccionada = llenarComboEspecialidad();
                  
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

        private void AltaInscripcionDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mix.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.mix.materias);
            // TODO: esta línea de código carga datos en la tabla 'mix.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.mix.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'mix.comisiones' Puede moverla o quitarla según sea necesario.
            this.comisionesTableAdapter.Fill(this.mix.comisiones);

        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int idMateria = (int)cmb.SelectedValue;

            BindingSource bindingComision = new BindingSource();
            bindingComision.DataSource = comisionCombo.GetAllByMateria(idMateria);
            cmbComision.DataSource = bindingComision.DataSource;
            
            this.cursoSeleccionado.IDComision = Convert.ToInt32(cmbComision.ValueMember = "id_comision");
        }

        private String llenarComboEspecialidad()
        {
            BindingSource bindingEspecialidad = new BindingSource();
            bindingEspecialidad.DataSource = especialidadCombo.GetAllByIdPlan(alumnoAInscribir.IDPlan);
            cmbEspecialidad.DataSource = bindingEspecialidad.DataSource;
            return cmbEspecialidad.ValueMember = "id_especialidad";            
        }

        private void llenarComboMaterias()
        {
            BindingSource bindingMateria = new BindingSource();
            bindingMateria.DataSource = materiaCombo.GetAllByIdPlan(alumnoAInscribir.IDPlan);
            cmbMateria.DataSource = bindingMateria.DataSource;
            this.cursoSeleccionado.IDMateria = Convert.ToInt32(cmbMateria.ValueMember = "id_materia");
        }
    }
}
