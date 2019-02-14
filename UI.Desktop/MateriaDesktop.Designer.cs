namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tblMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHorasSemanales = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudHsSemanales = new System.Windows.Forms.NumericUpDown();
            this.nudHsTotales = new System.Windows.Forms.NumericUpDown();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.planesTableAdapter();
            this.tblMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMaterias
            // 
            this.tblMaterias.ColumnCount = 3;
            this.tblMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tblMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tblMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblMaterias.Controls.Add(this.lblId, 0, 0);
            this.tblMaterias.Controls.Add(this.lblDescripcion, 0, 1);
            this.tblMaterias.Controls.Add(this.lblHorasSemanales, 0, 2);
            this.tblMaterias.Controls.Add(this.txtId, 1, 0);
            this.tblMaterias.Controls.Add(this.txtDescripcion, 1, 1);
            this.tblMaterias.Controls.Add(this.nudHsSemanales, 1, 2);
            this.tblMaterias.Controls.Add(this.nudHsTotales, 1, 3);
            this.tblMaterias.Controls.Add(this.lblHsTotales, 0, 3);
            this.tblMaterias.Controls.Add(this.lblPlanes, 0, 4);
            this.tblMaterias.Controls.Add(this.cmbPlanes, 1, 4);
            this.tblMaterias.Controls.Add(this.btnGuardar, 1, 5);
            this.tblMaterias.Controls.Add(this.btnCancelar, 2, 5);
            this.tblMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMaterias.Location = new System.Drawing.Point(0, 0);
            this.tblMaterias.Name = "tblMaterias";
            this.tblMaterias.RowCount = 6;
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tblMaterias.Size = new System.Drawing.Size(377, 172);
            this.tblMaterias.TabIndex = 0;
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
            this.lblDescripcion.Location = new System.Drawing.Point(3, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Desc. Materia";
            // 
            // lblHorasSemanales
            // 
            this.lblHorasSemanales.AutoSize = true;
            this.lblHorasSemanales.Location = new System.Drawing.Point(3, 55);
            this.lblHorasSemanales.Name = "lblHorasSemanales";
            this.lblHorasSemanales.Size = new System.Drawing.Size(80, 13);
            this.lblHorasSemanales.TabIndex = 2;
            this.lblHorasSemanales.Text = "HS. Semanales";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(93, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 32);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // nudHsSemanales
            // 
            this.nudHsSemanales.Location = new System.Drawing.Point(93, 58);
            this.nudHsSemanales.Name = "nudHsSemanales";
            this.nudHsSemanales.Size = new System.Drawing.Size(79, 20);
            this.nudHsSemanales.TabIndex = 6;
            // 
            // nudHsTotales
            // 
            this.nudHsTotales.Location = new System.Drawing.Point(93, 82);
            this.nudHsTotales.Name = "nudHsTotales";
            this.nudHsTotales.Size = new System.Drawing.Size(79, 20);
            this.nudHsTotales.TabIndex = 7;
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(3, 79);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(63, 13);
            this.lblHsTotales.TabIndex = 3;
            this.lblHsTotales.Text = "HS. Totales";
            // 
            // lblPlanes
            // 
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.Location = new System.Drawing.Point(3, 105);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(28, 13);
            this.lblPlanes.TabIndex = 8;
            this.lblPlanes.Text = "Plan";
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(93, 108);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(187, 21);
            this.cmbPlanes.TabIndex = 9;
            this.cmbPlanes.SelectedIndexChanged += new System.EventHandler(this.cmbPlanes_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(206, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 172);
            this.Controls.Add(this.tblMaterias);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tblMaterias.ResumeLayout(false);
            this.tblMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMaterias;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHorasSemanales;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudHsSemanales;
        private System.Windows.Forms.NumericUpDown nudHsTotales;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSetTableAdapters.planesTableAdapter planesTableAdapter;
    }
}