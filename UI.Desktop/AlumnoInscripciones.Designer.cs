namespace UI.Desktop
{
    partial class AlumnoInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoInscripciones));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.btnFiltar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInscribirAlumno = new System.Windows.Forms.ToolStripButton();
            this.tsEliminarInscripcion = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(770, 334);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(770, 359);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvInscripciones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nudHasta);
            this.splitContainer1.Panel2.Controls.Add(this.nudDesde);
            this.splitContainer1.Panel2.Controls.Add(this.btnFiltar);
            this.splitContainer1.Panel2.Controls.Add(this.lblFechaHasta);
            this.splitContainer1.Panel2.Controls.Add(this.lblFechaDesde);
            this.splitContainer1.Size = new System.Drawing.Size(770, 334);
            this.splitContainer1.SplitterDistance = 633;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.legajo,
            this.Nombre,
            this.Apellido,
            this.Curso,
            this.Año});
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.Location = new System.Drawing.Point(0, 0);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.Size = new System.Drawing.Size(633, 334);
            this.dgvInscripciones.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "LegajoAlumno";
            this.legajo.Frozen = true;
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreAlumno";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ApellidoAlumno";
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.Frozen = true;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.Frozen = true;
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(17, 90);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(82, 20);
            this.nudHasta.TabIndex = 6;
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(17, 31);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(82, 20);
            this.nudDesde.TabIndex = 5;
            // 
            // btnFiltar
            // 
            this.btnFiltar.Location = new System.Drawing.Point(12, 129);
            this.btnFiltar.Name = "btnFiltar";
            this.btnFiltar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltar.TabIndex = 4;
            this.btnFiltar.Text = "Filtrar";
            this.btnFiltar.UseVisualStyleBackColor = true;
            this.btnFiltar.Click += new System.EventHandler(this.btnFiltar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(14, 60);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(107, 13);
            this.lblFechaHasta.TabIndex = 2;
            this.lblFechaHasta.Text = "Año calendario hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(11, 14);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(110, 13);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Año calendario desde";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInscribirAlumno,
            this.tsEliminarInscripcion});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(89, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsInscribirAlumno
            // 
            this.tsInscribirAlumno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsInscribirAlumno.Image = ((System.Drawing.Image)(resources.GetObject("tsInscribirAlumno.Image")));
            this.tsInscribirAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInscribirAlumno.Name = "tsInscribirAlumno";
            this.tsInscribirAlumno.Size = new System.Drawing.Size(23, 22);
            this.tsInscribirAlumno.Text = "Nueva Inscripcion";
            this.tsInscribirAlumno.Click += new System.EventHandler(this.tsInscribirAlumno_Click);
            // 
            // tsEliminarInscripcion
            // 
            this.tsEliminarInscripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminarInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminarInscripcion.Image")));
            this.tsEliminarInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminarInscripcion.Name = "tsEliminarInscripcion";
            this.tsEliminarInscripcion.Size = new System.Drawing.Size(23, 22);
            this.tsEliminarInscripcion.Text = "Eliminar Inscripcion";
            // 
            // AlumnoInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 359);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "AlumnoInscripciones";
            this.Text = "AlumnoInscripciones";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsInscribirAlumno;
        private System.Windows.Forms.ToolStripButton tsEliminarInscripcion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnFiltar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
    }
}