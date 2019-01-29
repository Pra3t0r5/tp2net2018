using Business.Logic;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteCursos : Form
    {
        public ReporteCursos()
        {
            InitializeComponent();
            this.Controls.Add(rwCursos);
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            this.rwCursos.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReporteCursos.rdlc";
            ReportDataSource rds = new ReportDataSource("Cursos", cl.GetAll());
            this.rwCursos.LocalReport.DataSources.Clear();
            this.rwCursos.LocalReport.DataSources.Add(rds);
            this.rwCursos.RefreshReport();
        }
    }
}
