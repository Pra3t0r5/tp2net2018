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
        int idMatActual = 0;
        int idComActual = 0;
       

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
            /*
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
            }*/
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
                    llenarComboEspecialidad();
                    llenarComboMaterias();
                    llenarComboComisiones();


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
        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmbMateria.SelectedItem != null)
            {
                idMatActual = int.Parse(cmbMateria.SelectedItem.ToString());
            }
            else
            {
                idMatActual = 0;
            }

            if (cmbMateria.SelectedItem != null)
            {
                idComActual = int.Parse(cmbComision.SelectedValue.ToString());
            }
            else
            {
                idComActual = 0;
            }


           
          

        }

        private void llenarComboEspecialidad()
        {
            EspecialidadLogic e = new EspecialidadLogic();
            this.cmbEspecialidad.DataSource = e.GetAllByIdPlan(alumnoAInscribir.IDPlan);
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.ValueMember = "Id";
       
        }

        private void llenarComboMaterias()
        {
            MateriaLogic m = new MateriaLogic();
            this.cmbMateria.DataSource = m.GetAllByIdPlan(alumnoAInscribir.IDPlan);
            this.cmbMateria.DisplayMember = "Descripcion";
            this.cmbMateria.ValueMember = "Id";
        }

        private void llenarComboComisiones()
        {
            ComisionLogic c = new ComisionLogic();
            this.cmbComision.DataSource = c.GetAllByMateria(alumnoAInscribir.IDPlan);
            this.cmbComision.DisplayMember = "Descripcion";
            this.cmbComision.ValueMember = "Id";
        }

        public override void GuardarCambios()
        {
            
            // ainsLogic.InscribirAlumno(alumnoAInscribir.ID,  );

          
            
            
        }
    }
}
