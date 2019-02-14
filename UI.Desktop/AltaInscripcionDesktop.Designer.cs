namespace UI.Desktop
{
    partial class AltaInscripcionDesktop
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
            this.components = new System.ComponentModel.Container();
            this.lblNumeroInscripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdInscripcion = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mix = new UI.Desktop.mix();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comisionesTableAdapter = new UI.Desktop.mixTableAdapters.comisionesTableAdapter();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new UI.Desktop.mixTableAdapters.especialidadesTableAdapter();
            this.materiasTableAdapter = new UI.Desktop.mixTableAdapters.materiasTableAdapter();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroInscripcion
            // 
            this.lblNumeroInscripcion.AutoSize = true;
            this.lblNumeroInscripcion.Location = new System.Drawing.Point(14, 15);
            this.lblNumeroInscripcion.Name = "lblNumeroInscripcion";
            this.lblNumeroInscripcion.Size = new System.Drawing.Size(74, 13);
            this.lblNumeroInscripcion.TabIndex = 0;
            this.lblNumeroInscripcion.Text = "Inscripcion nº:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 181);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(372, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIdInscripcion
            // 
            this.txtIdInscripcion.Enabled = false;
            this.txtIdInscripcion.Location = new System.Drawing.Point(94, 12);
            this.txtIdInscripcion.Name = "txtIdInscripcion";
            this.txtIdInscripcion.ReadOnly = true;
            this.txtIdInscripcion.Size = new System.Drawing.Size(185, 20);
            this.txtIdInscripcion.TabIndex = 7;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(94, 62);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(185, 20);
            this.txtAlumno.TabIndex = 9;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(43, 65);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 8;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(18, 110);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 10;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(43, 136);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 12;
            this.lblMateria.Text = "Materia:";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(289, 136);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 13);
            this.lblComision.TabIndex = 14;
            this.lblComision.Text = "Comision:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(347, 62);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(67, 20);
            this.txtLegajo.TabIndex = 17;
            this.txtLegajo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLegajo_KeyDown);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(291, 65);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 16;
            this.lblLegajo.Text = "Legajo:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DataSource = this.materiasBindingSource;
            this.cmbMateria.DisplayMember = "desc_materia";
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(94, 133);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(184, 21);
            this.cmbMateria.TabIndex = 19;
            this.cmbMateria.ValueMember = "id_materia";
            
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.mixBindingSource;
            // 
            // mixBindingSource
            // 
            this.mixBindingSource.DataSource = this.mix;
            this.mixBindingSource.Position = 0;
            // 
            // mix
            // 
            this.mix.DataSetName = "mix";
            this.mix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbComision
            // 
            this.cmbComision.DataSource = this.comisionesBindingSource;
            this.cmbComision.DisplayMember = "desc_comision";
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(347, 133);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.Size = new System.Drawing.Size(67, 21);
            this.cmbComision.TabIndex = 20;
            this.cmbComision.ValueMember = "id_comision";
            this.cmbComision.SelectedIndexChanged += new System.EventHandler(this.cmbComision_SelectedIndexChanged);
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "comisiones";
            this.comisionesBindingSource.DataSource = this.mixBindingSource;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.mixBindingSource;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(94, 101);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(185, 21);
            this.cmbEspecialidad.TabIndex = 21;
            // 
            // AltaInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 212);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.cmbComision);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.txtIdInscripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroInscripcion);
            this.Name = "AltaInscripcionDesktop";
            this.Text = "AltaInscripcionDesktop";
            this.Load += new System.EventHandler(this.AltaInscripcionDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroInscripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIdInscripcion;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbComision;
        private System.Windows.Forms.BindingSource mixBindingSource;
        private mix mix;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private mixTableAdapters.comisionesTableAdapter comisionesTableAdapter;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private mixTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private mixTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}