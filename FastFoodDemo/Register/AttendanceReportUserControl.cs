using FastFoodDemo.DateConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Register
{
    public partial class AttendanceReportUserControl : UserControl
    {
        bool startDateIsNotChanged = true;
        bool endDateIsNotChanged = true;

        public AttendanceReportUserControl()
        {
            InitializeComponent();

            lbl_start_date.Text = "";
            lbl_end_date.Text = "";
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            startDateIsNotChanged = false;
            lbl_start_date.Text = MyDateConverter.FromGrigorianToEthiopian(dtp_start.Value);
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            endDateIsNotChanged = false;
            lbl_end_date.Text = MyDateConverter.FromGrigorianToEthiopian(dtp_end.Value);
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
                else if (cmb_type.SelectedIndex == 0)
                {
                    // only sex
                    if (startDateIsNotChanged && endDateIsNotChanged)
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

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dtp_start.Value = DateTime.Today;
            dtp_end.Value = DateTime.Today;

            startDateIsNotChanged = true;
            endDateIsNotChanged = true;


            lbl_start_date.Text = "";
            lbl_end_date.Text = "";

            cmb_type.SelectedIndex = 0;
            cmb_sex.SelectedIndex = 0;

            check_add_photo.Checked = false;

            filterCrystalReportViewer.ReportSource = null;
            filterCrystalReportViewer.Refresh();
        }
    }
}
