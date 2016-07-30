using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.Penjualan
{
    public partial class PenjualanList : System.Web.UI.Page
    {
        private PENJUALAN OPenjualan
        {
            get
            {
                if (ViewState["PENJUALAN"] == null)
                {
                    return null;
                }
                else
                {
                    return (PENJUALAN)ViewState["PENJUALAN"];
                }
            }
            set
            {
                ViewState["PENJUALAN"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
                Date();

            }
        }

        private void Date()
        {
            txtTGL_PENJUALAN.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss");
            

        }

        private void DisplayData()
        {
            PenjualanCRUD PCrud = new PenjualanCRUD();
            gvPenjualan.DataSource = PCrud.GetAllDataPenjualanAsTable().DefaultView;
            gvPenjualan.DataBind();
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            ProcessEdit();
        }

        private void ProcessEdit()
        {
            DataReadInEditState();
            PopulateControlInEditState();
            AdjustControlInEditState();
        }

        private void AdjustControlInEditState()
        {
            txtKODE_PENJUALAN.Enabled = false;
        }

        private void PopulateControlInEditState()
        {
            if (OPenjualan != null)
            {
                txtKODE_PENJUALAN.Text = OPenjualan.KODE_PENJUALAN;
                txtKODE_CUSTOMER.Text = OPenjualan.KODE_CUSTOMER;
                txtKODE_BARANG.Text = OPenjualan.KODE_BARANG;
                txtJUMLAH.Text = OPenjualan.JUMLAH_JUAL;
                txtTGL_PENJUALAN.Text = OPenjualan.TGL_PENJUALAN;


            }
        }

        private void DataReadInEditState()
        {
            OPenjualan = new PenjualanCRUD().GetPenjualanById(txtKODE_CUSTOMER.Text);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string ID_PENJUALAN = ((LinkButton)sender).CommandArgument;
            try
            {
                PenjualanCRUD sCrud = new PenjualanCRUD();
                sCrud.Delete(ID_PENJUALAN);
            }
            catch (Exception ex)
            {

            }
            DisplayData();
        }


        protected void gvPenjualan_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPenjualan.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void btnLOOKUPBARANG_Click(object sender, EventArgs e)
        {
            List<string> itemlookup = (List<string>)Session["itemlookup"];
            if (itemlookup != null)
            {

                string KODE_BARANG = itemlookup[0];
                BARANG B = new BarangCRUD().GetBarangByID(KODE_BARANG);
                if (B != null)
                {

                    txtKODE_BARANG.Text = KODE_BARANG;
                    txtNAMA_BARANG.Text = B.NAMA_BARANG;
                }
            }
        }

        protected void btnLOOKUPCUSTOMER_Click(object sender, EventArgs e)
        {
            List<string> itemlookup = (List<string>)Session["itemlookup"];
            if (itemlookup != null)
            {

                string KODE_CUSTOMER = itemlookup[0];
                CUSTOMER C = new CustomerCRUD().GetDataById(KODE_CUSTOMER);
                if (C != null)
                {

                    txtKODE_CUSTOMER.Text = KODE_CUSTOMER;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}