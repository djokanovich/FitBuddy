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
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(27, 74);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(189, 64);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 19;
            this.PictureBox1.TabStop = false;
            // 
            // btnAgendarTurno
            // 
            this.btnAgendarTurno.Location = new System.Drawing.Point(235, 218);
            this.btnAgendarTurno.Name = "btnAgendarTurno";
            this.btnAgendarTurno.Size = new System.Drawing.Size(179, 23);
            this.btnAgendarTurno.TabIndex = 9;
            this.btnAgendarTurno.Text = "Agendar Turno";
            this.btnAgendarTurno.UseVisualStyleBackColor = true;
            this.btnAgendarTurno.Click += new System.EventHandler(this.OnBtnAgendarTurnoClick);
            // 
            // btnReclamosSugerencias
            // 
            this.btnReclamosSugerencias.Location = new System.Drawing.Point(235, 190);
            this.btnReclamosSugerencias.Name = "btnReclamosSugerencias";
            this.btnReclamosSugerencias.Size = new System.Drawing.Size(179, 23);
            this.btnReclamosSugerencias.TabIndex = 8;
            this.btnReclamosSugerencias.Text = "Reclamos y Sugerencias";
            this.btnReclamosSugerencias.UseVisualStyleBackColor = true;
            this.btnReclamosSugerencias.Click += new System.EventHandler(this.OnBtnReclamosSugerenciasClick);
            // 
            // btnContactarProfesional
            // 
            this.btnContactarProfesional.Location = new System.Drawing.Point(235, 161);
            this.btnContactarProfesional.Name = "btnContactarProfesional";
            this.btnContactarProfesional.Size = new System.Drawing.Size(179, 23);
            this.btnContactarProfesional.TabIndex = 7;
            this.btnContactarProfesional.Text = "Contactar Profesional";
            this.btnContactarProfesional.UseVisualStyleBackColor = true;
            this.btnContactarProfesional.Click += new System.EventHandler(this.OnBtnContactarProfesionalClick);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(235, 131);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(179, 23);
            this.btnEstadisticas.TabIndex = 6;
            this.btnEstadisticas.Text = "Mis Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.OnBtnEstadisticasClick);
            // 
            // btnGestionarPlanEjercicio
            // 
            this.btnGestionarPlanEjercicio.Location = new System.Drawing.Point(27, 247);
            this.btnGestionarPlanEjercicio.Name = "btnGestionarPlanEjercicio";
            this.btnGestionarPlanEjercicio.Size = new System.Drawing.Size(189, 23);
            this.btnGestionarPlanEjercicio.TabIndex = 3;
            this.btnGestionarPlanEjercicio.Text = "Gestionar Plan de Ejercicio";
            this.btnGestionarPlanEjercicio.UseVisualStyleBackColor = true;
            this.btnGestionarPlanEjercicio.Click += new System.EventHandler(this.OnBtnGestionarPlanEjercicioClick);
            // 
            // btnCargaDiariaEjercicios
            // 
            this.btnCargaDiariaEjercicios.Location = new System.Drawing.Point(235, 102);
            this.btnCargaDiariaEjercicios.Name = "btnCargaDiariaEjercicios";
            this.btnCargaDiariaEjercicios.Size = new System.Drawing.Size(179, 23);
            this.btnCargaDiariaEjercicios.TabIndex = 5;
            this.btnCargaDiariaEjercicios.Text = "Carga Diaria de Ejercicios";
            this.btnCargaDiariaEjercicios.UseVisualStyleBackColor = true;
            this.btnCargaDiariaEjercicios.Click += new System.EventHandler(this.OnBtnCargaDiariaEjerciciosClick);
            // 
            // btnCargaDiariaComidas
            // 
            this.btnCargaDiariaComidas.Location = new System.Drawing.Point(235, 73);
            this.btnCargaDiariaComidas.Name = "btnCargaDiariaComidas";
            this.btnCargaDiariaComidas.Size = new System.Drawing.Size(179, 23);
            this.btnCargaDiariaComidas.TabIndex = 4;
            this.btnCargaDiariaComidas.Text = "Carga Diaria de Comidas";
            this.btnCargaDiariaComidas.UseVisualStyleBackColor = true;
            this.btnCargaDiariaComidas.Click += new System.EventHandler(this.OnBtnCargaDiariaComidasClick);
            // 
            // btnGestionarPlanAlimenticio
            // 
            this.btnGestionarPlanAlimenticio.Location = new System.Drawing.Point(27, 218);
            this.btnGestionarPlanAlimenticio.Name = "btnGestionarPlanAlimenticio";
            this.btnGestionarPlanAlimenticio.Size = new System.Drawing.Size(189, 23);
            this.btnGestionarPlanAlimenticio.TabIndex = 2;
            this.btnGestionarPlanAlimenticio.Text = "Gestionar Plan Alimeticio";
            this.btnGestionarPlanAlimenticio.UseVisualStyleBackColor = true;
            this.btnGestionarPlanAlimenticio.Click += new System.EventHandler(this.OnBtnGestionarPlanAlimenticioClick);
            // 
            // btnGestionarPerfil
            // 
            this.btnGestionarPerfil.Location = new System.Drawing.Point(27, 189);
            this.btnGestionarPerfil.Name = "btnGestionarPerfil";
            this.btnGestionarPerfil.Size = new System.Drawing.Size(189, 23);
            this.btnGestionarPerfil.TabIndex = 1;
            this.btnGestionarPerfil.Text = "Gestionar Perfil";
            this.btnGestionarPerfil.UseVisualStyleBackColor = true;
            this.btnGestionarPerfil.Click += new System.EventHandler(this.OnBtnGestionarPerfilClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(27, 24);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(387, 13);
            this.lblWelcome.TabIndex = 20;
            this.lblWelcome.Text = "Bienvenido";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(235, 247);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(179, 23);
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.OnBtnBackupClick);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(235, 328);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 23);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnBtnLogoutClick);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(441, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaPrincipal";
            this.Text = "Pantalla principal";
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