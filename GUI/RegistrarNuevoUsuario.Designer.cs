namespace GUI
{
    partial class RegistrarNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarNuevoUsuario));
            this.lnkAcercaDe = new System.Windows.Forms.LinkLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkAcercaDe
            // 
            this.lnkAcercaDe.AutoSize = true;
            this.lnkAcercaDe.Location = new System.Drawing.Point(437, 314);
            this.lnkAcercaDe.Name = "lnkAcercaDe";
            this.lnkAcercaDe.Size = new System.Drawing.Size(119, 13);
            this.lnkAcercaDe.TabIndex = 29;
            this.lnkAcercaDe.TabStop = true;
            this.lnkAcercaDe.Text = "Acerca de la Aplicación";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(17, 58);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(267, 260);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 28;
            this.PictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(437, 284);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 23);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.OnBtnRegistrarClick);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(437, 235);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(190, 20);
            this.txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(437, 206);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(437, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(437, 142);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(190, 20);
            this.txtRepeatPassword.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(437, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(364, 242);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 13);
            this.Label6.TabIndex = 21;
            this.Label6.Text = "Apellido";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(364, 213);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 13);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Nombre";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(437, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 19;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(373, 183);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 13);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "E-mail";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(301, 149);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Confirmar contraseña";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(347, 114);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Contraseña";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(365, 82);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Usuario";
            // 
            // RegistrarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 385);
            this.Controls.Add(this.lnkAcercaDe);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarNuevoUsuario";
            this.Text = "RegistrarNuevoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel lnkAcercaDe;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtRepeatPassword;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}