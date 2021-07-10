using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace FastFoodDemo.Register
{
    public partial class FilterUserControl : UserControl
    {
        public FilterUserControl()
        {
            InitializeComponent();
        }

        private void Filter2UserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalReports.filterCrystalReport crpt = new CrystalReports.filterCrystalReport();
                filterCrystalReportViewer.Visible = true;

                string sql = "SELECT * FROM view_for_filter";

                // none is selected
                if (cmb_sex.SelectedIndex == 0 && cmb_married.SelectedIndex == 0 && cmb_course_before.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter";

                // only sex
                else if (cmb_married.SelectedIndex == 0 && cmb_course_before.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter WHERE sex = N'" + cmb_sex.SelectedItem + "'";
                // only married
                else if (cmb_sex.SelectedIndex == 0 && cmb_course_before.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter WHERE married = N'" + cmb_married.SelectedItem + "'";
                // only course_before
                else if (cmb_sex.SelectedIndex == 0 && cmb_married.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter WHERE course_before = N'" + cmb_course_before.SelectedItem + "'";

                // only sex, married
                else if (cmb_course_before.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter " +
                        "WHERE sex = N'" + cmb_sex.SelectedItem + "' AND married = N'" + cmb_married.SelectedItem + "'";                
                // only sex, course_before
                else if(cmb_married.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter " +
                        "WHERE sex = N'" + cmb_sex.SelectedItem + "' AND course_before = N'" + cmb_course_before.SelectedItem + "'";
                // only married, course_before
                else if (cmb_sex.SelectedIndex == 0)
                    sql = "SELECT * FROM view_for_filter " +
                        "WHERE married = N'" + cmb_married.SelectedItem + "' AND course_before = N'" + cmb_course_before.SelectedItem + "'";
                
                // all is selected
                else
                    sql = "SELECT * FROM view_for_filter WHERE sex = N'" + cmb_sex.SelectedItem + "' AND " +
                        "married = N'" + cmb_married.SelectedItem + "' AND course_before = N'" + cmb_course_before.SelectedItem + "'";

                SqlConnection conn = DatabaseConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                crpt.SetDataSource(dataSet.Tables[0]);
                crpt.SetParameterValue("AppPath", Application.StartupPath + @"\upload\");
                filterCrystalReportViewer.ReportSource = null;
                filterCrystalReportViewer.ReportSource = crpt;

                filterCrystalReportViewer.Zoom(1);
                filterCrystalReportViewer.Refresh();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
