using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

        private void ReporteNotas_Load(object sender, EventArgs e)
        {
            this.rwNotas.RefreshReport();
        }
    }
}
