using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.Customer
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        private CUSTOMER Ocustomer
        {
            get
            {
                if (ViewState["CUSTOMER"] == null)
                {
                    return null;
                }
                else
                {
                    return (CUSTOMER)ViewState["CUSTOMER"];
                }
            }
            set
            {
                ViewState["CUSTOMER"] = value;
            }
        }

        private int PageState
        {
            get
            {
                return Convert.ToInt16(Request.QueryString["PageState"]);
            }
        }

        private string DataID
        {
            get
            {
                return Request.QueryString["DataID"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ProcessBegin();
            }
        }

        private void ProcessBegin()
        {
            switch (PageState)
            {
                case 0:
                    ProcessNew();
                    break;
                case 1:
                    PrecessEdit();
                    break;
                default:
                    break;
            }
        }

        private void PrecessEdit()
        {
            DataReadInEditState();
            PopulateControlInEditState();
            AdjustControlInEditState();
        }

        private void AdjustControlInEditState()
        {
            txtKODE_CUSTOMER.Enabled = false;
        }

        private void PopulateControlInEditState()
        {
            if (Ocustomer != null)
            {
                txtKODE_CUSTOMER.Text = Ocustomer.KODE_CUSTOMER;
                txtNAMA_CUSTOMER.Text = Ocustomer.NAMA_CUSTOMER;
                txtALAMAT_CUSTOMER.Text = Ocustomer.ALAMAT_CUSTOMER;
                txtTELEPON_CUSTOMER.Text = Ocustomer.TELEPON_CUSTOMER;
            }
        }

        private void DataReadInEditState()
        {
            Ocustomer = new CustomerCRUD().GetDataById(DataID);
        }

        private void ProcessNew()
        {
            DataReadInNewState();
            //PopulateControlInNewState();
            //AdjustControlInNewState();
        }

        private void DataReadInNewState()
        {
            Ocustomer = new CUSTOMER();
        }

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            string script = "";
            if (IsDataValidOnSave())
            {
                ProcessSave(out errorMsg);

                if (string.IsNullOrEmpty(errorMsg))
                {
                    script = "alert('Data berhasil disimpan'); window.close();";
                }
                else
                {
                    script = string.Format("alert('{0}')", errorMsg);
                }
            }
            ScriptManager.RegisterStartupScript(this, typeof(string), "onClick", script, true);
        }

        private void ProcessSave(out string errorMsg)
        {
            errorMsg = "";
            try
            {

                if (PageState == 0)
                {
                    Ocustomer.KODE_CUSTOMER = txtKODE_CUSTOMER.Text;
                }
                Ocustomer.NAMA_CUSTOMER = txtNAMA_CUSTOMER.Text;
                Ocustomer.ALAMAT_CUSTOMER = txtALAMAT_CUSTOMER.Text;
                Ocustomer.TELEPON_CUSTOMER = txtTELEPON_CUSTOMER.Text;

                if (PageState == 0)
                {
                    new CustomerCRUD().Insert(Ocustomer);
                }
                else
                {
                    new CustomerCRUD().Update(Ocustomer);
                }
            }

            catch (Exception ex)
            {
                errorMsg = "Preses Simpan GAGAL!!!!!!!";
            }
        }

        private bool IsDataValidOnSave()
        {
            string errorMsg = "";
            if (string.IsNullOrEmpty(txtKODE_CUSTOMER.Text))
            {
                errorMsg = "Kode Customer Kosong Mas!!!";
            }
            else if (string.IsNullOrEmpty(txtNAMA_CUSTOMER.Text))
            {
                errorMsg = "Nama Customer Masih Kosong LOH ";
            }
            else if (string.IsNullOrEmpty(txtALAMAT_CUSTOMER.Text))
            {
                errorMsg = "Alamat Customer Masih Kosong LOH ";
            }
            else if (string.IsNullOrEmpty(txtTELEPON_CUSTOMER.Text))
            {
                errorMsg = "No Telepon Masih Kosong LOH ";
            }
            else
            {
                return true;
            }

            string script = string.Format("alert('{0}')", errorMsg);
            ScriptManager.RegisterStartupScript(this, typeof(string), "onClick", script, true);
            return false;
        }
    }
}