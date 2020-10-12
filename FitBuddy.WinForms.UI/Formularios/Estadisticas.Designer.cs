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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Masa Corporal (IMC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Índice de Grasa Corporal (IGC)";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(64, 118);
            this.lblImc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(66, 32);
            this.lblImc.TabIndex = 2;
            this.lblImc.Text = "IMC";
            // 
            // lblIgc
            // 
            this.lblIgc.AutoSize = true;
            this.lblIgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgc.Location = new System.Drawing.Point(60, 249);
            this.lblIgc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIgc.Name = "lblIgc";
            this.lblIgc.Size = new System.Drawing.Size(63, 31);
            this.lblIgc.TabIndex = 3;
            this.lblIgc.Text = "IGC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Métricas del usuario:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(146, 29);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(43, 13);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Usuario";
            // 
            // lblImcClasificación
            // 
            this.lblImcClasificación.AutoSize = true;
            this.lblImcClasificación.Location = new System.Drawing.Point(70, 154);
            this.lblImcClasificación.Name = "lblImcClasificación";
            this.lblImcClasificación.Size = new System.Drawing.Size(66, 13);
            this.lblImcClasificación.TabIndex = 6;
            this.lblImcClasificación.Text = "Clasificación";
            // 
            // Estadísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 384);
            this.Controls.Add(this.lblImcClasificación);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIgc);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}