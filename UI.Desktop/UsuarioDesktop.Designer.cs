namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.tlpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 4;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.66667F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.33334F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpUsuario.Controls.Add(this.lblID, 0, 0);
            this.tlpUsuario.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuario.Controls.Add(this.lblEmail, 0, 2);
            this.tlpUsuario.Controls.Add(this.Clave, 0, 3);
            this.tlpUsuario.Controls.Add(this.lblApellido, 2, 1);
            this.tlpUsuario.Controls.Add(this.lblUsuario, 2, 2);
            this.tlpUsuario.Controls.Add(this.label1, 2, 3);
            this.tlpUsuario.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlpUsuario.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuario.Controls.Add(this.txtNombre, 1, 1);
            this.tlpUsuario.Controls.Add(this.txtEmail, 1, 2);
            this.tlpUsuario.Controls.Add(this.txtClave, 1, 3);
            this.tlpUsuario.Controls.Add(this.txtApellido, 3, 1);
            this.tlpUsuario.Controls.Add(this.txtUsuario, 3, 2);
            this.tlpUsuario.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlpUsuario.Controls.Add(this.btnAceptar, 2, 4);
            this.tlpUsuario.Controls.Add(this.Cancelar, 3, 4);
            this.tlpUsuario.Location = new System.Drawing.Point(2, 1);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 5;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpUsuario.Size = new System.Drawing.Size(494, 188);
            this.tlpUsuario.TabIndex = 0;
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(3, 78);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 3;
            this.Clave.Text = "Clave";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(230, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(230, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar Clave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(230, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(72, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(72, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(152, 20);
            this.txtClave.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(321, 28);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(321, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(321, 81);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(140, 20);
            this.txtConfirmarClave.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(321, 107);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 135);
            this.Controls.Add(this.tlpUsuario);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button Cancelar;
    }
}