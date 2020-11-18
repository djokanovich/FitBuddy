namespace FitBuddy.WinForms.UI.Formularios
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblVersión = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::FitBuddy.WinForms.UI.Properties.Resources.FitBuddy;
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // lblVersión
            // 
            resources.ApplyResources(this.lblVersión, "lblVersión");
            this.lblVersión.Name = "lblVersión";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAceptar.Highlight = true;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.OnBtnAceptarClick);
            // 
            // txtDescripción
            // 
            resources.ApplyResources(this.txtDescripción, "txtDescripción");
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.ReadOnly = true;
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblVersión);
            this.Controls.Add(this.imgLogo);
            this.DisplayHeader = false;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AcercaDe";
            this.Resizable = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnAcercaDeKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox imgLogo;
        internal MetroFramework.Controls.MetroLabel lblVersión;
        internal MetroFramework.Controls.MetroButton btnAceptar;
        private System.Windows.Forms.TextBox txtDescripción;
    }
}