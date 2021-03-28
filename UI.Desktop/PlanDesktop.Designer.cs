namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitarMateria = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPlanes
            // 
            this.tlpPlanes.ColumnCount = 3;
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.72939F));
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.27061F));
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpPlanes.Controls.Add(this.lblId, 0, 0);
            this.tlpPlanes.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpPlanes.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpPlanes.Controls.Add(this.lblEspecialidad, 0, 2);
            this.tlpPlanes.Controls.Add(this.cmbEspecialidad, 1, 2);
            this.tlpPlanes.Controls.Add(this.txtID, 1, 0);
            this.tlpPlanes.Controls.Add(this.lblMaterias, 0, 3);
            this.tlpPlanes.Controls.Add(this.dgvMaterias, 1, 4);
            this.tlpPlanes.Controls.Add(this.btnAgregarMateria, 0, 4);
            this.tlpPlanes.Controls.Add(this.btnEditar, 0, 5);
            this.tlpPlanes.Controls.Add(this.btnGuardar, 1, 7);
            this.tlpPlanes.Controls.Add(this.btnCancelar, 2, 7);
            this.tlpPlanes.Controls.Add(this.btnQuitarMateria, 0, 6);
            this.tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlpPlanes.Name = "tlpPlanes";
            this.tlpPlanes.RowCount = 8;
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.33333F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpPlanes.Size = new System.Drawing.Size(732, 369);
            this.tlpPlanes.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(117, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 59);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(117, 62);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(207, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(117, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(565, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(646, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(3, 87);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(47, 13);
            this.lblMaterias.TabIndex = 11;
            this.lblMaterias.Text = "Materias";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Materia,
            this.HsSemanales,
            this.HsTotales});
            this.tlpPlanes.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(117, 111);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.tlpPlanes.SetRowSpan(this.dgvMaterias, 3);
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(612, 217);
            this.dgvMaterias.TabIndex = 9;
            this.dgvMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellContentClick);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(3, 111);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarMateria.TabIndex = 12;
            this.btnAgregarMateria.Text = "AgregarMateria";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(3, 140);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar Materia";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnQuitarMateria
            // 
            this.btnQuitarMateria.Location = new System.Drawing.Point(3, 169);
            this.btnQuitarMateria.Name = "btnQuitarMateria";
            this.btnQuitarMateria.Size = new System.Drawing.Size(108, 23);
            this.btnQuitarMateria.TabIndex = 14;
            this.btnQuitarMateria.Text = "Quitar Materia";
            this.btnQuitarMateria.UseVisualStyleBackColor = true;
            this.btnQuitarMateria.Click += new System.EventHandler(this.btnQuitarMateria_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materia.DataPropertyName = "Descripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HSSemanales";
            this.HsSemanales.HeaderText = "Hs Semanales";
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            // 
            // HsTotales
            // 
            this.HsTotales.DataPropertyName = "HSTotales";
            this.HsTotales.HeaderText = "Hs Totales";
            this.HsTotales.Name = "HsTotales";
            this.HsTotales.ReadOnly = true;
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 369);
            this.Controls.Add(this.tlpPlanes);
            this.Name = "PlanDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanDesktop";
            this.tlpPlanes.ResumeLayout(false);
            this.tlpPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitarMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
    }
}