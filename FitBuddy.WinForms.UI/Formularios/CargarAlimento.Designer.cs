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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.datConsumoAlimentos = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.txtPorcion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbMomento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConsumoAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.Location = new System.Drawing.Point(1296, 878);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(150, 44);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.OnBtnAtrasClick);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(1296, 239);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(150, 44);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Agregar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1296, 161);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(150, 44);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(88, 144);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(446, 473);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(648, 277);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 25);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Porción";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(648, 215);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 25);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Comida";
            // 
            // datConsumoAlimentos
            // 
            this.datConsumoAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datConsumoAlimentos.Location = new System.Drawing.Point(640, 468);
            this.datConsumoAlimentos.Margin = new System.Windows.Forms.Padding(6);
            this.datConsumoAlimentos.Name = "datConsumoAlimentos";
            this.datConsumoAlimentos.RowHeadersWidth = 82;
            this.datConsumoAlimentos.Size = new System.Drawing.Size(814, 256);
            this.datConsumoAlimentos.TabIndex = 12;
            this.datConsumoAlimentos.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(1352, 63);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 21;
            // 
            // txtComida
            // 
            this.txtComida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtComida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtComida.Location = new System.Drawing.Point(808, 209);
            this.txtComida.Margin = new System.Windows.Forms.Padding(6);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(396, 31);
            this.txtComida.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1122, 789);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total calorías día:";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(1320, 789);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(134, 25);
            this.lblCalorias.TabIndex = 24;
            this.lblCalorias.Text = "SumCalorias";
            // 
            // txtPorcion
            // 
            this.txtPorcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPorcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPorcion.Location = new System.Drawing.Point(808, 274);
            this.txtPorcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtPorcion.Name = "txtPorcion";
            this.txtPorcion.Size = new System.Drawing.Size(396, 31);
            this.txtPorcion.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(808, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // cmbMomento
            // 
            this.cmbMomento.FormattingEnabled = true;
            this.cmbMomento.Location = new System.Drawing.Point(808, 342);
            this.cmbMomento.Name = "cmbMomento";
            this.cmbMomento.Size = new System.Drawing.Size(396, 33);
            this.cmbMomento.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Momento";
            // 
            // CargarAlimento
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(1536, 954);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMomento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPorcion);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.datConsumoAlimentos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CargarAlimento";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Text = "CargarAlimento";
            this.Load += new System.EventHandler(this.CargarAlimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConsumoAlimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAtras;
        internal System.Windows.Forms.Button btnEnviar;
        internal System.Windows.Forms.Button btnBorrar;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView datConsumoAlimentos;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.TextBox txtPorcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbMomento;
        internal System.Windows.Forms.Label label4;
    }
}