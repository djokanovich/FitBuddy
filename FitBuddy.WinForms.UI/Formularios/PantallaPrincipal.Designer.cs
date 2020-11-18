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
            this.btnAgendarTurno = new MetroFramework.Controls.MetroButton();
            this.btnReclamosSugerencias = new MetroFramework.Controls.MetroButton();
            this.btnContactarProfesional = new MetroFramework.Controls.MetroButton();
            this.btnEstadisticas = new MetroFramework.Controls.MetroButton();
            this.btnGestionarPlanEjercicio = new MetroFramework.Controls.MetroButton();
            this.btnCargaDiariaEjercicios = new MetroFramework.Controls.MetroButton();
            this.btnCargaDiariaComidas = new MetroFramework.Controls.MetroButton();
            this.btnGestionarPlanAlimenticio = new MetroFramework.Controls.MetroButton();
            this.btnGestionarPerfil = new MetroFramework.Controls.MetroButton();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnConfiguración = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.FitBuddy;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // btnAgendarTurno
            // 
            resources.ApplyResources(this.btnAgendarTurno, "btnAgendarTurno");
            this.btnAgendarTurno.Name = "btnAgendarTurno";
            this.btnAgendarTurno.UseSelectable = true;
            this.btnAgendarTurno.Click += new System.EventHandler(this.OnBtnAgendarTurnoClick);
            // 
            // btnReclamosSugerencias
            // 
            resources.ApplyResources(this.btnReclamosSugerencias, "btnReclamosSugerencias");
            this.btnReclamosSugerencias.Name = "btnReclamosSugerencias";
            this.btnReclamosSugerencias.UseSelectable = true;
            this.btnReclamosSugerencias.Click += new System.EventHandler(this.OnBtnReclamosSugerenciasClick);
            // 
            // btnContactarProfesional
            // 
            resources.ApplyResources(this.btnContactarProfesional, "btnContactarProfesional");
            this.btnContactarProfesional.Name = "btnContactarProfesional";
            this.btnContactarProfesional.UseSelectable = true;
            this.btnContactarProfesional.Click += new System.EventHandler(this.OnBtnContactarProfesionalClick);
            // 
            // btnEstadisticas
            // 
            resources.ApplyResources(this.btnEstadisticas, "btnEstadisticas");
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.UseSelectable = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.OnBtnEstadisticasClick);
            // 
            // btnGestionarPlanEjercicio
            // 
            resources.ApplyResources(this.btnGestionarPlanEjercicio, "btnGestionarPlanEjercicio");
            this.btnGestionarPlanEjercicio.Name = "btnGestionarPlanEjercicio";
            this.btnGestionarPlanEjercicio.UseSelectable = true;
            this.btnGestionarPlanEjercicio.Click += new System.EventHandler(this.OnBtnGestionarPlanEjercicioClick);
            // 
            // btnCargaDiariaEjercicios
            // 
            resources.ApplyResources(this.btnCargaDiariaEjercicios, "btnCargaDiariaEjercicios");
            this.btnCargaDiariaEjercicios.Name = "btnCargaDiariaEjercicios";
            this.btnCargaDiariaEjercicios.UseSelectable = true;
            this.btnCargaDiariaEjercicios.Click += new System.EventHandler(this.OnBtnCargaDiariaEjerciciosClick);
            // 
            // btnCargaDiariaComidas
            // 
            resources.ApplyResources(this.btnCargaDiariaComidas, "btnCargaDiariaComidas");
            this.btnCargaDiariaComidas.Name = "btnCargaDiariaComidas";
            this.btnCargaDiariaComidas.UseSelectable = true;
            this.btnCargaDiariaComidas.Click += new System.EventHandler(this.OnBtnCargaDiariaComidasClick);
            // 
            // btnGestionarPlanAlimenticio
            // 
            resources.ApplyResources(this.btnGestionarPlanAlimenticio, "btnGestionarPlanAlimenticio");
            this.btnGestionarPlanAlimenticio.Name = "btnGestionarPlanAlimenticio";
            this.btnGestionarPlanAlimenticio.UseSelectable = true;
            this.btnGestionarPlanAlimenticio.Click += new System.EventHandler(this.OnBtnGestionarPlanAlimenticioClick);
            // 
            // btnGestionarPerfil
            // 
            resources.ApplyResources(this.btnGestionarPerfil, "btnGestionarPerfil");
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.UseSelectable = true;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.OnBtnGestionarPerfilClick);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.OnBtnLogoutClick);
            // 
            // btnConfiguración
            // 
            resources.ApplyResources(this.btnConfiguración, "btnConfiguración");
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.UseSelectable = true;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.Controls.Add(this.btnConfiguración);
            this.Controls.Add(this.btnLogout);
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
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal MetroFramework.Controls.MetroButton btnAgendarTurno;
        internal MetroFramework.Controls.MetroButton btnReclamosSugerencias;
        internal MetroFramework.Controls.MetroButton btnContactarProfesional;
        internal MetroFramework.Controls.MetroButton btnEstadisticas;
        internal MetroFramework.Controls.MetroButton btnGestionarPlanEjercicio;
        internal MetroFramework.Controls.MetroButton btnCargaDiariaEjercicios;
        internal MetroFramework.Controls.MetroButton btnCargaDiariaComidas;
        internal MetroFramework.Controls.MetroButton btnGestionarPlanAlimenticio;
        internal MetroFramework.Controls.MetroButton btnGestionarPerfil;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        internal MetroFramework.Controls.MetroButton btnLogout;
        internal MetroFramework.Controls.MetroButton btnConfiguración;
    }
}