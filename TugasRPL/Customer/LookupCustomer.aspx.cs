using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;

namespace TugasRPL.Customer
{
    public partial class LookupCustomer : System.Web.UI.Page
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
            CustomerCRUD Bcrud = new CustomerCRUD();
            gvlookupcustomer.DataSource = Bcrud.GetDisplayVCustomer().DefaultView;
            gvlookupcustomer.DataBind();
        }

        protected void lbSelect_Click(object sender, EventArgs e)
        {
            List<string> itemlookup = new List<string>();
            LinkButton button = sender as LinkButton;
            itemlookup.Add(button.CommandArgument);
            Session["itemlookup"] = itemlookup;
            ScriptManager.RegisterStartupScript(this, typeof(string), "onclick", "window.close();", true);
        }
    }
}