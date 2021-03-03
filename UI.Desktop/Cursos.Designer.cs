namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.tsCursos = new System.Windows.Forms.ToolStripContainer();
            this.tblCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnInforme = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionmateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncomision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCursos.ContentPanel.SuspendLayout();
            this.tsCursos.TopToolStripPanel.SuspendLayout();
            this.tsCursos.SuspendLayout();
            this.tblCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCursos
            // 
            // 
            // tsCursos.ContentPanel
            // 
            this.tsCursos.ContentPanel.Controls.Add(this.tblCursos);
            this.tsCursos.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsCursos.Location = new System.Drawing.Point(0, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(800, 450);
            this.tsCursos.TabIndex = 0;
            this.tsCursos.Text = "toolStripContainer1";
            // 
            // tsCursos.TopToolStripPanel
            // 
            this.tsCursos.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tblCursos
            // 
            this.tblCursos.ColumnCount = 2;
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tblCursos.Controls.Add(this.btnActualizar, 0, 1);
            this.tblCursos.Controls.Add(this.button2, 1, 1);
            this.tblCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCursos.Location = new System.Drawing.Point(0, 0);
            this.tblCursos.Name = "tblCursos";
            this.tblCursos.RowCount = 2;
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCursos.Size = new System.Drawing.Size(800, 425);
            this.tblCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcionmateria,
            this.descripcioncomision,
            this.anio,
            this.cupo});
            this.tblCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(794, 390);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnInforme});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnInforme.Image")));
            this.btnInforme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(23, 22);
            this.btnInforme.Text = "toolStripButton1";
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // descripcionmateria
            // 
            this.descripcionmateria.DataPropertyName = "Materia";
            this.descripcionmateria.Frozen = true;
            this.descripcionmateria.HeaderText = "Materia";
            this.descripcionmateria.Name = "descripcionmateria";
            this.descripcionmateria.ReadOnly = true;
            // 
            // descripcioncomision
            // 
            this.descripcioncomision.DataPropertyName = "Comision";
            this.descripcioncomision.Frozen = true;
            this.descripcioncomision.HeaderText = "Comision";
            this.descripcioncomision.Name = "descripcioncomision";
            this.descripcioncomision.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "AnioCalendario";
            this.anio.Frozen = true;
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "Cupo";
            this.cupo.Frozen = true;
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.tsCursos.ContentPanel.ResumeLayout(false);
            this.tsCursos.TopToolStripPanel.ResumeLayout(false);
            this.tsCursos.TopToolStripPanel.PerformLayout();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.tblCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsCursos;
        private System.Windows.Forms.TableLayoutPanel tblCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionmateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncomision;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
    }
}