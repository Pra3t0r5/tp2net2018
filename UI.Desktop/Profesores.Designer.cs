namespace UI.Desktop
{
    partial class Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesores));
            this.tcProfesores = new System.Windows.Forms.ToolStripContainer();
            this.tlProfesores = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsProfesores = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcProfesores.ContentPanel.SuspendLayout();
            this.tcProfesores.TopToolStripPanel.SuspendLayout();
            this.tcProfesores.SuspendLayout();
            this.tlProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.tsProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcProfesores
            // 
            // 
            // tcProfesores.ContentPanel
            // 
            this.tcProfesores.ContentPanel.Controls.Add(this.tlProfesores);
            this.tcProfesores.ContentPanel.Size = new System.Drawing.Size(1035, 454);
            this.tcProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProfesores.Location = new System.Drawing.Point(0, 0);
            this.tcProfesores.Name = "tcProfesores";
            this.tcProfesores.Size = new System.Drawing.Size(1035, 479);
            this.tcProfesores.TabIndex = 0;
            this.tcProfesores.Text = "toolStripContainer1";
            // 
            // tcProfesores.TopToolStripPanel
            // 
            this.tcProfesores.TopToolStripPanel.Controls.Add(this.tsProfesores);
            // 
            // tlProfesores
            // 
            this.tlProfesores.ColumnCount = 2;
            this.tlProfesores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlProfesores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlProfesores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlProfesores.Controls.Add(this.dgvProfesores, 0, 0);
            this.tlProfesores.Controls.Add(this.btnActualizar, 0, 1);
            this.tlProfesores.Controls.Add(this.btnSalir, 1, 1);
            this.tlProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlProfesores.Location = new System.Drawing.Point(0, 0);
            this.tlProfesores.Name = "tlProfesores";
            this.tlProfesores.RowCount = 2;
            this.tlProfesores.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlProfesores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.tlProfesores.Size = new System.Drawing.Size(1035, 454);
            this.tlProfesores.TabIndex = 0;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.direccion,
            this.telefono,
            this.fechanacimiento,
            this.legajo,
            this.tipopersona,
            this.idplan});
            this.tlProfesores.SetColumnSpan(this.dgvProfesores, 2);
            this.dgvProfesores.Location = new System.Drawing.Point(3, 3);
            this.dgvProfesores.MultiSelect = false;
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesores.Size = new System.Drawing.Size(1029, 419);
            this.dgvProfesores.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.Frozen = true;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.Frozen = true;
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.DataPropertyName = "FechaNacimiento";
            this.fechanacimiento.Frozen = true;
            this.fechanacimiento.HeaderText = "Fecha Nacimiento";
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.Frozen = true;
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // tipopersona
            // 
            this.tipopersona.DataPropertyName = "TipoPersona";
            this.tipopersona.Frozen = true;
            this.tipopersona.HeaderText = "Tipo Persona";
            this.tipopersona.Name = "tipopersona";
            this.tipopersona.ReadOnly = true;
            this.tipopersona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipopersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idplan
            // 
            this.idplan.DataPropertyName = "IdPlan";
            this.idplan.Frozen = true;
            this.idplan.HeaderText = "Plan";
            this.idplan.Name = "idplan";
            this.idplan.ReadOnly = true;
            this.idplan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idplan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(876, 428);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(957, 428);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsProfesores
            // 
            this.tsProfesores.Dock = System.Windows.Forms.DockStyle.None;
            this.tsProfesores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbDelete});
            this.tsProfesores.Location = new System.Drawing.Point(3, 0);
            this.tsProfesores.Name = "tsProfesores";
            this.tsProfesores.Size = new System.Drawing.Size(112, 25);
            this.tsProfesores.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "tsbNuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "tsbEditar";
            this.tsbEditar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "tsbDelete";
            this.tsbDelete.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Business.Entities.Persona);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 479);
            this.Controls.Add(this.tcProfesores);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            this.tcProfesores.ContentPanel.ResumeLayout(false);
            this.tcProfesores.TopToolStripPanel.ResumeLayout(false);
            this.tcProfesores.TopToolStripPanel.PerformLayout();
            this.tcProfesores.ResumeLayout(false);
            this.tcProfesores.PerformLayout();
            this.tlProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.tsProfesores.ResumeLayout(false);
            this.tsProfesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcProfesores;
        private System.Windows.Forms.ToolStrip tsProfesores;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.TableLayoutPanel tlProfesores;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplan;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}