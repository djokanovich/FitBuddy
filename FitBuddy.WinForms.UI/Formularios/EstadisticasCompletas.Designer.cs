namespace FitBuddy.WinForms.UI.Formularios
{
    partial class EstadisticasCompletas
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.General = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.chartPeso = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.General)).BeginInit();
            this.General.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // General
            // 
            this.General.Controls.Add(this.tabNavigationPage1);
            this.General.Controls.Add(this.tabNavigationPage2);
            this.General.Controls.Add(this.tabNavigationPage3);
            this.General.Location = new System.Drawing.Point(12, 40);
            this.General.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.General.Name = "General";
            this.General.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.General.RegularSize = new System.Drawing.Size(1141, 600);
            this.General.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.General.SelectedPage = this.tabNavigationPage1;
            this.General.Size = new System.Drawing.Size(1141, 600);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Peso";
            this.tabNavigationPage1.Controls.Add(this.chartPeso);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1141, 547);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Cintura";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1141, 547);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Muslo";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1141, 547);
            // 
            // chartPeso
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartPeso.Diagram = xyDiagram1;
            this.chartPeso.Legend.Name = "Default Legend";
            this.chartPeso.Location = new System.Drawing.Point(25, 22);
            this.chartPeso.Name = "chartPeso";
            series1.Name = "Peso ";
            lineSeriesView1.Color = System.Drawing.Color.OrangeRed;
            series1.View = lineSeriesView1;
            this.chartPeso.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartPeso.Size = new System.Drawing.Size(1066, 518);
            this.chartPeso.TabIndex = 0;
            // 
            // EstadisticasCompletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 720);
            this.Controls.Add(this.General);
            this.Name = "EstadisticasCompletas";
            this.Text = "EstadisticasCompletas";
            ((System.ComponentModel.ISupportInitialize)(this.General)).EndInit();
            this.General.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane General;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraCharts.ChartControl chartPeso;
    }
}