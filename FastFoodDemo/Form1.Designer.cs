namespace FastFoodDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_menu_attendance = new System.Windows.Forms.Button();
            this.btn_menu_filter = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_menu_register = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_menu_search = new System.Windows.Forms.Button();
            this.btn_menu_main_dgv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tt_setting = new System.Windows.Forms.ToolTip(this.components);
            this.btn_setting = new System.Windows.Forms.Button();
            this.tt_logout = new System.Windows.Forms.ToolTip(this.components);
            this.btn_minimize = new System.Windows.Forms.Button();
            this.lbl_login_name = new System.Windows.Forms.Label();
            this.lbl_login_participation_number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_header_line = new System.Windows.Forms.Label();
            this.btn_logout = new Guna.UI.WinForms.GunaImageButton();
            this.pictureBox_login_photo = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.reportViewerUserControl1 = new FastFoodDemo.Register.ReportViewerUserControl();
            this.filterUserControl1 = new FastFoodDemo.Register.FilterUserControl();
            this.settingUserControl1 = new FastFoodDemo.Register.SettingUserControl();
            this.editUserControl1 = new FastFoodDemo.Register.EditUserControl();
            this.simpleSearch1 = new FastFoodDemo.Register.SimpleSearch();
            this.loginUserControl1 = new FastFoodDemo.Register.LoginUserControl();
            this.listDataUserControl1 = new FastFoodDemo.ListData.ListDataUserControl();
            this.registerUserControl1 = new FastFoodDemo.Register.RegisterUserControl();
            this.secondUserControl1 = new FastFoodDemo.Register.LoginUserControl();
            this.mySecondCustmControl1 = new FastFoodDemo.MySecondCustmControl();
            this.firstCustomControl1 = new FastFoodDemo.FirstCustomControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btn_menu_attendance);
            this.panel1.Controls.Add(this.btn_menu_filter);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_menu_register);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.btn_menu_search);
            this.panel1.Controls.Add(this.btn_menu_main_dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 583);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 417);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_menu_attendance
            // 
            this.btn_menu_attendance.FlatAppearance.BorderSize = 0;
            this.btn_menu_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_attendance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_attendance.ForeColor = System.Drawing.Color.White;
            this.btn_menu_attendance.Image = global::FastFoodDemo.Properties.Resources.attendance_32px;
            this.btn_menu_attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_attendance.Location = new System.Drawing.Point(12, 287);
            this.btn_menu_attendance.Name = "btn_menu_attendance";
            this.btn_menu_attendance.Size = new System.Drawing.Size(199, 54);
            this.btn_menu_attendance.TabIndex = 6;
            this.btn_menu_attendance.Text = "    አቴንዳስ";
            this.btn_menu_attendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_attendance.UseVisualStyleBackColor = true;
            this.btn_menu_attendance.Click += new System.EventHandler(this.btn_menu_attendance_Click);
            // 
            // btn_menu_filter
            // 
            this.btn_menu_filter.FlatAppearance.BorderSize = 0;
            this.btn_menu_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_filter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_filter.ForeColor = System.Drawing.Color.White;
            this.btn_menu_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_filter.Image")));
            this.btn_menu_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_filter.Location = new System.Drawing.Point(12, 227);
            this.btn_menu_filter.Name = "btn_menu_filter";
            this.btn_menu_filter.Size = new System.Drawing.Size(199, 54);
            this.btn_menu_filter.TabIndex = 5;
            this.btn_menu_filter.Text = "    ማጣሪያ";
            this.btn_menu_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_filter.UseVisualStyleBackColor = true;
            this.btn_menu_filter.Click += new System.EventHandler(this.btn_menu_filter_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // btn_menu_register
            // 
            this.btn_menu_register.FlatAppearance.BorderSize = 0;
            this.btn_menu_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_register.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_register.ForeColor = System.Drawing.Color.White;
            this.btn_menu_register.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_register.Image")));
            this.btn_menu_register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_register.Location = new System.Drawing.Point(12, 167);
            this.btn_menu_register.Name = "btn_menu_register";
            this.btn_menu_register.Size = new System.Drawing.Size(197, 54);
            this.btn_menu_register.TabIndex = 4;
            this.btn_menu_register.Text = "    ይመዝግቡ";
            this.btn_menu_register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_register.UseVisualStyleBackColor = true;
            this.btn_menu_register.Click += new System.EventHandler(this.button3_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // btn_menu_search
            // 
            this.btn_menu_search.FlatAppearance.BorderSize = 0;
            this.btn_menu_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_search.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_search.ForeColor = System.Drawing.Color.White;
            this.btn_menu_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_search.Image")));
            this.btn_menu_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_search.Location = new System.Drawing.Point(12, 113);
            this.btn_menu_search.Name = "btn_menu_search";
            this.btn_menu_search.Size = new System.Drawing.Size(197, 54);
            this.btn_menu_search.TabIndex = 4;
            this.btn_menu_search.Text = "     ይፈልጉ";
            this.btn_menu_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_search.UseVisualStyleBackColor = true;
            this.btn_menu_search.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_menu_main_dgv
            // 
            this.btn_menu_main_dgv.FlatAppearance.BorderSize = 0;
            this.btn_menu_main_dgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_main_dgv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_main_dgv.ForeColor = System.Drawing.Color.White;
            this.btn_menu_main_dgv.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_main_dgv.Image")));
            this.btn_menu_main_dgv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_main_dgv.Location = new System.Drawing.Point(12, 59);
            this.btn_menu_main_dgv.Name = "btn_menu_main_dgv";
            this.btn_menu_main_dgv.Size = new System.Drawing.Size(197, 54);
            this.btn_menu_main_dgv.TabIndex = 4;
            this.btn_menu_main_dgv.Text = "       የተመዘገቡ";
            this.btn_menu_main_dgv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_main_dgv.UseVisualStyleBackColor = true;
            this.btn_menu_main_dgv.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "የደብረ ገሊላ ዐማኑኤል ካቴድራል";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "እግዚአብሔር ምስሌነ ሰንበት ትምህርት ቤት";
            // 
            // btn_setting
            // 
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(863, 20);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(32, 35);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tt_setting.SetToolTip(this.btn_setting, "የይለፍ መረጃ ያስተካክሉ");
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.Location = new System.Drawing.Point(939, 19);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 35);
            this.btn_minimize.TabIndex = 22;
            this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tt_logout.SetToolTip(this.btn_minimize, "ከሲስተሙ ይውጡ");
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lbl_login_name
            // 
            this.lbl_login_name.AutoSize = true;
            this.lbl_login_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_login_name.Location = new System.Drawing.Point(723, 59);
            this.lbl_login_name.Name = "lbl_login_name";
            this.lbl_login_name.Size = new System.Drawing.Size(86, 20);
            this.lbl_login_name.TabIndex = 17;
            this.lbl_login_name.Text = "login name";
            // 
            // lbl_login_participation_number
            // 
            this.lbl_login_participation_number.AutoSize = true;
            this.lbl_login_participation_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_participation_number.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_login_participation_number.Location = new System.Drawing.Point(725, 79);
            this.lbl_login_participation_number.Name = "lbl_login_participation_number";
            this.lbl_login_participation_number.Size = new System.Drawing.Size(130, 13);
            this.lbl_login_participation_number.TabIndex = 18;
            this.lbl_login_participation_number.Text = "login participation_number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 21);
            this.label2.TabIndex = 326;
            this.label2.Text = "አባላት ግንኙነት እና ሥነ-ምግባር ክፍል ";
            // 
            // lbl_header_line
            // 
            this.lbl_header_line.AutoSize = true;
            this.lbl_header_line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lbl_header_line.Location = new System.Drawing.Point(357, 102);
            this.lbl_header_line.Name = "lbl_header_line";
            this.lbl_header_line.Size = new System.Drawing.Size(283, 13);
            this.lbl_header_line.TabIndex = 327;
            this.lbl_header_line.Text = "______________________________________________";
            // 
            // btn_logout
            // 
            this.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_logout.Location = new System.Drawing.Point(901, 19);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.OnHoverImage = null;
            this.btn_logout.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_logout.Size = new System.Drawing.Size(32, 32);
            this.btn_logout.TabIndex = 325;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // pictureBox_login_photo
            // 
            this.pictureBox_login_photo.Location = new System.Drawing.Point(728, 16);
            this.pictureBox_login_photo.Name = "pictureBox_login_photo";
            this.pictureBox_login_photo.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_login_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_login_photo.TabIndex = 19;
            this.pictureBox_login_photo.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(977, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(32, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // reportViewerUserControl1
            // 
            this.reportViewerUserControl1.Location = new System.Drawing.Point(211, 160);
            this.reportViewerUserControl1.Name = "reportViewerUserControl1";
            this.reportViewerUserControl1.Padding = new System.Windows.Forms.Padding(40);
            this.reportViewerUserControl1.Size = new System.Drawing.Size(815, 423);
            this.reportViewerUserControl1.TabIndex = 21;
            // 
            // filterUserControl1
            // 
            this.filterUserControl1.Location = new System.Drawing.Point(211, 160);
            this.filterUserControl1.Name = "filterUserControl1";
            this.filterUserControl1.Padding = new System.Windows.Forms.Padding(40);
            this.filterUserControl1.Size = new System.Drawing.Size(817, 423);
            this.filterUserControl1.TabIndex = 20;
            // 
            // settingUserControl1
            // 
            this.settingUserControl1.Location = new System.Drawing.Point(211, 160);
            this.settingUserControl1.Name = "settingUserControl1";
            this.settingUserControl1.Padding = new System.Windows.Forms.Padding(40);
            this.settingUserControl1.Size = new System.Drawing.Size(817, 423);
            this.settingUserControl1.TabIndex = 16;
            // 
            // editUserControl1
            // 
            this.editUserControl1.Location = new System.Drawing.Point(211, 160);
            this.editUserControl1.Name = "editUserControl1";
            this.editUserControl1.Size = new System.Drawing.Size(817, 423);
            this.editUserControl1.TabIndex = 14;
            // 
            // simpleSearch1
            // 
            this.simpleSearch1.Location = new System.Drawing.Point(211, 160);
            this.simpleSearch1.Name = "simpleSearch1";
            this.simpleSearch1.Padding = new System.Windows.Forms.Padding(40);
            this.simpleSearch1.Size = new System.Drawing.Size(817, 423);
            this.simpleSearch1.TabIndex = 13;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(211, 160);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Padding = new System.Windows.Forms.Padding(40);
            this.loginUserControl1.Size = new System.Drawing.Size(817, 423);
            this.loginUserControl1.TabIndex = 12;
            this.loginUserControl1.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // listDataUserControl1
            // 
            this.listDataUserControl1.Location = new System.Drawing.Point(211, 160);
            this.listDataUserControl1.Name = "listDataUserControl1";
            this.listDataUserControl1.Padding = new System.Windows.Forms.Padding(40);
            this.listDataUserControl1.Size = new System.Drawing.Size(817, 423);
            this.listDataUserControl1.TabIndex = 11;
            this.listDataUserControl1.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // registerUserControl1
            // 
            this.registerUserControl1.Location = new System.Drawing.Point(211, 160);
            this.registerUserControl1.Name = "registerUserControl1";
            this.registerUserControl1.Size = new System.Drawing.Size(817, 423);
            this.registerUserControl1.TabIndex = 10;
            // 
            // secondUserControl1
            // 
            this.secondUserControl1.Location = new System.Drawing.Point(211, 160);
            this.secondUserControl1.Name = "secondUserControl1";
            this.secondUserControl1.Padding = new System.Windows.Forms.Padding(20);
            this.secondUserControl1.Size = new System.Drawing.Size(815, 423);
            this.secondUserControl1.TabIndex = 8;
            // 
            // mySecondCustmControl1
            // 
            this.mySecondCustmControl1.Location = new System.Drawing.Point(211, 156);
            this.mySecondCustmControl1.Name = "mySecondCustmControl1";
            this.mySecondCustmControl1.Size = new System.Drawing.Size(815, 406);
            this.mySecondCustmControl1.TabIndex = 6;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(211, 156);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(803, 423);
            this.firstCustomControl1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.lbl_header_line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.reportViewerUserControl1);
            this.Controls.Add(this.filterUserControl1);
            this.Controls.Add(this.pictureBox_login_photo);
            this.Controls.Add(this.lbl_login_participation_number);
            this.Controls.Add(this.lbl_login_name);
            this.Controls.Add(this.settingUserControl1);
            this.Controls.Add(this.editUserControl1);
            this.Controls.Add(this.simpleSearch1);
            this.Controls.Add(this.loginUserControl1);
            this.Controls.Add(this.listDataUserControl1);
            this.Controls.Add(this.registerUserControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondUserControl1);
            this.Controls.Add(this.mySecondCustmControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ደብረ ገሊላ";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_menu_search;
        private System.Windows.Forms.Button btn_menu_main_dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_menu_register;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_exit;
        private FirstCustomControl firstCustomControl1;
        private MySecondCustmControl mySecondCustmControl1;
        private Register.LoginUserControl secondUserControl1;
        private System.Windows.Forms.Label label1;
        private Register.RegisterUserControl registerUserControl1;
        private ListData.ListDataUserControl listDataUserControl1;
        private Register.LoginUserControl loginUserControl1;
        private Register.SimpleSearch simpleSearch1;
        private Register.EditUserControl editUserControl1;
        private Register.SettingUserControl settingUserControl1;
        private System.Windows.Forms.ToolTip tt_setting;
        private System.Windows.Forms.ToolTip tt_logout;
        private System.Windows.Forms.Label lbl_login_name;
        private System.Windows.Forms.Label lbl_login_participation_number;
        private System.Windows.Forms.PictureBox pictureBox_login_photo;
        private System.Windows.Forms.Button btn_menu_filter;
        private Register.FilterUserControl filterUserControl1;
        private Register.ReportViewerUserControl reportViewerUserControl1;
        private System.Windows.Forms.Button btn_minimize;
        private Guna.UI.WinForms.GunaImageButton btn_logout;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_header_line;
        private System.Windows.Forms.Button btn_menu_attendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}

