using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;

namespace TugasRPL.Customer
{
    public partial class CustomerList : System.Web.UI.Page
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
                CustomerCRUD CCrud = new CustomerCRUD();
                gvCustomer.DataSource= CCrud.GetDisplayAllDataAsTable().DefaultView;
                gvCustomer.DataBind();
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void gvCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomer.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void btnTambah_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string KODE_CUSTOMER = ((LinkButton)sender).CommandArgument;
            new CustomerCRUD().Delete(KODE_CUSTOMER);

            DisplayData();

        }

        protected void btnCari_Click(object sender, EventArgs e)
        {
            DisplayData(txtCari.Text);
        }

        private void DisplayData(string criteria)
        {
            CustomerCRUD CCrud = new CustomerCRUD();
            gvCustomer.DataSource = CCrud.GetDisplayAllDataAsTable(criteria).DefaultView;
            gvCustomer.DataBind();
        }
    }
}