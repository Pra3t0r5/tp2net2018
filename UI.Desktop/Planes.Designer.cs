namespace UI.Desktop
{
    partial class Planes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            this.tsPlanes = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsPlanes.ContentPanel.SuspendLayout();
            this.tsPlanes.TopToolStripPanel.SuspendLayout();
            this.tsPlanes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPlanes
            // 
            // 
            // tsPlanes.ContentPanel
            // 
            this.tsPlanes.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tsPlanes.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsPlanes.Location = new System.Drawing.Point(0, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(800, 450);
            this.tsPlanes.TabIndex = 0;
            this.tsPlanes.Text = "toolStripContainer1";
            // 
            // tsPlanes.dgvPlanes
            // 
            this.tsPlanes.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsModificar,
            this.tsEliminar,
            this.toolStripSeparator1,
            this.txtBusqueda,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(231, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsNuevo.Text = "toolStripButton1";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsModificar
            // 
            this.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsModificar.Image")));
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(23, 22);
            this.tsModificar.Text = "toolStripButton2";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AcceptsReturn = true;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 25);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.88822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.11178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPlanes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvMaterias, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlanes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaterias, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.396947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60305F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Especialidad});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPlanes, 2);
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanes.Location = new System.Drawing.Point(3, 36);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(409, 354);
            this.dgvPlanes.TabIndex = 0;
            this.dgvPlanes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvPlanes_RowStateChanged);
            this.dgvPlanes.SelectionChanged += new System.EventHandler(this.dgvPlanes_SelectionChanged);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.HsSemanales});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(418, 36);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.Size = new System.Drawing.Size(379, 354);
            this.dgvMaterias.TabIndex = 2;
            // 
            // lblPlanes
            // 
            this.lblPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.Location = new System.Drawing.Point(3, 10);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(39, 13);
            this.lblPlanes.TabIndex = 3;
            this.lblPlanes.Text = "Planes";
            // 
            // lblMaterias
            // 
            this.lblMaterias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(418, 10);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(47, 13);
            this.lblMaterias.TabIndex = 4;
            this.lblMaterias.Text = "Materias";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripciòn";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especialidad.DataPropertyName = "DescripcionEspecialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Descripcion";
            this.Materia.HeaderText = "Descripcion";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HsSemanales";
            this.HsSemanales.HeaderText = "Hs Semanales";
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsPlanes);
            this.Name = "Planes";
            this.Text = "Planes";
            this.tsPlanes.ContentPanel.ResumeLayout(false);
            this.tsPlanes.TopToolStripPanel.ResumeLayout(false);
            this.tsPlanes.TopToolStripPanel.PerformLayout();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsPlanes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtBusqueda;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
    }
}