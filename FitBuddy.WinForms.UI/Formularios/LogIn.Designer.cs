namespace FitBuddy.WinForms.UI.Formularios
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lnkAcercaDe = new System.Windows.Forms.LinkLabel();
            this.lnkOlvideContrasena = new System.Windows.Forms.LinkLabel();
            this.lnkRegistrarUsuario = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkAcercaDe
            // 
            this.lnkAcercaDe.AutoSize = true;
            this.lnkAcercaDe.Location = new System.Drawing.Point(14, 353);
            this.lnkAcercaDe.Name = "lnkAcercaDe";
            this.lnkAcercaDe.Size = new System.Drawing.Size(119, 13);
            this.lnkAcercaDe.TabIndex = 24;
            this.lnkAcercaDe.TabStop = true;
            this.lnkAcercaDe.Text = "Acerca de la Aplicación";
            this.lnkAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkAcercaDeClick);
            // 
            // lnkOlvideContrasena
            // 
            this.lnkOlvideContrasena.AutoSize = true;
            this.lnkOlvideContrasena.Location = new System.Drawing.Point(393, 243);
            this.lnkOlvideContrasena.Name = "lnkOlvideContrasena";
            this.lnkOlvideContrasena.Size = new System.Drawing.Size(106, 13);
            this.lnkOlvideContrasena.TabIndex = 6;
            this.lnkOlvideContrasena.TabStop = true;
            this.lnkOlvideContrasena.Text = "Olvidé mi contraseña";
            this.lnkOlvideContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkOlvideContrasenaClicked);
            // 
            // lnkRegistrarUsuario
            // 
            this.lnkRegistrarUsuario.AutoSize = true;
            this.lnkRegistrarUsuario.Location = new System.Drawing.Point(393, 220);
            this.lnkRegistrarUsuario.Name = "lnkRegistrarUsuario";
            this.lnkRegistrarUsuario.Size = new System.Drawing.Size(88, 13);
            this.lnkRegistrarUsuario.TabIndex = 5;
            this.lnkRegistrarUsuario.TabStop = true;
            this.lnkRegistrarUsuario.Text = "No tengo usuario";
            this.lnkRegistrarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkRegistrarUsuarioClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(513, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.OnBtnCancelarClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(390, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.OnBtnAceptarClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(390, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(390, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(390, 113);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "&Contraseña";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(74, 68);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(263, 263);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoPictureBox.TabIndex = 16;
            this.LogoPictureBox.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(388, 57);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
            this.UsernameLabel.TabIndex = 25;
            this.UsernameLabel.Text = "&Nombre de usuario";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogIn
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(657, 378);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.lnkAcercaDe);
            this.Controls.Add(this.lnkOlvideContrasena);
            this.Controls.Add(this.lnkRegistrarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel lnkAcercaDe;
        internal System.Windows.Forms.LinkLabel lnkOlvideContrasena;
        internal System.Windows.Forms.LinkLabel lnkRegistrarUsuario;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Label UsernameLabel;
    }
}