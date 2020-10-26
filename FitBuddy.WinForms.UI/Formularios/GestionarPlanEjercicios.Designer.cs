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
            this.btnAtras.Location = new System.Drawing.Point(493, 336);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(64, 46);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(211, 313);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearPlan
            // 
            this.btnCrearPlan.Location = new System.Drawing.Point(320, 149);
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.Size = new System.Drawing.Size(248, 42);
            this.btnCrearPlan.TabIndex = 9;
            this.btnCrearPlan.Text = "Crear Plan";
            this.btnCrearPlan.UseVisualStyleBackColor = true;
            this.btnCrearPlan.Click += new System.EventHandler(this.OnBtnCrearPlanClick);
            // 
            // btnVerPlan
            // 
            this.btnVerPlan.Location = new System.Drawing.Point(320, 197);
            this.btnVerPlan.Name = "btnVerPlan";
            this.btnVerPlan.Size = new System.Drawing.Size(248, 42);
            this.btnVerPlan.TabIndex = 8;
            this.btnVerPlan.Text = "Ver Plan";
            this.btnVerPlan.UseVisualStyleBackColor = true;
            this.btnVerPlan.Click += new System.EventHandler(this.OnBtnVerPlanClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(485, 46);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 41;
            // 
            // GestionarPlanEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(632, 405);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnCrearPlan);
            this.Controls.Add(this.btnVerPlan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionarPlanEjercicios";
            this.Text = "GestionarPlanEjercicios";
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