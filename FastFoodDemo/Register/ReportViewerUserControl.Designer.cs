namespace FastFoodDemo.Register
{
    partial class ReportViewerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // filterCrystalReportViewer
            // 
            this.filterCrystalReportViewer.ActiveViewIndex = -1;
            this.filterCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterCrystalReportViewer.DisplayStatusBar = false;
            this.filterCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.filterCrystalReportViewer.Name = "filterCrystalReportViewer";
            this.filterCrystalReportViewer.Size = new System.Drawing.Size(1115, 634);
            this.filterCrystalReportViewer.TabIndex = 215;
            this.filterCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.filterCrystalReportViewer.Visible = false;
            // 
            // ReportViewerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterCrystalReportViewer);
            this.Name = "ReportViewerUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(1115, 634);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer filterCrystalReportViewer;
    }
}
