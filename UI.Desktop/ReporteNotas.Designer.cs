namespace UI.Desktop
{
    partial class ReporteNotas
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
            this.rwNotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rwNotas
            // 
            this.rwNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rwNotas.Location = new System.Drawing.Point(0, 0);
            this.rwNotas.Name = "rwNotas";
            this.rwNotas.ServerReport.BearerToken = null;
            this.rwNotas.Size = new System.Drawing.Size(800, 450);
            this.rwNotas.TabIndex = 0;
            // 
            // ReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rwNotas);
            this.Name = "ReporteNotas";
            this.Text = "ReporteNotas";
            this.Load += new System.EventHandler(this.ReporteNotas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwNotas;
    }
}