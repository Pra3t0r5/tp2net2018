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
    public partial class AlumnoInscripciones : Form
    {
        public AlumnoInscripciones()
        {
            InitializeComponent();
            this.dgvInscripciones.AutoGenerateColumns = false;
            this.CargaDatos();
        }

        public void CargaDatos()
        {
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvInscripciones.DataSource = ai.GetAllInscripciones();
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            this.dgvInscripciones.DataSource = ai.GetAlumnoInscripcionsWithDates(Convert.ToInt32(nudDesde.Value), Convert.ToInt32(nudHasta.Value));
        }

        private void tsInscribirAlumno_Click(object sender, EventArgs e)
        {
            AltaInscripcionDesktop altaAlumno = new AltaInscripcionDesktop();
            altaAlumno.ShowDialog();
            altaAlumno.Dispose();

        }
    }
}
