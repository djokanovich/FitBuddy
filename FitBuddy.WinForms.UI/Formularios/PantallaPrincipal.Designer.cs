namespace FitBuddy.WinForms.UI.Formularios
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgendarTurno = new System.Windows.Forms.Button();
            this.btnReclamosSugerencias = new System.Windows.Forms.Button();
            this.btnContactarProfesional = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnGestionarPlanEjercicio = new System.Windows.Forms.Button();
            this.btnCargaDiariaEjercicios = new System.Windows.Forms.Button();
            this.btnCargaDiariaComidas = new System.Windows.Forms.Button();
            this.btnGestionarPlanAlimenticio = new System.Windows.Forms.Button();
            this.btnGestionarPerfil = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnAgendarTurno
            // 
            resources.ApplyResources(this.btnAgendarTurno, "btnAgendarTurno");
            this.btnAgendarTurno.Name = "btnAgendarTurno";
            this.btnAgendarTurno.UseVisualStyleBackColor = true;
            this.btnAgendarTurno.Click += new System.EventHandler(this.OnBtnAgendarTurnoClick);
            // 
            // btnReclamosSugerencias
            // 
            resources.ApplyResources(this.btnReclamosSugerencias, "btnReclamosSugerencias");
            this.btnReclamosSugerencias.Name = "btnReclamosSugerencias";
            this.btnReclamosSugerencias.UseVisualStyleBackColor = true;
            this.btnReclamosSugerencias.Click += new System.EventHandler(this.OnBtnReclamosSugerenciasClick);
            // 
            // btnContactarProfesional
            // 
            resources.ApplyResources(this.btnContactarProfesional, "btnContactarProfesional");
            this.btnContactarProfesional.Name = "btnContactarProfesional";
            this.btnContactarProfesional.UseVisualStyleBackColor = true;
            this.btnContactarProfesional.Click += new System.EventHandler(this.OnBtnContactarProfesionalClick);
            // 
            // btnEstadisticas
            // 
            resources.ApplyResources(this.btnEstadisticas, "btnEstadisticas");
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.OnBtnEstadisticasClick);
            // 
            // btnGestionarPlanEjercicio
            // 
            resources.ApplyResources(this.btnGestionarPlanEjercicio, "btnGestionarPlanEjercicio");
            this.btnGestionarPlanEjercicio.Name = "btnGestionarPlanEjercicio";
            this.btnGestionarPlanEjercicio.UseVisualStyleBackColor = true;
            this.btnGestionarPlanEjercicio.Click += new System.EventHandler(this.OnBtnGestionarPlanEjercicioClick);
            // 
            // btnCargaDiariaEjercicios
            // 
            resources.ApplyResources(this.btnCargaDiariaEjercicios, "btnCargaDiariaEjercicios");
            this.btnCargaDiariaEjercicios.Name = "btnCargaDiariaEjercicios";
            this.btnCargaDiariaEjercicios.UseVisualStyleBackColor = true;
            this.btnCargaDiariaEjercicios.Click += new System.EventHandler(this.OnBtnCargaDiariaEjerciciosClick);
            // 
            // btnCargaDiariaComidas
            // 
            resources.ApplyResources(this.btnCargaDiariaComidas, "btnCargaDiariaComidas");
            this.btnCargaDiariaComidas.Name = "btnCargaDiariaComidas";
            this.btnCargaDiariaComidas.UseVisualStyleBackColor = true;
            this.btnCargaDiariaComidas.Click += new System.EventHandler(this.OnBtnCargaDiariaComidasClick);
            // 
            // btnGestionarPlanAlimenticio
            // 
            resources.ApplyResources(this.btnGestionarPlanAlimenticio, "btnGestionarPlanAlimenticio");
            this.btnGestionarPlanAlimenticio.Name = "btnGestionarPlanAlimenticio";
            this.btnGestionarPlanAlimenticio.UseVisualStyleBackColor = true;
            this.btnGestionarPlanAlimenticio.Click += new System.EventHandler(this.OnBtnGestionarPlanAlimenticioClick);
            // 
            // btnGestionarPerfil
            // 
            resources.ApplyResources(this.btnGestionarPerfil, "btnGestionarPerfil");
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.UseVisualStyleBackColor = true;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.OnBtnGestionarPerfilClick);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // btnBackup
            // 
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.OnBtnBackupClick);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnBtnLogoutClick);
            // 
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnAgendarTurno);
            this.Controls.Add(this.btnReclamosSugerencias);
            this.Controls.Add(this.btnContactarProfesional);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnGestionarPlanEjercicio);
            this.Controls.Add(this.btnCargaDiariaEjercicios);
            this.Controls.Add(this.btnCargaDiariaComidas);
            this.Controls.Add(this.btnGestionarPlanAlimenticio);
            this.Controls.Add(this.btnGestionarPerfil);
            this.Name = "PantallaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnAgendarTurno;
        internal System.Windows.Forms.Button btnReclamosSugerencias;
        internal System.Windows.Forms.Button btnContactarProfesional;
        internal System.Windows.Forms.Button btnEstadisticas;
        internal System.Windows.Forms.Button btnGestionarPlanEjercicio;
        internal System.Windows.Forms.Button btnCargaDiariaEjercicios;
        internal System.Windows.Forms.Button btnCargaDiariaComidas;
        internal System.Windows.Forms.Button btnGestionarPlanAlimenticio;
        internal System.Windows.Forms.Button btnGestionarPerfil;
        private System.Windows.Forms.Label lblWelcome;
        internal System.Windows.Forms.Button btnBackup;
        internal System.Windows.Forms.Button btnLogout;
    }
}