namespace FastFoodDemo.Register
{
    partial class FilterUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterUserControl));
            this.filterCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmb_sex = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_married = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_course_before = new Guna.UI.WinForms.GunaComboBox();
            this.btn_filter = new Guna.UI.WinForms.GunaImageButton();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // filterCrystalReportViewer
            // 
            this.filterCrystalReportViewer.ActiveViewIndex = -1;
            this.filterCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterCrystalReportViewer.DisplayStatusBar = false;
            this.filterCrystalReportViewer.Location = new System.Drawing.Point(43, 87);
            this.filterCrystalReportViewer.Name = "filterCrystalReportViewer";
            this.filterCrystalReportViewer.Size = new System.Drawing.Size(1029, 504);
            this.filterCrystalReportViewer.TabIndex = 214;
            this.filterCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmb_sex
            // 
            this.cmb_sex.BackColor = System.Drawing.Color.Transparent;
            this.cmb_sex.BaseColor = System.Drawing.Color.White;
            this.cmb_sex.BorderColor = System.Drawing.Color.Silver;
            this.cmb_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_sex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_sex.ForeColor = System.Drawing.Color.Black;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "ጾታ",
            "ወንድ",
            "ሴት"});
            this.cmb_sex.Location = new System.Drawing.Point(333, 43);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_sex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_sex.Size = new System.Drawing.Size(130, 26);
            this.cmb_sex.StartIndex = 0;
            this.cmb_sex.TabIndex = 311;
            // 
            // cmb_married
            // 
            this.cmb_married.BackColor = System.Drawing.Color.Transparent;
            this.cmb_married.BaseColor = System.Drawing.Color.White;
            this.cmb_married.BorderColor = System.Drawing.Color.Silver;
            this.cmb_married.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_married.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_married.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_married.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_married.ForeColor = System.Drawing.Color.Black;
            this.cmb_married.FormattingEnabled = true;
            this.cmb_married.Items.AddRange(new object[] {
            "ትዳር",
            "ያገባ",
            "ያላገባ"});
            this.cmb_married.Location = new System.Drawing.Point(469, 43);
            this.cmb_married.Name = "cmb_married";
            this.cmb_married.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_married.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_married.Size = new System.Drawing.Size(130, 26);
            this.cmb_married.StartIndex = 0;
            this.cmb_married.TabIndex = 312;
            // 
            // cmb_course_before
            // 
            this.cmb_course_before.BackColor = System.Drawing.Color.Transparent;
            this.cmb_course_before.BaseColor = System.Drawing.Color.White;
            this.cmb_course_before.BorderColor = System.Drawing.Color.Silver;
            this.cmb_course_before.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_course_before.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_course_before.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_course_before.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_course_before.ForeColor = System.Drawing.Color.Black;
            this.cmb_course_before.FormattingEnabled = true;
            this.cmb_course_before.Items.AddRange(new object[] {
            "ኮርስ",
            "ተምሬያለሁ",
            "አልተማርኩም",
            "እየተማርኩኝ ነው"});
            this.cmb_course_before.Location = new System.Drawing.Point(605, 43);
            this.cmb_course_before.Name = "cmb_course_before";
            this.cmb_course_before.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_course_before.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_course_before.Size = new System.Drawing.Size(130, 26);
            this.cmb_course_before.StartIndex = 0;
            this.cmb_course_before.TabIndex = 313;
            // 
            // btn_filter
            // 
            this.btn_filter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_filter.Location = new System.Drawing.Point(877, 37);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.OnHoverImage = null;
            this.btn_filter.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_filter.Size = new System.Drawing.Size(32, 32);
            this.btn_filter.TabIndex = 325;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "ኮርስ",
            "ተምሬያለሁ",
            "አልተማርኩም",
            "እየተማርኩኝ ነው"});
            this.gunaComboBox1.Location = new System.Drawing.Point(741, 43);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(130, 26);
            this.gunaComboBox1.StartIndex = 0;
            this.gunaComboBox1.TabIndex = 326;
            // 
            // FilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cmb_course_before);
            this.Controls.Add(this.cmb_married);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.filterCrystalReportViewer);
            this.Name = "FilterUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(1115, 634);
            this.Load += new System.EventHandler(this.Filter2UserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer filterCrystalReportViewer;
        private Guna.UI.WinForms.GunaComboBox cmb_sex;
        private Guna.UI.WinForms.GunaComboBox cmb_married;
        private Guna.UI.WinForms.GunaComboBox cmb_course_before;
        private Guna.UI.WinForms.GunaImageButton btn_filter;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}
