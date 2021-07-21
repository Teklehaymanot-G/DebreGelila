
namespace FastFoodDemo.Register
{
    partial class AttendanceAddUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceAddUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_attendance_add_date_day = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_month = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_year = new Guna.UI.WinForms.GunaComboBox();
            this.btn_attendance_add_date = new Guna.UI.WinForms.GunaImageButton();
            this.panel_attendance_add = new System.Windows.Forms.Panel();
            this.label63 = new System.Windows.Forms.Label();
            this.txt_participation_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.icon_attendance_add_participation_number_success = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_attendance_add_participation_number_error = new System.Windows.Forms.Label();
            this.btn_attendance_finish = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_attendance_type = new Guna.UI.WinForms.GunaComboBox();
            this.btn_attendance_view = new Guna.UI.WinForms.GunaImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_attendance_add_info = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.lbl_participation_number = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_attendance_add = new System.Windows.Forms.DataGridView();
            this.panel_attendance_add_table = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel_attendance_add.SuspendLayout();
            this.panel_attendance_add_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance_add)).BeginInit();
            this.panel_attendance_add_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_attendance_add_date);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_year);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_month);
            this.panel3.Controls.Add(this.cmb_attendance_add_date_day);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 76);
            this.panel3.TabIndex = 0;
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
            this.cmb_attendance_add_date_year.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_year_SelectedIndexChanged_1);
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
            // panel_attendance_add
            // 
            this.panel_attendance_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add.Controls.Add(this.label1);
            this.panel_attendance_add.Controls.Add(this.btn_attendance_view);
            this.panel_attendance_add.Controls.Add(this.cmb_attendance_type);
            this.panel_attendance_add.Controls.Add(this.btn_attendance_finish);
            this.panel_attendance_add.Controls.Add(this.lbl_attendance_add_participation_number_error);
            this.panel_attendance_add.Controls.Add(this.icon_attendance_add_participation_number_success);
            this.panel_attendance_add.Controls.Add(this.txt_participation_number);
            this.panel_attendance_add.Controls.Add(this.label63);
            this.panel_attendance_add.Location = new System.Drawing.Point(13, 132);
            this.panel_attendance_add.Name = "panel_attendance_add";
            this.panel_attendance_add.Size = new System.Drawing.Size(475, 155);
            this.panel_attendance_add.TabIndex = 1;
            this.panel_attendance_add.Visible = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(22, 70);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(93, 20);
            this.label63.TabIndex = 345;
            this.label63.Text = "የተሳትፎ ቁጥር";
            // 
            // txt_participation_number
            // 
            this.txt_participation_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_participation_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_participation_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_participation_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_participation_number.LineColor = System.Drawing.Color.Gray;
            this.txt_participation_number.Location = new System.Drawing.Point(121, 64);
            this.txt_participation_number.Name = "txt_participation_number";
            this.txt_participation_number.PasswordChar = '\0';
            this.txt_participation_number.Size = new System.Drawing.Size(172, 26);
            this.txt_participation_number.TabIndex = 344;
            this.txt_participation_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_participation_number_KeyDown);
            // 
            // icon_attendance_add_participation_number_success
            // 
            this.icon_attendance_add_participation_number_success.BackColor = System.Drawing.SystemColors.Control;
            this.icon_attendance_add_participation_number_success.DialogResult = System.Windows.Forms.DialogResult.None;
            this.icon_attendance_add_participation_number_success.Image = ((System.Drawing.Image)(resources.GetObject("icon_attendance_add_participation_number_success.Image")));
            this.icon_attendance_add_participation_number_success.ImageSize = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.Location = new System.Drawing.Point(299, 74);
            this.icon_attendance_add_participation_number_success.Name = "icon_attendance_add_participation_number_success";
            this.icon_attendance_add_participation_number_success.OnHoverImage = null;
            this.icon_attendance_add_participation_number_success.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.icon_attendance_add_participation_number_success.Size = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.TabIndex = 346;
            this.icon_attendance_add_participation_number_success.Visible = false;
            // 
            // lbl_attendance_add_participation_number_error
            // 
            this.lbl_attendance_add_participation_number_error.AutoSize = true;
            this.lbl_attendance_add_participation_number_error.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_attendance_add_participation_number_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_attendance_add_participation_number_error.Location = new System.Drawing.Point(118, 93);
            this.lbl_attendance_add_participation_number_error.Name = "lbl_attendance_add_participation_number_error";
            this.lbl_attendance_add_participation_number_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_attendance_add_participation_number_error.TabIndex = 347;
            this.lbl_attendance_add_participation_number_error.Text = "label1";
            this.lbl_attendance_add_participation_number_error.Visible = false;
            // 
            // btn_attendance_finish
            // 
            this.btn_attendance_finish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_attendance_finish.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_finish.Image")));
            this.btn_attendance_finish.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_attendance_finish.Location = new System.Drawing.Point(426, 106);
            this.btn_attendance_finish.Name = "btn_attendance_finish";
            this.btn_attendance_finish.OnHoverImage = null;
            this.btn_attendance_finish.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_finish.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_finish.TabIndex = 348;
            this.btn_attendance_finish.Click += new System.EventHandler(this.btn_attendance_finish_Click);
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
            this.cmb_attendance_type.Location = new System.Drawing.Point(121, 17);
            this.cmb_attendance_type.Name = "cmb_attendance_type";
            this.cmb_attendance_type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_type.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_type.Size = new System.Drawing.Size(154, 26);
            this.cmb_attendance_type.StartIndex = 0;
            this.cmb_attendance_type.TabIndex = 349;
            // 
            // btn_attendance_view
            // 
            this.btn_attendance_view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_attendance_view.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_view.Image")));
            this.btn_attendance_view.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_attendance_view.Location = new System.Drawing.Point(388, 106);
            this.btn_attendance_view.Name = "btn_attendance_view";
            this.btn_attendance_view.OnHoverImage = null;
            this.btn_attendance_view.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_view.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_view.TabIndex = 350;
            this.btn_attendance_view.Click += new System.EventHandler(this.btn_attendance_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 351;
            this.label1.Text = "የአቴንዳሱ አይነት";
            // 
            // panel_attendance_add_info
            // 
            this.panel_attendance_add_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add_info.Controls.Add(this.lbl_participation_number);
            this.panel_attendance_add_info.Controls.Add(this.pictureBox_photo);
            this.panel_attendance_add_info.Controls.Add(this.lbl_name);
            this.panel_attendance_add_info.Location = new System.Drawing.Point(15, 328);
            this.panel_attendance_add_info.Name = "panel_attendance_add_info";
            this.panel_attendance_add_info.Size = new System.Drawing.Size(473, 181);
            this.panel_attendance_add_info.TabIndex = 2;
            this.panel_attendance_add_info.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(226, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(230, 85);
            this.lbl_name.TabIndex = 303;
            this.lbl_name.Text = "ስም";
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.Image")));
            this.pictureBox_photo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.InitialImage")));
            this.pictureBox_photo.Location = new System.Drawing.Point(14, 11);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(164, 161);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 302;
            this.pictureBox_photo.TabStop = false;
            // 
            // lbl_participation_number
            // 
            this.lbl_participation_number.AutoSize = true;
            this.lbl_participation_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_participation_number.Location = new System.Drawing.Point(226, 50);
            this.lbl_participation_number.Name = "lbl_participation_number";
            this.lbl_participation_number.Size = new System.Drawing.Size(93, 20);
            this.lbl_participation_number.TabIndex = 304;
            this.lbl_participation_number.Text = "የተሳትፎ ቁጥር";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_attendance_add_info);
            this.panel1.Controls.Add(this.panel_attendance_add);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(47, 56);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(501, 522);
            this.panel1.TabIndex = 2;
            // 
            // dgv_attendance_add
            // 
            this.dgv_attendance_add.AllowUserToAddRows = false;
            this.dgv_attendance_add.AllowUserToDeleteRows = false;
            this.dgv_attendance_add.AllowUserToResizeColumns = false;
            this.dgv_attendance_add.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_attendance_add.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_attendance_add.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_attendance_add.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_attendance_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_attendance_add.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_attendance_add.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_attendance_add.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_attendance_add.ColumnHeadersHeight = 30;
            this.dgv_attendance_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_attendance_add.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_attendance_add.EnableHeadersVisualStyles = false;
            this.dgv_attendance_add.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_attendance_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_attendance_add.Location = new System.Drawing.Point(13, 13);
            this.dgv_attendance_add.MultiSelect = false;
            this.dgv_attendance_add.Name = "dgv_attendance_add";
            this.dgv_attendance_add.ReadOnly = true;
            this.dgv_attendance_add.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_attendance_add.RowHeadersVisible = false;
            this.dgv_attendance_add.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_attendance_add.Size = new System.Drawing.Size(394, 494);
            this.dgv_attendance_add.TabIndex = 2;
            // 
            // panel_attendance_add_table
            // 
            this.panel_attendance_add_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_attendance_add_table.Controls.Add(this.dgv_attendance_add);
            this.panel_attendance_add_table.Location = new System.Drawing.Point(646, 56);
            this.panel_attendance_add_table.Name = "panel_attendance_add_table";
            this.panel_attendance_add_table.Padding = new System.Windows.Forms.Padding(10);
            this.panel_attendance_add_table.Size = new System.Drawing.Size(422, 522);
            this.panel_attendance_add_table.TabIndex = 3;
            this.panel_attendance_add_table.Visible = false;
            // 
            // AttendanceAddUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_attendance_add_table);
            this.Controls.Add(this.panel1);
            this.Name = "AttendanceAddUserControl";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1115, 634);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_attendance_add.ResumeLayout(false);
            this.panel_attendance_add.PerformLayout();
            this.panel_attendance_add_info.ResumeLayout(false);
            this.panel_attendance_add_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance_add)).EndInit();
            this.panel_attendance_add_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_add_date;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_year;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_month;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_attendance_add;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_view;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_type;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_finish;
        private System.Windows.Forms.Label lbl_attendance_add_participation_number_error;
        private Guna.UI.WinForms.GunaImageButton icon_attendance_add_participation_number_success;
        private Guna.UI.WinForms.GunaLineTextBox txt_participation_number;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel panel_attendance_add_info;
        private System.Windows.Forms.Label lbl_participation_number;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_attendance_add;
        private System.Windows.Forms.Panel panel_attendance_add_table;
    }
}
