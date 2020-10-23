namespace FitBuddy.WinForms.UI.Formularios
{
    partial class Estadísticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadísticas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblIgc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblImcClasificación = new System.Windows.Forms.Label();
            this.lblIgcClasificacion = new System.Windows.Forms.Label();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.picAguja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Masa Corporal (IMC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Índice de Grasa Corporal (IGC)";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(128, 227);
            this.lblImc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(121, 60);
            this.lblImc.TabIndex = 2;
            this.lblImc.Text = "IMC";
            // 
            // lblIgc
            // 
            this.lblIgc.AutoSize = true;
            this.lblIgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgc.Location = new System.Drawing.Point(120, 479);
            this.lblIgc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIgc.Name = "lblIgc";
            this.lblIgc.Size = new System.Drawing.Size(123, 63);
            this.lblIgc.TabIndex = 3;
            this.lblIgc.Text = "IGC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Métricas del usuario:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(292, 56);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 25);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Usuario";
            // 
            // lblImcClasificación
            // 
            this.lblImcClasificación.AutoSize = true;
            this.lblImcClasificación.Location = new System.Drawing.Point(140, 296);
            this.lblImcClasificación.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImcClasificación.Name = "lblImcClasificación";
            this.lblImcClasificación.Size = new System.Drawing.Size(134, 25);
            this.lblImcClasificación.TabIndex = 6;
            this.lblImcClasificación.Text = "Clasificación";
            // 
            // lblIgcClasificacion
            // 
            this.lblIgcClasificacion.AutoSize = true;
            this.lblIgcClasificacion.Location = new System.Drawing.Point(136, 542);
            this.lblIgcClasificacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIgcClasificacion.Name = "lblIgcClasificacion";
            this.lblIgcClasificacion.Size = new System.Drawing.Size(134, 25);
            this.lblIgcClasificacion.TabIndex = 7;
            this.lblIgcClasificacion.Text = "Clasificación";
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(569, 141);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(496, 338);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 8;
            this.picFondo.TabStop = false;
            // 
            // picAguja
            // 
            this.picAguja.BackColor = System.Drawing.Color.Transparent;
            this.picAguja.Image = ((System.Drawing.Image)(resources.GetObject("picAguja.Image")));
            this.picAguja.Location = new System.Drawing.Point(775, 259);
            this.picAguja.Name = "picAguja";
            this.picAguja.Size = new System.Drawing.Size(150, 220);
            this.picAguja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAguja.TabIndex = 9;
            this.picAguja.TabStop = false;
            // 
            // Estadísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 854);
            this.Controls.Add(this.picAguja);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.lblIgcClasificacion);
            this.Controls.Add(this.lblImcClasificación);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIgc);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Estadísticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblIgc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblImcClasificación;
        private System.Windows.Forms.Label lblIgcClasificacion;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.PictureBox picAguja;
    }
}