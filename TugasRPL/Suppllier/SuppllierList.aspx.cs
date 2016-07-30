using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;

namespace TugasRPL.Suppllier
{
    public partial class SuppllierList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            SupplierCRUD SCrud = new SupplierCRUD();
            gvSuppllier.DataSource = SCrud.GetAllDataSupplierAsTable().DefaultView;
            gvSuppllier.DataBind();
        }

        protected void gvSuppllier_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSuppllier.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string KODE_SUPPLIER = ((LinkButton)sender).CommandArgument;
            try
            {
                SupplierCRUD SCrud = new SupplierCRUD();
                SCrud.Delete(KODE_SUPPLIER);

            }
            catch (Exception ex)
            {

            }
            DisplayData();
        }

        protected void btnTambah_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void btnCari_Click(object sender, EventArgs e)
        {

        }
    }
}