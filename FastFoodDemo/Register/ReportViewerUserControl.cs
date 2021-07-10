using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Register
{
    public partial class ReportViewerUserControl : UserControl
    {
        public ReportViewerUserControl()
        {
            InitializeComponent();
        }

        public void load_report(CrystalReports.filterCrystalReport crpt, DataSet dataSet)
        {
            try
            {
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
