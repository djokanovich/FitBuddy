namespace FitBuddy.WinForms.UI.Formularios
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            resources.ApplyResources(this.TableLayoutPanel, "TableLayoutPanel");
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.btnAceptar, 1, 5);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Image = global::FitBuddy.WinForms.UI.Properties.Resources.FitBuddy;
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            this.LogoPictureBox.TabStop = false;
            // 
            // LabelProductName
            // 
            resources.ApplyResources(this.LabelProductName, "LabelProductName");
            this.LabelProductName.Name = "LabelProductName";
            // 
            // LabelVersion
            // 
            resources.ApplyResources(this.LabelVersion, "LabelVersion");
            this.LabelVersion.Name = "LabelVersion";
            // 
            // LabelCopyright
            // 
            resources.ApplyResources(this.LabelCopyright, "LabelCopyright");
            this.LabelCopyright.Name = "LabelCopyright";
            // 
            // LabelCompanyName
            // 
            resources.ApplyResources(this.LabelCompanyName, "LabelCompanyName");
            this.LabelCompanyName.Name = "LabelCompanyName";
            // 
            // TextBoxDescription
            // 
            resources.ApplyResources(this.TextBoxDescription, "TextBoxDescription");
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.TabStop = false;
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Click += new System.EventHandler(this.OnBtnAceptarClick);
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.KeyPreview = true;
            this.Name = "AcercaDe";
            this.Opacity = 0.9D;
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnAcercaDeKeyDown);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Label LabelProductName;
        internal System.Windows.Forms.Label LabelVersion;
        internal System.Windows.Forms.Label LabelCopyright;
        internal System.Windows.Forms.Label LabelCompanyName;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Button btnAceptar;
    }
}