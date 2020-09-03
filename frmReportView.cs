using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace CHITA
{
    public partial class frmReportView : Form
    {
        public string id = null;
        public frmReportView()
        {
            InitializeComponent();
        }

        private void FrmReportView_Load(object sender, EventArgs e)
        {
            DataTable dt = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblMember where id = "+id);
            ReportDataSource rdc = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"F:\repos\CHITA\Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdc);
            ReportParameter rimage = new ReportParameter()
            reportViewer1.LocalReport.SetParameters

            this.reportViewer1.RefreshReport();
        }
    }
}
