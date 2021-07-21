
namespace FastFoodDemo.Register
{
    partial class AttendanceReportUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceReportUserControl));
            this.btn_reload = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.check_add_photo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.filterCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_filter = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_type = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_sex = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // btn_reload
            // 
            this.btn_reload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_reload.Location = new System.Drawing.Point(1032, 40);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.OnHoverImage = null;
            this.btn_reload.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_reload.Size = new System.Drawing.Size(32, 32);
            this.btn_reload.TabIndex = 358;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Location = new System.Drawing.Point(166, 70);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(68, 13);
            this.lbl_end_date.TabIndex = 357;
            this.lbl_end_date.Text = "lbl_end_date";
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Location = new System.Drawing.Point(43, 70);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(70, 13);
            this.lbl_start_date.TabIndex = 356;
            this.lbl_start_date.Text = "lbl_start_date";
            // 
            // check_add_photo
            // 
            this.check_add_photo.AutoSize = true;
            this.check_add_photo.Depth = 0;
            this.check_add_photo.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_add_photo.Location = new System.Drawing.Point(616, 40);
            this.check_add_photo.Margin = new System.Windows.Forms.Padding(0);
            this.check_add_photo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_add_photo.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_add_photo.Name = "check_add_photo";
            this.check_add_photo.Ripple = true;
            this.check_add_photo.Size = new System.Drawing.Size(89, 30);
            this.check_add_photo.TabIndex = 355;
            this.check_add_photo.Text = "ፎቶ ጨምር";
            this.check_add_photo.UseVisualStyleBackColor = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(169, 44);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(120, 20);
            this.dtp_end.TabIndex = 354;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(43, 44);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(120, 20);
            this.dtp_start.TabIndex = 353;
            this.dtp_start.Value = new System.DateTime(2021, 7, 21, 10, 44, 43, 0);
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // filterCrystalReportViewer
            // 
            this.filterCrystalReportViewer.ActiveViewIndex = -1;
            this.filterCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterCrystalReportViewer.Location = new System.Drawing.Point(40, 101);
            this.filterCrystalReportViewer.Name = "filterCrystalReportViewer";
            this.filterCrystalReportViewer.Size = new System.Drawing.Size(1035, 493);
            this.filterCrystalReportViewer.TabIndex = 352;
            this.filterCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_filter
            // 
            this.btn_filter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_filter.Location = new System.Drawing.Point(717, 40);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.OnHoverImage = null;
            this.btn_filter.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_filter.Size = new System.Drawing.Size(32, 32);
            this.btn_filter.TabIndex = 351;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_type.BaseColor = System.Drawing.Color.White;
            this.cmb_type.BorderColor = System.Drawing.Color.Silver;
            this.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_type.ForeColor = System.Drawing.Color.Black;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "አቴንዳስ",
            "ተገኝቷል",
            "አርፍዷል",
            "አስፈቅዷል"});
            this.cmb_type.Location = new System.Drawing.Point(295, 42);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_type.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_type.Size = new System.Drawing.Size(168, 26);
            this.cmb_type.StartIndex = 0;
            this.cmb_type.TabIndex = 350;
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
            this.cmb_sex.Location = new System.Drawing.Point(469, 42);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_sex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_sex.Size = new System.Drawing.Size(135, 26);
            this.cmb_sex.StartIndex = 0;
            this.cmb_sex.TabIndex = 349;
            // 
            // AttendanceReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.lbl_end_date);
            this.Controls.Add(this.lbl_start_date);
            this.Controls.Add(this.check_add_photo);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.filterCrystalReportViewer);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.cmb_sex);
            this.Name = "AttendanceReportUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(1115, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton btn_reload;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.Label lbl_start_date;
        private MaterialSkin.Controls.MaterialCheckBox check_add_photo;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer filterCrystalReportViewer;
        private Guna.UI.WinForms.GunaImageButton btn_filter;
        private Guna.UI.WinForms.GunaComboBox cmb_type;
        private Guna.UI.WinForms.GunaComboBox cmb_sex;
    }
}
