namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tblCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.nmdAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.huih = new System.Windows.Forms.Label();
            this.nmdCupo = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tblCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCurso
            // 
            this.tblCurso.ColumnCount = 3;
            this.tblCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.09506F));
            this.tblCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.90495F));
            this.tblCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblCurso.Controls.Add(this.lblID, 0, 0);
            this.tblCurso.Controls.Add(this.cmbMaterias, 1, 1);
            this.tblCurso.Controls.Add(this.lblMateria, 0, 1);
            this.tblCurso.Controls.Add(this.lblComision, 0, 2);
            this.tblCurso.Controls.Add(this.cmbComision, 1, 2);
            this.tblCurso.Controls.Add(this.nmdAnio, 1, 3);
            this.tblCurso.Controls.Add(this.lblAnioCalendario, 0, 3);
            this.tblCurso.Controls.Add(this.huih, 0, 4);
            this.tblCurso.Controls.Add(this.nmdCupo, 1, 4);
            this.tblCurso.Controls.Add(this.txtId, 1, 0);
            this.tblCurso.Controls.Add(this.btnAceptar, 1, 5);
            this.tblCurso.Controls.Add(this.btnCancelar, 2, 5);
            this.tblCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCurso.Location = new System.Drawing.Point(0, 0);
            this.tblCurso.Name = "tblCurso";
            this.tblCurso.RowCount = 6;
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.59259F));
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.40741F));
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblCurso.Size = new System.Drawing.Size(393, 207);
            this.tblCurso.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(74, 32);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(190, 21);
            this.cmbMaterias.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(3, 29);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 69);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 3;
            this.lblComision.Text = "Comision";
            // 
            // cmbComision
            // 
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(74, 72);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.Size = new System.Drawing.Size(190, 21);
            this.cmbComision.TabIndex = 4;
            // 
            // nmdAnio
            // 
            this.nmdAnio.Location = new System.Drawing.Point(74, 106);
            this.nmdAnio.Name = "nmdAnio";
            this.nmdAnio.Size = new System.Drawing.Size(120, 20);
            this.nmdAnio.TabIndex = 5;
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(3, 103);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCalendario.TabIndex = 6;
            this.lblAnioCalendario.Text = "Año";
            // 
            // huih
            // 
            this.huih.AutoSize = true;
            this.huih.Location = new System.Drawing.Point(3, 146);
            this.huih.Name = "huih";
            this.huih.Size = new System.Drawing.Size(32, 13);
            this.huih.TabIndex = 7;
            this.huih.Text = "Cupo";
            // 
            // nmdCupo
            // 
            this.nmdCupo.Location = new System.Drawing.Point(74, 149);
            this.nmdCupo.Name = "nmdCupo";
            this.nmdCupo.Size = new System.Drawing.Size(120, 20);
            this.nmdCupo.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(74, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(190, 20);
            this.txtId.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(205, 178);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.tblCurso);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tblCurso.ResumeLayout(false);
            this.tblCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdCupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCurso;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cmbComision;
        private System.Windows.Forms.NumericUpDown nmdAnio;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label huih;
        private System.Windows.Forms.NumericUpDown nmdCupo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}