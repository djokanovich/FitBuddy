namespace FitBuddy.WinForms.UI.Formularios
{
    partial class CargarDiarioEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarDiarioEjercicios));
            this.txtTiempo = new MetroFramework.Controls.MetroTextBox();
            this.Label4 = new MetroFramework.Controls.MetroLabel();
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.btnBorrar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRepeticiones = new System.Windows.Forms.ComboBox();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTiempo
            // 
            // 
            // 
            // 
            this.txtTiempo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtTiempo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtTiempo.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.txtTiempo.CustomButton.Name = "";
            this.txtTiempo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtTiempo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTiempo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtTiempo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTiempo.CustomButton.UseSelectable = true;
            this.txtTiempo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtTiempo.Lines = new string[0];
            resources.ApplyResources(this.txtTiempo, "txtTiempo");
            this.txtTiempo.MaxLength = 32767;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.PasswordChar = '\0';
            this.txtTiempo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTiempo.SelectedText = "";
            this.txtTiempo.SelectionLength = 0;
            this.txtTiempo.SelectionStart = 0;
            this.txtTiempo.ShortcutsEnabled = true;
            this.txtTiempo.UseSelectable = true;
            this.txtTiempo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTiempo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
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
            // btnBorrar
            // 
            this.btnBorrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseSelectable = true;
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
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.EjerciciosDiarios;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // cmbRepeticiones
            // 
            this.cmbRepeticiones.FormattingEnabled = true;
            resources.ApplyResources(this.cmbRepeticiones, "cmbRepeticiones");
            this.cmbRepeticiones.Name = "cmbRepeticiones";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEjercicio, "cmbEjercicio");
            this.cmbEjercicio.Name = "cmbEjercicio";
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
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DataGridView1, "DataGridView1");
            this.DataGridView1.Name = "DataGridView1";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // CargarDiarioEjercicios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cmbRepeticiones);
            this.Controls.Add(this.cmbEjercicio);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "CargarDiarioEjercicios";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroTextBox txtTiempo;
        internal MetroFramework.Controls.MetroLabel Label4;
        internal MetroFramework.Controls.MetroButton btnAtras;
        internal MetroFramework.Controls.MetroButton btnBorrar;
        internal MetroFramework.Controls.MetroButton btnAgregar;
        internal MetroFramework.Controls.MetroLabel Label3;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ComboBox cmbRepeticiones;
        internal System.Windows.Forms.ComboBox cmbEjercicio;
        internal MetroFramework.Controls.MetroLabel Label2;
        internal MetroFramework.Controls.MetroLabel Label1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private MetroFramework.Controls.MetroLabel lblWelcome;
    }
}