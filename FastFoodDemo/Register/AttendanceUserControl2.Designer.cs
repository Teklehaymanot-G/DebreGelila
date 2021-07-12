
namespace FastFoodDemo.Register
{
    partial class AttendanceUserControl2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceUserControl2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_attendance_add = new System.Windows.Forms.TabPage();
            this.panel_attendance_add_table = new System.Windows.Forms.Panel();
            this.dgv_attendance_add = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_attendance_add_info = new System.Windows.Forms.Panel();
            this.lbl_participation_number = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_attendance_add = new System.Windows.Forms.Panel();
            this.btn_attendance_view = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_attendance_type = new Guna.UI.WinForms.GunaComboBox();
            this.btn_attendance_finish = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_attendance_add_participation_number_error = new System.Windows.Forms.Label();
            this.icon_attendance_add_participation_number_success = new Guna.UI.WinForms.GunaImageButton();
            this.txt_participation_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_attendance_add_date = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_attendance_add_date_year = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_month = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_day = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_attendance_report = new System.Windows.Forms.TabPage();
            this.check_add_photo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.filterCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_filter = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_type = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_sex = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_attendance_add.SuspendLayout();
            this.panel_attendance_add_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance_add)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_attendance_add_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel_attendance_add.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tab_attendance_report.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_attendance_add);
            this.tabControl1.Controls.Add(this.tab_attendance_report);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_attendance_add
            // 
            this.tabPage_attendance_add.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_attendance_add.Controls.Add(this.panel_attendance_add_table);
            this.tabPage_attendance_add.Controls.Add(this.panel1);
            this.tabPage_attendance_add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_attendance_add.Name = "tabPage_attendance_add";
            this.tabPage_attendance_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_attendance_add.Size = new System.Drawing.Size(809, 397);
            this.tabPage_attendance_add.TabIndex = 0;
            this.tabPage_attendance_add.Text = "አዲስ ያስገቡ";
            // 
            // panel_attendance_add_table
            // 
            this.panel_attendance_add_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add_table.Controls.Add(this.dgv_attendance_add);
            this.panel_attendance_add_table.Location = new System.Drawing.Point(431, 3);
            this.panel_attendance_add_table.Name = "panel_attendance_add_table";
            this.panel_attendance_add_table.Size = new System.Drawing.Size(375, 391);
            this.panel_attendance_add_table.TabIndex = 1;
            this.panel_attendance_add_table.Visible = false;
            // 
            // dgv_attendance_add
            // 
            this.dgv_attendance_add.AllowUserToAddRows = false;
            this.dgv_attendance_add.AllowUserToDeleteRows = false;
            this.dgv_attendance_add.AllowUserToResizeColumns = false;
            this.dgv_attendance_add.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_attendance_add.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_attendance_add.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_attendance_add.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_attendance_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_attendance_add.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_attendance_add.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_attendance_add.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_attendance_add.ColumnHeadersHeight = 30;
            this.dgv_attendance_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_attendance_add.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_attendance_add.EnableHeadersVisualStyles = false;
            this.dgv_attendance_add.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_attendance_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_attendance_add.Location = new System.Drawing.Point(3, 6);
            this.dgv_attendance_add.MultiSelect = false;
            this.dgv_attendance_add.Name = "dgv_attendance_add";
            this.dgv_attendance_add.ReadOnly = true;
            this.dgv_attendance_add.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_attendance_add.RowHeadersVisible = false;
            this.dgv_attendance_add.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_attendance_add.Size = new System.Drawing.Size(367, 376);
            this.dgv_attendance_add.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_attendance_add_info);
            this.panel1.Controls.Add(this.panel_attendance_add);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 385);
            this.panel1.TabIndex = 0;
            // 
            // panel_attendance_add_info
            // 
            this.panel_attendance_add_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add_info.Controls.Add(this.lbl_participation_number);
            this.panel_attendance_add_info.Controls.Add(this.pictureBox_photo);
            this.panel_attendance_add_info.Controls.Add(this.lbl_name);
            this.panel_attendance_add_info.Location = new System.Drawing.Point(3, 201);
            this.panel_attendance_add_info.Name = "panel_attendance_add_info";
            this.panel_attendance_add_info.Size = new System.Drawing.Size(415, 181);
            this.panel_attendance_add_info.TabIndex = 2;
            this.panel_attendance_add_info.Visible = false;
            // 
            // lbl_participation_number
            // 
            this.lbl_participation_number.AutoSize = true;
            this.lbl_participation_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_participation_number.Location = new System.Drawing.Point(173, 56);
            this.lbl_participation_number.Name = "lbl_participation_number";
            this.lbl_participation_number.Size = new System.Drawing.Size(93, 20);
            this.lbl_participation_number.TabIndex = 304;
            this.lbl_participation_number.Text = "የተሳትፎ ቁጥር";
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.Image")));
            this.pictureBox_photo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.InitialImage")));
            this.pictureBox_photo.Location = new System.Drawing.Point(3, 17);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(164, 161);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 302;
            this.pictureBox_photo.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(173, 93);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(230, 85);
            this.lbl_name.TabIndex = 303;
            this.lbl_name.Text = "ስም";
            // 
            // panel_attendance_add
            // 
            this.panel_attendance_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add.Controls.Add(this.btn_attendance_view);
            this.panel_attendance_add.Controls.Add(this.cmb_attendance_type);
            this.panel_attendance_add.Controls.Add(this.btn_attendance_finish);
            this.panel_attendance_add.Controls.Add(this.lbl_attendance_add_participation_number_error);
            this.panel_attendance_add.Controls.Add(this.icon_attendance_add_participation_number_success);
            this.panel_attendance_add.Controls.Add(this.txt_participation_number);
            this.panel_attendance_add.Controls.Add(this.label63);
            this.panel_attendance_add.Location = new System.Drawing.Point(1, 86);
            this.panel_attendance_add.Name = "panel_attendance_add";
            this.panel_attendance_add.Size = new System.Drawing.Size(417, 109);
            this.panel_attendance_add.TabIndex = 1;
            this.panel_attendance_add.Visible = false;
            // 
            // btn_attendance_view
            // 
            this.btn_attendance_view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_attendance_view.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_view.Image")));
            this.btn_attendance_view.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_attendance_view.Location = new System.Drawing.Point(334, 52);
            this.btn_attendance_view.Name = "btn_attendance_view";
            this.btn_attendance_view.OnHoverImage = null;
            this.btn_attendance_view.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_view.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_view.TabIndex = 350;
            this.btn_attendance_view.Click += new System.EventHandler(this.btn_attendance_view_Click);
            // 
            // cmb_attendance_type
            // 
            this.cmb_attendance_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_attendance_type.BaseColor = System.Drawing.Color.White;
            this.cmb_attendance_type.BorderColor = System.Drawing.Color.Silver;
            this.cmb_attendance_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_attendance_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_attendance_type.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_attendance_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_attendance_type.ForeColor = System.Drawing.Color.Black;
            this.cmb_attendance_type.FormattingEnabled = true;
            this.cmb_attendance_type.Items.AddRange(new object[] {
            "ተገኝቷል",
            "አርፍዷል",
            "አስፈቅዷል"});
            this.cmb_attendance_type.Location = new System.Drawing.Point(16, 23);
            this.cmb_attendance_type.Name = "cmb_attendance_type";
            this.cmb_attendance_type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_type.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_type.Size = new System.Drawing.Size(117, 26);
            this.cmb_attendance_type.StartIndex = 0;
            this.cmb_attendance_type.TabIndex = 349;
            // 
            // btn_attendance_finish
            // 
            this.btn_attendance_finish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_attendance_finish.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_finish.Image")));
            this.btn_attendance_finish.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_attendance_finish.Location = new System.Drawing.Point(372, 52);
            this.btn_attendance_finish.Name = "btn_attendance_finish";
            this.btn_attendance_finish.OnHoverImage = null;
            this.btn_attendance_finish.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_finish.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_finish.TabIndex = 348;
            this.btn_attendance_finish.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // lbl_attendance_add_participation_number_error
            // 
            this.lbl_attendance_add_participation_number_error.AutoSize = true;
            this.lbl_attendance_add_participation_number_error.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_attendance_add_participation_number_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_attendance_add_participation_number_error.Location = new System.Drawing.Point(108, 84);
            this.lbl_attendance_add_participation_number_error.Name = "lbl_attendance_add_participation_number_error";
            this.lbl_attendance_add_participation_number_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_attendance_add_participation_number_error.TabIndex = 347;
            this.lbl_attendance_add_participation_number_error.Text = "label1";
            this.lbl_attendance_add_participation_number_error.Visible = false;
            // 
            // icon_attendance_add_participation_number_success
            // 
            this.icon_attendance_add_participation_number_success.BackColor = System.Drawing.SystemColors.Control;
            this.icon_attendance_add_participation_number_success.DialogResult = System.Windows.Forms.DialogResult.None;
            this.icon_attendance_add_participation_number_success.Image = ((System.Drawing.Image)(resources.GetObject("icon_attendance_add_participation_number_success.Image")));
            this.icon_attendance_add_participation_number_success.ImageSize = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.Location = new System.Drawing.Point(289, 65);
            this.icon_attendance_add_participation_number_success.Name = "icon_attendance_add_participation_number_success";
            this.icon_attendance_add_participation_number_success.OnHoverImage = null;
            this.icon_attendance_add_participation_number_success.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.icon_attendance_add_participation_number_success.Size = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.TabIndex = 346;
            this.icon_attendance_add_participation_number_success.Visible = false;
            // 
            // txt_participation_number
            // 
            this.txt_participation_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_participation_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_participation_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_participation_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_participation_number.LineColor = System.Drawing.Color.Gray;
            this.txt_participation_number.Location = new System.Drawing.Point(111, 55);
            this.txt_participation_number.Name = "txt_participation_number";
            this.txt_participation_number.PasswordChar = '\0';
            this.txt_participation_number.Size = new System.Drawing.Size(172, 26);
            this.txt_participation_number.TabIndex = 344;
            this.txt_participation_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_participation_number_KeyDown);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(12, 61);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(93, 20);
            this.label63.TabIndex = 345;
            this.label63.Text = "የተሳትፎ ቁጥር";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_attendance_add_date);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_year);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_month);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_day);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 76);
            this.panel3.TabIndex = 0;
            // 
            // btn_attendance_add_date
            // 
            this.btn_attendance_add_date.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_attendance_add_date.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_add_date.Image")));
            this.btn_attendance_add_date.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_attendance_add_date.Location = new System.Drawing.Point(373, 27);
            this.btn_attendance_add_date.Name = "btn_attendance_add_date";
            this.btn_attendance_add_date.OnHoverImage = null;
            this.btn_attendance_add_date.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_add_date.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_add_date.TabIndex = 326;
            this.btn_attendance_add_date.Click += new System.EventHandler(this.btn_attendance_add_date_Click);
            // 
            // cmb_attendance_add_date_year
            // 
            this.cmb_attendance_add_date_year.BackColor = System.Drawing.Color.Transparent;
            this.cmb_attendance_add_date_year.BaseColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_year.BorderColor = System.Drawing.Color.Silver;
            this.cmb_attendance_add_date_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_attendance_add_date_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_attendance_add_date_year.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_attendance_add_date_year.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_attendance_add_date_year.ForeColor = System.Drawing.Color.Black;
            this.cmb_attendance_add_date_year.FormattingEnabled = true;
            this.cmb_attendance_add_date_year.Items.AddRange(new object[] {
            "ዓመት",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmb_attendance_add_date_year.Location = new System.Drawing.Point(76, 31);
            this.cmb_attendance_add_date_year.Name = "cmb_attendance_add_date_year";
            this.cmb_attendance_add_date_year.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_year.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_year.Size = new System.Drawing.Size(97, 26);
            this.cmb_attendance_add_date_year.StartIndex = 0;
            this.cmb_attendance_add_date_year.TabIndex = 310;
            this.cmb_attendance_add_date_year.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_year_SelectedIndexChanged);
            // 
            // cmb_attendance_add_date_month
            // 
            this.cmb_attendance_add_date_month.BackColor = System.Drawing.Color.Transparent;
            this.cmb_attendance_add_date_month.BaseColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_month.BorderColor = System.Drawing.Color.Silver;
            this.cmb_attendance_add_date_month.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_attendance_add_date_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_attendance_add_date_month.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_attendance_add_date_month.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_attendance_add_date_month.ForeColor = System.Drawing.Color.Black;
            this.cmb_attendance_add_date_month.FormattingEnabled = true;
            this.cmb_attendance_add_date_month.Items.AddRange(new object[] {
            "ወር"});
            this.cmb_attendance_add_date_month.Location = new System.Drawing.Point(179, 31);
            this.cmb_attendance_add_date_month.Name = "cmb_attendance_add_date_month";
            this.cmb_attendance_add_date_month.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_month.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_month.Size = new System.Drawing.Size(97, 26);
            this.cmb_attendance_add_date_month.StartIndex = 0;
            this.cmb_attendance_add_date_month.TabIndex = 311;
            this.cmb_attendance_add_date_month.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_month_SelectedIndexChanged);
            // 
            // cmb_attendance_add_date_day
            // 
            this.cmb_attendance_add_date_day.BackColor = System.Drawing.Color.Transparent;
            this.cmb_attendance_add_date_day.BaseColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_day.BorderColor = System.Drawing.Color.Silver;
            this.cmb_attendance_add_date_day.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_attendance_add_date_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_attendance_add_date_day.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_attendance_add_date_day.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_attendance_add_date_day.ForeColor = System.Drawing.Color.Black;
            this.cmb_attendance_add_date_day.FormattingEnabled = true;
            this.cmb_attendance_add_date_day.Items.AddRange(new object[] {
            "ቀን"});
            this.cmb_attendance_add_date_day.Location = new System.Drawing.Point(282, 31);
            this.cmb_attendance_add_date_day.Name = "cmb_attendance_add_date_day";
            this.cmb_attendance_add_date_day.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_day.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_day.Size = new System.Drawing.Size(75, 26);
            this.cmb_attendance_add_date_day.StartIndex = 0;
            this.cmb_attendance_add_date_day.TabIndex = 312;
            this.cmb_attendance_add_date_day.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_day_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 313;
            this.label2.Text = "ቀን ያስገቡ";
            // 
            // tab_attendance_report
            // 
            this.tab_attendance_report.BackColor = System.Drawing.SystemColors.Control;
            this.tab_attendance_report.Controls.Add(this.lbl_end_date);
            this.tab_attendance_report.Controls.Add(this.lbl_start_date);
            this.tab_attendance_report.Controls.Add(this.check_add_photo);
            this.tab_attendance_report.Controls.Add(this.dtp_end);
            this.tab_attendance_report.Controls.Add(this.dtp_start);
            this.tab_attendance_report.Controls.Add(this.filterCrystalReportViewer);
            this.tab_attendance_report.Controls.Add(this.btn_filter);
            this.tab_attendance_report.Controls.Add(this.cmb_type);
            this.tab_attendance_report.Controls.Add(this.cmb_sex);
            this.tab_attendance_report.Location = new System.Drawing.Point(4, 22);
            this.tab_attendance_report.Name = "tab_attendance_report";
            this.tab_attendance_report.Padding = new System.Windows.Forms.Padding(3);
            this.tab_attendance_report.Size = new System.Drawing.Size(809, 397);
            this.tab_attendance_report.TabIndex = 1;
            this.tab_attendance_report.Text = "አቴንዳስ ሪፖርት";
            // 
            // check_add_photo
            // 
            this.check_add_photo.AutoSize = true;
            this.check_add_photo.Depth = 0;
            this.check_add_photo.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_add_photo.Location = new System.Drawing.Point(530, 20);
            this.check_add_photo.Margin = new System.Windows.Forms.Padding(0);
            this.check_add_photo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_add_photo.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_add_photo.Name = "check_add_photo";
            this.check_add_photo.Ripple = true;
            this.check_add_photo.Size = new System.Drawing.Size(89, 30);
            this.check_add_photo.TabIndex = 334;
            this.check_add_photo.Text = "ፎቶ ጨምር";
            this.check_add_photo.UseVisualStyleBackColor = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(94, 12);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(82, 20);
            this.dtp_end.TabIndex = 332;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(6, 12);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(82, 20);
            this.dtp_start.TabIndex = 331;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // filterCrystalReportViewer
            // 
            this.filterCrystalReportViewer.ActiveViewIndex = -1;
            this.filterCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterCrystalReportViewer.Location = new System.Drawing.Point(3, 60);
            this.filterCrystalReportViewer.Name = "filterCrystalReportViewer";
            this.filterCrystalReportViewer.Size = new System.Drawing.Size(803, 334);
            this.filterCrystalReportViewer.TabIndex = 330;
            this.filterCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_filter
            // 
            this.btn_filter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_filter.Location = new System.Drawing.Point(429, 6);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.OnHoverImage = null;
            this.btn_filter.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_filter.Size = new System.Drawing.Size(32, 32);
            this.btn_filter.TabIndex = 329;
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
            this.cmb_type.Location = new System.Drawing.Point(182, 9);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_type.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_type.Size = new System.Drawing.Size(130, 26);
            this.cmb_type.StartIndex = 0;
            this.cmb_type.TabIndex = 328;
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
            this.cmb_sex.Location = new System.Drawing.Point(318, 9);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_sex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_sex.Size = new System.Drawing.Size(97, 26);
            this.cmb_sex.StartIndex = 0;
            this.cmb_sex.TabIndex = 326;
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Location = new System.Drawing.Point(7, 41);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(70, 13);
            this.lbl_start_date.TabIndex = 335;
            this.lbl_start_date.Text = "lbl_start_date";
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Location = new System.Drawing.Point(91, 41);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(68, 13);
            this.lbl_end_date.TabIndex = 336;
            this.lbl_end_date.Text = "lbl_end_date";
            // 
            // AttendanceUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AttendanceUserControl2";
            this.Size = new System.Drawing.Size(817, 423);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_attendance_add.ResumeLayout(false);
            this.panel_attendance_add_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance_add)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_attendance_add_info.ResumeLayout(false);
            this.panel_attendance_add_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel_attendance_add.ResumeLayout(false);
            this.panel_attendance_add.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tab_attendance_report.ResumeLayout(false);
            this.tab_attendance_report.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_attendance_add;
        private System.Windows.Forms.TabPage tab_attendance_report;
        private System.Windows.Forms.Panel panel_attendance_add_table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_attendance_add;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_year;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_month;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_day;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_add_date;
        private Guna.UI.WinForms.GunaImageButton icon_attendance_add_participation_number_success;
        private Guna.UI.WinForms.GunaLineTextBox txt_participation_number;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label lbl_attendance_add_participation_number_error;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label lbl_participation_number;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_finish;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_type;
        private System.Windows.Forms.Panel panel_attendance_add_info;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_view;
        private System.Windows.Forms.DataGridView dgv_attendance_add;
        private Guna.UI.WinForms.GunaImageButton btn_filter;
        private Guna.UI.WinForms.GunaComboBox cmb_type;
        private Guna.UI.WinForms.GunaComboBox cmb_sex;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer filterCrystalReportViewer;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private MaterialSkin.Controls.MaterialCheckBox check_add_photo;
        private System.Windows.Forms.Label lbl_start_date;
        private System.Windows.Forms.Label lbl_end_date;
    }
}
