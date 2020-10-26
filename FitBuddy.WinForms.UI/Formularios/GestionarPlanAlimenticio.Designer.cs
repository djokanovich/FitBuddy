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
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.Location = new System.Drawing.Point(476, 325);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(47, 35);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(211, 313);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // btnCrearDieta
            // 
            this.btnCrearDieta.Location = new System.Drawing.Point(303, 138);
            this.btnCrearDieta.Name = "btnCrearDieta";
            this.btnCrearDieta.Size = new System.Drawing.Size(248, 42);
            this.btnCrearDieta.TabIndex = 1;
            this.btnCrearDieta.Text = "Crear Dieta";
            this.btnCrearDieta.UseVisualStyleBackColor = true;
            this.btnCrearDieta.Click += new System.EventHandler(this.OnBtnCrearDietaClick);
            // 
            // btnVerDieta
            // 
            this.btnVerDieta.Location = new System.Drawing.Point(303, 186);
            this.btnVerDieta.Name = "btnVerDieta";
            this.btnVerDieta.Size = new System.Drawing.Size(248, 42);
            this.btnVerDieta.TabIndex = 2;
            this.btnVerDieta.Text = "Ver Dieta";
            this.btnVerDieta.UseVisualStyleBackColor = true;
            this.btnVerDieta.Click += new System.EventHandler(this.OnBtnVerDietaClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(300, 35);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(60, 13);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Bienvenido";
            // 
            // GestionarPlanAlimenticio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(605, 385);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnCrearDieta);
            this.Controls.Add(this.btnVerDieta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionarPlanAlimenticio";
            this.Text = "Gestionar plan alimenticio";
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