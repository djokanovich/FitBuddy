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
            this.btnAtras = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearDieta = new System.Windows.Forms.Button();
            this.btnVerDieta = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.dinner_icon;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearDieta
            // 
            resources.ApplyResources(this.btnCrearDieta, "btnCrearDieta");
            this.btnCrearDieta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearDieta.Name = "btnCrearDieta";
            this.btnCrearDieta.UseVisualStyleBackColor = false;
            this.btnCrearDieta.Click += new System.EventHandler(this.OnBtnCrearDietaClick);
            // 
            // btnVerDieta
            // 
            resources.ApplyResources(this.btnVerDieta, "btnVerDieta");
            this.btnVerDieta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerDieta.Name = "btnVerDieta";
            this.btnVerDieta.UseVisualStyleBackColor = false;
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
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAtras;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnCrearDieta;
        internal System.Windows.Forms.Button btnVerDieta;
        private System.Windows.Forms.Label lblWelcome;
    }
}