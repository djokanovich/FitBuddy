namespace FitBuddy.WinForms.UI.Formularios
{
    partial class GestionarPlanAlimenticio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPlanAlimenticio));
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearDieta = new MetroFramework.Controls.MetroButton();
            this.btnVerDieta = new MetroFramework.Controls.MetroButton();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseSelectable = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.PlanAlimenticio;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearDieta
            // 
            this.btnCrearDieta.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnCrearDieta, "btnCrearDieta");
            this.btnCrearDieta.Name = "btnCrearDieta";
            this.btnCrearDieta.UseSelectable = true;
            this.btnCrearDieta.Click += new System.EventHandler(this.OnBtnCrearDietaClick);
            // 
            // btnVerDieta
            // 
            this.btnVerDieta.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnVerDieta, "btnVerDieta");
            this.btnVerDieta.Name = "btnVerDieta";
            this.btnVerDieta.UseSelectable = true;
            this.btnVerDieta.Click += new System.EventHandler(this.OnBtnVerDietaClick);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // GestionarPlanAlimenticio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnCrearDieta);
            this.Controls.Add(this.btnVerDieta);
            this.Name = "GestionarPlanAlimenticio";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroButton btnAtras;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal MetroFramework.Controls.MetroButton btnCrearDieta;
        internal MetroFramework.Controls.MetroButton btnVerDieta;
        private MetroFramework.Controls.MetroLabel lblWelcome;
    }
}