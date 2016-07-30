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
    public partial class BarangDetail : System.Web.UI.Page
    {
        private BARANG OBarang//---------UNTUK MEMNAGGIL ENTITY DENGAN VIEWSTATE------------
        {
            get
            {
                if (ViewState["BARANG"] == null)
                {

                    return null;
                }
                else
                {
                    return (BARANG)ViewState["BARANG"];
                }
            }
            set
            {
                ViewState["BARANG"] = value;
            }
        }

        private string DataID//---------UNTUK MEMNAGGIL QUERY STRING ID DARI ENTITY SEPERTI PRIMARY KEY------------
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

        private int PageState
        {
            get
            {
                return Convert.ToInt16(Request.QueryString["PageState"]);
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
                    ProsesEdit();
                    break;
            }
        }

        private void ProcessNew()
        {
            DataReadInNewState();
            PopulateControlinNewState();
            AdjustControlInNewState();
        }


        private void AdjustControlInNewState()
        {

        }

        private void PopulateControlinNewState()
        {
        }

        private void DataReadInNewState()
        {
            OBarang = new BARANG();

        }
        private void ProsesEdit()
        {
            DataReadInEditState();
            PopulateControlinEditState();
            AdjustControlInEditState();
        }

        private void AdjustControlInEditState()
        {
            txtKODE_BARANG.Enabled = false;
        }

        private void PopulateControlinEditState()//---------UNTUK LOAD DATA KE TEXTBOX------------
        {
            if (OBarang != null)
            {
                txtKODE_BARANG.Text = OBarang.KODE_BARANG;
                txtNAMA_BARANG.Text = OBarang.NAMA_BARANG;
                txtSTOK.Text = Convert.ToString(OBarang.STOK);
                txtHARGA.Text = Convert.ToString(OBarang.HARGA);
                txtKODE_SUPPLIER.Text =OBarang.KODE_SUPPLIER;
            }
        }

        private void DataReadInEditState()//---------UNTUK MEANGGIL BY ID DI CLASSCRUD------------
        {
            OBarang = new BarangCRUD().GetBarangByID(DataID);
        }

        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (IsDatavalidOnSave())
            {
                ProcessSave(out errorMsg);//---------UNTUK FUNGSI SIMPAN DARI TEXTBOX KE ENTIRY------------

                string script = "";
                if (string.IsNullOrEmpty(errorMsg))
                {
                    script = "alert('Data Barang berhasil disimpan!');window.close()";
                }
                else
                {
                    script = string.Format("alert('{0}');", errorMsg);
                }
                ScriptManager.RegisterStartupScript(this, typeof(string), "onClick", script, true);
            }
        }

        private void ProcessSave(out string errorMsg)
        {
            errorMsg = "";
            try
            {
                if (PageState == 0)
                {
                    OBarang.KODE_BARANG = txtKODE_BARANG.Text;
                }
                OBarang.NAMA_BARANG = txtNAMA_BARANG.Text;
                OBarang.STOK = Convert.ToInt32(txtSTOK.Text);
                OBarang.HARGA = Convert.ToInt32(txtHARGA.Text);
                OBarang.KODE_SUPPLIER = txtKODE_SUPPLIER.Text;
                if (PageState == 0)
                {
                    new BarangCRUD().Insert(OBarang);
                }
                else
                {
                    new BarangCRUD().Update(OBarang);
                }
            }
            catch (Exception ex) { errorMsg = "Simpan Data Barang Error Mas "; }
        }

        private bool IsDatavalidOnSave()
        {
            string errorMsg = "";
            if (string.IsNullOrEmpty(txtKODE_BARANG.Text))
            {
                errorMsg = "Kode Barang tidak boleh kosong!";
            }
            else if (string.IsNullOrEmpty(txtNAMA_BARANG.Text))
            {
                errorMsg = "Nama Barang tidak boleh kosong!";
            }
            else if (string.IsNullOrEmpty(txtSTOK.Text))
            {
                errorMsg = "Stok tidak boleh kosong!";
            }

            else if (string.IsNullOrEmpty(txtKODE_SUPPLIER.Text))
            {
                errorMsg = "Kode Supplier tidak boleh kosong!";
            }
            else if (cekStock() == 0)
            {
                errorMsg = "Woi Data Jagan NOL";
            }

            else
            {
                return true;
            }
            string script = string.Format("alert('{0}');", errorMsg);
            ScriptManager.RegisterStartupScript(this, typeof(string), "onClick", script, true);
            return false;
        }

        private int cekStock()
        {
            try
            {
                return Convert.ToInt32(txtSTOK.Text);
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
    }
}