using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.Barang
{
    public partial class BarangList : System.Web.UI.Page
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
            BarangCRUD BCrud = new BarangCRUD();
            gvBarang.DataSource = BCrud.GetAllBarangAsDataTable().DefaultView;
            gvBarang.DataBind();
        }

        protected void gvBarang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBarang.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string KODE_BARANG = ((LinkButton)sender).CommandArgument;
            try
            {
                new BarangCRUD().Delete(KODE_BARANG);
            }
            catch (Exception ex) { }
            DisplayData();
        }

        protected void btnTambah_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            DisplayData();
            
        }

        protected void btnCari_Click(object sender, EventArgs e)
        {
            DisplaySearchMulti();//DENGAN DROPDOWN MULTI.
            //DisplaySearchSingle();//DDENGAN TANPA DROPDOWN SINGLE.
        }

        private void DisplaySearchSingle()
        {
            
        }

        private void DisplaySearchMulti()
        {
            string criteria = ddlCari.SelectedValue;
            string value = txtCari.Text;
            DisplayData(criteria, value);
            //ScriptManager.RegisterStartupScript(this, typeof(string), "onclick","alert('"+criteria+"');", true);
        }

        private void DisplayData(string criteria, string value)
        {
            BarangCRUD BCrud = new BarangCRUD();
            gvBarang.DataSource = BCrud.GetAllBarangAsDataTable(criteria, value).DefaultView;
            gvBarang.DataBind();
        }

    }
}