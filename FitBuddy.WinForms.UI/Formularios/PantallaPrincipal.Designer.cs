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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCargaDiariaComidas = new System.Windows.Forms.Button();
            this.btnContactarProfesional = new System.Windows.Forms.Button();
            this.btnGestionarPlanEjercicio = new System.Windows.Forms.Button();
            this.btnAgendarTurno = new System.Windows.Forms.Button();
            this.btnReclamosSugerencias = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnCargaDiariaEjercicios = new System.Windows.Forms.Button();
            this.btnGestionarPlanAlimenticio = new System.Windows.Forms.Button();
            this.btnGestionarPerfil = new System.Windows.Forms.Button();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.Fitbuddy;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.OnBtnLogoutClick);
            // 
            // btnCargaDiariaComidas
            // 
            this.btnCargaDiariaComidas.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnCargaDiariaComidas, "btnCargaDiariaComidas");
            this.btnCargaDiariaComidas.Name = "btnCargaDiariaComidas";
            this.btnCargaDiariaComidas.UseVisualStyleBackColor = false;
            this.btnCargaDiariaComidas.Click += new System.EventHandler(this.OnBtnCargaDiariaComidasClick);
            // 
            // btnContactarProfesional
            // 
            this.btnContactarProfesional.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnContactarProfesional, "btnContactarProfesional");
            this.btnContactarProfesional.Name = "btnContactarProfesional";
            this.btnContactarProfesional.UseVisualStyleBackColor = false;
            this.btnContactarProfesional.Click += new System.EventHandler(this.OnBtnContactarProfesionalClick);
            // 
            // btnGestionarPlanEjercicio
            // 
            this.btnGestionarPlanEjercicio.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnGestionarPlanEjercicio, "btnGestionarPlanEjercicio");
            this.btnGestionarPlanEjercicio.Name = "btnGestionarPlanEjercicio";
            this.btnGestionarPlanEjercicio.UseVisualStyleBackColor = false;
            this.btnGestionarPlanEjercicio.Click += new System.EventHandler(this.OnBtnGestionarPlanEjercicioClick);
            // 
            // btnAgendarTurno
            // 
            this.btnAgendarTurno.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnAgendarTurno, "btnAgendarTurno");
            this.btnAgendarTurno.Name = "btnAgendarTurno";
            this.btnAgendarTurno.UseVisualStyleBackColor = false;
            this.btnAgendarTurno.Click += new System.EventHandler(this.OnBtnAgendarTurnoClick);
            // 
            // btnReclamosSugerencias
            // 
            this.btnReclamosSugerencias.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnReclamosSugerencias, "btnReclamosSugerencias");
            this.btnReclamosSugerencias.Name = "btnReclamosSugerencias";
            this.btnReclamosSugerencias.UseVisualStyleBackColor = false;
            this.btnReclamosSugerencias.Click += new System.EventHandler(this.OnBtnReclamosSugerenciasClick);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnEstadisticas, "btnEstadisticas");
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.OnBtnEstadisticasClick);
            // 
            // btnCargaDiariaEjercicios
            // 
            this.btnCargaDiariaEjercicios.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnCargaDiariaEjercicios, "btnCargaDiariaEjercicios");
            this.btnCargaDiariaEjercicios.Name = "btnCargaDiariaEjercicios";
            this.btnCargaDiariaEjercicios.UseVisualStyleBackColor = false;
            this.btnCargaDiariaEjercicios.Click += new System.EventHandler(this.OnBtnCargaDiariaEjerciciosClick);
            // 
            // btnGestionarPlanAlimenticio
            // 
            this.btnGestionarPlanAlimenticio.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnGestionarPlanAlimenticio, "btnGestionarPlanAlimenticio");
            this.btnGestionarPlanAlimenticio.Name = "btnGestionarPlanAlimenticio";
            this.btnGestionarPlanAlimenticio.UseVisualStyleBackColor = false;
            this.btnGestionarPlanAlimenticio.Click += new System.EventHandler(this.OnBtnGestionarPlanAlimenticioClick);
            // 
            // btnGestionarPerfil
            // 
            this.btnGestionarPerfil.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnGestionarPerfil, "btnGestionarPerfil");
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.UseVisualStyleBackColor = false;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.OnBtnGestionarPerfilClick);
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnConfiguración, "btnConfiguración");
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.UseVisualStyleBackColor = false;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfiguración);
            this.panel1.Controls.Add(this.btnGestionarPerfil);
            this.panel1.Controls.Add(this.btnGestionarPlanAlimenticio);
            this.panel1.Controls.Add(this.btnCargaDiariaEjercicios);
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Controls.Add(this.btnReclamosSugerencias);
            this.panel1.Controls.Add(this.btnAgendarTurno);
            this.panel1.Controls.Add(this.btnGestionarPlanEjercicio);
            this.panel1.Controls.Add(this.btnContactarProfesional);
            this.panel1.Controls.Add(this.btnCargaDiariaComidas);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PantallaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipal";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button btnCargaDiariaComidas;
        internal System.Windows.Forms.Button btnContactarProfesional;
        internal System.Windows.Forms.Button btnGestionarPlanEjercicio;
        internal System.Windows.Forms.Button btnAgendarTurno;
        internal System.Windows.Forms.Button btnReclamosSugerencias;
        internal System.Windows.Forms.Button btnEstadisticas;
        internal System.Windows.Forms.Button btnCargaDiariaEjercicios;
        internal System.Windows.Forms.Button btnGestionarPlanAlimenticio;
        internal System.Windows.Forms.Button btnGestionarPerfil;
        internal System.Windows.Forms.Button btnConfiguración;
        private System.Windows.Forms.Panel panel1;
    }
}