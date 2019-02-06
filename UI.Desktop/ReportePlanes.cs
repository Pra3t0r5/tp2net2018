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
    public partial class ReportePlanes : Form
    {
        public ReportePlanes()
        {
            InitializeComponent();
        }

        private void ReportePlanes_Load(object sender, EventArgs e)
        {
            this.rwPlanes.RefreshReport();
            PlanLogic pl = new PlanLogic();
            this.rwPlanes.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReportePlanes.rdlc";
            ReportDataSource rds = new ReportDataSource("Planes", pl.GetAll());
            this.rwPlanes.LocalReport.DataSources.Clear();
            this.rwPlanes.LocalReport.DataSources.Add(rds);
            this.rwPlanes.RefreshReport();
        }

        private void rwPlanes_Load(object sender, EventArgs e)
        {

        }
    }
}
