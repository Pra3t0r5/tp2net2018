namespace UI.Desktop
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tblUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tblUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tsUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tblUsuarios);
            this.tcUsuarios.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(1067, 527);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(1067, 554);
            this.tcUsuarios.TabIndex = 0;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.tsUsuarios);
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.ColumnCount = 2;
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblUsuarios.Controls.Add(this.dgvUsuarios, 0, 0);
            this.tblUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tblUsuarios.Controls.Add(this.btnSalir, 1, 1);
            this.tblUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tblUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblUsuarios.Name = "tblUsuarios";
            this.tblUsuarios.RowCount = 2;
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblUsuarios.Size = new System.Drawing.Size(1067, 527);
            this.tblUsuarios.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.usuario,
            this.email,
            this.habilitado});
            this.tblUsuarios.SetColumnSpan(this.dgvUsuarios, 2);
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(4, 4);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1059, 483);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.Frozen = true;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "NombreUsuario";
            this.usuario.Frozen = true;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.Frozen = true;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "Habilitado";
            this.habilitado.Frozen = true;
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(855, 495);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(963, 495);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsModificar,
            this.tsEliminar});
            this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(84, 27);
            this.tsUsuarios.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(24, 24);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsModificar
            // 
            this.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsModificar.Image")));
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(24, 24);
            this.tsModificar.Text = "Modificar";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(24, 24);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tcUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tblUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.TableLayoutPanel tblUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
    }
}