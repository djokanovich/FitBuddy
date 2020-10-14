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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblIgc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblImcClasificación = new System.Windows.Forms.Label();
            this.lblClasificacionIGC = new System.Windows.Forms.Label();
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
            // lblClasificacionIGC
            // 
            this.lblClasificacionIGC.AutoSize = true;
            this.lblClasificacionIGC.Location = new System.Drawing.Point(136, 542);
            this.lblClasificacionIGC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClasificacionIGC.Name = "lblClasificacionIGC";
            this.lblClasificacionIGC.Size = new System.Drawing.Size(134, 25);
            this.lblClasificacionIGC.TabIndex = 7;
            this.lblClasificacionIGC.Text = "Clasificación";
            // 
            // Estadísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 738);
            this.Controls.Add(this.lblClasificacionIGC);
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
        private System.Windows.Forms.Label lblClasificacionIGC;
    }
}