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
    public partial class LaporanSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportDataSource RDS = new ReportDataSource("DataSet1", GetReportSupplier());

                ReportViewerLaporanSupplier.LocalReport.DataSources.Add(RDS);
                ReportViewerLaporanSupplier.LocalReport.ReportPath = Server.MapPath("ReportSupplier.rdlc");


                ReportViewerLaporanSupplier.LocalReport.Refresh();
            }
        }

        private DataTable GetReportSupplier()
        {
            SupplierCRUD SCrud = new SupplierCRUD();
            return SCrud.GetVLaporanSupplierAsTable();
        }
    }
}