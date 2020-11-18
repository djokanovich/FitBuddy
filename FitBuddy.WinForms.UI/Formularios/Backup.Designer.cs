namespace FitBuddy.WinForms.UI.Formularios
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.btnRestaurar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateBackup = new MetroFramework.Controls.MetroButton();
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCreateBackup.Highlight = true;
            resources.ApplyResources(this.btnCreateBackup, "btnCreateBackup");
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.UseSelectable = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.OnBtnCrearBackupClick);
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
            // Backup
            // 
            this.AcceptButton = this.btnCreateBackup;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCreateBackup);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Backup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnRestaurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnCreateBackup;
        private MetroFramework.Controls.MetroButton btnAtras;
    }
}