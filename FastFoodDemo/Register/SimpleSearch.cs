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
using CrystalDecisions.CrystalReports.Engine;

namespace FastFoodDemo.Register
{
    public partial class SimpleSearch : UserControl
    {
        private class Member
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public SimpleSearch()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                try
                {
                    String sql = "SELECT general_info_id, full_name, participation_number FROM general_info WHERE " +
                        "participation_number LIKE '%" + txt_search.Text + "%' OR " +
                        "full_name LIKE N'%" + txt_search.Text + "%'";

                    SqlConnection conn = DatabaseConnection.getConnection();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var member = new List<Member>();
                        while (reader.Read())
                        {
                            int general_info_id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string participation_number = reader.GetString(2);

                            member.Add(new Member() { Id = general_info_id, Name = name });
                        }

                        lb_search_result.DisplayMember = "Name";
                        lb_search_result.ValueMember = "Id";
                        lb_search_result.DataSource = member;
                        lb_search_result.ClearSelected();
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void lb_search_result_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
        }

        private void getGeneralInfo(string general_info_id, CrystalReports.registerCrystalReport crpt)
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
                    //MessageBox.Show(Application.StartupPath + @"\upload\" + getSqlStringData(reader, "photo"));
                    crpt.SetParameterValue("ImagePath", Application.StartupPath + @"\upload\" + getSqlStringData(reader, "photo").Trim());

                    putDataOnReport(crpt, "Section2", "txt_participation_number_1", getSqlStringData(reader, "participation_number"));
                    putDataOnReport(crpt, "Section2", "txt_full_name_1", getSqlStringData(reader, "full_name"));
                    putDataOnReport(crpt, "Section2", "txt_christian_name_1", getSqlStringData(reader, "christian_name"));
                    putDataOnReport(crpt, "Section2", "txt_mother_name_1", getSqlStringData(reader, "mother_name"));
                    putDataOnReport(crpt, "Section2", "txt_birth_date_1", getSqlStringData(reader, "birth_day"));
                    if (getSqlStringData(reader, "birth_day") == "ወንድ")
                        putDataOnReport(crpt, "Section2", "check_male_1", "✔");
                    else
                        putDataOnReport(crpt, "Section2", "check_female_1", "✔");
                    putDataOnReport(crpt, "Section2", "txt_registration_date_1", getSqlStringData(reader, "registration_date"));
                    putDataOnReport(crpt, "Section2", "txt_fill_date_1", getSqlStringData(reader, "date_fill_info"));
                    
                    if (getSqlIntData(reader, "christianity_date") == 1)
                        putDataOnReport(crpt, "Section2", "check_christianity_date_40_80_1", "✔");
                    else
                    {
                        putDataOnReport(crpt, "Section2", "check_christianity_date_other_1", "✔");
                        putDataOnReport(crpt, "Section2", "txt_christianity_date_other_1", getSqlStringData(reader, "why_christianity_date"));
                    }

                    String[] serveArr = getSqlStringData(reader, "serve").Trim().Split('፣');
                    for (int i = 0; i < (serveArr.Length - 1); i++)
                    {
                        putDataOnReport(crpt, "Section2", "txt_serve_" + serveArr[i] + "_1", (i + 1).ToString());
                    }

                    putDataOnReport(crpt, "Section2", "txt_emergency_name_1", getSqlStringData(reader, "emergency_name"));
                    putDataOnReport(crpt, "Section2", "txt_emergency_phone_1", getSqlStringData(reader, "emergency_phone"));
                    putDataOnReport(crpt, "Section2", "txt_repentance_father_name_1", getSqlStringData(reader, "repentance_father_name"));
                    putDataOnReport(crpt, "Section2", "txt_repentance_father_place_1", getSqlStringData(reader, "repentance_father_place"));
                    
                    putDataOnReport(crpt, "Section2", "txt_partner_name_1", getPartnerInfo(getSqlStringData(reader, "partner_member_id"), "general_info", "full_name"));
                    putDataOnReport(crpt, "Section2", "txt_partner_phone_1", getPartnerInfo(getSqlStringData(reader, "partner_member_id"), "address_info", "cell_phone"));
                    putDataOnReport(crpt, "Section2", "txt_partner_date_1", getSqlStringData(reader, "partner_date"));
                    putDataOnReport(crpt, "Section2", "txt_partner_participation_number_1", getPartnerInfo(getSqlStringData(reader, "partner_member_id"), "general_info", "participation_number"));
                }
                conn.Close();
            }
            catch(SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void getAddressInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                    putDataOnReport(crpt, "Section2", "txt_sub_city_1", getSqlStringData(reader, "sub_city"));
                    putDataOnReport(crpt, "Section2", "txt_woreda_1", getSqlStringData(reader, "woreda"));
                    putDataOnReport(crpt, "Section2", "txt_kebele_1", getSqlStringData(reader, "kebele"));
                    putDataOnReport(crpt, "Section2", "txt_house_number_1", getSqlStringData(reader, "house_number"));
                    putDataOnReport(crpt, "Section2", "txt_cell_phone_1", getSqlStringData(reader, "cell_phone"));
                    putDataOnReport(crpt, "Section2", "txt_home_phone_1", getSqlStringData(reader, "home_phone"));
                    putDataOnReport(crpt, "Section2", "txt_email_1", getSqlStringData(reader, "email"));
                    putDataOnReport(crpt, "Section2", "txt_church_before_1", getSqlStringData(reader, "church_before"));
                }
                conn.Close();
            }
            catch(SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void getEducationalBackgroundInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                    if (reader.GetString(reader.GetOrdinal("type")) == "መንፈሳዊ")
                    {
                        putDataOnReport(crpt, "Section2", "txt_spritual_educational_level_1", getSqlStringData(reader, "educational_level"));
                        putDataOnReport(crpt, "Section2", "txt_spritual_educational_qualification_1", getSqlStringData(reader, "educational_qualification"));
                    }
                    else if (reader.GetString(reader.GetOrdinal("type")) == "ዓለማዊ")
                    {
                        putDataOnReport(crpt, "Section2", "txt_secular_education_level_1", getSqlStringData(reader, "educational_level"));
                        putDataOnReport(crpt, "Section2", "txt_secular_education_qualification_1", getSqlStringData(reader, "educational_qualification"));
                    }
                    putDataOnReport(crpt, "Section2", "txt_school_name_1", getSqlStringData(reader, "school_name"));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void getFamilyInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                        putDataOnReport(crpt, "Section2", "check_married_1_1", "✔");
                    else
                        putDataOnReport(crpt, "Section2", "check_married_2_1", "✔");

                    putDataOnReport(crpt, "Section2", "txt_spouse_name_1", getSqlStringData(reader, "spouse_name"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_christian_name_1", getSqlStringData(reader, "spouse_christian_name"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_work_position_1", getSqlStringData(reader, "spouse_work_position"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_spritual_education_1", getSqlStringData(reader, "spouse_spritual_education"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_secular_education_1", getSqlStringData(reader, "spouse_secular_education"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_work_place_1", getSqlStringData(reader, "spouse_work_place"));
                    putDataOnReport(crpt, "Section2", "txt_spouse_work_role_1", getSqlStringData(reader, "spouse_role"));
                    
                    String[] childrenNameArr = getSqlStringData(reader, "children_name").Trim().Split('፣');
                    String[] childrenBirthDateArr = getSqlStringData(reader, "children_birth_date").Trim().Split('፣');
                    putDataOnReport(crpt, "Section2", "txt_children_count_1", "       " + getSqlIntData(reader, "children_count"));

                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_name_1"]).Height = (childrenNameArr.Length - 1) * 240;
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_birth_date_1"]).Height = (childrenBirthDateArr.Length - 1) * 240;
                    for (int i = 0; i < (childrenNameArr.Length - 1); i++)
                    {
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_name_1"]).Text += childrenNameArr[i] + "\n";
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_children_birth_date_1"]).Text += childrenBirthDateArr[i] + "\n";
                    }
                    
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void getServiceInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                    // በአመራርነት 
                    String[] leadershipArr = getSqlStringData(reader, "leadership").Trim().Split('፤');
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_kifil_1"]).Height = (leadershipArr.Length - 1) * 240;
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_time_1"]).Height = (leadershipArr.Length - 1) * 240;
                    for (int i = 0; i < (leadershipArr.Length - 1); i++)
                    {
                        String[] arr = leadershipArr[i].Split('፣');
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_kifil_1"]).Text += arr[0] + "\n";
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_leadership_service_time_1"]).Text += arr[1] + "\n";
                    }

                    // በንዑስነት  
                    String[] subArr = getSqlStringData(reader, "sub").Trim().Split('፤');
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_kifil_1"]).Height = (subArr.Length - 1) * 240;
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_time_1"]).Height = (subArr.Length - 1) * 240;
                    for (int i = 0; i < (subArr.Length - 1); i++)
                    {
                        String[] arr = subArr[i].Split('፣');
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_kifil_1"]).Text += arr[0] + "\n";
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sub_service_time_1"]).Text += arr[1] + "\n";
                    }

                    // በዘርፍነት 
                    String[] sectorArr = getSqlStringData(reader, "sector").Trim().Split('፤');
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_kifil_1"]).Height = (sectorArr.Length - 1) * 240;
                    ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_time_1"]).Height = (sectorArr.Length - 1) * 240;
                    for (int i = 0; i < (sectorArr.Length - 1); i++)
                    {
                        String[] arr = sectorArr[i].Split('፣');
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_kifil_1"]).Text += arr[0] + "\n";
                        ((TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txt_sector_service_time_1"]).Text += arr[1] + "\n";
                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        
        private void getSpritualEducationBackgroundInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                        putDataOnReport(crpt, "Section2", "txt_course_before_1_1", "    ✔");
                        putDataOnReport(crpt, "Section2", "txt_church_1", getSqlStringData(reader, "church"));
                        String[] subjectsArr = getSqlStringData(reader, "subjects").Trim().Split('፣');
                        for (int i = 0; i < (subjectsArr.Length - 1); i++)
                        {
                            putDataOnReport(crpt, "Section2", "check_subjects_" + subjectsArr[i] + "_1", "✔");
                        }
                        putDataOnReport(crpt, "Section2", "txt_subjects_other_1", getSqlStringData(reader, "subject_other"));
                    }
                    else if (getSqlIntData(reader, "course_before") == 2)
                        putDataOnReport(crpt, "Section2", "txt_course_before_2_1", "    ✔");
                    else
                    {
                        putDataOnReport(crpt, "Section2", "txt_course_before_3_1", "    ✔");
                        putDataOnReport(crpt, "Section2", "txt_year_1", "         " + getSqlIntData(reader, "year"));
                        putDataOnReport(crpt, "Section2", "txt_church_1", getSqlStringData(reader, "church"));
                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
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

        private void getWorkInfo(string member_id, CrystalReports.registerCrystalReport crpt)
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
                    putDataOnReport(crpt, "Section2", "txt_work_skill_1", getSqlStringData(reader, "skill"));
                    putDataOnReport(crpt, "Section2", "txt_work_role_1", getSqlStringData(reader, "role"));
                    putDataOnReport(crpt, "Section2", "txt_work_place_1", getSqlStringData(reader, "place"));
                    putDataOnReport(crpt, "Section2", "txt_work_company_name_1", getSqlStringData(reader, "company_name"));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message+"asdda");
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(e.Message);
            }
            return -1;
        }

        private string getPartnerInfo(string partner_member_id, string tbl, string col)
        {
            try
            {
                string whereCol = "general_info_id";
                if(tbl == "address_info")
                    whereCol = "member_id";

                string sql = "SELECT " + col + " FROM "+tbl+" WHERE "+whereCol+"='" + partner_member_id + "'";
                
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                conn.Close();
            }
            catch(SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_search.Text != "")
                {
                    try
                    {
                        String sql = "SELECT general_info_id, full_name, participation_number FROM general_info WHERE " +
                            "participation_number LIKE '%" + txt_search.Text + "%' OR " +
                            "full_name LIKE N'%" + txt_search.Text + "%'";

                        SqlConnection conn = DatabaseConnection.getConnection();
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            var member = new List<Member>();
                            while (reader.Read())
                            {
                                int general_info_id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string participation_number = reader.GetString(2);

                                member.Add(new Member() { Id = general_info_id, Name = name });
                            }

                            lb_search_result.SelectedIndex = -1;
                            lb_search_result.DisplayMember = "Name";
                            lb_search_result.ValueMember = "Id";
                            lb_search_result.DataSource = member;
                            lb_search_result.ClearSelected();
                        }
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void lb_search_result_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb_search_result.SelectedIndex == -1)
                return;
            try
            {
                CrystalReports.registerCrystalReport crpt = new CrystalReports.registerCrystalReport();
                getGeneralInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getAddressInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getEducationalBackgroundInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getFamilyInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getServiceInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getSpritualEducationBackgroundInfo(lb_search_result.SelectedValue.ToString(), crpt);
                getWorkInfo(lb_search_result.SelectedValue.ToString(), crpt);

                /*string sql = "SELECT * FROM view_for_simple_search " +
                    "WHERE dbo.general_info.general_info_id='"+lb_search_result.SelectedValue+"'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    putDataOnReport(crpt, "Section2", "txt_participation_number_1", (reader.GetOrdinal("cell_phone")).ToString());
                    putDataOnReport(crpt, "Section2", "txt_full_name_1", reader.GetString(reader.GetOrdinal("full_name")).ToString());
                    putDataOnReport(crpt, "Section2", "txt_christian_name_1", "cristian name");
                    putDataOnReport(crpt, "Section2", "txt_mother_name_1", "mother_name");
                    putDataOnReport(crpt, "Section2", "txt_birth_date_1", "birth_day");
                }
                conn.Close();*/





                /*try
                {
                    string sql = "SELECT photo FROM general_info WHERE general_info_id=1";

                    SqlConnection conn = DatabaseConnection.getConnection();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    crpt.SetDataSource(dataSet.Tables["tabble"]);
                    crpt.SetParameterValue("AppPath", Application.StartupPath + @"\upload\ሙሉ ስም - 00001.JPG");

                    simpleSearchCrystalReportViewer.ReportSource = null;
                    simpleSearchCrystalReportViewer.ReportSource = crpt;

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }*/

                simpleSearchCrystalReportViewer.Visible = true;
                
                simpleSearchCrystalReportViewer.ReportSource = crpt;
                simpleSearchCrystalReportViewer.Zoom(1);
                simpleSearchCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }


        public void load_report()
        {
            
        }
    }
}
