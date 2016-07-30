using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.Suppllier
{
    public partial class SupplierDetail : System.Web.UI.Page
    {
        private SUPPLIER OSupplier
        {
            get
            {
                if (ViewState["SUPPLIER"] == null)
                {
                    return null;
                }
                else
                {
                    return (SUPPLIER)ViewState["SUPPLIER"];
                }
            }
            set
            {
                ViewState["SUPPLIER"] = value;
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
                    ProcessEdit();
                    break;

                default: break;
            }
        }

        private void ProcessNew()
        {
            DataReadInNewState();
            PopulateControlInNewState();
            AdjustControlInNewState();
        }

        private void AdjustControlInNewState()
        {
            
        }

        private void PopulateControlInNewState()
        {
            
        }

        private void DataReadInNewState()
        {
            OSupplier = new SUPPLIER();
        }

        private void ProcessEdit()
        {
            DataReadInEditState();
            PopulateControlInEditState();
            AdjustControlInEditState();
        }

        private void AdjustControlInEditState()
        {
            txtKODE_SUPPLIER.Enabled = false;
        }

        private void PopulateControlInEditState()
        {
            if (OSupplier != null)
            {
                txtKODE_SUPPLIER.Text = OSupplier.KODE_SUPPLIER;
                txtNAMA_SUPPLIER.Text = OSupplier.NAMA_SUPPLIER;
                txtALAMAT_SUPPLIER.Text = OSupplier.ALAMAT_SUPPLIER;
                txtTELEPON_SUPPLIER.Text = OSupplier.TELEPON_SUPPLIER;
            }
        }

        private void DataReadInEditState()
        {
            SupplierCRUD SCrud = new SupplierCRUD();
            OSupplier = SCrud.GetSupplierById(DataID);
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
                    OSupplier.KODE_SUPPLIER = txtKODE_SUPPLIER.Text;
                }
                OSupplier.NAMA_SUPPLIER = txtNAMA_SUPPLIER.Text;
                OSupplier.ALAMAT_SUPPLIER = txtALAMAT_SUPPLIER.Text;
                OSupplier.TELEPON_SUPPLIER = txtTELEPON_SUPPLIER.Text;

                if (PageState == 0)
                {
                    new SupplierCRUD().Insert(OSupplier);
                }
                else
                {
                    new SupplierCRUD().Update(OSupplier);
                }
            }
            catch (Exception ex)
            {
                errorMsg = "Save Data Pasok Error!";
            }
        }

        private bool IsDataValidOnSave()
        {
            string errorMsg = "";
            if (string.IsNullOrEmpty(txtKODE_SUPPLIER.Text))
            {
                errorMsg = "Kode Supplier Tidak boleh Kosong!";
            }
            else if (string.IsNullOrEmpty(txtNAMA_SUPPLIER.Text))
            {
                errorMsg = "Nama Supplier Tidak boleh Kosong!";
            }
            else if (string.IsNullOrEmpty(txtALAMAT_SUPPLIER.Text))
            {
                errorMsg = "Alamat Supplier Tidak boleh Kosong!";
            }
            else if (string.IsNullOrEmpty(txtTELEPON_SUPPLIER.Text))
            {
                errorMsg = "Telepon Supplier Tidak boleh Kosong!";
            }
            else
            {
                return true;
            }

            string script = string.Format("alert('{0}');", errorMsg);
            ScriptManager.RegisterStartupScript(this, typeof(string), "onClick", script, true);
            return false;
        }
    }
}