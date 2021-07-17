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
using FastFoodDemo.Register;

namespace FastFoodDemo.ListData
{
    public partial class ListDataUserControl : UserControl
    {
        public event EventHandler EditClicked;
        public string general_info_id = "-1";
        public string loginMemberId = "-1";

        public ListDataUserControl()
        {
            InitializeComponent();
        }

        public void loadDataToDataGridView()
        {
            try
            {
                var sql = "SELECT TOP (1000) " +
                    "[general_info_id]" +
                    ",[participation_number] AS 'የተሳትፎ ቁጥር'" +
                    ",[full_name] AS 'ሙሉ ስም'" +
                    ",[christian_name] AS 'የክርስትና ስም'" +
                    ",[mother_name] AS 'የእናት ስም'" +
                    ",[cell_phone] AS 'ስልክ'" +
                    ",[sex] AS 'ጾታ'" +
                    ",[registration_date] AS 'የምዝገባ ቀን' " +
                    "FROM general_info JOIN address_info " +
                    "ON general_info.general_info_id = address_info.member_id";
                var conn = DatabaseConnection.getConnection();
                var dataAdapter = new SqlDataAdapter(sql, conn);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                //dataSet.Clone();
                //dataSet.Tables[0].Columns[6].DataType = typeof(string);
                /*for(int i=0; i<dataSet.Tables[0].Rows.Count; i++)
                {
                    if (dataSet.Tables[0].Rows[i].ItemArray[6].ToString().Trim() == "1")
                        dataSet.Tables[0].Rows[i].ItemArray[6] = "ያገባ";
                    else
                        dataSet.Tables[0].Rows[i].ItemArray[6] = "ያላገባ";


                    if (dataSet.Tables[0].Rows[i].ItemArray[9].ToString().Trim() == "1")
                        dataSet.Tables[0].Rows[i].ItemArray[9] = "ተምሬያለሁ";
                    else if (dataSet.Tables[0].Rows[i].ItemArray[9].ToString().Trim() == "2")
                        dataSet.Tables[0].Rows[i].ItemArray[9] = "አልተማርኩም";
                    else
                        dataSet.Tables[0].Rows[i].ItemArray[9] = "እየተማርኩኝ ነው";


                    //dataSet.Tables[0].Rows[i].SetModified();
                    //dataSet.Tables[0].Rows[i].AcceptChanges();
                }*/
                /*dataSet.Tables[0].AcceptChanges();
                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    row[6] = "asddsa";
                   
                }
                dataSet.Tables[0].AcceptChanges();*/



                dgv_main.ReadOnly = true;
                dgv_main.DataSource = dataSet.Tables[0];
                //MessageBox.Show(dataSet.Tables[0].Rows[0].ItemArray[9].ToString());

                dgv_main.Columns[0].Visible = false;
                dgv_main.Columns[1].Visible = true;
                dgv_main.Columns[2].Visible = true;
                dgv_main.Columns[3].Visible = true;
                dgv_main.Columns[4].Visible = true;
                dgv_main.Columns[5].Visible = true;
                dgv_main.Columns[6].Visible = true;
                dgv_main.Columns[7].Visible = true;
                dgv_main.ClearSelection();

                // remove selected id
                txt_general_info_id.Text = "";
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private string get_address_info(string column, string val)
        {
            try
            {
                string sql = "SELECT " + column + "FROM address_info WHERE member_id='" + val + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_general_info_id.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show(
                    "የአባል ሙሉ መረጃ ማጥፋት ይፈልጋሉ?", "", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (txt_general_info_id.Text == loginMemberId.ToString())
                {
                    MessageBox.Show("የራስን መረጃ ማጥፋት አይቻልም");
                    return;
                }

                if (dialogResult == DialogResult.Yes)
                {
                    delete_from_tbl("address_info", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("educational_background", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("family_info", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("service_info", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("spritual_education_background", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("user_account", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("work_info", "member_id", txt_general_info_id.Text);
                    delete_from_tbl("general_info", "general_info_id", txt_general_info_id.Text);
                    loadDataToDataGridView();
                }
            }
            
        }

        private bool delete_from_tbl(string tbl, string col, string id)
        {
            try
            {
                string sql = "DELETE FROM " + tbl + " WHERE " + col + "='" + id + "'";
                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch(SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void dgv_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txt_general_info_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txt_general_info_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(txt_general_info_id.Text == "")
            {
                return;
            }
           
            general_info_id = txt_general_info_id.Text;
            OnClick(EventArgs.Empty);
        }

        protected virtual void ListDataUserControl_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, e);
        }

        private void dgv_main_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgv_main_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //int index = dgv_main.CurrentRow.Index;
                //txt_general_info_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgv_main_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int index = dgv_main.CurrentRow.Index;
                txt_general_info_id.Text = dgv_main.Rows[index].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgv_main_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int column = e.ColumnIndex;
            
            if (column == 1)
            {
                if(dgv_main.Columns[1].HeaderText == "የተሳትፎ ቁጥር ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[1], ListSortDirection.Descending);
                    dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር ˅";
                }
                else {
                    dgv_main.Sort(dgv_main.Columns[1], ListSortDirection.Ascending);
                    dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር ˄";
                }

                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[6].HeaderText = "ጾታ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 2)
            {
                if (dgv_main.Columns[2].HeaderText == "ሙሉ ስም ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[2], ListSortDirection.Descending);
                    dgv_main.Columns[2].HeaderText = "ሙሉ ስም ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[2], ListSortDirection.Ascending);
                    dgv_main.Columns[2].HeaderText = "ሙሉ ስም ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[6].HeaderText = "ጾታ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 3)
            {
                if (dgv_main.Columns[3].HeaderText == "የክርስትና ስም ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[3], ListSortDirection.Descending);
                    dgv_main.Columns[3].HeaderText = "የክርስትና ስም ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[3], ListSortDirection.Ascending);
                    dgv_main.Columns[3].HeaderText = "የክርስትና ስም ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[6].HeaderText = "ጾታ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 4)
            {
                if (dgv_main.Columns[4].HeaderText == "የእናት ስም ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[4], ListSortDirection.Descending);
                    dgv_main.Columns[4].HeaderText = "የእናት ስም ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[4], ListSortDirection.Ascending);
                    dgv_main.Columns[4].HeaderText = "የእናት ስም ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[6].HeaderText = "ጾታ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 5)
            {
                if (dgv_main.Columns[5].HeaderText == "ስልክ ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[4], ListSortDirection.Descending);
                    dgv_main.Columns[5].HeaderText = "ስልክ ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[5], ListSortDirection.Ascending);
                    dgv_main.Columns[5].HeaderText = "ስልክ ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[6].HeaderText = "ጾታ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 6)
            {
                if (dgv_main.Columns[6].HeaderText == "ጾታ ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[6], ListSortDirection.Descending);
                    dgv_main.Columns[6].HeaderText = "ጾታ ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[6], ListSortDirection.Ascending);
                    dgv_main.Columns[6].HeaderText = "ጾታ ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን";
            }

            else if (column == 7)
            {
                if (dgv_main.Columns[7].HeaderText == "የምዝገባ ቀን ˄")
                {
                    dgv_main.Sort(dgv_main.Columns[7], ListSortDirection.Descending);
                    dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን ˅";
                }
                else
                {
                    dgv_main.Sort(dgv_main.Columns[7], ListSortDirection.Ascending);
                    dgv_main.Columns[7].HeaderText = "የምዝገባ ቀን ˄";
                }

                dgv_main.Columns[1].HeaderText = "የተሳትፎ ቁጥር";
                dgv_main.Columns[2].HeaderText = "ሙሉ ስም";
                dgv_main.Columns[3].HeaderText = "የክርስትና ስም";
                dgv_main.Columns[4].HeaderText = "የእናት ስም";
                dgv_main.Columns[5].HeaderText = "ስልክ";
                dgv_main.Columns[6].HeaderText = "ጾታ";
            }
        }
    }
}
