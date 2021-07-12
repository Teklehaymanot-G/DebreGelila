using FastFoodDemo.DateConverter;
using FastFoodDemo.ListData;
using FastFoodDemo.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public bool loginSuccess = false;
        public int loginMemberId = -1;
        public bool is_listDataUserControl_1 = true;
        AttendanceUserControl2 attendanceUserControl2 = new AttendanceUserControl2();

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = 0;
            SidePanel.Top = loginUserControl1.Top;
            loginUserControl1.BringToFront();

            // clear text before login
            change_login_name("", "");

            //firstUserControl1.BringToFront();


            Controls.Add(attendanceUserControl2);
            attendanceUserControl2.Dock = editUserControl1.Dock;
            attendanceUserControl2.Location = editUserControl1.Location;
        }

        public Form1(bool loginSuccess, int loginMemberId, UserControl userControl, Button menu)
        {
            InitializeComponent();
            this.loginSuccess = loginSuccess;
            this.loginMemberId = loginMemberId;

            SidePanel.Height = menu.Height;
            SidePanel.Top = menu.Top;
            userControl.BringToFront();
            
            if(userControl == listDataUserControl1)
                listDataUserControl1.loadDataToDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginSuccess)
            {
                SidePanel.Height = btn_menu_main_dgv.Height;
                SidePanel.Top = btn_menu_main_dgv.Top;
                
                // load data
                listDataUserControl1.loadDataToDataGridView();

                this.Controls.Add(listDataUserControl1);
                listDataUserControl1.BringToFront();

                // clear edit form
                editUserControl1.reset_form();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (loginSuccess)
            {
                SidePanel.Height = btn_menu_main_dgv.Height;
                SidePanel.Top = btn_menu_search.Top;
                simpleSearch1.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (loginSuccess)
            {
                SidePanel.Height = btn_menu_register.Height;
                SidePanel.Top = btn_menu_register.Top;
                
                // login id
                registerUserControl1.loginMemberId = loginMemberId;
                
                registerUserControl1.BringToFront();
                
                // clear form
                registerUserControl1.reset_form();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (loginUserControl1.participation_number == loginUserControl1.password)
                loginSuccess = false;
            else
            {
                if (login(loginUserControl1.participation_number, loginUserControl1.password))
                {
                    loginSuccess = true;
                    SidePanel.Height = btn_menu_main_dgv.Height;
                    SidePanel.Top = btn_menu_main_dgv.Top;
                    listDataUserControl1.BringToFront();
                    listDataUserControl1.loadDataToDataGridView();
                    listDataUserControl1.loginMemberId = loginMemberId.ToString();
                    lbl_header_line.Text = "_____________________________________________________________________________________________________________";
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (listDataUserControl1.general_info_id == "-1")
                return;
            else
            {
                SidePanel.Height = btn_menu_main_dgv.Height;
                SidePanel.Top = btn_menu_main_dgv.Top;
                editUserControl1.load_data(listDataUserControl1.general_info_id);
                editUserControl1.BringToFront();
            }
        }

        private bool login(string participation_number, string password)
        {
            try
            {
                String sql = "SELECT general_info_id, status, full_name, photo " +
                    "FROM general_info INNER JOIN user_account " +
                    "ON general_info_id = member_id " +
                    "WHERE participation_number = '@participation_number' AND password = '@password'";

                sql = "SELECT general_info_id, status, full_name, photo FROM view_for_login WHERE " +
                    "participation_number=@participation_number AND " +
                    "password=@password";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@participation_number", participation_number);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int general_info_id = reader.GetInt32(0);
                    int status = reader.GetInt32(1);

                    if (status == 1)
                    {
                        loginMemberId = general_info_id;
                        change_login_name(reader.GetString(2), participation_number);

                        if (reader.GetString(3) != "")
                        {
                            String dest = Application.StartupPath + @"\upload\" + reader.GetString(3);
                            if (File.Exists(dest))
                            {
                                pictureBox_login_photo.Image = new Bitmap(dest);
                                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                                int len = 3;
                                gp.AddEllipse(0, 0, pictureBox_login_photo.Width - len, pictureBox_login_photo.Height - len);
                                Region rg = new Region(gp);
                                pictureBox_login_photo.Region = rg;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("አካውንትዎ ለጊዜው ተዘግቷል", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("የተሳትፎ ቁጥር ወይም/እና የይለፍ ቁጥር ተሳስቷል።", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (loginMemberId != -1)
            {
                settingUserControl1.BringToFront();
                settingUserControl1.loadDataToDataGridView();
            }
        }

        public void change_login_name(string name, string participation_number)
        {
            lbl_login_name.Text = name;
            lbl_login_participation_number.Text = participation_number;
        }

        private void btn_menu_filter_Click(object sender, EventArgs e)
        {
            if (loginMemberId != -1)
            {
                SidePanel.Height = btn_menu_filter.Height;
                SidePanel.Top = btn_menu_filter.Top;
                filterUserControl1.BringToFront();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            if (loginMemberId != -1)
            {
                registerUserControl1.reset_form();
                editUserControl1.reset_form();
                loginSuccess = false;
                loginMemberId = -1;
                is_listDataUserControl_1 = true;
                loginUserControl1.BringToFront();

                change_login_name("", "");
                pictureBox_login_photo.Image = null;
                lbl_header_line.Text = "______________________________________________";
            }
        }

        private void btn_menu_attendance_Click(object sender, EventArgs e)
        {
            if (loginMemberId != -1)
            {
                SidePanel.Height = btn_menu_attendance.Height;
                SidePanel.Top = btn_menu_attendance.Top;
                attendanceUserControl2.BringToFront();
            }
        }
    }
}
