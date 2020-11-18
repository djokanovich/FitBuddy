namespace FitBuddy.WinForms.UI.Formularios
{
    partial class AgendarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarTurno));
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.btnEnviar = new MetroFramework.Controls.MetroButton();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
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
            // btnEnviar
            // 
            this.btnEnviar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEnviar.Highlight = true;
            resources.ApplyResources(this.btnEnviar, "btnEnviar");
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.OnBtnEnviarClick);
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMedico, "cmbMedico");
            this.cmbMedico.Name = "cmbMedico";
            // 
            // cmbFranjaHoraria
            // 
            this.cmbFranjaHoraria.FormattingEnabled = true;
            resources.ApplyResources(this.cmbFranjaHoraria, "cmbFranjaHoraria");
            this.cmbFranjaHoraria.Name = "cmbFranjaHoraria";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // dtpFecha
            // 
            resources.ApplyResources(this.dtpFecha, "dtpFecha");
            this.dtpFecha.Name = "dtpFecha";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // PictureBox1
            // 
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // AgendarTurno
            // 
            this.AcceptButton = this.btnEnviar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.cmbFranjaHoraria);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "AgendarTurno";
            this.Load += new System.EventHandler(this.OnAgendarTurnoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroButton btnAtras;
        internal MetroFramework.Controls.MetroButton btnEnviar;
        internal System.Windows.Forms.ComboBox cmbMedico;
        internal System.Windows.Forms.ComboBox cmbFranjaHoraria;
        internal MetroFramework.Controls.MetroLabel Label3;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal MetroFramework.Controls.MetroLabel Label2;
        internal MetroFramework.Controls.MetroLabel Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private MetroFramework.Controls.MetroLabel lblWelcome;
    }
}