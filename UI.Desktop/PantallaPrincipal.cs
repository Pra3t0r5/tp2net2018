using Business.Entities;
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
    public partial class PantallaPrincipal : Form
    {
        private Usuario UsuarioLogin { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public PantallaPrincipal(Usuario usr)
        {
            InitializeComponent();
            this.UsuarioLogin = usr;
        }

        public void SetearPermisos(Usuario usr)
        {
           if(usr.IDPersona.HasValue)
            {
                switch(usr.TipoPersona)
                {
                    case 1: this.btnAnotarAlumno.Enabled = false;  // 1 = Profesor

                        break;

                    case 2: this.toolStripContainer1.Enabled = false;                                        // 2 = Alumno

                        break;
                }
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
            usuarios.Dispose();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.ShowDialog();
            alumnos.Dispose();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();
            profesores.ShowDialog();
            profesores.Dispose();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades especialidades = new Especialidades();
            especialidades.ShowDialog();
            especialidades.Dispose();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.ShowDialog();
            cursos.Dispose();
        }

        private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comisiones comisiones = new Comisiones();
            comisiones.ShowDialog();
            comisiones.Dispose();
        }

        private void btnAnotarAlumno_Click(object sender, EventArgs e)
        {
            
                AlumnoInscripciones alumnoInscripciones = new AlumnoInscripciones();
                alumnoInscripciones.ShowDialog();
                alumnoInscripciones.Dispose();
            

        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
            planes.Dispose();
            
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.ShowDialog();
            materias.Dispose();
        }
    }
}
