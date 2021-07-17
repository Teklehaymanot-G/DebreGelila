using FastFoodDemo.DateConverter;
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

namespace FastFoodDemo.Register
{
    public partial class AttendanceUserControl2 : UserControl
    {
        class AttendanceInfo
        {
            [Browsable(false)]
            public int member_id { get; set; }
            [DisplayName("የተሳትፎ ቁጥር")]
            public string participation_number { get; set; }
            [DisplayName("ሙሉ ስም")]
            public string name { get; set; }
            [DisplayName("አቴንዳስ")]
            public string type { get; set; }
        }

        List<AttendanceInfo> info = new List<AttendanceInfo>();
        
        String date_created = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        String date_modified = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        public int loginMemberId = 1;

        //===================================================
        bool startDateIsNotChanged = true;
        bool endDateIsNotChanged = true;       


        public AttendanceUserControl2()
        {
            InitializeComponent();
            lbl_start_date.Text = "";
            lbl_end_date.Text = "";
        }

        private void cmb_attendance_add_date_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            // empty cmb_attendance_add_month_1
            cmb_attendance_add_date_month.Items.Clear();
            cmb_attendance_add_date_month.DisplayMember = "Text";
            cmb_attendance_add_date_month.ValueMember = "Text";

            cmb_attendance_add_date_month.Items.Add(new { Text = "ወር" });
            cmb_attendance_add_date_month.SelectedIndex = 0;

