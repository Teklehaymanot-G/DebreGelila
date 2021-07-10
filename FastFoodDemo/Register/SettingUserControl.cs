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

namespace FastFoodDemo.Register
{
    public partial class SettingUserControl : UserControl
    {
        //===================================================
        int member_id_for_add = -1;
        string member_id_for_edit_and_delete = "-1";
        string account_id_for_edit_and_delete = "-1";
        int status = 1;

        int user_created = 1, user_modified = 1;
        String date_created = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        String date_modified = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        //===================================================
        public int loginMemberId = 1;

        public SettingUserControl()
        {
            InitializeComponent();
        }

        public void loadDataToDataGridView()
        {
            try
            {
                var sql = "SELECT "+
                            "general_info.participation_number AS 'የተሳትፎ ቁጥር', "+
	                        "general_info.full_name AS 'ሙሉ ስም', "+
	                        "user_account.account_id, "+
	                        "user_account.member_id, "+
	                        "user_account.password AS 'የይለፍ ቁጥር', "+
                            "user_account.status, " +
                            "Case when user_account.status = 1 then N'አዎ ይቻል' " +
                                "when  user_account.status = 2 then N'አይ አይቻል' else '' end AS 'መግባት ይቻል'" +
                         "FROM "+
                            "general_info INNER JOIN user_account "+
                         "ON "+
                            "general_info.general_info_id = user_account.member_id";
                var conn = DatabaseConnection.getConnection();
                var dataAdapter = new SqlDataAdapter(sql, conn);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();

                dataAdapter.Fill(dataSet);


                dgv_setting.ReadOnly = true;
                dgv_setting.DataSource = dataSet.Tables[0];
                //MessageBox.Show(dataSet.Tables[0].Rows[0].ItemArray[9].ToString());

                dgv_setting.Columns[0].Visible = true;
                dgv_setting.Columns[1].Visible = true;
                dgv_setting.Columns[2].Visible = false;
                dgv_setting.Columns[3].Visible = false;
                dgv_setting.Columns[4].Visible = false;
                dgv_setting.Columns[5].Visible = false;
                dgv_setting.ClearSelection();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dgv_setting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                txt_participation_number.Text = dgv_setting.Rows[index].Cells[0].Value.ToString();
                txt_participation_number.Enabled = false;
                account_id_for_edit_and_delete = dgv_setting.Rows[index].Cells[2].Value.ToString();
                member_id_for_edit_and_delete = dgv_setting.Rows[index].Cells[3].Value.ToString();
                txt_full_name.Text = dgv_setting.Rows[index].Cells[1].Value.ToString();
                txt_password.Text = dgv_setting.Rows[index].Cells[4].Value.ToString();
                txt_password.PasswordChar = '*';
                string status = dgv_setting.Rows[index].Cells[5].Value.ToString();
                if (status == "1")
                    cmb_status.SelectedIndex = 0; 
                else 
                    cmb_status.SelectedIndex = 1;
            }
            catch
            {
                ////MessageBox.Show(ex.Message);
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.SelectedIndex == 0)
                status = 1;
            else
                status = 2;
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

        private void txt_participation_number_TextChanged(object sender, EventArgs e)
        {
            member_id_for_add = -1;
            icon_participation_number_success.Visible = false;
            txt_full_name.Text = "";
        }

        private void txt_participation_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_participation_number.Text != "")
                {
                    try
                    {
                        String sql = "SELECT general_info_id, full_name FROM general_info " +
                            "WHERE participation_number = @participation_number";
                        SqlConnection conn = DatabaseConnection.getConnection();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@participation_number", txt_participation_number.Text);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            if (check_member_id_found_on_account(getSqlIntData(reader, "general_info_id")))
                            {
                                icon_participation_number_success.Visible = false;
                                txt_full_name.Text = "";
                                MessageBox.Show(txt_participation_number.Text +
                                    " አካውንት ስላለው ከመረጃ ጠረጴዛው ላይ ይፈልጉ");
                            }                                
                            else
                            {
                                icon_participation_number_success.Visible = true;
                                txt_full_name.Text = getSqlStringData(reader, "full_name");
                                member_id_for_add = getSqlIntData(reader, "general_info_id");
                            }
                        }
                        else
                        {
                            icon_participation_number_success.Visible = false;
                            txt_full_name.Text = "";
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

        private bool check_member_id_found_on_account(int member_id)
        {
            try
            {
                String sql = "SELECT member_id FROM user_account " +
                    "WHERE member_id = @member_id";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@member_id", member_id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(member_id_for_add == -1)
                {
                    MessageBox.Show("የተሳትፎ ቁጥር አልመረጡም");
                    txt_participation_number.Focus();
                    return;
                }
                if (txt_password.Text == "")
                {
                    MessageBox.Show("የይለፍ ቁጥር አልመረጡም");
                    txt_password.Focus();
                    return;
                }
                if (txt_password.Text.Length < 4)
                {
                    MessageBox.Show("የይለፍ ቁጥር ብዛት ከ4 ማነስ የለበትም");
                    txt_password.Focus();
                    return;
                }
                if (txt_password.Text.Length > 8)
                {
                    MessageBox.Show("የይለፍ ቁጥር ብዛት ከ8 መብዛት የለበትም");
                    txt_password.Focus();
                    return;
                }

                String sql = "INSERT INTO user_account " +
                    "(member_id, password, status, " +
                    "user_created, date_created, " +
                    "user_modified, date_modified)" +

                    " VALUES (@member_id, @password, @status, " +
                    "@user_created, @date_created, " +
                    "@user_modified, @date_modified)";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@member_id", member_id_for_add);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@user_created", loginMemberId);
                cmd.Parameters.AddWithValue("@date_created", date_created);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);

                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                if(result > 0)
                {
                    reset_form();
                    MessageBox.Show("መረጃው በትክክል ተመዝግቧል");
                }
            }
            catch 
            {
                ////MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (account_id_for_edit_and_delete == "-1")
                {
                    MessageBox.Show("በመጀመሪያ ማስተካከል የፈለጉትን ከመረጃ ጠረጴዛው ላይ ይምረጡ");
                    return;
                }
                if (txt_password.Text == "")
                {
                    MessageBox.Show("የይለፍ ቁጥር አልመረጡም");
                    txt_password.Focus();
                    return;
                }
                if (txt_password.Text.Length < 4)
                {
                    MessageBox.Show("የይለፍ ቁጥር ብዛት ከ4 ማነስ የለበትም");
                    txt_password.Focus();
                    return;
                }
                if (txt_password.Text.Length > 8)
                {
                    MessageBox.Show("የይለፍ ቁጥር ብዛት ከ8 መብዛት የለበትም");
                    txt_password.Focus();
                    return;
                }
                if ((member_id_for_edit_and_delete == loginMemberId.ToString()) && status == 2)
                {
                    MessageBox.Show("የራስን መረጃ መግባት እንዳይችል ማድረግ አይቻልም");
                    return;
                }

                String sql = "UPDATE user_account " +
                    "SET " +
                    "password = @password, " +
                    "status = @status, " +
                    "user_modified = @user_modified, " +
                    "date_modified = @date_modified " +
                    "WHERE account_id = @account_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@account_id", account_id_for_edit_and_delete);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@user_modified", loginMemberId);
                cmd.Parameters.AddWithValue("@date_modified", date_modified);

                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                if (result > 0)
                {
                    reset_form();
                    MessageBox.Show("መረጃው በትክክል ተስተካክሏል");
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (account_id_for_edit_and_delete == "-1")
                {
                    MessageBox.Show("በመጀመሪያ ማስተካከል የፈለጉትን ከመረጃ ጠረጴዛው ላይ ይምረጡ");
                    return;
                }
                
                if ((member_id_for_edit_and_delete == loginMemberId.ToString()) && status == 2)
                {
                    MessageBox.Show("የራስን መረጃ ማጥፋት አይቻልም");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    "እርግጠኛ ኖት ይህን መረጃ ማጥፋት ይፈልጋሉ?",
                    "", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.No)
                    return;

                String sql = "DELETE FROM user_account " +
                    "WHERE account_id = @account_id";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@account_id", account_id_for_edit_and_delete);

                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conn.Close();
                if (result > 0)
                {
                    reset_form();
                    MessageBox.Show("መረጃው በትክክል ጠፍቷል");
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void reset_form()
        {
            txt_participation_number.Text = "";
            txt_participation_number.Enabled = true;
            account_id_for_edit_and_delete = "-1";
            icon_participation_number_success.Visible = false;
            member_id_for_add = -1;
            txt_full_name.Text = "";
            txt_password.Text = "";
            txt_password.PasswordChar = '\0';
            cmb_status.SelectedIndex = 0;
            loadDataToDataGridView();
        }
    }
}
