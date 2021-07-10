
namespace FastFoodDemo.Register
{
    partial class AttendanceUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceUserControl));
            this.tabControl_attendance = new System.Windows.Forms.TabControl();
            this.tabPage_add = new System.Windows.Forms.TabPage();
            this.panel_attendance_add = new System.Windows.Forms.Panel();
            this.panel_attendance_add_info = new System.Windows.Forms.Panel();
            this.cmb_attendance_type = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.txt_participation_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_attendance_add_date = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_attendance_add_date_year = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_month = new Guna.UI.WinForms.GunaComboBox();
            this.cmb_attendance_add_date_day = new Guna.UI.WinForms.GunaComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dBDebregelilaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DebregelilaDataSet = new FastFoodDemo.DB_DebregelilaDataSet();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.lbl_participation_number = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.icon_attendance_add_participation_number_success = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_attendance_add_participation_number_error = new System.Windows.Forms.Label();
            this.tabControl_attendance.SuspendLayout();
            this.tabPage_add.SuspendLayout();
            this.panel_attendance_add.SuspendLayout();
            this.panel_attendance_add_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDebregelilaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DebregelilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_attendance
            // 
            this.tabControl_attendance.Controls.Add(this.tabPage_add);
            this.tabControl_attendance.Controls.Add(this.tabPage2);
            this.tabControl_attendance.Location = new System.Drawing.Point(3, 3);
            this.tabControl_attendance.Name = "tabControl_attendance";
            this.tabControl_attendance.SelectedIndex = 0;
            this.tabControl_attendance.Size = new System.Drawing.Size(811, 420);
            this.tabControl_attendance.TabIndex = 0;
            // 
            // tabPage_add
            // 
            this.tabPage_add.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_add.Controls.Add(this.panel_attendance_add);
            this.tabPage_add.Controls.Add(this.label43);
            this.tabPage_add.Controls.Add(this.btn_attendance_add_date);
            this.tabPage_add.Controls.Add(this.cmb_attendance_add_date_year);
            this.tabPage_add.Controls.Add(this.cmb_attendance_add_date_month);
            this.tabPage_add.Controls.Add(this.cmb_attendance_add_date_day);
            this.tabPage_add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_add.Name = "tabPage_add";
            this.tabPage_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_add.Size = new System.Drawing.Size(803, 394);
            this.tabPage_add.TabIndex = 0;
            this.tabPage_add.Text = "አዲስ ያስገቡ";
            // 
            // panel_attendance_add
            // 
            this.panel_attendance_add.Controls.Add(this.lbl_attendance_add_participation_number_error);
            this.panel_attendance_add.Controls.Add(this.icon_attendance_add_participation_number_success);
            this.panel_attendance_add.Controls.Add(this.panel_attendance_add_info);
            this.panel_attendance_add.Controls.Add(this.cmb_attendance_type);
            this.panel_attendance_add.Controls.Add(this.label1);
            this.panel_attendance_add.Controls.Add(this.gunaImageButton1);
            this.panel_attendance_add.Controls.Add(this.txt_participation_number);
            this.panel_attendance_add.Location = new System.Drawing.Point(17, 49);
            this.panel_attendance_add.Name = "panel_attendance_add";
            this.panel_attendance_add.Size = new System.Drawing.Size(783, 342);
            this.panel_attendance_add.TabIndex = 280;
            this.panel_attendance_add.Visible = false;
            // 
            // panel_attendance_add_info
            // 
            this.panel_attendance_add_info.Controls.Add(this.lbl_name);
            this.panel_attendance_add_info.Controls.Add(this.lbl_participation_number);
            this.panel_attendance_add_info.Controls.Add(this.pictureBox_photo);
            this.panel_attendance_add_info.Location = new System.Drawing.Point(435, 3);
            this.panel_attendance_add_info.Name = "panel_attendance_add_info";
            this.panel_attendance_add_info.Size = new System.Drawing.Size(345, 336);
            this.panel_attendance_add_info.TabIndex = 281;
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
            this.cmb_attendance_type.Location = new System.Drawing.Point(18, 74);
            this.cmb_attendance_type.Name = "cmb_attendance_type";
            this.cmb_attendance_type.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_type.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_type.Size = new System.Drawing.Size(117, 26);
            this.cmb_attendance_type.StartIndex = 0;
            this.cmb_attendance_type.TabIndex = 280;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 278;
            this.label1.Text = "የአባሉን የተሳትፎ ቁርጥ ያስገቡ";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            //this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(32, 30);
            this.gunaImageButton1.Location = new System.Drawing.Point(153, 239);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton1.TabIndex = 279;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // txt_participation_number
            // 
            this.txt_participation_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_participation_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_participation_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_participation_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_participation_number.LineColor = System.Drawing.Color.Gray;
            this.txt_participation_number.Location = new System.Drawing.Point(163, 74);
            this.txt_participation_number.Name = "txt_participation_number";
            this.txt_participation_number.PasswordChar = '\0';
            this.txt_participation_number.Size = new System.Drawing.Size(210, 26);
            this.txt_participation_number.TabIndex = 277;
            this.txt_participation_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_participation_number_KeyDown);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(13, 18);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 20);
            this.label43.TabIndex = 275;
            this.label43.Text = "ቀኑን ያስገቡ";
            // 
            // btn_attendance_add_date
            // 
            this.btn_attendance_add_date.DialogResult = System.Windows.Forms.DialogResult.None;
            //this.btn_attendance_add_date.Image = ((System.Drawing.Image)(resources.GetObject("btn_attendance_add_date.Image")));
            this.btn_attendance_add_date.ImageSize = new System.Drawing.Size(32, 30);
            this.btn_attendance_add_date.Location = new System.Drawing.Point(382, 11);
            this.btn_attendance_add_date.Name = "btn_attendance_add_date";
            this.btn_attendance_add_date.OnHoverImage = null;
            this.btn_attendance_add_date.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_attendance_add_date.Size = new System.Drawing.Size(32, 32);
            this.btn_attendance_add_date.TabIndex = 274;
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
            "2023",
            "2024"});
            this.cmb_attendance_add_date_year.Location = new System.Drawing.Point(95, 17);
            this.cmb_attendance_add_date_year.Name = "cmb_attendance_add_date_year";
            this.cmb_attendance_add_date_year.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_year.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_year.Size = new System.Drawing.Size(97, 26);
            this.cmb_attendance_add_date_year.StartIndex = 0;
            this.cmb_attendance_add_date_year.TabIndex = 12;
            this.cmb_attendance_add_date_year.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_year_1_SelectedIndexChanged);
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
            this.cmb_attendance_add_date_month.Location = new System.Drawing.Point(198, 17);
            this.cmb_attendance_add_date_month.Name = "cmb_attendance_add_date_month";
            this.cmb_attendance_add_date_month.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_month.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_month.Size = new System.Drawing.Size(97, 26);
            this.cmb_attendance_add_date_month.StartIndex = 0;
            this.cmb_attendance_add_date_month.TabIndex = 13;
            this.cmb_attendance_add_date_month.SelectedIndexChanged += new System.EventHandler(this.cmb_attendance_add_date_month_1_SelectedIndexChanged);
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
            this.cmb_attendance_add_date_day.Location = new System.Drawing.Point(301, 17);
            this.cmb_attendance_add_date_day.Name = "cmb_attendance_add_date_day";
            this.cmb_attendance_add_date_day.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_attendance_add_date_day.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_attendance_add_date_day.Size = new System.Drawing.Size(75, 26);
            this.cmb_attendance_add_date_day.StartIndex = 0;
            this.cmb_attendance_add_date_day.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dBDebregelilaDataSetBindingSource
            // 
            this.dBDebregelilaDataSetBindingSource.DataSource = this.dB_DebregelilaDataSet;
            this.dBDebregelilaDataSetBindingSource.Position = 0;
            // 
            // dB_DebregelilaDataSet
            // 
            this.dB_DebregelilaDataSet.DataSetName = "DB_DebregelilaDataSet";
            this.dB_DebregelilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox_photo
            // 
            /*this.pictureBox_photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.Image")));
            this.pictureBox_photo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_photo.InitialImage")));
            this.pictureBox_photo.Location = new System.Drawing.Point(114, 3);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(164, 161);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_photo.TabIndex = 301;
            this.pictureBox_photo.TabStop = false;*/
            // 
            // lbl_participation_number
            // 
            this.lbl_participation_number.AutoSize = true;
            this.lbl_participation_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_participation_number.Location = new System.Drawing.Point(110, 182);
            this.lbl_participation_number.Name = "lbl_participation_number";
            this.lbl_participation_number.Size = new System.Drawing.Size(93, 20);
            this.lbl_participation_number.TabIndex = 302;
            this.lbl_participation_number.Text = "የተሳትፎ ቁጥር";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(110, 206);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_name.TabIndex = 303;
            this.lbl_name.Text = "የተሳትፎ ቁጥር";
            // 
            // icon_attendance_add_participation_number_success
            // 
            this.icon_attendance_add_participation_number_success.BackColor = System.Drawing.SystemColors.Control;
            this.icon_attendance_add_participation_number_success.DialogResult = System.Windows.Forms.DialogResult.None;
            //this.icon_attendance_add_participation_number_success.Image = ((System.Drawing.Image)(resources.GetObject("icon_attendance_add_participation_number_success.Image")));
            this.icon_attendance_add_participation_number_success.ImageSize = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.Location = new System.Drawing.Point(381, 84);
            this.icon_attendance_add_participation_number_success.Name = "icon_attendance_add_participation_number_success";
            this.icon_attendance_add_participation_number_success.OnHoverImage = null;
            this.icon_attendance_add_participation_number_success.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.icon_attendance_add_participation_number_success.Size = new System.Drawing.Size(16, 16);
            this.icon_attendance_add_participation_number_success.TabIndex = 344;
            this.icon_attendance_add_participation_number_success.Visible = false;
            // 
            // lbl_attendance_add_participation_number_error
            // 
            this.lbl_attendance_add_participation_number_error.AutoSize = true;
            this.lbl_attendance_add_participation_number_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_attendance_add_participation_number_error.Location = new System.Drawing.Point(160, 103);
            this.lbl_attendance_add_participation_number_error.Name = "lbl_attendance_add_participation_number_error";
            this.lbl_attendance_add_participation_number_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_attendance_add_participation_number_error.TabIndex = 345;
            this.lbl_attendance_add_participation_number_error.Text = "label2";
            this.lbl_attendance_add_participation_number_error.Visible = false;
            // 
            // AttendanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_attendance);
            this.Name = "AttendanceUserControl";
            this.Size = new System.Drawing.Size(817, 423);
            this.tabControl_attendance.ResumeLayout(false);
            this.tabPage_add.ResumeLayout(false);
            this.tabPage_add.PerformLayout();
            this.panel_attendance_add.ResumeLayout(false);
            this.panel_attendance_add.PerformLayout();
            this.panel_attendance_add_info.ResumeLayout(false);
            this.panel_attendance_add_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDebregelilaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DebregelilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_attendance;
        private System.Windows.Forms.TabPage tabPage_add;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_year;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_month;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_add_date_day;
        private Guna.UI.WinForms.GunaImageButton btn_attendance_add_date;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Panel panel_attendance_add;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaLineTextBox txt_participation_number;
        private System.Windows.Forms.BindingSource dBDebregelilaDataSetBindingSource;
        private DB_DebregelilaDataSet dB_DebregelilaDataSet;
        private System.Windows.Forms.Panel panel_attendance_add_info;
        private Guna.UI.WinForms.GunaComboBox cmb_attendance_type;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_participation_number;
        private Guna.UI.WinForms.GunaImageButton icon_attendance_add_participation_number_success;
        private System.Windows.Forms.Label lbl_attendance_add_participation_number_error;
    }
}
