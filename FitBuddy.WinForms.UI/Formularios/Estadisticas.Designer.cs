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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.picAguja = new System.Windows.Forms.PictureBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerMás = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Masa Corporal (IMC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Índice de Grasa Corporal (IGC)";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(27, 151);
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
            this.lblIgc.Location = new System.Drawing.Point(27, 305);
            this.lblIgc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIgc.Name = "lblIgc";
            this.lblIgc.Size = new System.Drawing.Size(63, 31);
            this.lblIgc.TabIndex = 3;
            this.lblIgc.Text = "IGC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Métricas del usuario:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(22, 28);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(43, 13);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Usuario";
            // 
            // lblImcClasificación
            // 
            this.lblImcClasificación.AutoSize = true;
            this.lblImcClasificación.Location = new System.Drawing.Point(27, 200);
            this.lblImcClasificación.Name = "lblImcClasificación";
            this.lblImcClasificación.Size = new System.Drawing.Size(66, 13);
            this.lblImcClasificación.TabIndex = 6;
            this.lblImcClasificación.Text = "Clasificación";
            // 
            // lblIgcClasificacion
            // 
            this.lblIgcClasificacion.AutoSize = true;
            this.lblIgcClasificacion.Location = new System.Drawing.Point(27, 356);
            this.lblIgcClasificacion.Name = "lblIgcClasificacion";
            this.lblIgcClasificacion.Size = new System.Drawing.Size(66, 13);
            this.lblIgcClasificacion.TabIndex = 7;
            this.lblIgcClasificacion.Text = "Clasificación";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(110, 394);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.OnBtnCerrarClick);
            // 
            // picAguja
            // 
            this.picAguja.BackColor = System.Drawing.Color.Transparent;
            this.picAguja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAguja.InitialImage = null;
            this.picAguja.Location = new System.Drawing.Point(368, 174);
            this.picAguja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAguja.Name = "picAguja";
            this.picAguja.Size = new System.Drawing.Size(248, 126);
            this.picAguja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAguja.TabIndex = 9;
            this.picAguja.TabStop = false;
            // 
            // picFondo
            // 
            this.picFondo.Location = new System.Drawing.Point(320, 83);
            this.picFondo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(248, 176);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 8;
            this.picFondo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(10, 31);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 490);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Escaneá para entender las variables del cálculo";
            // 
            // btnVerMás
            // 
            this.btnVerMás.Location = new System.Drawing.Point(30, 394);
            this.btnVerMás.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerMás.Name = "btnVerMás";
            this.btnVerMás.Size = new System.Drawing.Size(70, 23);
            this.btnVerMás.TabIndex = 15;
            this.btnVerMás.Text = "Ver más";
            this.btnVerMás.UseVisualStyleBackColor = true;
            this.btnVerMás.Click += new System.EventHandler(this.OnBtnVerMásClick);
            // 
            // Estadísticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(595, 531);
            this.Controls.Add(this.btnVerMás);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Estadísticas";
            this.Padding = new System.Windows.Forms.Padding(10, 31, 10, 10);
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerMás;
    }
}