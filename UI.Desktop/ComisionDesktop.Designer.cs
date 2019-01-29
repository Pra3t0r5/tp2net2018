namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.tlpComision = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tlpComision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpComision
            // 
            this.tlpComision.ColumnCount = 3;
            this.tlpComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tlpComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tlpComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlpComision.Controls.Add(this.lblId, 0, 0);
            this.tlpComision.Controls.Add(this.lblAño, 0, 2);
            this.tlpComision.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpComision.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpComision.Controls.Add(this.lblPlan, 0, 3);
            this.tlpComision.Controls.Add(this.cmbPlanes, 1, 3);
            this.tlpComision.Controls.Add(this.btnAceptar, 1, 4);
            this.tlpComision.Controls.Add(this.btnCancelar, 2, 4);
            this.tlpComision.Controls.Add(this.numericUpDown1, 1, 2);
            this.tlpComision.Controls.Add(this.txtID, 1, 0);
            this.tlpComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComision.Location = new System.Drawing.Point(0, 0);
            this.tlpComision.Name = "tlpComision";
            this.tlpComision.RowCount = 5;
            this.tlpComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpComision.Size = new System.Drawing.Size(392, 207);
            this.tlpComision.TabIndex = 0;
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
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(3, 66);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(88, 13);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año especialidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 36);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(162, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(3, 113);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(109, 116);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(162, 21);
            this.cmbPlanes.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(210, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 20);
            this.txtID.TabIndex = 9;
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 207);
            this.Controls.Add(this.tlpComision);
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.tlpComision.ResumeLayout(false);
            this.tlpComision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpComision;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtID;
    }
}