            // if year selected fill month names
            if (cmb_attendance_add_date_year.SelectedIndex != 0)
            {
                cmb_attendance_add_date_month.Items.Add(new { Text = "መስከረም" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ጥቅምት" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ሕዳር" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ታሕሳስ" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ጥር" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "የካቲት" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "መጋቢት" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ሚያዚያ" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ግንቦት" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ሰኔ" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ሐምሌ" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ነሐሴ" });
                cmb_attendance_add_date_month.Items.Add(new { Text = "ጷጉሜን" });
            }


            // empty cmb_attendance_add_day_1
            cmb_attendance_add_date_day.Items.Clear();
            cmb_attendance_add_date_day.DisplayMember = "Text";
            cmb_attendance_add_date_day.ValueMember = "Text";

            cmb_attendance_add_date_day.Items.Add(new { Text = "ቀን" });
            cmb_attendance_add_date_day.SelectedIndex = 0;
        }

        private void cmb_attendance_add_date_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if month is not selected day become empty then return
                if (cmb_attendance_add_date_month.SelectedIndex == 0)
                {
                    cmb_attendance_add_date_day.Items.Clear();
                    cmb_attendance_add_date_day.DisplayMember = "Text";
                    cmb_attendance_add_date_day.ValueMember = "Text";

                    cmb_attendance_add_date_day.Items.Add(new { Text = "ቀን" });
                    cmb_attendance_add_date_day.SelectedIndex = 0;

                    return;
                }



                // empty cmb_attendance_add_day_1 and add 5 days
                cmb_attendance_add_date_day.Items.Clear();
                cmb_attendance_add_date_day.DisplayMember = "Text";
                cmb_attendance_add_date_day.ValueMember = "Text";

                cmb_attendance_add_date_day.Items.Add(new { Text = "ቀን" });
                cmb_attendance_add_date_day.Items.Add(new { Text = "1" });
                cmb_attendance_add_date_day.Items.Add(new { Text = "2" });
                cmb_attendance_add_date_day.Items.Add(new { Text = "3" });
                cmb_attendance_add_date_day.Items.Add(new { Text = "4" });
                cmb_attendance_add_date_day.Items.Add(new { Text = "5" });

                cmb_attendance_add_date_day.SelectedIndex = 0;

                // if month is not equal ጷጉሜን add days from 6-30 
                if (cmb_attendance_add_date_month.Text != "ጷጉሜን")
                {
                    cmb_attendance_add_date_day.Items.Add(new { Text = "6" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "7" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "8" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "9" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "10" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "11" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "12" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "13" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "14" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "15" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "16" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "17" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "18" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "19" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "20" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "21" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "22" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "23" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "24" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "25" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "26" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "27" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "28" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "29" });
                    cmb_attendance_add_date_day.Items.Add(new { Text = "30" });
                }
                // if month is ጷጉሜን
                else
                {
                    // if year is not empty
                    if (cmb_attendance_add_date_year.SelectedIndex != 0)
                    {
                        // convert year to int
                        int yearInt = int.Parse(cmb_attendance_add_date_year.Text.ToString());

                        // check the if the year has 6 days in ጷጉሜን
                        if (yearInt % 4 == 3)
                            cmb_attendance_add_date_day.Items.Add(new { Text = "6" });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_attendance_add_date_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_attendance_add_date_Click(object sender, EventArgs e)
        {
            if (cmb_attendance_add_date_year.SelectedIndex == 0 ||
                cmb_attendance_add_date_month.SelectedIndex == 0 ||
                cmb_attendance_add_date_day.SelectedIndex == 0)
            {
                panel_attendance_add.Visible = false;
                MessageBox.Show("ቀን በትክክል ይምረጡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panel_attendance_add.Visible = true;
        }

        private void txt_participation_number_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    panel_attendance_add_info.Visible = false;
                    txt_participation_number.LineColor = Color.Gray;
                    txt_participation_number.FocusedLineColor = Color.FromArgb(73, 160, 174);

                    if (txt_participation_number.Text == "")
                    {
                        panel_attendance_add_info.Visible = false;
                        txt_participation_number.LineColor = Color.Red;
                        txt_participation_number.FocusedLineColor = Color.Red;
                        icon_attendance_add_participation_number_success.Visible = false;
                        lbl_attendance_add_participation_number_error.Text = "እባክዎ የተሳትፎ ቁጥር ይምረጡ";
                        lbl_attendance_add_participation_number_error.Visible = true;
                        return;
                    }

                    if (info.Exists(x => x.participation_number.Equals(txt_participation_number.Text)))
                    {
                        panel_attendance_add_info.Visible = false;
                        txt_participation_number.LineColor = Color.Red;
                        txt_participation_number.FocusedLineColor = Color.Red;
                        icon_attendance_add_participation_number_success.Visible = false;
                        lbl_attendance_add_participation_number_error.Text = "የአባሉ መረጃ ገብቷል";
                        lbl_attendance_add_participation_number_error.Visible = true;
                        return;
                    }

                    string sql = "SELECT [general_info_id], [photo], [full_name] " +
                            "FROM [general_info]" +
                            "WHERE participation_number = @participation_number";
                    SqlConnection conn = DatabaseConnection.getConnection();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@participation_number", txt_participation_number.Text);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            panel_attendance_add_info.Visible = true;

                            string photo = reader.GetString(1);
                            string name = reader.GetString(2);

                            if (getSqlStringData(reader, "photo") != "")
                            {
                                String photo_old = getSqlStringData(reader, "photo");
                                String dest = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,
                                    "upload",
                                    getSqlStringData(reader, "photo"));
                                //String dest = @"C:\Users\Teklehaymnot\Desktop\ደብረ ገሊላ\upload\" + getSqlStringData(reader, "photo");
                                if (File.Exists(dest))
                                    pictureBox_photo.Image = new Bitmap(dest);
                                else
                                    pictureBox_photo.Image = pictureBox_photo.InitialImage;
                            }

                            lbl_name.Text = getSqlStringData(reader, "full_name");
                            lbl_participation_number.Text = txt_participation_number.Text;

                            txt_participation_number.LineColor = Color.Gray;
                            txt_participation_number.FocusedLineColor = Color.FromArgb(73, 160, 174);

                            AttendanceInfo p = new AttendanceInfo();
                            p.participation_number = txt_participation_number.Text;
                            p.member_id = getSqlIntData(reader, "general_info_id");
                            p.name = getSqlStringData(reader, "full_name");
                            p.type = cmb_attendance_type.SelectedItem.ToString();
                            info.Add(p);

                            txt_participation_number.Text = "";
                            icon_attendance_add_participation_number_success.Visible = true;
                            lbl_attendance_add_participation_number_error.Text = "";
                            lbl_attendance_add_participation_number_error.Visible = false;
                        }
                        else
                        {
                            panel_attendance_add_info.Visible = false;
                            txt_participation_number.LineColor = Color.Red;
                            txt_participation_number.FocusedLineColor = Color.Red;
                            icon_attendance_add_participation_number_success.Visible = false;
                            lbl_attendance_add_participation_number_error.Text = "የአባሉ የተሳትፎ ቁጥር አይገኝም";
                            lbl_attendance_add_participation_number_error.Visible = true;
                        }
                    }

                    else
                    {
                        panel_attendance_add_info.Visible = false;
                        txt_participation_number.LineColor = Color.Red;
                        txt_participation_number.FocusedLineColor = Color.Red;
                        icon_attendance_add_participation_number_success.Visible = false;
                        lbl_attendance_add_participation_number_error.Text = "የአባሉ የተሳትፎ ቁጥር አይገኝም";
                        lbl_attendance_add_participation_number_error.Visible = true;
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getSqlStringData(SqlDataReader reader, string col)
        {
            try
            {
                return reader.GetString(reader.GetOrdinal(col));
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            return "";
        }

        private int getSqlIntData(SqlDataReader reader, string col)
        {
            try
            {
                return reader.GetInt32(reader.GetOrdinal(col));
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            return -1;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            String attendance_date = cmb_attendance_add_date_month.Text + " " +
                "" + cmb_attendance_add_date_day.Text + " " + cmb_attendance_add_date_year.Text;
            attendance_date = attendance_date.Replace("ወር ", "").Trim();
            attendance_date = attendance_date.Replace("ቀን", "").Trim();
            attendance_date = attendance_date.Replace("ዓመት", "").Trim();

            int success = 0;

            foreach (AttendanceInfo item in info)
            {
                try
                {
                    String sql = "INSERT INTO attendance_info " +
                        "(member_id, date_eth, type, " +
                        "user_created, date_created, " +
                        "user_modified, date_modified)" +

                        " VALUES (@member_id, @date_eth, @type, " +
                        "@user_created, @date_created, " +
                        "@user_modified, @date_modified)";

                    SqlConnection conn = DatabaseConnection.getConnection();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@member_id", item.member_id);
                    cmd.Parameters.AddWithValue("@date_eth", attendance_date);
                    cmd.Parameters.AddWithValue("@type", item.type);
                    cmd.Parameters.AddWithValue("@user_created", loginMemberId);
                    cmd.Parameters.AddWithValue("@date_created", date_created);
                    cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                    cmd.Parameters.AddWithValue("@date_modified", date_modified);

                    conn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                    conn.Close();
                    if (result > 0)
                    {
                        success++;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(success > 0)
            {
                MessageBox.Show("መረጃው በትክክል ተመዝግቧል");

                dgv_attendance_add.DataSource = null;
                panel_attendance_add_table.Visible = false;

                lbl_participation_number.Text = "";
                lbl_name.Text = "";
                pictureBox_photo.Image = pictureBox_photo.InitialImage;
                panel_attendance_add_info.Visible = false;

                icon_attendance_add_participation_number_success.Visible = false;
                txt_participation_number.Text = "";
                lbl_attendance_add_participation_number_error.Text = "";
                cmb_attendance_type.SelectedIndex = 0;
                panel_attendance_add.Visible = false;

                cmb_attendance_add_date_day.SelectedIndex = 0;
                cmb_attendance_add_date_month.SelectedIndex = 0;
                cmb_attendance_add_date_year.SelectedIndex = 0;
            }
        }

        private void btn_attendance_view_Click(object sender, EventArgs e)
        {
            try
            {
                panel_attendance_add_table.Visible = true;
                var bindingList = new BindingList<AttendanceInfo>(info);
                var source = new BindingSource(bindingList, null);
                dgv_attendance_add.DataSource = source;
                dgv_attendance_add.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalReports.attendanceWithImageCrystalReport crpt_img = new CrystalReports.attendanceWithImageCrystalReport();
                CrystalReports.attendanceCrystalReport crpt = new CrystalReports.attendanceCrystalReport();
                filterCrystalReportViewer.Visible = true;

                string sql = "SELECT * FROM view_for_attendance_report";

                // none is selected
                if (startDateIsNotChanged && endDateIsNotChanged && cmb_type.SelectedIndex == 0 && cmb_sex.SelectedIndex == 0)
                    return;
                
                // only start
                else if (endDateIsNotChanged && cmb_type.SelectedIndex == 0 && cmb_sex.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_attendance_report WHERE date_created = '" + dtp_start.Value + "'";
                // only end
                else if (startDateIsNotChanged && cmb_type.SelectedIndex == 0 && cmb_sex.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_attendance_report WHERE date_created = '" + dtp_end.Value + "'";
                // only both start, end
                else if (cmb_type.SelectedIndex == 0 && cmb_sex.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_attendance_report WHERE " +
                        "date_created BETWEEN '" + dtp_start.Value + "' AND '" + dtp_end.Value + "' ";

                // only sex
                else if(cmb_type.SelectedIndex == 0)
                {
                    // only sex
                    if(startDateIsNotChanged && endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "'";
                    // only sex, start
                    else if (endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                            "date_created = '" + dtp_start.Value + "'";
                    // only sex, end
                    else if (startDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                            "date_created = '" + dtp_end.Value + "'";
                    // only sex, start, end
                    else
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND  " +
                            "date_created BETWEEN '" + dtp_start.Value + "' AND '" + dtp_end.Value + "' ";
                }
                // only type
                else if (cmb_sex.SelectedIndex == 0)
                {
                    // only type
                    if (startDateIsNotChanged && endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE type = N'" + cmb_type.SelectedItem + "'";
                    // only type, start
                    else if (endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE type = N'" + cmb_type.SelectedItem + "' AND " +
                            "date_created = '" + dtp_start.Value + "'";
                    // only type, end
                    else if (startDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE type = N'" + cmb_type.SelectedItem + "' AND " +
                            "date_created = '" + dtp_end.Value + "'";
                    // only type, start, end
                    else
                        sql = "SELECT * FROM view_for_attendance_report WHERE type = N'" + cmb_type.SelectedItem + "' AND  " +
                            "date_created BETWEEN '" + dtp_start.Value + "' AND '" + dtp_end.Value + "' ";
                }
                // both sex, type
                else 
                {
                    // only sex, type
                    if (startDateIsNotChanged && endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                            "type = N'" + cmb_type.SelectedItem + "'";
                    // only sex, type, start
                    else if (endDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                            "type = N'" + cmb_type.SelectedItem + "' AND date_created = '" + dtp_start.Value + "'";
                    // only sex, type, end
                    else if (startDateIsNotChanged)
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                            "type = N'" + cmb_type.SelectedItem + "' AND date_created = '" + dtp_end.Value + "'";
                    // only sex, type, start, end
                    else
                        sql = "SELECT * FROM view_for_attendance_report WHERE sex = N'" + cmb_sex.SelectedItem + "' AND  " +
                            "type = N'" + cmb_type.SelectedItem + "' AND date_created BETWEEN '" + dtp_start.Value + "' AND " +
                            "'" + dtp_end.Value + "' ";
                }
                
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                

                filterCrystalReportViewer.ReportSource = null;

                if (check_add_photo.Checked)
                {
                    crpt_img.SetDataSource(dataSet.Tables[0]);
                    crpt_img.SetParameterValue("AppPath", Application.StartupPath + @"\upload\");
                    filterCrystalReportViewer.ReportSource = crpt_img;
                }
                else
                {
                    crpt.SetDataSource(dataSet.Tables[0]);
                    filterCrystalReportViewer.ReportSource = crpt;
                }

                filterCrystalReportViewer.Zoom(1);
                filterCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            endDateIsNotChanged = false;
            lbl_end_date.Text = MyDateConverter.FromGrigorianToEthiopian(dtp_end.Value);
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            startDateIsNotChanged = false;
            lbl_start_date.Text = MyDateConverter.FromGrigorianToEthiopian(dtp_start.Value);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today;

            startDateIsNotChanged = true;
            endDateIsNotChanged = true;


            lbl_start_date.Visible = false;
            lbl_end_date.Visible = false;

            cmb_type.SelectedIndex = 0;
            cmb_sex.SelectedIndex = 0;

            check_add_photo.Checked = false;

            filterCrystalReportViewer.ReportSource = null;
            filterCrystalReportViewer.Refresh();
        }
    }
}
