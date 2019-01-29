namespace UI.Desktop
{
    partial class ReporteCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rwCursos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rwCursos
            // 
            this.rwCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rwCursos.LocalReport.DisplayName = "ReporteCursos.rdlc";
            this.rwCursos.LocalReport.ReportEmbeddedResource = "ReporteCursos.rdlc";
            this.rwCursos.LocalReport.ReportPath = "C:\\Users\\David\\source\\repos\\TP2\\UI.Desktop\\ReporteCursos.rdlc";
            this.rwCursos.Location = new System.Drawing.Point(0, 0);
            this.rwCursos.Name = "rwCursos";
            this.rwCursos.ServerReport.BearerToken = null;
            this.rwCursos.Size = new System.Drawing.Size(636, 450);
            this.rwCursos.TabIndex = 0;
            // 
            // ReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.rwCursos);
            this.Name = "ReporteCursos";
            this.Text = "ReporteCursos";
            this.Load += new System.EventHandler(this.ReporteCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwCursos;
    }
}