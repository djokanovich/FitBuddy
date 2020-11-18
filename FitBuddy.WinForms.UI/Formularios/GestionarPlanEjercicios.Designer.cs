namespace FitBuddy.WinForms.UI.Formularios
{
    partial class GestionarPlanEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPlanEjercicios));
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearPlan = new MetroFramework.Controls.MetroButton();
            this.btnVerPlan = new MetroFramework.Controls.MetroButton();
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
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.PlanEjercicios;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearPlan
            // 
            this.btnCrearPlan.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnCrearPlan, "btnCrearPlan");
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.UseSelectable = true;
            this.btnCrearPlan.Click += new System.EventHandler(this.OnBtnCrearPlanClick);
            // 
            // btnVerPlan
            // 
            this.btnVerPlan.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnVerPlan, "btnVerPlan");
            this.btnVerPlan.Name = "btnVerPlan";
            this.btnVerPlan.UseSelectable = true;
            this.btnVerPlan.Click += new System.EventHandler(this.OnBtnVerPlanClick);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // GestionarPlanEjercicios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnCrearPlan);
            this.Controls.Add(this.btnVerPlan);
            this.Name = "GestionarPlanEjercicios";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroButton btnAtras;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal MetroFramework.Controls.MetroButton btnCrearPlan;
        internal MetroFramework.Controls.MetroButton btnVerPlan;
        private MetroFramework.Controls.MetroLabel lblWelcome;
    }
}