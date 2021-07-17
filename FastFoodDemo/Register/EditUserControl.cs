using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using FastFoodDemo.ListData;
using CrystalDecisions.CrystalReports.Engine;

namespace FastFoodDemo.Register
{
    public partial class EditUserControl : UserControl
    {

        string general_info_id = "-1";
        //===================================================
        //panel first
        String full_name = "", christian_name = "", mother_name = "", birth_day = "", sex = "ወንድ";
        String registration_date = "", date_fill_info = "", why_christianity_date = "", participation_number = "";
        String participation_number_for_db = "";
        int christianity_date = 1; //1- በ ፵/ ፹ቀን, 2-ከዚያውጪ
        bool is_imageChanged = false;
        string photo_old = "";
        string image_path = "";
        //===================================================

        //===================================================
        //panel second
        String sub_city = "", woreda = "", kebele = "", house_number = "", cell_phone = "";
        String home_phone = "", email = "", church_before = "";
        //===================================================

        //===================================================
        //panel third
        String secular_educational_level = "", spritual_educational_level = "";
        String secular_educational_qualification = "", spritual_educational_qualification = "";
        String school_name = "";
        String work_skill = "", work_role = "", work_place = "", work_company_name = "";
        //===================================================

        //===================================================
        //panel fourth
        String church = "", subjects = "", subject_other = "";
        int course_before = 1, year = 1;
        //===================================================

        //===================================================
        //panel fifth
        String spouse_name = "", spouse_christian_name = "", spouse_work_place = "";
        String spouse_work_position = "", spouse_role = "", spouse_spritual_education = "";
        String spouse_secular_education = "", children_name = "", children_birth_date = "";
        string children_name_old = "", children_birth_date_old = "";
        int married = 1, children_count = 0, children_count_old = 0, children_count_iterator = 0;
        // 0 = append, 1 = clear
        int children_append = -1;
        //===================================================

        //===================================================
        //panel sixth
        String emergency_name = "", emergency_phone = "", repentance_father_name = "";
        String repentance_father_place = "", partner_date = "", partner_participation_number = "";
        bool is_partner_participation_number_changed = false;
        int partner_member_id_old = -1;
        int partner_member_id = -1;
        //===================================================

        //===================================================
        //panel seventh
        String serve = "";
        List<String> serve_list = new List<string>();
        int serve_listbox_iterator = 0;
        //===================================================

        //===================================================
        //panel eighth
        //በንዑስነት ፡- ክፍል እና ጊዜ eg መዝሙር ክፍል ፣ 2 ዓመት ፤ ትምህርት ክፍል ፣ አራት አመት ፤
        String leadership_service = "", sub_service = "", sector_service = "";
        String leadership_service_old = "", sub_service_old = "", sector_service_old = "";
        // 0 = append, 1 = clear
        int leadership_service_append = -1, sub_service_append = -1, sector_service_append = -1;
        int leadership_service_iterator = 0, sub_service_iterator = 0, sector_service_iterator = 0;
        //===================================================

        //===================================================
        //for all
        int user_modified = 1;
        String date_modified = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        //===================================================

        public int loginMemberId = 1;



        public object SidePanel { get; private set; }

        //===================================================

        public void load_data(string id)
        {
            general_info_id = id;

            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(panel_1);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            put_general_info(general_info_id);
            put_address_info(general_info_id);
            put_educational_background(general_info_id);
            put_work_info(general_info_id);
            put_spritual_education_background(general_info_id);
            put_family_info(general_info_id);
            put_service_info(general_info_id);
        }

        public EditUserControl()
        {
            InitializeComponent();

            // store person image to initial image 
            // and we will restore it when we need refreash oir picture box
            pictureBox.InitialImage = pictureBox.Image;
        }


