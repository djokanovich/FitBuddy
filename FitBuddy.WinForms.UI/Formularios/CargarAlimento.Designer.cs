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
            this.btnAtrás = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPorción = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.datConsumoAlimentos = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.lblCalorías = new System.Windows.Forms.Label();
            this.txtPorción = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMomentoDelDía = new System.Windows.Forms.ComboBox();
            this.lblMomento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConsumoAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtrás.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnAtrás, "btnAtras");
            this.btnAtrás.Name = "btnAtras";
            this.btnAtrás.UseVisualStyleBackColor = true;
            this.btnAtrás.Click += new System.EventHandler(this.OnBtnAtrásClick);
            // 
            // btnAgregar
            // 
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.OnBtnAgregarClick);
            // 
            // btnBorrar
            // 
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
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
            resources.ApplyResources(this.txtComida, "txtComida");
            this.txtComida.Name = "txtComida";
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
            resources.ApplyResources(this.txtPorción, "txtPorción");
            this.txtPorción.Name = "txtPorción";
            this.txtPorción.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTxtPorciónKeyPress);
            // 
            // dtpFecha
            // 
            resources.ApplyResources(this.dtpFecha, "dtpFecha");
            this.dtpFecha.Name = "dtpFecha";
            // 
            // cmbMomentoDelDía
            // 
            this.cmbMomentoDelDía.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMomentoDelDía.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMomentoDelDía, "cmbMomentoDelDía");
            this.cmbMomentoDelDía.Name = "cmbMomentoDelDía";
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
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAtrás;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnBorrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblPorción;
        internal System.Windows.Forms.Label lblComida;
        internal System.Windows.Forms.DataGridView datConsumoAlimentos;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label lblCalorías;
        private System.Windows.Forms.TextBox txtPorción;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbMomentoDelDía;
        internal System.Windows.Forms.Label lblMomento;
    }
}