namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.tscMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tblMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsModificacion = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscMaterias.ContentPanel.SuspendLayout();
            this.tscMaterias.TopToolStripPanel.SuspendLayout();
            this.tscMaterias.SuspendLayout();
            this.tblMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMaterias
            // 
            // 
            // tscMaterias.ContentPanel
            // 
            this.tscMaterias.ContentPanel.Controls.Add(this.tblMaterias);
            this.tscMaterias.ContentPanel.Size = new System.Drawing.Size(656, 425);
            this.tscMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMaterias.Location = new System.Drawing.Point(0, 0);
            this.tscMaterias.Name = "tscMaterias";
            this.tscMaterias.Size = new System.Drawing.Size(656, 450);
            this.tscMaterias.TabIndex = 0;
            this.tscMaterias.Text = "toolStripContainer1";
            // 
            // tscMaterias.TopToolStripPanel
            // 
            this.tscMaterias.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tblMaterias
            // 
            this.tblMaterias.ColumnCount = 2;
            this.tblMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tblMaterias.Controls.Add(this.btnActualizar, 0, 1);
            this.tblMaterias.Controls.Add(this.btnCancelar, 1, 1);
            this.tblMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMaterias.Location = new System.Drawing.Point(0, 0);
            this.tblMaterias.Name = "tblMaterias";
            this.tblMaterias.RowCount = 2;
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterias.Size = new System.Drawing.Size(656, 425);
            this.tblMaterias.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.HSSemanales,
            this.HorasTotales,
            this.Plan});
            this.tblMaterias.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.Size = new System.Drawing.Size(650, 390);
            this.dgvMaterias.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.Location = new System.Drawing.Point(497, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(578, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsModificacion,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tsNuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsModificacion
            // 
            this.tsModificacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificacion.Image = ((System.Drawing.Image)(resources.GetObject("tsModificacion.Image")));
            this.tsModificacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificacion.Name = "tsModificacion";
            this.tsModificacion.Size = new System.Drawing.Size(23, 22);
            this.tsModificacion.Text = "Modificar";
            this.tsModificacion.Click += new System.EventHandler(this.tsModificacion_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsEliminar.Text = "toolStripButton3";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // HSSemanales
            // 
            this.HSSemanales.DataPropertyName = "HSSemanales";
            this.HSSemanales.Frozen = true;
            this.HSSemanales.HeaderText = "Horas semanales";
            this.HSSemanales.Name = "HSSemanales";
            this.HSSemanales.ReadOnly = true;
            // 
            // HorasTotales
            // 
            this.HorasTotales.DataPropertyName = "HSTotales";
            this.HorasTotales.Frozen = true;
            this.HorasTotales.HeaderText = "Horas totales";
            this.HorasTotales.Name = "HorasTotales";
            this.HorasTotales.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "DescripcionPlan";
            this.Plan.Frozen = true;
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.tscMaterias);
            this.Name = "Materias";
            this.Text = "Materias";
            this.tscMaterias.ContentPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.PerformLayout();
            this.tscMaterias.ResumeLayout(false);
            this.tscMaterias.PerformLayout();
            this.tblMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMaterias;
        private System.Windows.Forms.TableLayoutPanel tblMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsModificacion;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}