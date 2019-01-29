namespace UI.Desktop
{
    partial class ProfesorDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConfirmarClave, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbPlanes, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(3, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(3, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(3, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(32, 13);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Email";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.AutoSize = true;
            this.txtClave.Location = new System.Drawing.Point(3, 84);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(34, 13);
            this.txtClave.TabIndex = 3;
            this.txtClave.Text = "Clave";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(237, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 13);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.Text = "Apellido";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(237, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(43, 13);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "Usuario";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfirmarClave.AutoSize = true;
            this.txtConfirmarClave.Location = new System.Drawing.Point(237, 84);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(81, 13);
            this.txtConfirmarClave.TabIndex = 8;
            this.txtConfirmarClave.Text = "Confirmar Clave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(237, 4);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 9;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(237, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(324, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(53, 81);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(173, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(324, 81);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBox2.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(324, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(324, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(179, 20);
            this.textBox5.TabIndex = 18;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(3, 104);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 19;
            this.lblPlan.Text = "Plan";
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(53, 107);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(173, 21);
            this.cmbPlanes.TabIndex = 20;
            // 
            // ProfesorDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProfesorDesktop";
            this.Text = "Profesor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtClave;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtConfirmarClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cmbPlanes;
    }
}