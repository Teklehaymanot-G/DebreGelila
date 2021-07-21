namespace FastFoodDemo.Register
{
    partial class SimpleSearch
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
            this.txt_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_search_result = new System.Windows.Forms.ListBox();
            this.simpleSearchCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Control;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.LineColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(166, 107);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.Size = new System.Drawing.Size(344, 26);
            this.txt_search.TabIndex = 203;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged_1);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 201;
            this.label5.Text = "ስም ወይም የተሳትፎ ቁጥር ያስገቡ";
            // 
            // lb_search_result
            // 
            this.lb_search_result.BackColor = System.Drawing.SystemColors.Control;
            this.lb_search_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_search_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search_result.FormattingEnabled = true;
            this.lb_search_result.ItemHeight = 16;
            this.lb_search_result.Location = new System.Drawing.Point(8, 8);
            this.lb_search_result.Name = "lb_search_result";
            this.lb_search_result.Size = new System.Drawing.Size(406, 96);
            this.lb_search_result.TabIndex = 205;
            this.lb_search_result.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_search_result_MouseClick);
            this.lb_search_result.SelectedIndexChanged += new System.EventHandler(this.lb_search_result_SelectedIndexChanged);
            // 
            // simpleSearchCrystalReportViewer
            // 
            this.simpleSearchCrystalReportViewer.ActiveViewIndex = -1;
            this.simpleSearchCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simpleSearchCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpleSearchCrystalReportViewer.DisplayStatusBar = false;
            this.simpleSearchCrystalReportViewer.Location = new System.Drawing.Point(43, 145);
            this.simpleSearchCrystalReportViewer.Name = "simpleSearchCrystalReportViewer";
            this.simpleSearchCrystalReportViewer.Size = new System.Drawing.Size(1029, 446);
            this.simpleSearchCrystalReportViewer.TabIndex = 206;
            this.simpleSearchCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_search_result);
            this.panel1.Location = new System.Drawing.Point(516, 21);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(422, 112);
            this.panel1.TabIndex = 207;
            // 
            // SimpleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleSearchCrystalReportViewer);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Name = "SimpleSearch";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(1115, 634);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLineTextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_search_result;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer simpleSearchCrystalReportViewer;
        private System.Windows.Forms.Panel panel1;
    }
}
