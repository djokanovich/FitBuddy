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
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
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
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.OnBtnCancelarClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAceptar.Highlight = true;
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.OnBtnAceptarClick);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtPassword.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtPassword.Lines = new string[0];
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtUsername.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtUsername.Lines = new string[0];
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.ShowClearButton = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::FitBuddy.WinForms.UI.Properties.Resources.FitBuddy;
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
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel lnkAcercaDe;
        internal System.Windows.Forms.LinkLabel lnkOlvideContrasena;
        internal System.Windows.Forms.LinkLabel lnkRegistrarUsuario;
        internal MetroFramework.Controls.MetroButton btnCancelar;
        internal MetroFramework.Controls.MetroButton btnAceptar;
        internal MetroFramework.Controls.MetroTextBox txtPassword;
        internal MetroFramework.Controls.MetroTextBox txtUsername;
        internal MetroFramework.Controls.MetroLabel PasswordLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal MetroFramework.Controls.MetroLabel UsernameLabel;
    }
}