namespace GUI
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(1204, 549);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 44);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 384);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Location = new System.Drawing.Point(1042, 549);
            this.btnCreateBackup.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(150, 44);
            this.btnCreateBackup.TabIndex = 5;
            this.btnCreateBackup.Text = "Crear";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 736);
            this.Controls.Add(this.btnCreateBackup);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Backup";
            this.Text = "Backup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateBackup;
    }
}