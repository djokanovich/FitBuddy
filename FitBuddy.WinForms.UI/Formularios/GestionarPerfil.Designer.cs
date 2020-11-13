namespace FitBuddy.WinForms.UI.Formularios
{
    partial class GestionarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPerfil));
            this.btnAtras = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.bntLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBrazo = new System.Windows.Forms.MaskedTextBox();
            this.txtMuslo = new System.Windows.Forms.MaskedTextBox();
            this.txtCadera = new System.Windows.Forms.MaskedTextBox();
            this.txtCintura = new System.Windows.Forms.MaskedTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lnkInstrucciones = new System.Windows.Forms.LinkLabel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxSexo = new System.Windows.Forms.GroupBox();
            this.radBtnFemenino = new System.Windows.Forms.RadioButton();
            this.radBtnMasculino = new System.Windows.Forms.RadioButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRegistroAnterior = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.grpBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnAtras, "btnAtras");
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // Label15
            // 
            resources.ApplyResources(this.Label15, "Label15");
            this.Label15.Name = "Label15";
            // 
            // dtpFechaRegistro
            // 
            resources.ApplyResources(this.dtpFechaRegistro, "dtpFechaRegistro");
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            // 
            // bntLimpiar
            // 
            resources.ApplyResources(this.bntLimpiar, "bntLimpiar");
            this.bntLimpiar.Name = "bntLimpiar";
            this.bntLimpiar.UseVisualStyleBackColor = true;
            this.bntLimpiar.Click += new System.EventHandler(this.OnBtnLimpiarClick);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.OnBtnGuardarClick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.label13);
            this.GroupBox2.Controls.Add(this.txtBrazo);
            this.GroupBox2.Controls.Add(this.txtMuslo);
            this.GroupBox2.Controls.Add(this.txtCadera);
            this.GroupBox2.Controls.Add(this.txtCintura);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.lnkInstrucciones);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            resources.ApplyResources(this.GroupBox2, "GroupBox2");
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtBrazo
            // 
            this.txtBrazo.BeepOnError = true;
            resources.ApplyResources(this.txtBrazo, "txtBrazo");
            this.txtBrazo.Name = "txtBrazo";
            this.txtBrazo.ValidatingType = typeof(int);
            // 
            // txtMuslo
            // 
            this.txtMuslo.BeepOnError = true;
            resources.ApplyResources(this.txtMuslo, "txtMuslo");
            this.txtMuslo.Name = "txtMuslo";
            this.txtMuslo.ValidatingType = typeof(int);
            // 
            // txtCadera
            // 
            this.txtCadera.BeepOnError = true;
            resources.ApplyResources(this.txtCadera, "txtCadera");
            this.txtCadera.Name = "txtCadera";
            this.txtCadera.ValidatingType = typeof(int);
            // 
            // txtCintura
            // 
            this.txtCintura.BeepOnError = true;
            resources.ApplyResources(this.txtCintura, "txtCintura");
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.ValidatingType = typeof(int);
            // 
            // Label12
            // 
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.Name = "Label12";
            // 
            // Label11
            // 
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.Name = "Label11";
            // 
            // lnkInstrucciones
            // 
            resources.ApplyResources(this.lnkInstrucciones, "lnkInstrucciones");
            this.lnkInstrucciones.Name = "lnkInstrucciones";
            this.lnkInstrucciones.TabStop = true;
            this.lnkInstrucciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInstrucciones_LinkClicked);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblEdad);
            this.GroupBox1.Controls.Add(this.lblFechaNacimiento);
            this.GroupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.GroupBox1.Controls.Add(this.txtAltura);
            this.GroupBox1.Controls.Add(this.txtPeso);
            this.GroupBox1.Controls.Add(this.grpBoxSexo);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label3);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // lblEdad
            // 
            resources.ApplyResources(this.lblEdad, "lblEdad");
            this.lblEdad.Name = "lblEdad";
            // 
            // lblFechaNacimiento
            // 
            resources.ApplyResources(this.lblFechaNacimiento, "lblFechaNacimiento");
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            // 
            // dtpFechaNacimiento
            // 
            resources.ApplyResources(this.dtpFechaNacimiento, "dtpFechaNacimiento");
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            // 
            // txtAltura
            // 
            this.txtAltura.BeepOnError = true;
            resources.ApplyResources(this.txtAltura, "txtAltura");
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // txtPeso
            // 
            this.txtPeso.BeepOnError = true;
            resources.ApplyResources(this.txtPeso, "txtPeso");
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ValidatingType = typeof(int);
            // 
            // grpBoxSexo
            // 
            this.grpBoxSexo.Controls.Add(this.radBtnFemenino);
            this.grpBoxSexo.Controls.Add(this.radBtnMasculino);
            resources.ApplyResources(this.grpBoxSexo, "grpBoxSexo");
            this.grpBoxSexo.Name = "grpBoxSexo";
            this.grpBoxSexo.TabStop = false;
            // 
            // radBtnFemenino
            // 
            resources.ApplyResources(this.radBtnFemenino, "radBtnFemenino");
            this.radBtnFemenino.Name = "radBtnFemenino";
            this.radBtnFemenino.TabStop = true;
            this.radBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radBtnMasculino
            // 
            resources.ApplyResources(this.radBtnMasculino, "radBtnMasculino");
            this.radBtnMasculino.Name = "radBtnMasculino";
            this.radBtnMasculino.TabStop = true;
            this.radBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.Name = "Label10";
            // 
            // Label9
            // 
            resources.ApplyResources(this.Label9, "Label9");
            this.Label9.Name = "Label9";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblRegistroAnterior
            // 
            resources.ApplyResources(this.lblRegistroAnterior, "lblRegistroAnterior");
            this.lblRegistroAnterior.Name = "lblRegistroAnterior";
            // 
            // GestionarPerfil
            // 
            this.AcceptButton = this.btnGuardar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.lblRegistroAnterior);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.bntLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "GestionarPerfil";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grpBoxSexo.ResumeLayout(false);
            this.grpBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAtras;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        internal System.Windows.Forms.Button bntLimpiar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.LinkLabel lnkInstrucciones;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton radBtnFemenino;
        internal System.Windows.Forms.RadioButton radBtnMasculino;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpBoxSexo;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtBrazo;
        private System.Windows.Forms.MaskedTextBox txtMuslo;
        private System.Windows.Forms.MaskedTextBox txtCadera;
        private System.Windows.Forms.MaskedTextBox txtCintura;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Label lblRegistroAnterior;
        internal System.Windows.Forms.Label lblEdad;
        internal System.Windows.Forms.Label lblFechaNacimiento;
        internal System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}