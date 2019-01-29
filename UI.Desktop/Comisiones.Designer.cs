namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tscComisiones = new System.Windows.Forms.ToolStripContainer();
            this.tbpComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscComisiones.ContentPanel.SuspendLayout();
            this.tscComisiones.TopToolStripPanel.SuspendLayout();
            this.tscComisiones.SuspendLayout();
            this.tbpComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscComisiones
            // 
            // 
            // tscComisiones.ContentPanel
            // 
            this.tscComisiones.ContentPanel.Controls.Add(this.tbpComisiones);
            this.tscComisiones.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscComisiones.Location = new System.Drawing.Point(0, 0);
            this.tscComisiones.Name = "tscComisiones";
            this.tscComisiones.Size = new System.Drawing.Size(800, 450);
            this.tscComisiones.TabIndex = 0;
            this.tscComisiones.Text = "toolStripContainer1";
            // 
            // tscComisiones.TopToolStripPanel
            // 
            this.tscComisiones.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tbpComisiones
            // 
            this.tbpComisiones.ColumnCount = 2;
            this.tbpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbpComisiones.Controls.Add(this.button1, 0, 1);
            this.tbpComisiones.Controls.Add(this.button2, 1, 1);
            this.tbpComisiones.Controls.Add(this.dgvComisiones, 0, 0);
            this.tbpComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpComisiones.Location = new System.Drawing.Point(0, 0);
            this.tbpComisiones.Name = "tbpComisiones";
            this.tbpComisiones.RowCount = 2;
            this.tbpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpComisiones.Size = new System.Drawing.Size(800, 425);
            this.tbpComisiones.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(641, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(722, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripcion,
            this.anioespecialidad,
            this.plan});
            this.tbpComisiones.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(794, 390);
            this.dgvComisiones.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsModificar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
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
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // anioespecialidad
            // 
            this.anioespecialidad.DataPropertyName = "AnioEspecialidad";
            this.anioespecialidad.Frozen = true;
            this.anioespecialidad.HeaderText = "Año Especialidad";
            this.anioespecialidad.Name = "anioespecialidad";
            this.anioespecialidad.ReadOnly = true;
            // 
            // plan
            // 
            this.plan.DataPropertyName = "DescripcionPlan";
            this.plan.Frozen = true;
            this.plan.HeaderText = "Plan";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            // 
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscComisiones);
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.tscComisiones.ContentPanel.ResumeLayout(false);
            this.tscComisiones.TopToolStripPanel.ResumeLayout(false);
            this.tscComisiones.TopToolStripPanel.PerformLayout();
            this.tscComisiones.ResumeLayout(false);
            this.tscComisiones.PerformLayout();
            this.tbpComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscComisiones;
        private System.Windows.Forms.TableLayoutPanel tbpComisiones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
    }
}