namespace FitBuddy.WinForms.UI.Formularios
{
    partial class CargarAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarAlimento));
            this.btnAtrás = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnBorrar = new MetroFramework.Controls.MetroButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPorción = new MetroFramework.Controls.MetroLabel();
            this.lblComida = new MetroFramework.Controls.MetroLabel();
            this.datConsumoAlimentos = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.txtComida = new MetroFramework.Controls.MetroTextBox();
            this.lblCalorías = new MetroFramework.Controls.MetroLabel();
            this.txtPorción = new MetroFramework.Controls.MetroTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMomentoDelDía = new MetroFramework.Controls.MetroComboBox();
            this.lblMomento = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConsumoAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrás
            // 
            this.btnAtrás.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtrás.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnAtrás, "btnAtrás");
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.UseSelectable = true;
            this.btnAtrás.Click += new System.EventHandler(this.OnBtnAtrásClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAgregar.Highlight = true;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.OnBtnAgregarClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseSelectable = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::FitBuddy.WinForms.UI.Properties.Resources.AlimentoCargar;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // lblPorción
            // 
            resources.ApplyResources(this.lblPorción, "lblPorción");
            this.lblPorción.Name = "lblPorción";
            // 
            // lblComida
            // 
            resources.ApplyResources(this.lblComida, "lblComida");
            this.lblComida.Name = "lblComida";
            // 
            // datConsumoAlimentos
            // 
            this.datConsumoAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.datConsumoAlimentos, "datConsumoAlimentos");
            this.datConsumoAlimentos.Name = "datConsumoAlimentos";
            this.datConsumoAlimentos.TabStop = false;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // txtComida
            // 
            this.txtComida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtComida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtComida.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtComida.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtComida.CustomButton.Name = "";
            this.txtComida.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtComida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComida.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtComida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComida.CustomButton.UseSelectable = true;
            this.txtComida.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtComida.Lines = new string[0];
            resources.ApplyResources(this.txtComida, "txtComida");
            this.txtComida.MaxLength = 32767;
            this.txtComida.Name = "txtComida";
            this.txtComida.PasswordChar = '\0';
            this.txtComida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComida.SelectedText = "";
            this.txtComida.SelectionLength = 0;
            this.txtComida.SelectionStart = 0;
            this.txtComida.ShortcutsEnabled = true;
            this.txtComida.UseSelectable = true;
            this.txtComida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCalorías
            // 
            resources.ApplyResources(this.lblCalorías, "lblCalorías");
            this.lblCalorías.Name = "lblCalorías";
            // 
            // txtPorción
            // 
            this.txtPorción.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPorción.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtPorción.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtPorción.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtPorción.CustomButton.Name = "";
            this.txtPorción.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtPorción.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorción.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtPorción.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorción.CustomButton.UseSelectable = true;
            this.txtPorción.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtPorción.Lines = new string[0];
            resources.ApplyResources(this.txtPorción, "txtPorción");
            this.txtPorción.MaxLength = 32767;
            this.txtPorción.Name = "txtPorción";
            this.txtPorción.PasswordChar = '\0';
            this.txtPorción.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorción.SelectedText = "";
            this.txtPorción.SelectionLength = 0;
            this.txtPorción.SelectionStart = 0;
            this.txtPorción.ShortcutsEnabled = true;
            this.txtPorción.UseSelectable = true;
            this.txtPorción.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorción.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorción.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTxtPorciónKeyPress);
            // 
            // dtpFecha
            // 
            resources.ApplyResources(this.dtpFecha, "dtpFecha");
            this.dtpFecha.Name = "dtpFecha";
            // 
            // cmbMomentoDelDía
            // 
            this.cmbMomentoDelDía.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMomentoDelDía, "cmbMomentoDelDía");
            this.cmbMomentoDelDía.Name = "cmbMomentoDelDía";
            this.cmbMomentoDelDía.UseSelectable = true;
            // 
            // lblMomento
            // 
            resources.ApplyResources(this.lblMomento, "lblMomento");
            this.lblMomento.Name = "lblMomento";
            // 
            // CargarAlimento
            // 
            this.AcceptButton = this.btnAgregar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtrás;
            this.Controls.Add(this.lblMomento);
            this.Controls.Add(this.cmbMomentoDelDía);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPorción);
            this.Controls.Add(this.lblCalorías);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lblPorción);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.datConsumoAlimentos);
            this.Name = "CargarAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConsumoAlimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroButton btnAtrás;
        internal MetroFramework.Controls.MetroButton btnAgregar;
        internal MetroFramework.Controls.MetroButton btnBorrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal MetroFramework.Controls.MetroLabel lblPorción;
        internal MetroFramework.Controls.MetroLabel lblComida;
        internal System.Windows.Forms.DataGridView datConsumoAlimentos;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroTextBox txtComida;
        private MetroFramework.Controls.MetroLabel lblCalorías;
        private MetroFramework.Controls.MetroTextBox txtPorción;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MetroFramework.Controls.MetroComboBox cmbMomentoDelDía;
        internal MetroFramework.Controls.MetroLabel lblMomento;
    }
}