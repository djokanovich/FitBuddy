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
            this.btnAtras = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.txtEdad = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxSexo = new System.Windows.Forms.GroupBox();
            this.radBtnFemenino = new System.Windows.Forms.RadioButton();
            this.radBtnMasculino = new System.Windows.Forms.RadioButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
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
            this.btnAtras.Location = new System.Drawing.Point(480, 376);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(63, 21);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(12, 50);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(74, 13);
            this.Label15.TabIndex = 33;
            this.Label15.Text = "Fecha registro";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(92, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 20;
            // 
            // bntLimpiar
            // 
            this.bntLimpiar.Location = new System.Drawing.Point(213, 314);
            this.bntLimpiar.Name = "bntLimpiar";
            this.bntLimpiar.Size = new System.Drawing.Size(161, 39);
            this.bntLimpiar.TabIndex = 11;
            this.bntLimpiar.Text = "Limpiar";
            this.bntLimpiar.UseVisualStyleBackColor = true;
            this.bntLimpiar.Click += new System.EventHandler(this.OnBtnLimpiarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(380, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
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
            this.GroupBox2.Location = new System.Drawing.Point(262, 120);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(281, 176);
            this.GroupBox2.TabIndex = 28;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Medidas Específicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "cm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "cm";
            // 
            // txtBrazo
            // 
            this.txtBrazo.BeepOnError = true;
            this.txtBrazo.Location = new System.Drawing.Point(75, 95);
            this.txtBrazo.Mask = "000";
            this.txtBrazo.Name = "txtBrazo";
            this.txtBrazo.Size = new System.Drawing.Size(68, 20);
            this.txtBrazo.TabIndex = 8;
            this.txtBrazo.ValidatingType = typeof(int);
            // 
            // txtMuslo
            // 
            this.txtMuslo.BeepOnError = true;
            this.txtMuslo.Location = new System.Drawing.Point(75, 69);
            this.txtMuslo.Mask = "000";
            this.txtMuslo.Name = "txtMuslo";
            this.txtMuslo.Size = new System.Drawing.Size(68, 20);
            this.txtMuslo.TabIndex = 7;
            this.txtMuslo.ValidatingType = typeof(int);
            // 
            // txtCadera
            // 
            this.txtCadera.BeepOnError = true;
            this.txtCadera.Location = new System.Drawing.Point(75, 43);
            this.txtCadera.Mask = "000";
            this.txtCadera.Name = "txtCadera";
            this.txtCadera.Size = new System.Drawing.Size(68, 20);
            this.txtCadera.TabIndex = 6;
            this.txtCadera.ValidatingType = typeof(int);
            // 
            // txtCintura
            // 
            this.txtCintura.BeepOnError = true;
            this.txtCintura.Location = new System.Drawing.Point(75, 17);
            this.txtCintura.Mask = "000";
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(68, 20);
            this.txtCintura.TabIndex = 5;
            this.txtCintura.ValidatingType = typeof(int);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(149, 46);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(21, 13);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "cm";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(149, 21);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(21, 13);
            this.Label11.TabIndex = 20;
            this.Label11.Text = "cm";
            // 
            // lnkInstrucciones
            // 
            this.lnkInstrucciones.AutoSize = true;
            this.lnkInstrucciones.Location = new System.Drawing.Point(28, 130);
            this.lnkInstrucciones.Name = "lnkInstrucciones";
            this.lnkInstrucciones.Size = new System.Drawing.Size(165, 13);
            this.lnkInstrucciones.TabIndex = 19;
            this.lnkInstrucciones.TabStop = true;
            this.lnkInstrucciones.Text = "Instrucciones para tomar medidas";
            this.lnkInstrucciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInstrucciones_LinkClicked);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(28, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Cintura";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(28, 46);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 13);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Cadera";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(28, 98);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 13);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Brazo";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(28, 72);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 13);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Muslo";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtAltura);
            this.GroupBox1.Controls.Add(this.txtPeso);
            this.GroupBox1.Controls.Add(this.txtEdad);
            this.GroupBox1.Controls.Add(this.grpBoxSexo);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(12, 120);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(225, 176);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Características Generales";
            // 
            // txtAltura
            // 
            this.txtAltura.BeepOnError = true;
            this.txtAltura.Location = new System.Drawing.Point(61, 70);
            this.txtAltura.Mask = "000";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(68, 20);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // txtPeso
            // 
            this.txtPeso.BeepOnError = true;
            this.txtPeso.Location = new System.Drawing.Point(61, 44);
            this.txtPeso.Mask = "000";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(68, 20);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.ValidatingType = typeof(int);
            // 
            // txtEdad
            // 
            this.txtEdad.BeepOnError = true;
            this.txtEdad.Location = new System.Drawing.Point(61, 18);
            this.txtEdad.Mask = "00";
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(68, 20);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.ValidatingType = typeof(int);
            // 
            // grpBoxSexo
            // 
            this.grpBoxSexo.Controls.Add(this.radBtnFemenino);
            this.grpBoxSexo.Controls.Add(this.radBtnMasculino);
            this.grpBoxSexo.Location = new System.Drawing.Point(26, 98);
            this.grpBoxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxSexo.Name = "grpBoxSexo";
            this.grpBoxSexo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxSexo.Size = new System.Drawing.Size(172, 68);
            this.grpBoxSexo.TabIndex = 4;
            this.grpBoxSexo.TabStop = false;
            this.grpBoxSexo.Text = "Sexo";
            // 
            // radBtnFemenino
            // 
            this.radBtnFemenino.AutoSize = true;
            this.radBtnFemenino.Location = new System.Drawing.Point(15, 17);
            this.radBtnFemenino.Name = "radBtnFemenino";
            this.radBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.radBtnFemenino.TabIndex = 9;
            this.radBtnFemenino.TabStop = true;
            this.radBtnFemenino.Text = "Femenino";
            this.radBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radBtnMasculino
            // 
            this.radBtnMasculino.AutoSize = true;
            this.radBtnMasculino.Location = new System.Drawing.Point(15, 41);
            this.radBtnMasculino.Name = "radBtnMasculino";
            this.radBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.radBtnMasculino.TabIndex = 10;
            this.radBtnMasculino.TabStop = true;
            this.radBtnMasculino.Text = "Masculino";
            this.radBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(135, 73);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(21, 13);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "cm";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(135, 47);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(19, 13);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "kg";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Edad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Peso";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Altura";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(12, 12);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(531, 15);
            this.lblWelcome.TabIndex = 41;
            this.lblWelcome.Text = "Bienvenido";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRegistroAnterior
            // 
            this.lblRegistroAnterior.Location = new System.Drawing.Point(299, 50);
            this.lblRegistroAnterior.Name = "lblRegistroAnterior";
            this.lblRegistroAnterior.Size = new System.Drawing.Size(244, 49);
            this.lblRegistroAnterior.TabIndex = 42;
            this.lblRegistroAnterior.Text = "{{RegistroAnterior}}";
            // 
            // GestionarPerfil
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(562, 417);
            this.Controls.Add(this.lblRegistroAnterior);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.bntLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionarPerfil";
            this.Text = "Gestionar perfil";
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
        internal System.Windows.Forms.DateTimePicker dtpFecha;
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
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton radBtnFemenino;
        internal System.Windows.Forms.RadioButton radBtnMasculino;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpBoxSexo;
        private System.Windows.Forms.MaskedTextBox txtEdad;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtBrazo;
        private System.Windows.Forms.MaskedTextBox txtMuslo;
        private System.Windows.Forms.MaskedTextBox txtCadera;
        private System.Windows.Forms.MaskedTextBox txtCintura;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Label lblRegistroAnterior;
    }
}