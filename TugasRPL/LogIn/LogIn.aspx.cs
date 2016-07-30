using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.LogIn
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnSigIn_Click(object sender, EventArgs e)
        {
            string ErrorMsg = "";
            if (txtNAMA_USERS.Text == "admin" && txtPASSWORDS.Text == "admin")
            {
                Response.Redirect("../Barang/BarangList.aspx");
            }
            else
            {
                ErrorMsg = "alert('Password salah')";
            }
            ScriptManager.RegisterStartupScript(this, typeof(string), "Onclik", ErrorMsg, true);
        }

    }
}