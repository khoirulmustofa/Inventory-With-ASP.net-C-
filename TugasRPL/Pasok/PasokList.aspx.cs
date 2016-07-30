using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasRPL.CRUD;
using TugasRPL.Entity;

namespace TugasRPL.Pasok
{
    public partial class PasokList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Tanggal();
        }

        private void Tanggal()
        {
            txtTANGGAL_PASOK.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }

        protected void gvPasok_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

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
    }
}