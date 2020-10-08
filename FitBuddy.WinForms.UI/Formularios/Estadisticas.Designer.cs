namespace FitBuddy.WinForms.UI.Formularios
{
    partial class Estadisticas
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
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblIGC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Masa Corporal (IMC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Índice de Grasa Corporal (IGC)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(129, 226);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(0, 60);
            this.lblIMC.TabIndex = 2;
            this.lblIMC.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblIGC
            // 
            this.lblIGC.AutoSize = true;
            this.lblIGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGC.Location = new System.Drawing.Point(119, 479);
            this.lblIGC.Name = "lblIGC";
            this.lblIGC.Size = new System.Drawing.Size(0, 63);
            this.lblIGC.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Métricas del usuario:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(291, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 5;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 738);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIGC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblIGC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWelcome;
    }
}