﻿namespace FitBuddy.WinForms.UI.Formularios
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
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.lblImc = new MetroFramework.Controls.MetroLabel();
            this.lblIgc = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.lblImcClasificación = new MetroFramework.Controls.MetroLabel();
            this.lblIgcClasificacion = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.picAguja = new System.Windows.Forms.PictureBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.btnVerMás = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label2.Name = "label2";
            // 
            // lblImc
            // 
            resources.ApplyResources(this.lblImc, "lblImc");
            this.lblImc.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImc.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblImc.Name = "lblImc";
            // 
            // lblIgc
            // 
            resources.ApplyResources(this.lblIgc, "lblIgc");
            this.lblIgc.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIgc.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIgc.Name = "lblIgc";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblImcClasificación
            // 
            resources.ApplyResources(this.lblImcClasificación, "lblImcClasificación");
            this.lblImcClasificación.Name = "lblImcClasificación";
            this.lblImcClasificación.WrapToLine = true;
            // 
            // lblIgcClasificacion
            // 
            resources.ApplyResources(this.lblIgcClasificacion, "lblIgcClasificacion");
            this.lblIgcClasificacion.Name = "lblIgcClasificacion";
            this.lblIgcClasificacion.WrapToLine = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.OnBtnCerrarClick);
            // 
            // picAguja
            // 
            this.picAguja.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picAguja, "picAguja");
            this.picAguja.Name = "picAguja";
            this.picAguja.TabStop = false;
            // 
            // picFondo
            // 
            resources.ApplyResources(this.picFondo, "picFondo");
            this.picFondo.Name = "picFondo";
            this.picFondo.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.WrapToLine = true;
            // 
            // btnVerMás
            // 
            this.btnVerMás.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVerMás.Highlight = true;
            resources.ApplyResources(this.btnVerMás, "btnVerMás");
            this.btnVerMás.Name = "btnVerMás";
            this.btnVerMás.UseSelectable = true;
            this.btnVerMás.Click += new System.EventHandler(this.OnBtnVerMásClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Estadísticas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerMás);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.picAguja);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.lblIgcClasificacion);
            this.Controls.Add(this.lblImcClasificación);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIgc);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadísticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAguja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel lblImc;
        private MetroFramework.Controls.MetroLabel lblIgc;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroLabel lblImcClasificación;
        private MetroFramework.Controls.MetroLabel lblIgcClasificacion;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.PictureBox picAguja;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroButton btnVerMás;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}