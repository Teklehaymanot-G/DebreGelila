namespace FastFoodDemo.Register
{
    partial class LoginUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserControl));
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_participation_number = new Guna.UI.WinForms.GunaLineTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "የተሳትፎ ቁጥር";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.LineColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(533, 203);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(163, 26);
            this.txt_password.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 131;
            this.label1.Text = "የይለፍ ቁጥር";
            // 
            // txt_participation_number
            // 
            this.txt_participation_number.BackColor = System.Drawing.SystemColors.Control;
            this.txt_participation_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_participation_number.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.txt_participation_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_participation_number.LineColor = System.Drawing.Color.Gray;
            this.txt_participation_number.Location = new System.Drawing.Point(533, 168);
            this.txt_participation_number.Name = "txt_participation_number";
            this.txt_participation_number.PasswordChar = '\0';
            this.txt_participation_number.Size = new System.Drawing.Size(163, 26);
            this.txt_participation_number.TabIndex = 130;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 157;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Gray;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(565, 257);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(106, 38);
            this.btn_login.TabIndex = 160;
            this.btn_login.Text = "  ይግቡ";
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_participation_number);
            this.Name = "LoginUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(817, 423);
            this.Click += new System.EventHandler(this.LoginUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaLineTextBox txt_password;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txt_participation_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
    }
}
