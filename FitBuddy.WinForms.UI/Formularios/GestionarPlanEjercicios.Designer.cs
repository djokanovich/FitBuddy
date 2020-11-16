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
            this.btnAtras = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearPlan = new System.Windows.Forms.Button();
            this.btnVerPlan = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources._542ec68513d564e12f422d96d739da49;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearPlan
            // 
            resources.ApplyResources(this.btnCrearPlan, "btnCrearPlan");
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.UseVisualStyleBackColor = true;
            this.btnCrearPlan.Click += new System.EventHandler(this.OnBtnCrearPlanClick);
            // 
            // btnVerPlan
            // 
            resources.ApplyResources(this.btnVerPlan, "btnVerPlan");
            this.btnVerPlan.Name = "btnVerPlan";
            this.btnVerPlan.UseVisualStyleBackColor = true;
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
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAtras;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnCrearPlan;
        internal System.Windows.Forms.Button btnVerPlan;
        private System.Windows.Forms.Label lblWelcome;
    }
}