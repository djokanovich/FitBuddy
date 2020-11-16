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
            resources.ApplyResources(this.lnkAcercaDe, "lnkAcercaDe");
            this.lnkAcercaDe.Name = "lnkAcercaDe";
            this.lnkAcercaDe.TabStop = true;
            this.lnkAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkAcercaDeClick);
            // 
            // lnkOlvideContrasena
            // 
            resources.ApplyResources(this.lnkOlvideContrasena, "lnkOlvideContrasena");
            this.lnkOlvideContrasena.Name = "lnkOlvideContrasena";
            this.lnkOlvideContrasena.TabStop = true;
            this.lnkOlvideContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkOlvideContrasenaClicked);
            // 
            // lnkRegistrarUsuario
            // 
            resources.ApplyResources(this.lnkRegistrarUsuario, "lnkRegistrarUsuario");
            this.lnkRegistrarUsuario.Name = "lnkRegistrarUsuario";
            this.lnkRegistrarUsuario.TabStop = true;
            this.lnkRegistrarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLnkRegistrarUsuarioClicked);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Click += new System.EventHandler(this.OnBtnCancelarClick);
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Click += new System.EventHandler(this.OnBtnAceptarClick);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // LogIn
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
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
            this.Name = "LogIn";
            this.Opacity = 0.9D;
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