        private void put_general_info(string general_info_id)
        {
            try
            {
                string sql = "SELECT * FROM general_info WHERE general_info_id='" + general_info_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_participation_number_1.Text = getSqlIntData(reader, "participation_number").ToString();
                    txt_full_name_1.Text = getSqlStringData(reader, "full_name");
                    txt_christian_name_1.Text = getSqlStringData(reader, "christian_name");
                    txt_mother_name_1.Text = getSqlStringData(reader, "mother_name");
                    lbl_birth_day_1.Text = getSqlStringData(reader, "birth_day");
                    if (getSqlStringData(reader, "sex").Trim() == "ወንድ")
                        radio_sex_male_1.Checked = true;
                    else
                        radio_sex_female_1.Checked = true;
                    lbl_registration_date_1.Text = getSqlStringData(reader, "registration_date");
                    lbl_fill_date_1.Text = getSqlStringData(reader, "date_fill_info");
                    if (getSqlIntData(reader, "christianity_date") == 1)
                        radio_christianity_date_40_80_1.Checked = true;
                    else
                    {
                        radio_christianity_date_other_1.Checked = true;
                        txt_why_christianity_date_1.Text = getSqlStringData(reader, "why_christianity_date");
                        panel_christian_date_other_1.Visible = true;
                    }

                    if (getSqlStringData(reader, "photo") != "")
                    {
                        photo_old = getSqlStringData(reader, "photo");
                        String dest = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, 
                            "upload", 
                            getSqlStringData(reader, "photo"));
                        //String dest = @"C:\Users\Teklehaymnot\Desktop\ደብረ ገሊላ\upload\" + getSqlStringData(reader, "photo");
                        if(File.Exists(dest))
                            pictureBox.Image = new Bitmap(dest);
                    }
                    serveListInit(getSqlStringData(reader, "serve"));
                    
                    txt_emergency_name_6.Text = getSqlStringData(reader, "emergency_name");
                    txt_emergency_phone_6.Text = getSqlStringData(reader, "emergency_phone");
                    txt_repentance_father_name_6.Text = getSqlStringData(reader, "repentance_father_name");
                    txt_repentance_father_place_6.Text = getSqlStringData(reader, "repentance_father_place");

                    lbl_partner_date_7.Text = getSqlStringData(reader, "partner_date");
                    string[] partner = get_partner_info(general_info_id, getSqlStringData(reader, "partner_member_id")).Split('፤');
                    txt_partner_participation_number_6.Text = partner[0];
                    txt_partner_name_6.Text = partner[1];
                    txt_partner_phone_6.Text = partner[2];
                    partner_member_id = Int32.Parse(getSqlStringData(reader, "partner_member_id"));
                    partner_member_id_old = partner_member_id;

                    txt_partner_participation_number_6.LineColor = txt_partner_name_6.LineColor;
                    txt_partner_participation_number_6.FocusedLineColor = txt_partner_name_6.FocusedLineColor;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_address_info(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM address_info WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_sub_city_2.Text = getSqlStringData(reader, "sub_city");
                    txt_woreda_2.Text = getSqlStringData(reader, "woreda");
                    txt_kebele_2.Text = getSqlStringData(reader, "kebele");
                    txt_house_number_2.Text = getSqlStringData(reader, "house_number");
                    txt_cell_phone_2.Text = getSqlStringData(reader, "cell_phone");
                    txt_home_phone_2.Text = getSqlStringData(reader, "home_phone");
                    txt_email_2.Text = getSqlStringData(reader, "email");
                    txt_church_before_2.Text = getSqlStringData(reader, "church_before");                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_educational_background(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM educational_background WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(getSqlStringData(reader, "type") == "መንፈሳዊ")
                    {
                        txt_spritual_educational_level_3.Text = getSqlStringData(reader, "educational_level");
                        txt_spritual_educational_qualification_3.Text = getSqlStringData(reader, "educational_qualification");
                    }
                    else if (getSqlStringData(reader, "type") == "ዓለማዊ")
                    {
                        txt_secular_educational_level_3.Text = getSqlStringData(reader, "educational_level");
                        txt_secular_educational_qualification_3.Text = getSqlStringData(reader, "educational_qualification");
                        txt_school_name_3.Text = getSqlStringData(reader, "school_name");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_work_info(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM work_info WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_work_skill_3.Text = getSqlStringData(reader, "skill");
                    txt_work_role_3.Text = getSqlStringData(reader, "role");
                    txt_work_place_3.Text = getSqlStringData(reader, "place");
                    txt_work_company_name_3.Text = getSqlStringData(reader, "company_name");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_spritual_education_background(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM spritual_education_background WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (getSqlIntData(reader, "course_before") == 1)
                    {
                        radio_course_before_yes_4.Checked = true;
                        panel_year_4.Visible = false;
                        panel_church_4.Visible = true;
                        panel_course_before_yes_4.Visible = true;

                        txt_church_4.Text = getSqlStringData(reader, "church");
                        txt_subject_other_4.Text = getSqlStringData(reader, "subject_other");

                        string[] subjectArray = getSqlStringData(reader, "subjects").Split('፣');
                        foreach(object key in subjectArray)
                        {
                            if (key.ToString() == "1")
                                check_subject_1_4.Checked = true;
                            else if (key.ToString() == "2")
                                check_subject_2_4.Checked = true;
                            else if (key.ToString() == "3")
                                check_subject_3_4.Checked = true;
                            else if (key.ToString() == "4")
                                check_subject_4_4.Checked = true;
                            else if (key.ToString() == "5")
                                check_subject_5_4.Checked = true;
                        }
                    }
                    else if (getSqlIntData(reader, "course_before") == 2)
                    {
                        radio_course_before_no_4.Checked = true;

                        panel_year_4.Visible = false;
                        panel_church_4.Visible = false;
                        panel_course_before_yes_4.Visible = false;
                    }
                    else if (getSqlIntData(reader, "course_before") == 3)
                    {
                        radio_course_before_progress_4.Checked = true;

                        panel_year_4.Visible = true;
                        panel_church_4.Visible = true;
                        panel_course_before_yes_4.Visible = false;

                        num_year_4.Value = getSqlIntData(reader, "year");
                        txt_church_4.Text = getSqlStringData(reader, "church");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_family_info(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM family_info WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (getSqlIntData(reader, "married") == 1)
                    {
                        radio_married_yes_5.Checked = true;
                        txt_spouse_name_5.Text = getSqlStringData(reader, "spouse_name");
                        txt_spouse_christian_name_5.Text = getSqlStringData(reader, "spouse_christian_name");
                        txt_spouse_work_place_5.Text = getSqlStringData(reader, "spouse_work_place");
                        txt_spouse_work_position_5.Text = getSqlStringData(reader, "spouse_work_position");
                        txt_spouse_role_5.Text = getSqlStringData(reader, "spouse_role");
                        txt_spouse_spritual_education_5.Text = getSqlStringData(reader, "spouse_spritual_education");
                        txt_spouse_secular_education_5.Text = getSqlStringData(reader, "spouse_secular_education");
                        children_count_old = getSqlIntData(reader, "children_count");
                        num_children_count_5.Value = children_count_old;
                        children_name_old = getSqlStringData(reader, "children_name");
                        children_birth_date_old = getSqlStringData(reader, "children_birth_date");
                    }
                    else
                        radio_married_no_5.Checked = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void put_service_info(string member_id)
        {
            try
            {
                string sql = "SELECT * FROM service_info WHERE member_id='" + member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    leadership_service_old = getSqlStringData(reader, "leadership");
                    sub_service_old = getSqlStringData(reader, "sub");
                    sector_service_old = getSqlStringData(reader, "sector");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private string get_partner_info(string general_info_id, string partner_member_id)
        {
            try
            {
                string sql = "SELECT * FROM general_info INNER JOIN address_info " +
                    "ON general_info.general_info_id = address_info.member_id " +
                    "WHERE general_info_id='" + partner_member_id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return getSqlStringData(reader, "participation_number")+"፤"+
                        getSqlStringData(reader, "full_name")+ "፤" +
                        getSqlStringData(reader, "cell_phone");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return "";
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

        private void cmb_birth_date_year_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // empty cmb_birth_month_1
            cmb_birth_date_month_1.Items.Clear();
            cmb_birth_date_month_1.DisplayMember = "Text";
            cmb_birth_date_month_1.ValueMember = "Text";

            cmb_birth_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_birth_date_month_1.SelectedIndex = 0;

            // if year selected fill month names
            if (cmb_birth_date_year_1.SelectedIndex != 0)
            {
                cmb_birth_date_month_1.Items.Add(new { Text = "መስከረም" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ጥቅምት" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ሕዳር" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ታሕሳስ" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ጥር" });
                cmb_birth_date_month_1.Items.Add(new { Text = "የካቲት" });
                cmb_birth_date_month_1.Items.Add(new { Text = "መጋቢት" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ሚያዚያ" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ግንቦት" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ሰኔ" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ሐምሌ" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ነሐሴ" });
                cmb_birth_date_month_1.Items.Add(new { Text = "ጷጉሜን" });
            }


            // empty cmb_birth_day_1
            cmb_birth_date_day_1.Items.Clear();
            cmb_birth_date_day_1.DisplayMember = "Text";
            cmb_birth_date_day_1.ValueMember = "Text";

            cmb_birth_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_birth_date_day_1.SelectedIndex = 0;

            // birth day is changed
            lbl_birth_day_1.Text = "";
        }

        private void cmb_birth_date_month_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if month is not selected day become empty then return
                if (cmb_birth_date_month_1.SelectedIndex == 0)
                {
                    cmb_birth_date_day_1.Items.Clear();
                    cmb_birth_date_day_1.DisplayMember = "Text";
                    cmb_birth_date_day_1.ValueMember = "Text";

                    cmb_birth_date_day_1.Items.Add(new { Text = "ቀን" });
                    cmb_birth_date_day_1.SelectedIndex = 0;

                    return;
                }



                // empty cmb_birth_day_1 and add 5 days
                cmb_birth_date_day_1.Items.Clear();
                cmb_birth_date_day_1.DisplayMember = "Text";
                cmb_birth_date_day_1.ValueMember = "Text";

                cmb_birth_date_day_1.Items.Add(new { Text = "ቀን" });
                cmb_birth_date_day_1.Items.Add(new { Text = "1" });
                cmb_birth_date_day_1.Items.Add(new { Text = "2" });
                cmb_birth_date_day_1.Items.Add(new { Text = "3" });
                cmb_birth_date_day_1.Items.Add(new { Text = "4" });
                cmb_birth_date_day_1.Items.Add(new { Text = "5" });

                cmb_birth_date_day_1.SelectedIndex = 0;

                // if month is not equal ጷጉሜን add days from 6-30 
                if (cmb_birth_date_month_1.Text != "ጷጉሜን")
                {
                    cmb_birth_date_day_1.Items.Add(new { Text = "6" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "7" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "8" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "9" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "10" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "11" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "12" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "13" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "14" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "15" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "16" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "17" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "18" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "19" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "20" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "21" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "22" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "23" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "24" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "25" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "26" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "27" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "28" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "29" });
                    cmb_birth_date_day_1.Items.Add(new { Text = "30" });
                }
                // if month is ጷጉሜን
                else
                {
                    // if year is not empty
                    if (cmb_birth_date_year_1.SelectedIndex != 0)
                    {
                        // convert year to int
                        int yearInt = int.Parse(cmb_birth_date_year_1.Text.ToString());

                        // check the if the year has 6 days in ጷጉሜን
                        if (yearInt % 4 == 3)
                            cmb_birth_date_day_1.Items.Add(new { Text = "6" });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_registration_date_year_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // empty cmb_registration_month_1
            cmb_registration_date_month_1.Items.Clear();
            cmb_registration_date_month_1.DisplayMember = "Text";
            cmb_registration_date_month_1.ValueMember = "Text";

            cmb_registration_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_registration_date_month_1.SelectedIndex = 0;

            // if year selected fill month names
            if (cmb_registration_date_year_1.SelectedIndex != 0)
            {
                cmb_registration_date_month_1.Items.Add(new { Text = "መስከረም" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ጥቅምት" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ሕዳር" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ታሕሳስ" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ጥር" });
                cmb_registration_date_month_1.Items.Add(new { Text = "የካቲት" });
                cmb_registration_date_month_1.Items.Add(new { Text = "መጋቢት" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ሚያዚያ" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ግንቦት" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ሰኔ" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ሐምሌ" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ነሐሴ" });
                cmb_registration_date_month_1.Items.Add(new { Text = "ጷጉሜን" });
            }


            // empty cmb_registration_day_1
            cmb_registration_date_day_1.Items.Clear();
            cmb_registration_date_day_1.DisplayMember = "Text";
            cmb_registration_date_day_1.ValueMember = "Text";

            cmb_registration_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_registration_date_day_1.SelectedIndex = 0;

            // birth day is changed
            lbl_registration_date_1.Text = "";
        }

        private void cmb_registration_date_month_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if month is not selected day become empty then return
                if (cmb_registration_date_month_1.SelectedIndex == 0)
                {
                    cmb_registration_date_day_1.Items.Clear();
                    cmb_registration_date_day_1.DisplayMember = "Text";
                    cmb_registration_date_day_1.ValueMember = "Text";

                    cmb_registration_date_day_1.Items.Add(new { Text = "ቀን" });
                    cmb_registration_date_day_1.SelectedIndex = 0;

                    return;
                }



                // empty cmb_registration_day_1 and add 5 days
                cmb_registration_date_day_1.Items.Clear();
                cmb_registration_date_day_1.DisplayMember = "Text";
                cmb_registration_date_day_1.ValueMember = "Text";

                cmb_registration_date_day_1.Items.Add(new { Text = "ቀን" });
                cmb_registration_date_day_1.Items.Add(new { Text = "1" });
                cmb_registration_date_day_1.Items.Add(new { Text = "2" });
                cmb_registration_date_day_1.Items.Add(new { Text = "3" });
                cmb_registration_date_day_1.Items.Add(new { Text = "4" });
                cmb_registration_date_day_1.Items.Add(new { Text = "5" });

                cmb_registration_date_day_1.SelectedIndex = 0;

                // if month is not equal ጷጉሜን add days from 6-30 
                if (cmb_registration_date_month_1.Text != "ጷጉሜን")
                {
                    cmb_registration_date_day_1.Items.Add(new { Text = "6" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "7" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "8" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "9" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "10" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "11" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "12" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "13" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "14" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "15" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "16" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "17" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "18" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "19" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "20" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "21" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "22" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "23" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "24" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "25" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "26" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "27" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "28" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "29" });
                    cmb_registration_date_day_1.Items.Add(new { Text = "30" });
                }
                // if month is ጷጉሜን
                else
                {
                    // if year is not empty
                    if (cmb_registration_date_year_1.SelectedIndex != 0)
                    {
                        // convert year to int
                        int yearInt = int.Parse(cmb_registration_date_year_1.Text.ToString());

                        // check the if the year has 6 days in ጷጉሜን
                        if (yearInt % 4 == 3)
                            cmb_registration_date_day_1.Items.Add(new { Text = "6" });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_fill_date_year_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // empty cmb_fill_month_1
            cmb_fill_date_month_1.Items.Clear();
            cmb_fill_date_month_1.DisplayMember = "Text";
            cmb_fill_date_month_1.ValueMember = "Text";

            cmb_fill_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_fill_date_month_1.SelectedIndex = 0;

            // if year selected fill month names
            if (cmb_fill_date_year_1.SelectedIndex != 0)
            {
                cmb_fill_date_month_1.Items.Add(new { Text = "መስከረም" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ጥቅምት" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ሕዳር" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ታሕሳስ" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ጥር" });
                cmb_fill_date_month_1.Items.Add(new { Text = "የካቲት" });
                cmb_fill_date_month_1.Items.Add(new { Text = "መጋቢት" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ሚያዚያ" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ግንቦት" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ሰኔ" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ሐምሌ" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ነሐሴ" });
                cmb_fill_date_month_1.Items.Add(new { Text = "ጷጉሜን" });
            }


            // empty cmb_fill_day_1
            cmb_fill_date_day_1.Items.Clear();
            cmb_fill_date_day_1.DisplayMember = "Text";
            cmb_fill_date_day_1.ValueMember = "Text";

            cmb_fill_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_fill_date_day_1.SelectedIndex = 0;

            // birth day is changed
            lbl_fill_date_1.Text = "";
        }

        private void cmb_fill_date_month_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if month is not selected day become empty then return
                if (cmb_fill_date_month_1.SelectedIndex == 0)
                {
                    cmb_fill_date_day_1.Items.Clear();
                    cmb_fill_date_day_1.DisplayMember = "Text";
                    cmb_fill_date_day_1.ValueMember = "Text";

                    cmb_fill_date_day_1.Items.Add(new { Text = "ቀን" });
                    cmb_fill_date_day_1.SelectedIndex = 0;

                    return;
                }



                // empty cmb_fill_day_1 and add 5 days
                cmb_fill_date_day_1.Items.Clear();
                cmb_fill_date_day_1.DisplayMember = "Text";
                cmb_fill_date_day_1.ValueMember = "Text";

                cmb_fill_date_day_1.Items.Add(new { Text = "ቀን" });
                cmb_fill_date_day_1.Items.Add(new { Text = "1" });
                cmb_fill_date_day_1.Items.Add(new { Text = "2" });
                cmb_fill_date_day_1.Items.Add(new { Text = "3" });
                cmb_fill_date_day_1.Items.Add(new { Text = "4" });
                cmb_fill_date_day_1.Items.Add(new { Text = "5" });

                cmb_fill_date_day_1.SelectedIndex = 0;

                // if month is not equal ጷጉሜን add days from 6-30 
                if (cmb_fill_date_month_1.Text != "ጷጉሜን")
                {
                    cmb_fill_date_day_1.Items.Add(new { Text = "6" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "7" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "8" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "9" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "10" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "11" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "12" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "13" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "14" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "15" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "16" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "17" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "18" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "19" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "20" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "21" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "22" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "23" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "24" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "25" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "26" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "27" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "28" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "29" });
                    cmb_fill_date_day_1.Items.Add(new { Text = "30" });
                }
                // if month is ጷጉሜን
                else
                {
                    // if year is not empty
                    if (cmb_fill_date_year_1.SelectedIndex != 0)
                    {
                        // convert year to int
                        int yearInt = int.Parse(cmb_fill_date_year_1.Text.ToString());

                        // check the if the year has 6 days in ጷጉሜን
                        if (yearInt % 4 == 3)
                            cmb_fill_date_day_1.Items.Add(new { Text = "6" });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_christianity_date_40_80_1_CheckedChanged(object sender, EventArgs e)
        {
            panel_christian_date_other_1.Visible = false;
            txt_why_christianity_date_1.Text = "";
        }

        private void radio_christianity_date_other_1_CheckedChanged(object sender, EventArgs e)
        {
            panel_christian_date_other_1.Visible = true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;)|*.jpg;*.jpeg;*.gif;*.bmp;*.png;";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                is_imageChanged = true;
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void changeTab(TabPage to)
        {
            //remove panel 1
            //add panel 2
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.TabPages.Add(to);
        }

        private void btn_pg_1_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_1_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_1_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_1_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_1_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_1_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_1_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_1_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_next_1_Click(object sender, EventArgs e)
        {            
            changeTab(panel_2);
        }

        private void btn_back_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_2_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_2_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_2_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_2_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_2_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_2_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_2_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_2_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_next_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_back_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_3_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_3_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_3_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_3_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_3_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_3_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_3_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_3_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_next_3_Click_1(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_back_4_Click_1(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_4_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_4_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_4_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_4_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_4_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_4_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_4_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_4_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_back_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_5_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_5_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_5_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_5_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_5_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_5_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_5_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_5_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_next_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_back_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_6_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_6_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_6_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_6_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_6_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_6_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_6_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_6_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_next_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_back_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_7_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_7_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_7_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_7_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_7_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_pg_7_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_pg_7_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_7_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_back_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_8_1_Click(object sender, EventArgs e)
        {
            changeTab(panel_1);
        }

        private void btn_pg_8_2_Click(object sender, EventArgs e)
        {
            changeTab(panel_2);
        }

        private void btn_pg_8_3_Click(object sender, EventArgs e)
        {
            changeTab(panel_3);
        }

        private void btn_pg_8_4_Click(object sender, EventArgs e)
        {
            changeTab(panel_4);
        }

        private void btn_pg_8_5_Click(object sender, EventArgs e)
        {
            changeTab(panel_5);
        }

        private void btn_sub_service_old_data_8_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = "";
                string[] each_sub = sub_service_old.Split('፤');
                int len = each_sub.Length;
                int i = 0;

                foreach (string key in each_sub)
                {
                    // the last value is always empty
                    if (len == i)
                        return;

                    string[] arr = key.Split('፣');
                    txt += arr[0];
                    if (arr.Length == 2)
                        txt += "\t\t" + arr[1];

                    // the last value is always empty
                    if (len != i + 1)
                        txt += "\n";
                    i++;
                }
                MessageBox.Show(txt, "በንዑስነት");
            }
            catch { }
        }

        private void btn_leadership_service_clear_8_Click(object sender, EventArgs e)
        {
            try
            {
                // 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት በሙሉ ጠፍቶ እንደ አዲስ መረጃ ማስገባት ይፈልጋሉ?",
                    "በአመራርነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    leadership_service_append = 1;
                    btn_leadership_service_8.Visible = true;
                    btn_leadership_service_clear_8.BackColor = btn_leadership_service_8.BackColor;
                    btn_leadership_service_append_8.BackColor = SystemColors.ControlDark;

                    // reset combo box
                    cmb_leadership_service_kifil_8.Items.Clear();
                    cmb_leadership_service_kifil_8.DisplayMember = "Text";
                    cmb_leadership_service_kifil_8.ValueMember = "Text";
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ትምህርት ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "መዝሙር ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ሕጻናት እና ማዕከላውያን ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ልማት ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "አባላት ግንኙነት እና ሥነ - ምግባር ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ጉዞና ጉብኝት ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "የበጎ አድራጎትና ሙያ አገልግሎት ክፍል" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ውጪ ግንኙነት" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ማኅበራት አንድነት" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ጥናት ፣ ምርምርና ስልጠና" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ልዩ ልዩ ጉባኤያት" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ሽያጭ" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "አርትኦት" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "መረጃ እና መዛግብት" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ኦዲትና ኢንስፔክሽን" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ምክረ - አበው" });
                    cmb_leadership_service_kifil_8.Items.Add(new { Text = "ገንዘብና ንብረት" });
                    cmb_leadership_service_kifil_8.SelectedIndex = 0;


                    //iterator for success icon
                    leadership_service_iterator = 0;
                    lbl_leadership_service_success_8.Text = "";

                    //empty leadership_service
                    leadership_service = "";
                }
            }
            catch { }
        }

        private void cmb_leadership_service_kifil_8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_leadership_service_8_Click(object sender, EventArgs e)
        {
            // check both kifil and time is entered
            if (cmb_leadership_service_kifil_8.SelectedIndex == 0)
            {
                MessageBox.Show("በአመራርነት ክፍሉን ይምረጡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_leadership_service_time_8.Text == "")
            {
                MessageBox.Show("በአመራርነት ጊዜውን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // append to varable
            leadership_service += cmb_leadership_service_kifil_8.Text + "፣" + txt_leadership_service_time_8.Text + "፤";

            // remove selected index
            cmb_leadership_service_kifil_8.Items.RemoveAt(cmb_leadership_service_kifil_8.SelectedIndex);
            // clear form
            cmb_leadership_service_kifil_8.SelectedIndex = 0;
            txt_leadership_service_time_8.Text = "";


            leadership_service_iterator++;
            if (leadership_service_iterator == 1)
            {
                icon_leadership_service_success_8.Visible = true;
                lbl_leadership_service_success_8.Text = "";
            }
            else
            {
                icon_leadership_service_success_8.Visible = true;
                lbl_leadership_service_success_8.Visible = true;
                lbl_leadership_service_success_8.Text = leadership_service_iterator.ToString();
            }
        }

        private void btn_sub_service_append_8_Click(object sender, EventArgs e)
        {
            try
            {
                // 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት መረጃ ሳይጠፋ በሱ ላይ ተጨማሪ መረጃ ማስገባት ይፈልጋሉ?",
                    "በንዑስነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sub_service_append = 0;
                    btn_sub_service_8.Visible = true;
                    btn_sub_service_append_8.BackColor = btn_sub_service_8.BackColor;
                    btn_sub_service_clear_8.BackColor = SystemColors.ControlDark;


                    // remove old kifil from combo box
                    string[] each_sub = sub_service_old.Split('፤');
                    int len = each_sub.Length;
                    int i = 0;

                    foreach (string key in each_sub)
                    {
                        // the last value is always empty
                        if (len == i)
                            return;

                        string[] arr = key.Split('፣');
                        cmb_sub_service_kifil_8.Items.Remove(arr[0]);
                    }

                    //iterator for success icon
                    sub_service_iterator = len - 1;

                    //copy old sub data to sub_service
                    sub_service = sub_service_old;
                }
            }
            catch { }
        }

        private void btn_sub_service_clear_8_Click(object sender, EventArgs e)
        {
            try
            {
                // 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት በሙሉ ጠፍቶ እንደ አዲስ መረጃ ማስገባት ይፈልጋሉ?",
                    "በንዑስነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sub_service_append = 1;
                    btn_sub_service_8.Visible = true;
                    btn_sub_service_clear_8.BackColor = btn_sub_service_8.BackColor;
                    btn_sub_service_append_8.BackColor = SystemColors.ControlDark;

                    // reset combo box
                    cmb_sub_service_kifil_8.Items.Clear();
                    cmb_sub_service_kifil_8.DisplayMember = "Text";
                    cmb_sub_service_kifil_8.ValueMember = "Text";
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ትምህርት ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "መዝሙር ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ሕጻናት እና ማዕከላውያን ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ልማት ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "አባላት ግንኙነት እና ሥነ - ምግባር ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ጉዞና ጉብኝት ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "የበጎ አድራጎትና ሙያ አገልግሎት ክፍል" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ውጪ ግንኙነት" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ማኅበራት አንድነት" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ጥናት ፣ ምርምርና ስልጠና" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ልዩ ልዩ ጉባኤያት" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ሽያጭ" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "አርትኦት" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "መረጃ እና መዛግብት" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ኦዲትና ኢንስፔክሽን" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ምክረ - አበው" });
                    cmb_sub_service_kifil_8.Items.Add(new { Text = "ገንዘብና ንብረት" });
                    cmb_sub_service_kifil_8.SelectedIndex = 0;

                    //iterator for success icon
                    sub_service_iterator = 0;
                    lbl_sub_service_success_8.Text = "";

                    //empty sub_service
                    sub_service = "";
                }
            }
            catch { }
        }

        private void btn_sub_service_8_Click(object sender, EventArgs e)
        {
            // check both kifil and time is entered
            if (cmb_sub_service_kifil_8.SelectedIndex == 0)
            {
                MessageBox.Show("በንዑስነት ክፍሉን ይምረጡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_sub_service_time_8.Text == "")
            {
                MessageBox.Show("በንዑስነት ጊዜውን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // append to varable
            sub_service += cmb_sub_service_kifil_8.Text + "፣" + txt_sub_service_time_8.Text + "፤";

            // remove selected index
            cmb_sub_service_kifil_8.Items.RemoveAt(cmb_sub_service_kifil_8.SelectedIndex);
            // clear form
            cmb_sub_service_kifil_8.SelectedIndex = 0;
            txt_sub_service_time_8.Text = "";


            sub_service_iterator++;
            if (sub_service_iterator == 1)
            {
                icon_sub_service_success_8.Visible = true;
                lbl_sub_service_success_8.Text = "";
            }
            else
            {
                icon_sub_service_success_8.Visible = true;
                lbl_sub_service_success_8.Visible = true;
                lbl_sub_service_success_8.Text = sub_service_iterator.ToString();
            }
        }

        private void gunaImageButton2_Click_1(object sender, EventArgs e)
        {
            try
            {// 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት መረጃ ሳይጠፋ በሱ ላይ ተጨማሪ መረጃ ማስገባት ይፈልጋሉ?",
                    "በዘርፍነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sector_service_append = 0;
                    btn_sector_service_8.Visible = true;
                    btn_sector_service_append_8.BackColor = btn_sector_service_8.BackColor;
                    btn_sector_service_clear_8.BackColor = SystemColors.ControlDark;


                    // remove old kifil from combo box
                    string[] each_sector = sector_service_old.Split('፤');
                    int len = each_sector.Length;
                    int i = 0;

                    foreach (string key in each_sector)
                    {
                        // the last value is always empty
                        if (len == i)
                            return;

                        string[] arr = key.Split('፣');
                        cmb_sector_service_kifil_8.Items.Remove(arr[0]);
                    }

                    //iterator for success icon
                    sector_service_iterator = len - 1;

                    //copy old sector data to sector_service
                    sector_service = sector_service_old;
                }
            }
            catch { }
        }

        private void btn_sector_service_clear_8_Click(object sender, EventArgs e)
        {
            try
            {// 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት በሙሉ ጠፍቶ እንደ አዲስ መረጃ ማስገባት ይፈልጋሉ?",
                    "በዘርፍነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sector_service_append = 1;
                    btn_sector_service_8.Visible = true;
                    btn_sector_service_clear_8.BackColor = btn_sector_service_8.BackColor;
                    btn_sector_service_append_8.BackColor = SystemColors.ControlDark;

                    // reset combo box
                    cmb_sector_service_kifil_8.Items.Clear();
                    cmb_sector_service_kifil_8.DisplayMember = "Text";
                    cmb_sector_service_kifil_8.ValueMember = "Text";
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ትምህርት ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "መዝሙር ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ሕጻናት እና ማዕከላውያን ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ልማት ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "አባላት ግንኙነት እና ሥነ - ምግባር ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ጉዞና ጉብኝት ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "የበጎ አድራጎትና ሙያ አገልግሎት ክፍል" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ውጪ ግንኙነት" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ማኅበራት አንድነት" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ጥናት ፣ ምርምርና ስልጠና" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ልዩ ልዩ ጉባኤያት" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ሽያጭ" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "አርትኦት" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "መረጃ እና መዛግብት" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ኦዲትና ኢንስፔክሽን" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ምክረ - አበው" });
                    cmb_sector_service_kifil_8.Items.Add(new { Text = "ገንዘብና ንብረት" });
                    cmb_sector_service_kifil_8.SelectedIndex = 0;

                    //iterator for success icon
                    sector_service_iterator = 0;
                    lbl_sector_service_success_8.Text = "";

                    //empty sub_service
                    sector_service = "";
                }
            }
            catch { }
        }

        private void btn_sector_service_8_Click(object sender, EventArgs e)
        {
            // check both kifil and time is entered
            if (cmb_sector_service_kifil_8.SelectedIndex == 0)
            {
                MessageBox.Show("በዘርፍነት ክፍሉን ይምረጡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_sector_service_time_8.Text == "")
            {
                MessageBox.Show("በዘርፍነት ጊዜውን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // append to varable
            sector_service += cmb_sector_service_kifil_8.Text + "፣" + txt_sector_service_time_8.Text + "፤";

            // remove selected index
            cmb_sector_service_kifil_8.Items.RemoveAt(cmb_sector_service_kifil_8.SelectedIndex);
            // clear form
            cmb_sector_service_kifil_8.SelectedIndex = 0;
            txt_sector_service_time_8.Text = "";


            sector_service_iterator++;
            if (sector_service_iterator == 1)
            {
                icon_sector_service_success_8.Visible = true;
                lbl_sector_service_success_8.Text = "";
            }
            else
            {
                icon_sector_service_success_8.Visible = true;
                lbl_sector_service_success_8.Visible = true;
                lbl_sector_service_success_8.Text = sector_service_iterator.ToString();
            }
        }

        private void btn_sector_service_old_data_8_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = "";
                string[] each_sector = sector_service_old.Split('፤');
                int len = each_sector.Length;
                int i = 0;

                foreach (string key in each_sector)
                {
                    // the last value is always empty
                    if (len == i)
                        return;

                    string[] arr = key.Split('፣');
                    txt += arr[0];
                    if (arr.Length == 2)
                        txt += "\t\t" + arr[1];

                    // the last value is always empty
                    if (len != i + 1)
                        txt += "\n";
                    i++;
                }
                MessageBox.Show(txt, "በዘርፍነት");
            }
            catch { }
        }

        private void txt_partner_participation_number_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                is_partner_participation_number_changed = true;

                if (txt_partner_participation_number_6.Text != "")
                {
                    try
                    {
                        String sql = "SELECT general_info_id, full_name, cell_phone FROM general_info JOIN address_info " +
                            "ON general_info.general_info_id = address_info.member_id " +
                            "WHERE general_info.participation_number='" + txt_partner_participation_number_6.Text + "'";
                        SqlConnection conn = DatabaseConnection.getConnection();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txt_partner_name_6.Text = reader.GetString(1);
                            txt_partner_phone_6.Text = reader.GetString(2);

                            icon_partner_participation_number_success_6.Visible = true;
                            partner_member_id = reader.GetInt32(0);
                            partner_participation_number = txt_partner_participation_number_6.Text;
                            txt_partner_participation_number_6.LineColor = Color.Gray;
                            txt_partner_participation_number_6.FocusedLineColor = Color.FromArgb(73, 160, 174);
                        }
                        else
                        {
                            txt_partner_name_6.Text = "";
                            txt_partner_phone_6.Text = "";

                            icon_partner_participation_number_success_6.Visible = false;
                            partner_member_id = -1;
                            partner_participation_number = "";
                            txt_partner_participation_number_6.LineColor = Color.Red;
                            txt_partner_participation_number_6.FocusedLineColor = Color.Red;
                        }
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_children_old_data_5_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = "የልጆች ብዛት\t" + children_count_old + "\n-------------\n";
                string[] nameArr = children_name_old.Split('፣');
                string[] birthArr = children_birth_date_old.Split('፣');
                int len = nameArr.Length;
                int i = 0;

                foreach (string key in nameArr)
                {
                    // the last value is always empty
                    if (len == i)
                        return;

                    txt += nameArr[i];
                    txt += "\t\t" + birthArr[i];

                    // the last value is always empty
                    if (len != i + 1)
                        txt += "\n";
                    i++;
                }
                MessageBox.Show(txt, "የልጆች ስምና የትውልድ ቀን");
            }
            catch { }
        }

        private void btn_children_append_5_Click(object sender, EventArgs e)
        {
            // 0 = append, 1 = clear
            DialogResult result = MessageBox.Show(
                "ከዚህ በፊት የመረጡት መረጃ ሳይጠፋ በሱ ላይ ተጨማሪ መረጃ ማስገባት ይፈልጋሉ?",
                "የልጆች ስምና የትውልድ ዘመን",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                children_append = 0;
                children_count_iterator = children_count_old;
                num_children_count_5.Minimum = children_count_old;
                num_children_count_5.Value = children_count_old;
                num_children_count_5.Enabled = true;
                btn_children_append_5.BackColor = btn_children_5.BackColor;
                btn_children_clear_5.BackColor = SystemColors.ControlDark;
                
                //copy old children data
                children_name = children_name_old;
                children_birth_date = children_birth_date_old;
            }
        }

        private void btn_children_clear_5_Click(object sender, EventArgs e)
        {
            try
            {
                // 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት ያስገቡት የልጆች መረጃበ ሙሉ ጠፍቶ እንደ አዲስ መረጃ ማስገባት ይፈልጋሉ?",
                    "የልጆች ስምና የትውልድ ዘመን",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    children_append = 1;
                    children_count_iterator = 0;
                    num_children_count_5.Minimum = 0;
                    num_children_count_5.Value = 0;
                    num_children_count_5.Enabled = true;
                    btn_children_clear_5.BackColor = btn_children_5.BackColor;
                    btn_children_append_5.BackColor = SystemColors.ControlDark;

                    //iterator for success icon
                    //leadership_service_iterator = 0;
                    //lbl_leadership_service_success_8.Text = "";

                    //empty children data
                    children_name = "";
                    children_birth_date = "";
                }
            }
            catch { }
        }

        private void btn_children_5_Click(object sender, EventArgs e)
        {
            // check both name and birth day is entered
            if (txt_children_name_5.Text == "")
            {
                MessageBox.Show("የልጅ ስም ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_children_birth_date_5.Text == "")
            {
                MessageBox.Show("የልጅ የልደት ቀን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // check the values are inserted
            if (children_count_iterator < children_count)
            {
                // append values
                children_name += txt_children_name_5.Text + "፣";
                children_birth_date += txt_children_birth_date_5.Text + "፣";

                // empty forms
                txt_children_name_5.Text = "";
                txt_children_birth_date_5.Text = "";

                children_count_iterator++;
                // add values
                if (children_count_iterator == 1)
                {
                    icon_children_count_success_5.Visible = true;
                }
                else
                {
                    icon_children_count_success_5.Visible = true;
                    lbl_children_count_success_5.Visible = true;
                    lbl_children_count_success_5.Text = children_count_iterator.ToString();
                }
            }
        }

        private void num_children_count_5_ValueChanged(object sender, EventArgs e)
        {
            // if children_append is 1 (clear) minimum value is 0
            // and if children_append is 0 (append) minimum value is will be children_count_old
            // then disable name, birth day and add button else enable
            // or children_append is -1 (means on start)
            if ((children_append == 1 && num_children_count_5.Value == 0) || 
                (children_append == 0 && num_children_count_5.Value == children_count_old) ||
                children_append == -1)
            {
                txt_children_name_5.Enabled = false;
                txt_children_birth_date_5.Enabled = false;
                btn_children_5.Enabled = false;

                // empty values
                txt_children_name_5.Text = "";
                txt_children_birth_date_5.Text = "";

                children_name = "";
                children_birth_date = "";

                // hide icon_children_count_success_5 and lbl_children_count_success_5
                icon_children_count_success_5.Visible = false;
                lbl_children_count_success_5.Visible = false;
            }
            else
            {
                txt_children_name_5.Enabled = true;
                txt_children_birth_date_5.Enabled = true;
                btn_children_5.Enabled = true;

                // if num value are changed, empty name and birth day values for db
                // also change iterator and hide icon and lbl
                children_name = "";
                children_birth_date = "";
                if (children_append == 0)
                {
                    children_count_iterator = children_count_old;
                    children_name = children_name_old;
                    children_birth_date = children_birth_date_old;
                }
                else
                {
                    children_count_iterator = 0;
                    children_name = "";
                    children_birth_date = "";
                }

                icon_children_count_success_5.Visible = false;
                lbl_children_count_success_5.Visible = false;
            }

            children_count = (int)num_children_count_5.Value;
        }

        private void btn_leadership_service_append_8_Click(object sender, EventArgs e)
        {
            try
            {// 0 = append, 1 = clear
                DialogResult result = MessageBox.Show(
                    "ከዚህ በፊት የመረጡት መረጃ ሳይጠፋ በሱ ላይ ተጨማሪ መረጃ ማስገባት ይፈልጋሉ?",
                    "በአመራርነት",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    leadership_service_append = 0;
                    btn_leadership_service_8.Visible = true;
                    btn_leadership_service_append_8.BackColor = btn_leadership_service_8.BackColor;
                    btn_leadership_service_clear_8.BackColor = SystemColors.ControlDark;


                    // remove old kifil from combo box
                    string[] each_leadership = leadership_service_old.Split('፤');
                    int len = each_leadership.Length;
                    int i = 0;

                    foreach (string key in each_leadership)
                    {
                        // the last value is always empty
                        if (len == i)
                            return;

                        string[] arr = key.Split('፣');
                        cmb_leadership_service_kifil_8.Items.Remove(arr[0]);
                    }

                    //iterator for success icon
                    leadership_service_iterator = len - 1;

                    //copy old leadership data to leadership_service
                    leadership_service = leadership_service_old;
                }
            }
            catch { }
        }

        private void btn_pg_8_6_Click(object sender, EventArgs e)
        {
            changeTab(panel_6);
        }

        private void btn_leadership_service_old_data_8_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = "";
                string[] each_leadership = leadership_service_old.Split('፤');
                int len = each_leadership.Length;
                int i = 0;

                foreach (string key in each_leadership)
                {
                    // the last value is always empty
                    if (len == i)
                        return;

                    string[] arr = key.Split('፣');
                    txt += arr[0];
                    if (arr.Length == 2)
                        txt += "\t\t" + arr[1];

                    // the last value is always empty
                    if (len != i + 1)
                        txt += "\n";
                    i++;
                }
                MessageBox.Show(txt, "በአመራርነት");
            }
            catch { }
        }

        private void txt_partner_participation_number_6_TextChanged(object sender, EventArgs e)
        {
            txt_partner_name_6.Text = "";
            txt_partner_phone_6.Text = "";

            icon_partner_participation_number_success_6.Visible = false;
            partner_member_id = -1;
            // partner_participation_number = "";
            txt_partner_participation_number_6.LineColor = Color.Red;
            txt_partner_participation_number_6.FocusedLineColor = Color.Red;
        }

        private void btn_pg_8_7_Click(object sender, EventArgs e)
        {
            changeTab(panel_7);
        }

        private void btn_pg_8_8_Click(object sender, EventArgs e)
        {
            changeTab(panel_8);
        }

        private void btn_finish_8_Click(object sender, EventArgs e)
        {
            // panel first
            full_name = txt_full_name_1.Text;

            // if ሙሉ ስም is empty
            if (full_name == "")
            {
                MessageBox.Show("ሙሉ ስም እባክዎን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeTab(panel_1);
                txt_full_name_1.Focus();
                return;
            }
            participation_number_for_db = txt_participation_number_1.Text;
            if (participation_number_for_db == "")
            {
                MessageBox.Show("ትክክለኛ የተሳትፎ ቁጥር እባክዎን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeTab(panel_1);
                txt_participation_number_1.Focus();
                return;
            }

            /*if (partner_member_id == -1)
            {
                MessageBox.Show("ትክክለኛ የባልደረባ የተሳትፎ ቁጥር እባክዎን ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeTab(panel_6);
                txt_partner_participation_number_6.Focus();
                return;
            }*/

            christian_name = txt_christian_name_1.Text;
            mother_name = txt_mother_name_1.Text;

            // if not changed use old data
            if (cmb_birth_date_year_1.SelectedIndex == 0)
            {
                birth_day = lbl_birth_day_1.Text;
            }
            else
            {
                birth_day = cmb_birth_date_month_1.Text + " " + cmb_birth_date_day_1.Text + " " + cmb_birth_date_year_1.Text;
                birth_day = birth_day.Replace("ወር ", "").Trim();
                birth_day = birth_day.Replace("ቀን", "").Trim();
                birth_day = birth_day.Replace("ዓመት", "").Trim();
            }            
            
            sex = radio_sex_male_1.Checked ? "ወንድ" : "ሴት";

            // if not changed use old data
            if (cmb_registration_date_year_1.SelectedIndex == 0)
                registration_date = lbl_registration_date_1.Text;
            else
            {
                registration_date = cmb_registration_date_month_1.Text + " " + cmb_registration_date_day_1.Text + " " + cmb_registration_date_year_1.Text;
                registration_date = registration_date.Replace("ወር ", "").Trim();
                registration_date = registration_date.Replace("ቀን", "").Trim();
                registration_date = registration_date.Replace("ዓመት", "").Trim();
            }

            // if not changed use old data
            if (cmb_fill_date_year_1.SelectedIndex == 0)
                date_fill_info = lbl_fill_date_1.Text;
            else
            {
                date_fill_info = cmb_fill_date_month_1.Text + " " + cmb_fill_date_day_1.Text + " " + cmb_fill_date_year_1.Text;
                date_fill_info = date_fill_info.Replace("ወር ", "").Trim();
                date_fill_info = date_fill_info.Replace("ቀን", "").Trim();
                date_fill_info = date_fill_info.Replace("ዓመት", "").Trim();
            }
            
            christianity_date = radio_christianity_date_40_80_1.Checked ? 1 : 2;
            why_christianity_date = txt_why_christianity_date_1.Text;
            participation_number = txt_participation_number_1.Text;


            // panel second
            sub_city = txt_sub_city_2.Text;
            woreda = txt_woreda_2.Text;
            kebele = txt_kebele_2.Text;
            house_number = txt_house_number_2.Text;
            cell_phone = txt_cell_phone_2.Text;
            home_phone = txt_home_phone_2.Text;
            email = txt_email_2.Text;
            church_before = txt_church_before_2.Text;


            // panel third
            secular_educational_level = txt_secular_educational_level_3.Text;
            secular_educational_qualification = txt_secular_educational_qualification_3.Text;
            school_name = txt_school_name_3.Text;
            spritual_educational_level = txt_spritual_educational_level_3.Text;
            spritual_educational_qualification = txt_spritual_educational_qualification_3.Text;
            work_skill = txt_work_skill_3.Text;
            work_role = txt_work_role_3.Text;
            work_place = txt_work_place_3.Text;
            work_company_name = txt_work_company_name_3.Text;


            // panel fourth
            year = (int)num_year_4.Value;
            church = txt_church_4.Text;
            subjects = check_subject_1_4.Checked ? "1፣" : "";
            subjects += check_subject_2_4.Checked ? "2፣" : "";
            subjects += check_subject_3_4.Checked ? "3፣" : "";
            subjects += check_subject_4_4.Checked ? "4፣" : "";
            subjects += check_subject_5_4.Checked ? "5፣" : "";
            subject_other = txt_subject_other_4.Text;


            // panel fifth
            spouse_name = txt_spouse_name_5.Text;
            spouse_christian_name = txt_spouse_christian_name_5.Text;
            spouse_work_position = txt_spouse_work_position_5.Text;
            spouse_secular_education = txt_spouse_secular_education_5.Text;
            spouse_spritual_education = txt_spouse_spritual_education_5.Text;
            spouse_work_place = txt_spouse_work_place_5.Text;
            spouse_role = txt_spouse_role_5.Text;
            children_count = (int)num_children_count_5.Value;



            // panel sixth
            emergency_name = txt_emergency_name_6.Text;
            emergency_phone = txt_emergency_phone_6.Text;
            repentance_father_name = txt_repentance_father_name_6.Text;
            repentance_father_place = txt_repentance_father_place_6.Text;

            // if not changed use old data
            if (cmb_partner_date_year_6.SelectedIndex == 0)
                partner_date = lbl_partner_date_7.Text;
            else
            {
                partner_date = cmb_partner_date_month_6.Text + " " + cmb_partner_date_day_6.Text + " " + cmb_partner_date_year_6.Text;
                partner_date = partner_date.Replace("ወር ", "").Trim();
                partner_date = partner_date.Replace("ቀን", "").Trim();
                partner_date = partner_date.Replace("ዓመት", "").Trim();
            }
            
            serve = "";
            //panel seventh
            foreach (object key in serve_list)
            {
                switch (key.ToString())
                {
                    case "ትምህርት ክፍል":
                        serve += "1፣";
                        break;
                    case "መዝሙር ክፍል":
                        serve += "2፣";
                        break;
                    case "ሕጻናት እና ማዕከላውያን ክፍል":
                        serve += "3፣";
                        break;
                    case "ልማት ክፍል":
                        serve += "4፣";
                        break;
                    case "አባላት ግንኙነት እና ሥነ-ምግባር ክፍል":
                        serve += "5፣";
                        break;
                    case "ጉዞና ጉብኝት ክፍል":
                        serve += "6፣";
                        break;
                    case "የበጎ አድራጎትና ሙያ አገልግሎት ክፍል":
                        serve += "7፣";
                        break;
                    case "ውጪ ግንኙነት":
                        serve += "8፣";
                        break;
                    case "ማኅበራት አንድነት":
                        serve += "9፣";
                        break;
                    case "ጥናት ፣ ምርምርና ስልጠና":
                        serve += "10፣";
                        break;
                    case "ልዩ ልዩ ጉባኤያት":
                        serve += "11፣";
                        break;
                    case "ሽያጭ":
                        serve += "12፣";
                        break;
                    case "አርትኦት":
                        serve += "13፣";
                        break;
                    case "መረጃ እና መዛግብት":
                        serve += "14፣";
                        break;
                    case "ኦዲትና ኢንስፔክሽን":
                        serve += "15፣";
                        break;
                    case "ምክረ-አበው":
                        serve += "16፣";
                        break;
                    case "ገንዘብና ንብረት":
                        serve += "17፣";
                        break;
                }
            }

            // if partner info is not changed
            if (partner_member_id == partner_member_id_old)
                partner_participation_number = txt_partner_participation_number_6.Text;
            
            insertDataToDb();
        }

        private void insertDataToDb()
        {
            editGeneralInfo();
            /*if (member_id == -1)
            {
                MessageBox.Show("ይቅርታ ሲስተሙ ችግር አጋጥሞታል። እባክዎን ደግመው ይሞክሩ።", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            
            editAddressInfo();
            editEducationalBackground(general_info_id, "ዓለማዊ", secular_educational_level, secular_educational_qualification, school_name);
            editEducationalBackground(general_info_id, "መንፈሳዊ", spritual_educational_level, spritual_educational_qualification, "");
            editSpritualEducationBackground();
            editFamilyInfo();
            editWorkInfo();
            editServiceInfo();

            MessageBox.Show("መረጃው በትክክል ተስተካክሏል።", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            changeTab(panel_9);
            CrystalReports.registerCrystalReport crpt = new CrystalReports.registerCrystalReport();
            crpt.SetParameterValue("ImagePath", Application.StartupPath + @"\upload\" + image_path);


            putDataOnReport(crpt, "Section2", "txt_participation_number_1", participation_number_for_db);
            putDataOnReport(crpt, "Section2", "txt_full_name_1", full_name);
            putDataOnReport(crpt, "Section2", "txt_christian_name_1", christian_name);
            putDataOnReport(crpt, "Section2", "txt_mother_name_1", mother_name);
            putDataOnReport(crpt, "Section2", "txt_birth_date_1", birth_day);
            if (sex == "ወንድ")
                putDataOnReport(crpt, "Section2", "check_male_1", "✔");
            else
                putDataOnReport(crpt, "Section2", "check_female_1", "✔");
            putDataOnReport(crpt, "Section2", "txt_sub_city_1", sub_city);
            putDataOnReport(crpt, "Section2", "txt_woreda_1", woreda);
            putDataOnReport(crpt, "Section2", "txt_kebele_1", kebele);
            putDataOnReport(crpt, "Section2", "txt_house_number_1", house_number);
            putDataOnReport(crpt, "Section2", "txt_cell_phone_1", cell_phone);
            putDataOnReport(crpt, "Section2", "txt_home_phone_1", home_phone);
            putDataOnReport(crpt, "Section2", "txt_email_1", email);
            putDataOnReport(crpt, "Section2", "txt_secular_education_level_1", secular_educational_level);
            putDataOnReport(crpt, "Section2", "txt_secular_education_qualification_1", secular_educational_qualification);
            putDataOnReport(crpt, "Section2", "txt_school_name_1", school_name);
            putDataOnReport(crpt, "Section2", "txt_work_skill_1", work_skill);
            putDataOnReport(crpt, "Section2", "txt_work_role_1", work_role);
            putDataOnReport(crpt, "Section2", "txt_work_place_1", work_place);
            putDataOnReport(crpt, "Section2", "txt_work_company_name_1", work_company_name);
            putDataOnReport(crpt, "Section2", "txt_registration_date_1", registration_date);
            putDataOnReport(crpt, "Section2", "txt_fill_date_1", date_fill_info);

            if (christianity_date == 1)
                putDataOnReport(crpt, "Section2", "check_christianity_date_40_80_1", "✔");
            else
            {
                putDataOnReport(crpt, "Section2", "check_christianity_date_other_1", "✔");
                putDataOnReport(crpt, "Section2", "txt_christianity_date_other_1", why_christianity_date);
            }
            putDataOnReport(crpt, "Section2", "txt_church_before_1", church_before);

            if (course_before == 1)
            {
                putDataOnReport(crpt, "Section2", "txt_course_before_1_1", "    ✔");
                putDataOnReport(crpt, "Section2", "txt_church_1", church);
                String[] subjectsArr = subjects.Trim().Split('፣');
                for (int i = 0; i < (subjectsArr.Length - 1); i++)
                {
                    putDataOnReport(crpt, "Section2", "check_subjects_" + subjectsArr[i] + "_1", "✔");
                }
                putDataOnReport(crpt, "Section2", "txt_subjects_other_1", subject_other);
            }
            else if (course_before == 2)
                putDataOnReport(crpt, "Section2", "txt_course_before_2_1", "    ✔");
            else
            {
                putDataOnReport(crpt, "Section2", "txt_course_before_3_1", "    ✔");
                putDataOnReport(crpt, "Section2", "txt_year_1", "         " + year);
                putDataOnReport(crpt, "Section2", "txt_church_1", church);
            }





            putDataOnReport(crpt, "Section2", "txt_spritual_educational_level_1", spritual_educational_level);
            putDataOnReport(crpt, "Section2", "txt_spritual_educational_qualification_1", spritual_educational_qualification);

            if (married == 1)
                putDataOnReport(crpt, "Section2", "check_married_1_1", "✔");
            else
                putDataOnReport(crpt, "Section2", "check_married_2_1", "✔");

            putDataOnReport(crpt, "Section2", "txt_spouse_name_1", spouse_name);
            putDataOnReport(crpt, "Section2", "txt_spouse_christian_name_1", spouse_christian_name);
            putDataOnReport(crpt, "Section2", "txt_spouse_work_position_1", spouse_work_position);
            putDataOnReport(crpt, "Section2", "txt_spouse_spritual_education_1", spouse_spritual_education);
            putDataOnReport(crpt, "Section2", "txt_spouse_secular_education_1", spouse_secular_education);
            putDataOnReport(crpt, "Section2", "txt_spouse_work_place_1", spouse_work_place);
            putDataOnReport(crpt, "Section2", "txt_spouse_work_role_1", spouse_role);
            putDataOnReport(crpt, "Section2", "txt_children_count_1", "       " + children_count.ToString());

            // if value is not changed use old children data
            if(children_append == -1)
            {
                children_name = children_name_old;
                children_birth_date = children_birth_date_old;
            }

            String[] childrenNameArr = children_name.Trim().Split('፣');
            String[] childrenBirthDateArr = children_birth_date.Trim().Split('፣');
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_name_1"]).Height = (childrenNameArr.Length - 1) * 240;
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_birth_date_1"]).Height = (childrenBirthDateArr.Length - 1) * 240;
            for (int i = 0; i < (childrenNameArr.Length - 1); i++)
            {
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_name_1"]).Text += childrenNameArr[i] + "\n";
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_birth_date_1"]).Text += childrenBirthDateArr[i] + "\n";
            }


            putDataOnReport(crpt, "Section2", "txt_emergency_name_1", emergency_name);
            putDataOnReport(crpt, "Section2", "txt_emergency_phone_1", emergency_phone);
            putDataOnReport(crpt, "Section2", "txt_repentance_father_name_1", repentance_father_name);
            putDataOnReport(crpt, "Section2", "txt_repentance_father_place_1", repentance_father_place);

            putDataOnReport(crpt, "Section2", "txt_partner_name_1", txt_partner_name_6.Text);
            putDataOnReport(crpt, "Section2", "txt_partner_phone_1", txt_partner_phone_6.Text);
            putDataOnReport(crpt, "Section2", "txt_partner_date_1", partner_date);
            putDataOnReport(crpt, "Section2", "txt_partner_participation_number_1", partner_participation_number);



            String[] serveArr = serve.Trim().Split('፣');
            for (int i = 0; i < (serveArr.Length - 1); i++)
            {
                putDataOnReport(crpt, "Section2", "txt_serve_" + serveArr[i] + "_1", (i + 1).ToString());
            }



            // በአመራርነት 
            String[] leadershipArr = leadership_service.Trim().Split('፤');
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_kifil_1"]).Height = (leadershipArr.Length - 1) * 240;
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_time_1"]).Height = (leadershipArr.Length - 1) * 240;
            for (int i = 0; i < (leadershipArr.Length - 1); i++)
            {
                String[] arr = leadershipArr[i].Split('፣');
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_kifil_1"]).Text += arr[0] + "\n";
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_time_1"]).Text += arr[1] + "\n";
            }

            // በንዑስነት  
            String[] subArr = sub_service.Trim().Split('፤');
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_kifil_1"]).Height = (subArr.Length - 1) * 240;
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_time_1"]).Height = (subArr.Length - 1) * 240;
            for (int i = 0; i < (subArr.Length - 1); i++)
            {
                String[] arr = subArr[i].Split('፣');
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_kifil_1"]).Text += arr[0] + "\n";
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_time_1"]).Text += arr[1] + "\n";
            }

            // በዘርፍነት 
            String[] sectorArr = sector_service.Trim().Split('፤');
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_kifil_1"]).Height = (sectorArr.Length - 1) * 240;
            ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_time_1"]).Height = (sectorArr.Length - 1) * 240;
            for (int i = 0; i < (sectorArr.Length - 1); i++)
            {
                String[] arr = sectorArr[i].Split('፣');
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_kifil_1"]).Text += arr[0] + "\n";
                ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_time_1"]).Text += arr[1] + "\n";
            }


            /*try
            {
                String sql = "SELECT full_name FROM general_info WHERE general_info_id = 1";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                crpt.SetDataSource(dataSet.Tables["table"]);
                indivigualCrystalReportViewer.ReportSource = crpt;
                //registerCrystalReport
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }*/
            //indivigualCrystalReportViewer.ReportSource = null;
            indivigualCrystalReportViewer.ReportSource = crpt;
            indivigualCrystalReportViewer.Zoom(1);
        }

        private void putDataOnReport(CrystalReports.registerCrystalReport crpt, String sec, String var, String val)
        {
            try
            {
                ((TextObject)crpt.ReportDefinition.Sections[sec].ReportObjects[var]).Text = val;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private int editGeneralInfo()
        {
            try
            {
                // file upload files
                String[] fileNames = openFileDialog.FileName.Split('\\');
                String fileName = fileNames[(fileNames.Length) - 1];

                String[] fileTypes = fileName.Split('.');
                String fileType = fileTypes[(fileTypes.Length) - 1];

                string photo = photo_old.Trim();
                image_path = photo_old.Trim(); //if image is not changed
                string dest = "";

                if (is_imageChanged)
                {
                    Random rand = new Random();
                    string file_name = rand.Next(100000000, 999999999).ToString();
                    photo = file_name + "." + fileType;
                    dest = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "upload", photo);
                    image_path = photo; // for report
                }
                
                String sql = "UPDATE general_info " +
                    "SET " +
                    "participation_number = @participation_number, " +
                    "christian_name = @christian_name, " +
                    "photo = @photo, " +
                    "full_name = @full_name, " +
                    "mother_name = @mother_name, " +
                    "birth_day = @birth_day, " +
                    "sex = @sex, " +
                    "registration_date = @registration_date, " +
                    "date_fill_info = @date_fill_info, " +
                    "serve = @serve, " +
                    "christianity_date = @christianity_date, " +
                    "why_christianity_date = @why_christianity_date, " +
                    "emergency_name = @emergency_name, " +
                    "emergency_phone = @emergency_phone, " +
                    "repentance_father_name = @repentance_father_name, " +
                    "repentance_father_place = @repentance_father_place, " +
                    "partner_member_id = @partner_member_id, " +
                    "partner_date = @partner_date, " +
                    "user_modified = @user_modified, " +
                    "date_modified = @date_modified " +
                    "WHERE general_info_id = @general_info_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@participation_number", participation_number_for_db);
                cmd.Parameters.AddWithValue("@christian_name", christian_name);
                cmd.Parameters.AddWithValue("@photo", photo.Trim());
                cmd.Parameters.AddWithValue("@full_name", full_name);
                cmd.Parameters.AddWithValue("@mother_name", mother_name);
                cmd.Parameters.AddWithValue("@birth_day", birth_day.ToString());
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@registration_date", registration_date.ToString());
                cmd.Parameters.AddWithValue("@date_fill_info", date_fill_info.ToString());
                cmd.Parameters.AddWithValue("@serve", serve);
                cmd.Parameters.AddWithValue("@christianity_date", christianity_date);
                cmd.Parameters.AddWithValue("@why_christianity_date", why_christianity_date);
                cmd.Parameters.AddWithValue("@emergency_name", emergency_name);
                cmd.Parameters.AddWithValue("@emergency_phone", emergency_phone);
                cmd.Parameters.AddWithValue("@repentance_father_name", repentance_father_name);
                cmd.Parameters.AddWithValue("@repentance_father_place", repentance_father_place);
                cmd.Parameters.AddWithValue("@partner_member_id", partner_member_id);
                cmd.Parameters.AddWithValue("@partner_date", partner_date);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@general_info_id", general_info_id);
                
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    // if file is selected, copy the file to the destnation
                    if (openFileDialog.FileName != "" && is_imageChanged)
                    {
                        File.Copy(openFileDialog.FileName, dest, true);
                    }
                    return result;
                }
            }
            catch (SqlException ex)
            {
                ////MessageBox.Show(ex.Message);
            }
            return -1;
        }

        private void editAddressInfo()
        {
            try
            {
                String sql = "UPDATE address_info " +
                    "SET " +
                    "sub_city = @sub_city, " +
                    "woreda = @woreda, " +
                    "kebele = @kebele, " +
                    "house_number = @house_number, " +
                    "cell_phone = @cell_phone, " +
                    "home_phone = @home_phone, " +
                    "email = @email, " +
                    "church_before = @church_before, " +
                    "user_modified = @user_modified, " +
                    "date_modified = @date_modified " +
                    "WHERE member_id = @member_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sub_city", sub_city);
                cmd.Parameters.AddWithValue("@woreda", woreda);
                cmd.Parameters.AddWithValue("@kebele", kebele);
                cmd.Parameters.AddWithValue("@house_number", house_number);
                cmd.Parameters.AddWithValue("@cell_phone", cell_phone);
                cmd.Parameters.AddWithValue("@home_phone", home_phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@church_before", church_before);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void editEducationalBackground(string member_id, String type, String level, String qual, String sch)
        {
            try
            {
                String sql = "UPDATE educational_background " +
                    "SET " +
                    "educational_level = @educational_level, " +
                    "educational_qualification = @educational_qualification, " +
                    "school_name = @school_name, " +
                    "user_modified = @user_modified, " +
                    "date_modified = @date_modified " +
                    "WHERE member_id = @member_id AND type = N'"+type+"'";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@educational_level", level);
                cmd.Parameters.AddWithValue("@educational_qualification", qual);
                cmd.Parameters.AddWithValue("@school_name", sch);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void editSpritualEducationBackground()
        {
            try
            {
                String sql = "";
                // ከዚህ በፊት ተምሬያለሁ ካለ, year አይኖርም   
                if (course_before == 1)
                    sql = "UPDATE spritual_education_background " +
                        "SET " +
                        "course_before = @course_before, " +
                        "church = @church, " +
                        "subjects = @subjects, " +
                        "subject_other = @subject_other, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";
                else if (course_before == 3) // ከዚህ በፊት እየተማርኩኝ ነው ካለ,  year ይኖራል 
                    sql = "UPDATE spritual_education_background " +
                        "SET " +
                        "course_before = @course_before, " +
                        "year = @year, " +
                        "church = @church, " +
                        "subjects = @subjects, " +
                        "subject_other = @subject_other, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";
                else // ከዚህ በፊት አልተማርኩም ካለ ምንም አይኖርም 
                    sql = "UPDATE spritual_education_background " +
                        "SET " +
                        "course_before = @course_before, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";
                
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);
                cmd.Parameters.AddWithValue("@course_before", course_before);
                // ከዚህ በፊት እየተማርኩኝ ነቅ ካለ ብቻ year ይገባል   
                if (course_before == 3)
                    cmd.Parameters.AddWithValue("@year", year);

                // ከዚህ በፊት አልተማርኩም ካላለ ብቻ ይገባል   
                if (course_before != 2)
                {
                    cmd.Parameters.AddWithValue("@church", church);
                    cmd.Parameters.AddWithValue("@subjects", subjects);
                    cmd.Parameters.AddWithValue("@subject_other", subject_other);
                }

                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);

                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void editFamilyInfo()
        {
            try
            {
                String sql = "";
                // ያገባ ከሆነ
                if (married == 1)
                    sql = "UPDATE family_info " +
                        "SET " +
                        "married = @married, " +
                        "spouse_name = @spouse_name, " +
                        "spouse_christian_name = @spouse_christian_name, " +
                        "spouse_work_place = @spouse_work_place, " +
                        "spouse_work_position = @spouse_work_position, " +
                        "spouse_role = @spouse_role, " +
                        "spouse_spritual_education = @spouse_spritual_education, " +
                        "spouse_secular_education = @spouse_secular_education, " +
                        "children_count = @children_count, " +
                        "children_name = @children_name, " +
                        "children_birth_date = @children_birth_date, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";
                else // ያላገባ ከሆነ ምንም የሚገባ መረጃ አይኖርም
                    sql = "UPDATE family_info " +
                        "SET " +
                        "married = @married, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);
                cmd.Parameters.AddWithValue("@married", married);
                // ያገባ ከሆነ
                if (married == 1)
                {
                    cmd.Parameters.AddWithValue("@spouse_name", spouse_name);
                    cmd.Parameters.AddWithValue("@spouse_christian_name", spouse_christian_name);
                    cmd.Parameters.AddWithValue("@spouse_work_place", spouse_work_place);
                    cmd.Parameters.AddWithValue("@spouse_work_position", spouse_work_position);
                    cmd.Parameters.AddWithValue("@spouse_role", spouse_role);
                    cmd.Parameters.AddWithValue("@spouse_spritual_education", spouse_spritual_education);
                    cmd.Parameters.AddWithValue("@spouse_secular_education", spouse_secular_education);
                    // if children value is not changed put old data
                    if(children_append == -1)
                    {
                        cmd.Parameters.AddWithValue("@children_count", children_count_old);
                        cmd.Parameters.AddWithValue("@children_name", children_name_old);
                        cmd.Parameters.AddWithValue("@children_birth_date", children_birth_date_old);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@children_count", children_count);
                        cmd.Parameters.AddWithValue("@children_name", children_name);
                        cmd.Parameters.AddWithValue("@children_birth_date", children_birth_date);
                    }                    
                }
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void editWorkInfo()
        {
            try
            {
                string sql = "UPDATE work_info " +
                        "SET " +
                        "skill = @skill, " +
                        "role = @role, " +
                        "place = @place, " +
                        "company_name = @company_name, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@skill", work_skill);
                cmd.Parameters.AddWithValue("@role", work_role);
                cmd.Parameters.AddWithValue("@place", work_place);
                cmd.Parameters.AddWithValue("@company_name", work_company_name);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void editServiceInfo()
        {
            try
            {
                string sql = "UPDATE service_info " +
                        "SET " +
                        "leadership = @leadership, " +
                        "sub = @sub, " +
                        "sector = @sector, " +
                        "user_modified = @user_modified, " +
                        "date_modified = @date_modified " +
                        "WHERE member_id = @member_id";

                //if value doesnt changed put old data
                if (leadership_service_append == -1)
                    leadership_service = leadership_service_old;
                if (sub_service_append == -1)
                    sub_service = sub_service_old;
                if (sector_service_append == -1)
                    sector_service = sector_service_old;

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@leadership", leadership_service);
                cmd.Parameters.AddWithValue("@sub", sub_service);
                cmd.Parameters.AddWithValue("@sector", sector_service);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);
                cmd.Parameters.AddWithValue("@member_id", general_info_id);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void serveListInit(String val)
        {
            if(val != "")
            {
                string[] serveArray = val.Split('፣');
                
                listBox_serve_7.Items.Clear();
                serve = "";
                int i = 0;
                foreach (object key in serveArray)
                {
                    Guna.UI.WinForms.GunaButton btn = btn_serve_1_7;
                    if (key.ToString() == "1")
                    {
                        listBox_serve_7.Items.Add(++i + " ትምህርት ክፍል");
                        serve_list.Add("ትምህርት ክፍል");
                        btn = btn_serve_1_7;
                    }
                    else if (key.ToString() == "2")
                    {
                        listBox_serve_7.Items.Add(++i + " መዝሙር ክፍል");
                        serve_list.Add("መዝሙር ክፍል");
                        btn = btn_serve_2_7;
                    }
                    else if (key.ToString() == "3")
                    {
                        listBox_serve_7.Items.Add(++i + " ሕጻናት እና ማዕከላውያን ክፍል");
                        serve_list.Add("ሕጻናት እና ማዕከላውያን ክፍል");
                        btn = btn_serve_3_7;
                    }
                    else if (key.ToString() == "4")
                    {
                        listBox_serve_7.Items.Add(++i + " ልማት ክፍል");
                        serve_list.Add("ልማት ክፍል");
                        btn = btn_serve_4_7;
                    }
                    else if (key.ToString() == "5")
                    {
                        listBox_serve_7.Items.Add(++i + " አባላት ግንኙነት እና ሥነ-ምግባር ክፍል");
                        serve_list.Add("አባላት ግንኙነት እና ሥነ-ምግባር ክፍል");
                        btn = btn_serve_5_7;
                    }
                    else if (key.ToString() == "6")
                    {
                        listBox_serve_7.Items.Add(++i + " ጉዞና ጉብኝት ክፍል");
                        serve_list.Add("ጉዞና ጉብኝት ክፍል");
                        btn = btn_serve_6_7;
                    }
                    else if (key.ToString() == "7")
                    {
                        listBox_serve_7.Items.Add(++i + " የበጎ አድራጎትና ሙያ አገልግሎት ክፍል");
                        serve_list.Add("የበጎ አድራጎትና ሙያ አገልግሎት ክፍል");
                        btn = btn_serve_7_7;
                    }
                    else if (key.ToString() == "8")
                    {
                        listBox_serve_7.Items.Add(++i + " ውጪ ግንኙነት");
                        serve_list.Add("ውጪ ግንኙነት");
                        btn = btn_serve_8_7;
                    }
                    else if (key.ToString() == "9")
                    {
                        listBox_serve_7.Items.Add(++i + " ማኅበራት አንድነት");
                        serve_list.Add("ማኅበራት አንድነት");
                        btn = btn_serve_9_7;
                    }
                    else if (key.ToString() == "10")
                    {
                        listBox_serve_7.Items.Add(++i + " ጥናት ፣ ምርምርና ስልጠና");
                        serve_list.Add("ጥናት ፣ ምርምርና ስልጠና");
                        btn = btn_serve_10_7;
                    }
                    else if (key.ToString() == "11")
                    {
                        listBox_serve_7.Items.Add(++i + " ልዩ ልዩ ጉባኤያት");
                        serve_list.Add("ልዩ ልዩ ጉባኤያት");
                        btn = btn_serve_11_7;
                    }
                    else if (key.ToString() == "12")
                    {
                        listBox_serve_7.Items.Add(++i + " ሽያጭ");
                        serve_list.Add("ሽያጭ");
                        btn = btn_serve_12_7;
                    }
                    else if (key.ToString() == "13")
                    {
                        listBox_serve_7.Items.Add(++i + " አርትኦት");
                        serve_list.Add("አርትኦት");
                        btn = btn_serve_13_7;
                    }
                    else if (key.ToString() == "14")
                    {
                        listBox_serve_7.Items.Add(++i + " መረጃ እና መዛግብት");
                        serve_list.Add("መረጃ እና መዛግብት");
                        btn = btn_serve_14_7;
                    }
                    else if (key.ToString() == "15")
                    {
                        listBox_serve_7.Items.Add(++i + " ኦዲትና ኢንስፔክሽን");
                        serve_list.Add("ኦዲትና ኢንስፔክሽን");
                        btn = btn_serve_15_7;
                    }
                    else if (key.ToString() == "16")
                    {
                        listBox_serve_7.Items.Add(++i + " ምክረ-አበው");
                        serve_list.Add("ምክረ-አበው");
                        btn = btn_serve_16_7;
                    }
                    else if (key.ToString() == "17")
                    {
                        listBox_serve_7.Items.Add(++i + " ገንዘብና ንብረት");
                        serve_list.Add("ገንዘብና ንብረት");
                        btn = btn_serve_17_7;
                    }
                    btn.BorderColor = btn_serve_hidden_7.OnHoverBorderColor;
                    btn.ForeColor = btn_serve_hidden_7.OnHoverBorderColor;
                }
            }
        }

        private void serveListBoxController(String val, Guna.UI.WinForms.GunaButton btn)
        {           
            if (serve_list.Contains(val))
            {
                // add value
                serve_list.Remove(val);

                // change color
                btn.BorderColor = Color.Black;
                btn.ForeColor = Color.Black;
            }
            else
            {
                // add value
                serve_list.Add(val);

                // change color             
                btn.BorderColor = btn_serve_hidden_7.OnHoverBorderColor;
                btn.ForeColor = btn_serve_hidden_7.OnHoverBorderColor;
            }


            listBox_serve_7.Items.Clear();
            int i = 0;
            foreach (object key in serve_list)
            {
                listBox_serve_7.Items.Add(++i + " " + key);
            }
        }

        private void btn_serve_1_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ትምህርት ክፍል", btn_serve_1_7);
        }

        private void btn_serve_2_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("መዝሙር ክፍል", btn_serve_2_7);
        }

        private void btn_serve_3_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ሕጻናት እና ማዕከላውያን ክፍል", btn_serve_3_7);
        }

        private void btn_serve_4_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ልማት ክፍል", btn_serve_4_7);
        }

        private void btn_serve_5_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("አባላት ግንኙነት እና ሥነ-ምግባር ክፍል", btn_serve_5_7);
        }

        private void btn_serve_6_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ጉዞና ጉብኝት ክፍል", btn_serve_6_7);
        }

        private void btn_serve_8_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ውጪ ግንኙነት", btn_serve_8_7);
        }

        private void btn_serve_7_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("የበጎ አድራጎትና ሙያ አገልግሎት ክፍል", btn_serve_7_7);
        }

        private void btn_serve_9_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ማኅበራት አንድነት", btn_serve_9_7);
        }

        private void btn_serve_10_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ጥናት ፣ ምርምርና ስልጠና", btn_serve_10_7);
        }

        private void btn_serve_11_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ልዩ ልዩ ጉባኤያት", btn_serve_11_7);
        }

        private void btn_serve_12_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ሽያጭ", btn_serve_12_7);
        }

        private void btn_serve_13_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("አርትኦት", btn_serve_13_7);
        }

        private void btn_serve_14_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("መረጃ እና መዛግብት", btn_serve_14_7);
        }

        private void btn_serve_15_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ኦዲትና ኢንስፔክሽን", btn_serve_15_7);
        }

        private void btn_serve_16_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ምክረ-አበው", btn_serve_16_7);
        }

        private void btn_serve_17_7_Click(object sender, EventArgs e)
        {
            serveListBoxController("ገንዘብና ንብረት", btn_serve_17_7);
        }

        private void cmb_partner_date_year_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            // empty cmb_partner_month_6
            cmb_partner_date_month_6.Items.Clear();
            cmb_partner_date_month_6.DisplayMember = "Text";
            cmb_partner_date_month_6.ValueMember = "Text";

            cmb_partner_date_month_6.Items.Add(new { Text = "ወር" });
            cmb_partner_date_month_6.SelectedIndex = 0;

            // if year selected partner month names
            if (cmb_partner_date_year_6.SelectedIndex != 0)
            {
                cmb_partner_date_month_6.Items.Add(new { Text = "መስከረም" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ጥቅምት" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ሕዳር" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ታሕሳስ" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ጥር" });
                cmb_partner_date_month_6.Items.Add(new { Text = "የካቲት" });
                cmb_partner_date_month_6.Items.Add(new { Text = "መጋቢት" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ሚያዚያ" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ግንቦት" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ሰኔ" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ሐምሌ" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ነሐሴ" });
                cmb_partner_date_month_6.Items.Add(new { Text = "ጷጉሜን" });
            }


            // empty cmb_partner_day_6
            cmb_partner_date_day_6.Items.Clear();
            cmb_partner_date_day_6.DisplayMember = "Text";
            cmb_partner_date_day_6.ValueMember = "Text";

            cmb_partner_date_day_6.Items.Add(new { Text = "ቀን" });
            cmb_partner_date_day_6.SelectedIndex = 0;

            // birth day is changed
            lbl_partner_date_7.Text = "";
        }

        private void cmb_partner_date_month_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if month is not selected day become empty then return
                if (cmb_partner_date_month_6.SelectedIndex == 0)
                {
                    cmb_partner_date_day_6.Items.Clear();
                    cmb_partner_date_day_6.DisplayMember = "Text";
                    cmb_partner_date_day_6.ValueMember = "Text";

                    cmb_partner_date_day_6.Items.Add(new { Text = "ቀን" });
                    cmb_partner_date_day_6.SelectedIndex = 0;

                    return;
                }



                // empty cmb_partner_day_6 and add 5 days
                cmb_partner_date_day_6.Items.Clear();
                cmb_partner_date_day_6.DisplayMember = "Text";
                cmb_partner_date_day_6.ValueMember = "Text";

                cmb_partner_date_day_6.Items.Add(new { Text = "ቀን" });
                cmb_partner_date_day_6.Items.Add(new { Text = "1" });
                cmb_partner_date_day_6.Items.Add(new { Text = "2" });
                cmb_partner_date_day_6.Items.Add(new { Text = "3" });
                cmb_partner_date_day_6.Items.Add(new { Text = "4" });
                cmb_partner_date_day_6.Items.Add(new { Text = "5" });

                cmb_partner_date_day_6.SelectedIndex = 0;

                // if month is not equal ጷጉሜን add days from 6-30 
                if (cmb_partner_date_month_6.Text != "ጷጉሜን")
                {
                    cmb_partner_date_day_6.Items.Add(new { Text = "6" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "7" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "8" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "9" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "10" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "11" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "12" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "13" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "14" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "15" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "16" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "17" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "18" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "19" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "20" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "21" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "22" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "23" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "24" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "25" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "26" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "27" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "28" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "29" });
                    cmb_partner_date_day_6.Items.Add(new { Text = "30" });
                }
                // if month is ጷጉሜን
                else
                {
                    // if year is not empty
                    if (cmb_partner_date_year_6.SelectedIndex != 0)
                    {
                        // convert year to int
                        int yearInt = int.Parse(cmb_partner_date_year_6.Text.ToString());

                        // check the if the year has 6 days in ጷጉሜን
                        if (yearInt % 4 == 3)
                            cmb_partner_date_day_6.Items.Add(new { Text = "6" });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_course_before_yes_4_CheckedChanged(object sender, EventArgs e)
        {
            course_before = 1;

            panel_year_4.Visible = false;
            panel_church_4.Visible = true;
            panel_course_before_yes_4.Visible = true;

            // empty forms in panel 4
            num_year_4.Value = 1;
            txt_church_4.Text = "";
            check_subject_1_4.Checked = false;
            check_subject_2_4.Checked = false;
            check_subject_3_4.Checked = false;
            check_subject_4_4.Checked = false;
            check_subject_5_4.Checked = false;
            txt_subject_other_4.Text = "";
        }

        private void radio_course_before_no_4_CheckedChanged(object sender, EventArgs e)
        {
            course_before = 2;

            panel_year_4.Visible = false;
            panel_church_4.Visible = false;
            panel_course_before_yes_4.Visible = false;

            // empty forms in panel 4
            num_year_4.Value = 1;
            txt_church_4.Text = "";
            check_subject_1_4.Checked = false;
            check_subject_2_4.Checked = false;
            check_subject_3_4.Checked = false;
            check_subject_4_4.Checked = false;
            check_subject_5_4.Checked = false;
            txt_subject_other_4.Text = "";
        }

        private void radio_course_before_progress_4_CheckedChanged(object sender, EventArgs e)
        {
            course_before = 3;

            panel_year_4.Visible = true;
            panel_church_4.Visible = true;
            panel_course_before_yes_4.Visible = false;

            // empty forms in panel 4
            num_year_4.Value = 1;
            txt_church_4.Text = "";
            check_subject_1_4.Checked = false;
            check_subject_2_4.Checked = false;
            check_subject_3_4.Checked = false;
            check_subject_4_4.Checked = false;
            check_subject_5_4.Checked = false;
            txt_subject_other_4.Text = "";
        }

        private void radio_married_yes_5_CheckedChanged(object sender, EventArgs e)
        {
            married = 1;

            panel_marrage_5.Visible = true;
        }

        private void radio_married_no_5_CheckedChanged(object sender, EventArgs e)
        {
            married = 2;

            panel_marrage_5.Visible = false;

            // empty form in panel fifth
            txt_spouse_name_5.Text = "";
            txt_spouse_christian_name_5.Text = "";
            txt_spouse_work_position_5.Text = "";
            txt_spouse_secular_education_5.Text = "";
            txt_spouse_spritual_education_5.Text = "";
            txt_spouse_work_place_5.Text = "";
            txt_spouse_role_5.Text = "";
            num_children_count_5.Value = 0;
            txt_children_name_5.Text = "";
            txt_children_birth_date_5.Text = "";

            // hide icon_children_count_success_5 and lbl_children_count_success_5
            icon_children_count_success_5.Visible = false;
            lbl_children_count_success_5.Visible = false;
        }

        public void reset_form()
        {
            general_info_id = "-1";
            date_modified = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            // ===========================================
            // panel 1
            // ===========================================
            txt_full_name_1.Text = "";
            txt_christian_name_1.Text = "";
            txt_mother_name_1.Text = "";

            cmb_birth_date_year_1.SelectedIndex = 0;
            // empty cmb_birth_month_1
            cmb_birth_date_month_1.Items.Clear();
            cmb_birth_date_month_1.DisplayMember = "Text";
            cmb_birth_date_month_1.ValueMember = "Text";
            cmb_birth_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_birth_date_month_1.SelectedIndex = 0;
            // empty cmb_birth_day_1
            cmb_birth_date_day_1.Items.Clear();
            cmb_birth_date_day_1.DisplayMember = "Text";
            cmb_birth_date_day_1.ValueMember = "Text";
            cmb_birth_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_birth_date_day_1.SelectedIndex = 0;
            lbl_birth_day_1.Text = "";

            radio_sex_male_1.Checked = true;

            cmb_registration_date_year_1.SelectedIndex = 0;
            // empty cmb_registration_month_1
            cmb_registration_date_month_1.Items.Clear();
            cmb_registration_date_month_1.DisplayMember = "Text";
            cmb_registration_date_month_1.ValueMember = "Text";
            cmb_registration_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_registration_date_month_1.SelectedIndex = 0;
            // empty cmb_registration_day_1
            cmb_registration_date_day_1.Items.Clear();
            cmb_registration_date_day_1.DisplayMember = "Text";
            cmb_registration_date_day_1.ValueMember = "Text";
            cmb_registration_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_registration_date_day_1.SelectedIndex = 0;
            lbl_registration_date_1.Text = "";

            cmb_fill_date_year_1.SelectedIndex = 0;
            // empty cmb_fill_month_1
            cmb_fill_date_month_1.Items.Clear();
            cmb_fill_date_month_1.DisplayMember = "Text";
            cmb_fill_date_month_1.ValueMember = "Text";
            cmb_fill_date_month_1.Items.Add(new { Text = "ወር" });
            cmb_fill_date_month_1.SelectedIndex = 0;
            // empty cmb_fill_day_1
            cmb_fill_date_day_1.Items.Clear();
            cmb_fill_date_day_1.DisplayMember = "Text";
            cmb_fill_date_day_1.ValueMember = "Text";
            cmb_fill_date_day_1.Items.Add(new { Text = "ቀን" });
            cmb_fill_date_day_1.SelectedIndex = 0;
            lbl_fill_date_1.Text = "";

            radio_christianity_date_40_80_1.Checked = true;
            txt_why_christianity_date_1.Text = "";
            panel_christian_date_other_1.Visible = false;

            openFileDialog.FileName = null;
            pictureBox.Image = pictureBox.InitialImage;

            txt_participation_number_1.Text = "";
            txt_participation_number_1.Enabled = false;
            txt_participation_number_1.LineColor = txt_full_name_1.LineColor;
            txt_participation_number_1.FocusedLineColor = txt_full_name_1.FocusedLineColor;
            icon_participation_number_success_1.Visible = false;

            full_name = ""; christian_name = ""; mother_name = ""; birth_day = ""; sex = "ወንድ";
            registration_date = ""; date_fill_info = ""; why_christianity_date = ""; participation_number = "";
            participation_number_for_db = "";
            christianity_date = 1;
            is_imageChanged = false;
            photo_old = "";

            // ===========================================
            // panel 2
            // ===========================================
            txt_sub_city_2.Text = "";
            txt_woreda_2.Text = "";
            txt_kebele_2.Text = "";
            txt_house_number_2.Text = "";
            txt_cell_phone_2.Text = "";
            txt_home_phone_2.Text = "";
            txt_email_2.Text = "";
            txt_church_before_2.Text = "";

            sub_city = ""; woreda = ""; kebele = ""; house_number = ""; cell_phone = "";
            home_phone = ""; email = ""; church_before = "";
            
            // ===========================================
            // panel 3
            // ===========================================
            txt_secular_educational_level_3.Text = "";
            txt_secular_educational_qualification_3.Text = "";
            txt_school_name_3.Text = "";
            txt_spritual_educational_level_3.Text = "";
            txt_spritual_educational_qualification_3.Text = "";
            txt_work_skill_3.Text = "";
            txt_work_role_3.Text = "";
            txt_work_place_3.Text = "";
            txt_work_company_name_3.Text = "";

            secular_educational_level = ""; spritual_educational_level = "";
            secular_educational_qualification = ""; spritual_educational_qualification = "";
            school_name = "";
            work_skill = ""; work_role = ""; work_place = ""; work_company_name = "";

            // ===========================================
            // panel 4
            // ===========================================
            radio_course_before_yes_4.Checked = true;
            num_year_4.Value = 1;
            txt_church_4.Text = "";
            check_subject_1_4.Checked = false;
            check_subject_2_4.Checked = false;
            check_subject_3_4.Checked = false;
            check_subject_4_4.Checked = false;
            check_subject_5_4.Checked = false;
            txt_subject_other_4.Text = "";
            panel_church_4.Visible = true;
            panel_course_before_yes_4.Visible = true;

            church = ""; subjects = ""; subject_other = "";
            course_before = 1; year = 1;

            // ===========================================
            // panel 5
            // ===========================================
            radio_married_yes_5.Checked = true;
            panel_marrage_5.Visible = true;
            txt_spouse_name_5.Text = "";
            txt_spouse_christian_name_5.Text = "";
            txt_spouse_work_position_5.Text = "";
            txt_spouse_spritual_education_5.Text = "";
            txt_spouse_secular_education_5.Text = "";
            txt_spouse_work_place_5.Text = "";
            txt_spouse_role_5.Text = "";

            num_children_count_5.Value = 0;
            txt_children_name_5.Text = "";
            txt_children_name_5.Enabled = false;
            txt_children_birth_date_5.Text = "";
            txt_children_birth_date_5.Enabled = false;
            icon_children_count_success_5.Visible = false;
            lbl_children_count_success_5.Visible = false;
            lbl_children_count_success_5.Text = "2";

            btn_children_append_5.BackColor = SystemColors.ControlDark;
            btn_children_clear_5.BackColor = SystemColors.ControlDark;
            num_children_count_5.Enabled = false;
            num_children_count_5.Minimum = 0;
            num_children_count_5.Value = 0;

            spouse_name = ""; spouse_christian_name = ""; spouse_work_place = "";
            spouse_work_position = ""; spouse_role = ""; spouse_spritual_education = "";
            spouse_secular_education = ""; children_name = ""; children_birth_date = "";
            children_name_old = ""; children_birth_date_old = "";
            married = 1; children_count = 0; children_count_old = 0;  children_count_iterator = 0;
            children_append = -1;

            // ===========================================
            // panel 6
            // ===========================================
            txt_emergency_name_6.Text = "";
            txt_emergency_phone_6.Text = "";
            txt_repentance_father_name_6.Text = "";
            txt_repentance_father_place_6.Text = "";

            txt_partner_participation_number_6.Text = "";
            txt_partner_participation_number_6.LineColor = txt_partner_name_6.LineColor;
            txt_partner_participation_number_6.FocusedLineColor = txt_partner_name_6.FocusedLineColor;
            icon_partner_participation_number_success_6.Visible = false;
            txt_partner_name_6.Text = "";
            txt_partner_phone_6.Text = "";

            cmb_partner_date_year_6.SelectedIndex = 0;
            // empty cmb_partner_month_6
            cmb_partner_date_month_6.Items.Clear();
            cmb_partner_date_month_6.DisplayMember = "Text";
            cmb_partner_date_month_6.ValueMember = "Text";
            cmb_partner_date_month_6.Items.Add(new { Text = "ወር" });
            cmb_partner_date_month_6.SelectedIndex = 0;
            // empty cmb_partner_day_6
            cmb_partner_date_day_6.Items.Clear();
            cmb_partner_date_day_6.DisplayMember = "Text";
            cmb_partner_date_day_6.ValueMember = "Text";
            cmb_partner_date_day_6.Items.Add(new { Text = "ቀን" });
            cmb_partner_date_day_6.SelectedIndex = 0;
            lbl_partner_date_7.Text = "";

            emergency_name = ""; emergency_phone = ""; repentance_father_name = "";
            repentance_father_place = ""; partner_date = ""; partner_participation_number = "";
            partner_member_id = -1;
            // ===========================================
            // panel 7
            // ===========================================
            btn_serve_1_7.BorderColor = Color.Black;
            btn_serve_1_7.ForeColor = Color.Black;
            btn_serve_2_7.BorderColor = Color.Black;
            btn_serve_2_7.ForeColor = Color.Black;
            btn_serve_3_7.BorderColor = Color.Black;
            btn_serve_3_7.ForeColor = Color.Black;
            btn_serve_4_7.BorderColor = Color.Black;
            btn_serve_4_7.ForeColor = Color.Black;
            btn_serve_5_7.BorderColor = Color.Black;
            btn_serve_5_7.ForeColor = Color.Black;
            btn_serve_6_7.BorderColor = Color.Black;
            btn_serve_6_7.ForeColor = Color.Black;
            btn_serve_7_7.BorderColor = Color.Black;
            btn_serve_7_7.ForeColor = Color.Black;
            btn_serve_8_7.BorderColor = Color.Black;
            btn_serve_8_7.ForeColor = Color.Black;
            btn_serve_9_7.BorderColor = Color.Black;
            btn_serve_9_7.ForeColor = Color.Black;
            btn_serve_10_7.BorderColor = Color.Black;
            btn_serve_10_7.ForeColor = Color.Black;
            btn_serve_11_7.BorderColor = Color.Black;
            btn_serve_11_7.ForeColor = Color.Black;
            btn_serve_12_7.BorderColor = Color.Black;
            btn_serve_12_7.ForeColor = Color.Black;
            btn_serve_13_7.BorderColor = Color.Black;
            btn_serve_13_7.ForeColor = Color.Black;
            btn_serve_14_7.BorderColor = Color.Black;
            btn_serve_14_7.ForeColor = Color.Black;
            btn_serve_15_7.BorderColor = Color.Black;
            btn_serve_15_7.ForeColor = Color.Black;
            btn_serve_16_7.BorderColor = Color.Black;
            btn_serve_16_7.ForeColor = Color.Black;
            btn_serve_17_7.BorderColor = Color.Black;
            btn_serve_17_7.ForeColor = Color.Black;
            listBox_serve_7.Items.Clear();

            serve = "";
            serve_list.Clear();
            serve_listbox_iterator = 0;

            // ===========================================
            // panel 8
            // ===========================================
            cmb_leadership_service_kifil_8.Items.Clear();
            cmb_leadership_service_kifil_8.Items.AddRange(cmb_hidden_service_kifil_8.Items.Cast<Object>().ToArray());
            cmb_leadership_service_kifil_8.SelectedIndex = 0;
            cmb_sub_service_kifil_8.Items.Clear();
            cmb_sub_service_kifil_8.Items.AddRange(cmb_hidden_service_kifil_8.Items.Cast<Object>().ToArray());
            cmb_sub_service_kifil_8.SelectedIndex = 0;
            cmb_sector_service_kifil_8.Items.Clear();
            cmb_sector_service_kifil_8.Items.AddRange(cmb_hidden_service_kifil_8.Items.Cast<Object>().ToArray());
            cmb_sector_service_kifil_8.SelectedIndex = 0;

            txt_leadership_service_time_8.Text = "";
            txt_sub_service_time_8.Text = "";
            txt_sector_service_time_8.Text = "";

            icon_leadership_service_success_8.Visible = false;
            icon_sub_service_success_8.Visible = false;
            icon_sector_service_success_8.Visible = false;

            lbl_leadership_service_success_8.Text = "2";
            lbl_leadership_service_success_8.Visible = false;
            lbl_sub_service_success_8.Text = "2";
            lbl_sub_service_success_8.Visible = false;
            lbl_sector_service_success_8.Text = "2";
            lbl_sector_service_success_8.Visible = false;

            btn_leadership_service_append_8.BackColor = SystemColors.ControlDark;
            btn_leadership_service_clear_8.BackColor = SystemColors.ControlDark;
            btn_sub_service_append_8.BackColor = SystemColors.ControlDark;
            btn_sub_service_clear_8.BackColor = SystemColors.ControlDark;
            btn_sector_service_append_8.BackColor = SystemColors.ControlDark;
            btn_sector_service_clear_8.BackColor = SystemColors.ControlDark;

            leadership_service = ""; sub_service = ""; sector_service = "";
            leadership_service_old = ""; sub_service_old = ""; sector_service_old = "";
            leadership_service_append = -1; sub_service_append = -1; sector_service_append = -1;
            leadership_service_iterator = 0; sub_service_iterator = 0; sector_service_iterator = 0;
        }
    }
}