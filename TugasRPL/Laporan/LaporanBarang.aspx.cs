using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;

namespace TugasRPL.Laporan
{
    public partial class LaporanBarang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportDataSource RDS = new ReportDataSource("DataSet1", GetReportBarang());

                ReportViewerBarang.LocalReport.DataSources.Add(RDS);
                ReportViewerBarang.LocalReport.ReportPath = Server.MapPath(".rdlc");


                ReportViewerBarang.LocalReport.Refresh();
            }
        }

        private DataTable GetReportBarang()
        {
            BarangCRUD BCrud = new BarangCRUD();
            return BCrud.GetVLaporanBarangAsTable();
        }
    }
}