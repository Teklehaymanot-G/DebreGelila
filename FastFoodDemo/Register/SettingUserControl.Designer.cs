namespace FastFoodDemo.Register
{
    partial class SettingUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingUserControl));
            this.dgv_setting = new System.Windows.Forms.DataGridView();
            this.txt_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_status = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_participation_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.icon_participation_number_success = new Guna.UI.WinForms.GunaImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_full_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_reload = new Guna.UI.WinForms.GunaImageButton();
            this.tt_reset = new System.Windows.Forms.ToolTip(this.components);
            this.tt_add = new System.Windows.Forms.ToolTip(this.components);
            this.tt_delete = new System.Windows.Forms.ToolTip(this.components);
            this.tt_edit = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_setting
            // 
            this.dgv_setting.AllowUserToAddRows = false;
            this.dgv_setting.AllowUserToDeleteRows = false;
            this.dgv_setting.AllowUserToResizeColumns = false;
            this.dgv_setting.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_setting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_setting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_setting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_setting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_setting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_setting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_setting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_setting.ColumnHeadersHeight = 30;
            this.dgv_setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_setting.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_setting.EnableHeadersVisualStyles = false;
            this.dgv_setting.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_setting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_setting.Location = new System.Drawing.Point(43, 43);
            this.dgv_setting.MultiSelect = false;
            this.dgv_setting.Name = "dgv_setting";
            this.dgv_setting.ReadOnly = true;
            this.dgv_setting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_setting.RowHeadersVisible = false;
            this.dgv_setting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_setting.Size = new System.Drawing.Size(731, 201);
            this.dgv_setting.TabIndex = 1;
            this.dgv_setting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_setting_CellClick);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.LineColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(145, 322);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.Size = new System.Drawing.Size(210, 26);
            this.txt_password.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 177;
            this.label7.Text = "የሚስጥር ቁጥር";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 180;
            this.label1.Text = "መግባት ይቻል";
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status.BaseColor = System.Drawing.Color.White;
            this.cmb_status.BorderColor = System.Drawing.Color.Silver;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "አዎ ይቻል",
            "አይ አይቻል"});
            this.cmb_status.Location = new System.Drawing.Point(145, 354);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.cmb_status.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_status.Size = new System.Drawing.Size(210, 26);
            this.cmb_status.StartIndex = 0;
            this.cmb_status.TabIndex = 181;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 183;
            this.label3.Text = "ሙሉ ስም";
            // 
            // txt_participation_number
            // 
            this.txt_participation_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_participation_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_participation_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_participation_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_participation_number.LineColor = System.Drawing.Color.Gray;
            this.txt_participation_number.Location = new System.Drawing.Point(145, 258);
            this.txt_participation_number.Name = "txt_participation_number";
            this.txt_participation_number.PasswordChar = '\0';
            this.txt_participation_number.Size = new System.Drawing.Size(210, 26);
            this.txt_participation_number.TabIndex = 182;
            this.txt_participation_number.TextChanged += new System.EventHandler(this.txt_participation_number_TextChanged);
            this.txt_participation_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_participation_number_KeyDown);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Gray;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(560, 344);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 42);
            this.btn_edit.TabIndex = 185;
            this.btn_edit.Text = "  ያስተካክሉ";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(670, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 42);
            this.btn_delete.TabIndex = 184;
            this.btn_delete.Text = "  ያጥፉ";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gray;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(450, 344);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 42);
            this.btn_add.TabIndex = 186;
            this.btn_add.Text = "  ያስገቡ";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // icon_participation_number_success
            // 
            this.icon_participation_number_success.BackColor = System.Drawing.SystemColors.Control;
            this.icon_participation_number_success.DialogResult = System.Windows.Forms.DialogResult.None;
            this.icon_participation_number_success.Image = ((System.Drawing.Image)(resources.GetObject("icon_participation_number_success.Image")));
            this.icon_participation_number_success.ImageSize = new System.Drawing.Size(16, 16);
            this.icon_participation_number_success.Location = new System.Drawing.Point(361, 268);
            this.icon_participation_number_success.Name = "icon_participation_number_success";
            this.icon_participation_number_success.OnHoverImage = null;
            this.icon_participation_number_success.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.icon_participation_number_success.Size = new System.Drawing.Size(16, 16);
            this.icon_participation_number_success.TabIndex = 346;
            this.icon_participation_number_success.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 345;
            this.label2.Text = "የተሳትፎ ቁጥር";
            // 
            // txt_full_name
            // 
            this.txt_full_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_full_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_full_name.Enabled = false;
            this.txt_full_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_full_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_full_name.LineColor = System.Drawing.Color.Gray;
            this.txt_full_name.Location = new System.Drawing.Point(145, 290);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.PasswordChar = '\0';
            this.txt_full_name.Size = new System.Drawing.Size(210, 26);
            this.txt_full_name.TabIndex = 344;
            // 
            // btn_reload
            // 
            this.btn_reload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_reload.Location = new System.Drawing.Point(412, 348);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.OnHoverImage = null;
            this.btn_reload.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_reload.Size = new System.Drawing.Size(32, 32);
            this.btn_reload.TabIndex = 347;
            this.tt_reset.SetToolTip(this.btn_reload, "ገጹን እንደገና ያስጀምሩ");
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // SettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.icon_participation_number_success);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_full_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_participation_number);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_setting);
            this.Name = "SettingUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_setting;
        private Guna.UI.WinForms.GunaLineTextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmb_status;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLineTextBox txt_participation_number;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private Guna.UI.WinForms.GunaImageButton icon_participation_number_success;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txt_full_name;
        private Guna.UI.WinForms.GunaImageButton btn_reload;
        private System.Windows.Forms.ToolTip tt_reset;
        private System.Windows.Forms.ToolTip tt_add;
        private System.Windows.Forms.ToolTip tt_edit;
        private System.Windows.Forms.ToolTip tt_delete;
    }
}
